Imports System.IO
Imports System.Data.OleDb

Public Class frmImpostazioni
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Dim fileConfig As String = frmConsuntivazione.fileConfig
    Dim vetModifiche() As String
    Dim contaModifiche As Integer = -1
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtPathDB.GotFocus
        HideCaret(txtPathDB.Handle)
    End Sub
    Private Sub frmImpostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        impostaConfig()
        'vetModifiche(0) = "PATH_DB=" & txtPathDB.Text
        btnAnnulla.Select()
    End Sub
    Dim DBDefault As String = ""
    Dim AggAutGiornoAttuale As Boolean = frmConsuntivazione.AggAutGiornoAttuale
    Dim AggAutDettaglio As Boolean = frmConsuntivazione.AggAutDettaglio
    Sub impostaConfig()
        Dim sr As New StreamReader(fileConfig)
        Dim appoggio As String = sr.ReadLine
        Dim selezionaModifica As String = ""
        Dim dato As String

        Do
            If appoggio.StartsWith("[") Then
                selezionaModifica = appoggio.Replace("[", "")
                selezionaModifica = selezionaModifica.Replace("]", "")
                appoggio = sr.ReadLine()
            End If
            If selezionaModifica = "ConfigImp" Then
                Dim index As Integer = appoggio.IndexOf("=") + 1
                dato = appoggio.Substring(index, appoggio.Length - index)
                If appoggio.Contains("DB_PATH") Then
                    txtPathDB.Text = dato
                ElseIf appoggio.Contains("DB_DEFAULT") Then
                    DBDefault = dato
                ElseIf appoggio.Contains("AggAutGiornoAttuale") Then
                    ckbGiornoAttuale.Checked = CBool(dato)
                ElseIf appoggio.Contains("AggAutDettaglio") Then
                    ckbAggDettaglio.Checked = CBool(dato)
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Sub valorizzaVetModifiche(voce As String, testo As String)
        Dim modificato As Boolean = False
        If vetModifiche Is Nothing = False Then
            For i = 0 To vetModifiche.Length - 1
                If vetModifiche(i).Contains(voce) Then
                    vetModifiche(i) = voce & "-" & testo
                    modificato = True
                End If
            Next
        End If
        If modificato = False Then
            contaModifiche += 1
            ReDim Preserve vetModifiche(contaModifiche)
            vetModifiche(contaModifiche) = voce & "-" & testo
        End If
    End Sub
    Private Sub lblOpenFolderDB_Click(sender As Object, e As EventArgs) Handles lblOpenFolderDB.Click
        If txtPathDB.Text = "" Then
            If MsgBox("Vuoi scegliere la cartella in cui incollare un database vuoto?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                creaDBCartella()
                Exit Sub
            End If
        End If

        ofdPath.ShowDialog()
        txtPathDB.Text = ofdPath.FileName.ToString
        'vetModifiche(0) = "DB_PATH=" & txtPathDB.Text
        Dim voce As String = "DB_PATH"
        Dim testo As String = txtPathDB.Text
        valorizzaVetModifiche(voce, testo)
    End Sub
    Sub creaDBCartella()
        fbdPath.ShowDialog()
        Dim pathCartella As String = fbdPath.SelectedPath.ToString + "\Consuntivazione.accdb"
        Dim pathDBDefault As String = Application.StartupPath
        If pathDBDefault.Contains("bin\Debug") Then
            pathDBDefault = pathDBDefault.Replace("bin\Debug", "Database\Consuntivazione.accdb")
        Else
            pathDBDefault += "\Database\Consuntivazione.accdb"
        End If
        Try
            File.Copy(pathDBDefault, pathCartella)
        Catch ex As Exception
            MsgBox("Il file è gia presente sotto questa Directory!", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        txtPathDB.Text = pathCartella
        Dim voce As String = "DB_PATH"
        Dim testo As String = txtPathDB.Text
        valorizzaVetModifiche(voce, testo)
    End Sub
    Private Sub ckbGiornoAttuale_CheckedChanged(sender As Object, e As EventArgs) Handles ckbGiornoAttuale.CheckedChanged
        Dim voce As String = "AggAutGiornoAttuale"
        Dim testo As String = CStr(ckbGiornoAttuale.Checked)
        valorizzaVetModifiche(voce, testo)
    End Sub

    Private Sub ckbAggDettaglio_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAggDettaglio.CheckedChanged
        Dim voce As String = "AggAutDettaglio"
        Dim testo As String = CStr(ckbAggDettaglio.Checked)
        valorizzaVetModifiche(voce, testo)
    End Sub

    Public modifica As Boolean = False
    Private Sub btnApplica_Click(sender As Object, e As EventArgs) Handles btnApplica.Click
        If vetModifiche Is Nothing Then
            MsgBox("Non è stata fatta nessuna modifica", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim restart As Boolean = False
        For i = 0 To vetModifiche.Length - 1
            If vetModifiche(i).StartsWith("DB") Then
                restart = True
            End If
        Next
        If restart = True Then
            If MsgBox("Vuoi applicare le modifiche? Il programma verrà chiuso per apportarle.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.No Then
                Exit Sub
            End If
            Call applicaModifiche(vetModifiche)
            modifica = True
            MsgBox("Modifiche apportate correttamente!", MsgBoxStyle.Information)
            Me.Close()
        Else
            If AggAutDettaglio = ckbAggDettaglio.Checked And AggAutGiornoAttuale = ckbGiornoAttuale.Checked Then
                MsgBox("Non è stata fatta nessuna modifica", MsgBoxStyle.Exclamation)
                vetModifiche = Nothing
                contaModifiche = -1
                Exit Sub
            End If
            Call applicaModifiche(vetModifiche)
            MsgBox("Modifiche apportate correttamente!", MsgBoxStyle.Information)
            AggAutDettaglio = ckbAggDettaglio.Checked
            frmConsuntivazione.AggAutDettaglio = AggAutDettaglio
            AggAutGiornoAttuale = ckbGiornoAttuale.Checked
            frmConsuntivazione.AggAutGiornoAttuale = AggAutGiornoAttuale
        End If
        vetModifiche = Nothing
        contaModifiche = -1
    End Sub
    Sub applicaModifiche(vetModifiche() As String)
        For i = 0 To vetModifiche.Length - 1
            Dim vetVoceTesto() As String = vetModifiche(i).Split("-")
            Dim voce As String = vetVoceTesto(0)
            Dim testo As String = vetVoceTesto(1)
            Dim sr As New StreamReader(fileConfig)
            Dim sw As New StreamWriter(Path.ChangeExtension(fileConfig, "tmp"))
            Dim appoggio As String = sr.ReadLine()

            Do
                If appoggio.Contains(voce) Then
                    sw.WriteLine(voce + "=" + testo)
                Else
                    sw.WriteLine(appoggio)
                End If
                appoggio = sr.ReadLine()
            Loop Until appoggio = Nothing
            sr.Close()
            sw.Close()
            File.Copy(Path.ChangeExtension(fileConfig, "tmp"), fileConfig, True)
            File.Delete(Path.ChangeExtension(fileConfig, "tmp"))
        Next
    End Sub
    Sub applicaModifiche(pathDefault As String)
        Dim voce As String = "DB_PATH"
        Dim testo As String = pathDefault
        Dim sr As New StreamReader(fileConfig)
        Dim sw As New StreamWriter(Path.ChangeExtension(fileConfig, "tmp"))
        Dim appoggio As String = sr.ReadLine()

        Do
            If appoggio.Contains(voce) Then
                sw.WriteLine(voce & "=" & testo)
            Else
                sw.WriteLine(appoggio)
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
        sw.Close()
        File.Copy(Path.ChangeExtension(fileConfig, "tmp"), fileConfig, True)
        File.Delete(Path.ChangeExtension(fileConfig, "tmp"))
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub btnAggiornaDB_Click(sender As Object, e As EventArgs) Handles btnAggiornaDB.Click
        Dim pathDB As String = txtPathDB.Text
        Dim indexLastSlash As Integer = pathDB.LastIndexOf("\")
        Dim nomeDB As String = pathDB.Substring(indexLastSlash + 1, pathDB.Length - indexLastSlash - 1)
        Dim pathCartellaDB As String = pathDB.Substring(0, indexLastSlash)
        Dim pathCartellaBackup As String = pathCartellaDB + "\Backup"

        If Directory.Exists(pathCartellaBackup) = False Then
            Directory.CreateDirectory(pathCartellaBackup)
        End If
        If File.Exists(pathDB) Then
            Dim dataExt As String = Date.Now.ToString.Replace("/", "").Replace(":", "").Replace(" ", "_")
            File.Copy(pathDB, pathCartellaBackup + "\" + nomeDB + "." + dataExt)
        Else
            MsgBox("Il DB attuale non è presente nel path " + pathDB, MsgBoxStyle.Critical)
            Exit Sub
        End If
        If File.Exists(DBDefault) Then
            If File.Exists(pathCartellaDB + "\new_" + nomeDB) Then
                File.Delete(pathCartellaDB + "\new_" + nomeDB)
            End If
            File.Copy(DBDefault, pathCartellaDB + "\new_" + nomeDB)
        Else
            MsgBox("Il DB di default non è presente nel seguente path: " + pathDB, MsgBoxStyle.Critical)
            Exit Sub
        End If
        Call trasferisciDB(pathCartellaDB, nomeDB)
        If trasferito = False Then
            MsgBox("Aggiornamento non avvenuto con successo!", MsgBoxStyle.Critical)
            File.Delete(pathCartellaDB + "\new_" + nomeDB)
            Exit Sub
        End If

        File.Delete(pathCartellaDB + "\" + nomeDB)
        FileSystem.Rename(pathCartellaDB + "\new_" + nomeDB, pathCartellaDB + "\" + nomeDB)
        MsgBox("Aggiornamento avvenuto con successo!")
    End Sub
    Dim strConn As String = frmConsuntivazione.strConn
    Public trasferito As Boolean = False
    Sub trasferisciDB(pathCartellaDB As String, nomeDB As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim Data As New DataSet
        Dim tables As New List(Of DataTable)
        Dim nRighe As Integer
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        Dim SchemaTable As DataTable = cn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, Nothing})
        For I As Int16 = 0 To SchemaTable.Rows.Count - 1
            If SchemaTable.Rows(I).Item(3) = "TABLE" Then
                Dim name As String = SchemaTable.Rows(I).Item(2)
                Dim table As DataTable
                str = "SELECT * FROM " & name & ""
                cmd = New OleDbCommand(str, cn)
                da = New OleDbDataAdapter(cmd)
                da.Fill(Data)
                table = Data.Tables(0)
                table.TableName = name
                tables.Add(table)
                Data.Dispose()
                Data = New DataSet
            End If
        Next
        cn.Close()
        Data.Clear()
        Data.Dispose()

        Dim strConnNuovoDB As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + pathCartellaDB + "\new_" + nomeDB
        cn = New OleDbConnection(strConnNuovoDB)
        For i = 0 To tables.Count - 1
            tabella.Clear()
            tabella = tables(i)

            Dim strInsert As String = ""
            Call generaInsert(strInsert, tabella)
            strInsert = strInsert.Substring(0, strInsert.Length - 1)
            Dim vetStrSQL() As String = strInsert.Split("|")

            Try
                cn.Open()
            Catch ex As Exception
                MsgBox("Errore di connessione. Codice Errore: " & ex.Message)
                Exit Sub
            End Try
            For j = 0 To vetStrSQL.Length - 1
                cmd = New OleDbCommand(vetStrSQL(j), cn)
                Try
                    nRighe = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                    cn.Close()
                    Exit Sub
                End Try
            Next
            cn.Close()
        Next
    End Sub
    Sub generaInsert(ByRef strInsert As String, tabella As DataTable)
        Dim nomeTabella As String = tabella.TableName
        Dim numColonne As Integer = tabella.Columns.Count
        Dim vetNomeColonne(numColonne - 1) As String
        Dim colonnaID As Integer = -1

        For i = 0 To numColonne - 1
            If tabella.Columns(i).ToString <> "ID" Then
                vetNomeColonne(i) = tabella.Columns(i).ToString
            Else
                colonnaID = i
            End If
        Next

        Dim colonneTabella As String = ""
        For i = 0 To vetNomeColonne.Length - 1
            If i <> colonnaID Then
                colonneTabella += vetNomeColonne(i) + ","
            End If
        Next
        colonneTabella = "(" + colonneTabella.Substring(0, colonneTabella.Length - 1) + ")"

        Dim values As String
        For i = 0 To tabella.Rows.Count - 1
            values = ""
            For j = 0 To vetNomeColonne.Length - 1
                If j <> colonnaID Then
                    If tabella.Rows(i).Item(vetNomeColonne(j)).ToString <> "" Then
                        values += "'" + tabella.Rows(i).Item(vetNomeColonne(j)).ToString + "',"
                    Else
                        values += "NULL,"
                    End If
                End If
            Next
            values = "(" + values.Substring(0, values.Length - 1) + ")"
            strInsert += "INSERT INTO " & nomeTabella & " " & colonneTabella & " VALUES " & values & "|"
        Next
    End Sub

    Private Sub btnCancellaDB_Click(sender As Object, e As EventArgs) Handles btnCancellaDB.Click
        If MsgBox("Sei sicuro di voler resettare il tuo database?
Verrà effettuato un backup e verranno cancellati tutti i dati.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim pathDB As String = txtPathDB.Text
        Dim indexLastSlash As Integer = pathDB.LastIndexOf("\")
        Dim nomeDB As String = pathDB.Substring(indexLastSlash + 1, pathDB.Length - indexLastSlash - 1)
        Dim pathCartellaDB As String = pathDB.Substring(0, indexLastSlash)
        Dim pathCartellaBackup As String = pathCartellaDB + "\Backup"

        If Directory.Exists(pathCartellaBackup) = False Then
            Directory.CreateDirectory(pathCartellaBackup)
        End If
        If File.Exists(pathDB) Then
            Dim dataExt As String = Date.Now.ToString.Replace("/", "").Replace(":", "").Replace(" ", "_")
            File.Copy(pathDB, pathCartellaBackup + "\" + nomeDB + "." + dataExt)
        Else
            MsgBox("Il DB attuale non è presente nel seguente path: " + pathDB, MsgBoxStyle.Critical)
            Exit Sub
        End If
        If File.Exists(DBDefault) Then
            If File.Exists(pathCartellaDB + "\new_" + nomeDB) Then
                File.Delete(pathCartellaDB + "\new_" + nomeDB)
            End If
            File.Copy(DBDefault, pathCartellaDB + "\new_" + nomeDB)
        Else
            MsgBox("Il DB di default non è presente nel seguente path: " + pathDB, MsgBoxStyle.Critical)
            Exit Sub
        End If
        File.Delete(pathCartellaDB + "\" + nomeDB)
        FileSystem.Rename(pathCartellaDB + "\new_" + nomeDB, pathCartellaDB + "\" + nomeDB)
        MsgBox("Cancellazione avvenuta con successo!
Il programma verrà chiuso per applicare la modifica.", MsgBoxStyle.Information)
        trasferito = True
        Me.Close()
    End Sub
End Class