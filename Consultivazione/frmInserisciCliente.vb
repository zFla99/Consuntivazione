Imports System.Data.OleDb
Imports System.IO
Public Class frmInserisciCliente
    ReadOnly strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Altro\Consuntivazione\published\Database\Consuntivazione.accdb"
    Private Sub frmInserisciCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pulisciCampi()
        impostaConfig()
    End Sub
    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
    Sub impostaConfig()
        Dim sr As New StreamReader(fileConfig)
        Dim appoggio As String = sr.ReadLine
        Dim selezionaModifica As String = ""

        Do
            If appoggio.StartsWith("[") Then
                selezionaModifica = appoggio.Replace("[", "")
                selezionaModifica = selezionaModifica.Replace("]", "")
                appoggio = sr.ReadLine()
            End If
            Dim index As Integer = appoggio.IndexOf("=") + 1
            Dim value As String = appoggio.Substring(index, appoggio.Length - index)
            If selezionaModifica = "ItemColor" Then
                If appoggio.Contains("Form_BackColor") Then
                    Me.BackColor = ColorTranslator.FromHtml(value)

                ElseIf appoggio.Contains("From_ForeColor") Then
                    lblCliente.ForeColor = ColorTranslator.FromHtml(value)
                    lblCodCliente.ForeColor = ColorTranslator.FromHtml(value)
                    lblCommessa.ForeColor = ColorTranslator.FromHtml(value)
                    lblSottCommessa.ForeColor = ColorTranslator.FromHtml(value)
                    lblFase.ForeColor = ColorTranslator.FromHtml(value)
                    lblSottFase.ForeColor = ColorTranslator.FromHtml(value)

                    rdbClienteConfig.ForeColor = ColorTranslator.FromHtml(value)
                    rdbCliente.ForeColor = ColorTranslator.FromHtml(value)
                    rdbConfig.ForeColor = ColorTranslator.FromHtml(value)

                    rdbVuota.ForeColor = ColorTranslator.FromHtml(value)
                    rdbFixed.ForeColor = ColorTranslator.FromHtml(value)
                    rdbFormazione.ForeColor = ColorTranslator.FromHtml(value)
                    rdbAltro.ForeColor = ColorTranslator.FromHtml(value)
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Sub pulisciCampi()
        txtCliente.Text = ""
        txtCodCliente.Text = ""
        txtCommessa.Text = ""
        txtSottoCommessa.Text = ""
        txtFase.Text = ""
        txtSottoFase.Text = ""
        rdbClienteConfig.Checked = True
        rdbVuota.Checked = True
    End Sub
    Private Sub txtCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCliente.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtCodCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtCommessa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCommessa.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtSottoCommessa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSottoCommessa.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtFase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFase.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtSottoFase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSottoFase.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub btnInserisci_Click(sender As Object, e As EventArgs) Handles btnInserisci.Click
        Dim cliente As String = txtCliente.Text
        Dim CodCliente As String = txtCodCliente.Text
        Dim commessa As String = txtCommessa.Text
        Dim SottoCommessa As String = txtSottoCommessa.Text
        Dim fase As String = txtFase.Text
        Dim SottoFase As String = txtSottoFase.Text

        If cliente = "" Then
            MsgBox("Inserisci un cliente")
            Exit Sub
        End If
        If btnInserisci.Text <> "Inserisci Cliente" Then
            If CodCliente = "" Then
                MsgBox("Inserisci un codice cliente")
                Exit Sub
            End If
            If commessa = "" Then
                MsgBox("Inserisci una commessa")
                Exit Sub
            End If
            If SottoCommessa = "" Then
                MsgBox("Inserisci una sotto commessa")
                Exit Sub
            End If
        End If

        Dim nota As String = ""
        Dim link As String
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cliente & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim vetCommNota(tabella.Rows.Count) As String
        For i = 0 To tabella.Rows.Count - 1
            vetCommNota(i) = tabella.Rows(i).Item("Nota").ToString
        Next

        Dim conta As Integer = 0
        Dim notaInput As String
        If rdbVuota.Checked = True Then
            nota = ""
        ElseIf rdbFixed.Checked = True Then
            nota = "Fixed"
        ElseIf rdbFormazione.Checked = True Then
            nota = "Formazione"
        ElseIf rdbAltro.Checked = True Then
            notaInput = InputBox("Inserisci una nota").Trim.ToLower
            notaInput = StrConv(notaInput, VbStrConv.ProperCase)

            If notaInput.Length > 150 Then
                MsgBox("Nota non valida (Max 150 car.)")
                Exit Sub
            ElseIf notaInput.ToLower.Contains("criticità") Or notaInput.ToLower.Contains("home") Or notaInput.ToLower.Contains("fixed") Or notaInput.ToLower.Contains("formazione") Or notaInput.ToLower.Contains("extra") Then
                MsgBox("Nota non valida (non puoi inserire questa commessa)")
                Exit Sub
            End If
            nota = notaInput
        End If

        For i = 0 To tabella.Rows.Count - 1
            If vetCommNota(i).ToLower = nota.ToLower Then
                conta += 1
            End If
        Next

        If conta > 0 Then
            MsgBox("Questa commessa è gia presente per questo cliente")
            Exit Sub
        End If

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti WHERE Cliente = '" & cliente & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If btnInserisci.Text = "Inserisci Commessa" Then
            If tabella.Rows.Count = 0 Then
                MsgBox("Questo cliente non esiste.")
                Exit Sub
            End If
        End If

        If btnInserisci.Text <> "Inserisci Commessa" Then
            If tabella.Rows.Count = 1 Then
                MsgBox("Questo cliente esiste già.")
                Exit Sub
            Else
                inserisciCliente(cliente)
                If btnInserisci.Text = "Inserisci Cliente" Then
                    MsgBox("Il cliente " & cliente & " è stato aggiunto!")
                    pulisciCampi()
                    Exit Sub
                End If
            End If
        End If

        link = "Cliente=" & CodCliente & "&Commessa=" & commessa & "&SottComm=" & SottoCommessa & "&Fase=" & fase & "&SottoFase=" & SottoFase
        inserisciConfig(cliente, nota, link)
        MsgBox("Il cliente " & cliente & " è la sua commessa è stato aggiunto!")

        pulisciCampi()
    End Sub

    Sub inserisciCliente(cliente As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "INSERT into Clienti (Cliente) VALUES ('" & cliente & "')"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
            cn.Close()
            inserito = False
            Exit Sub
        End Try
        cn.Close()


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        frmModifica.cmbCliente.Items.Clear()
        frmConsuntivazione.cmbCliente.Items.Clear()
        frmCommesse.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
            frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmCommesse.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next
    End Sub
    Sub inserisciConfig(cliente As String, nota As String, link As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        cn.Open()
        If nota = "" Then
            str = "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "',NULL,'" & link & "')"
        Else
            str = "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "','" & nota & "','" & link & "')"
        End If
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Dim clientiDaInserire As String = ""
    Dim inserito As Boolean
    Dim rigaExcel As Integer = 0
    Dim errore As String = ""
    Sub InserisciMassivamente()
        Dim msgResult As MsgBoxResult = MsgBox("Vuoi scaricare il Template per l'inserimento massivo?", MsgBoxStyle.YesNoCancel)
        If msgResult = MsgBoxResult.Yes Then
            Call scaricaTemplate()
            Exit Sub
        ElseIf msgResult = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        ofdFile.ShowDialog()

        Dim filePath As String = ofdFile.FileName

        If filePath.EndsWith("Template_Commesse.xlsx") = False Then
            MsgBox("Seleziona il template scaricato", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim cnStr As String
        Dim cn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable

        cnStr = String.Format("Provider=Microsoft.Ace.Oledb.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filePath)
        cn = New OleDbConnection(cnStr)
        cn.Open()
        da = New OleDbDataAdapter("SELECT * FROM [Commesse$] WHERE CLIENTE IS NOT NULL AND 'COD.CLIENTE' IS NOT NULL AND COMMESSA IS NOT NULL AND 'SOTT.COMMESSA' IS NOT NULL", cn)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows.Count = 0 Then
            MsgBox("Il template è vuoto")
            Exit Sub
        End If

        Dim cmd As OleDbCommand
        Dim str As String
        Dim tabellaClientiDB As New DataTable

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabellaClientiDB.Clear()
        da.Fill(tabellaClientiDB)
        cn.Close()

        Dim tabellaClientiExcel As New DataTable

        cn = New OleDbConnection(cnStr)
        cn.Open()
        da = New OleDbDataAdapter("SELECT DISTINCT CLIENTE FROM [Commesse$] WHERE CLIENTE IS NOT NULL", cn)
        tabellaClientiExcel.Clear()
        da.Fill(tabellaClientiExcel)
        cn.Close()

        Dim presente As Boolean = False
        For i = 0 To tabellaClientiExcel.Rows.Count - 1
            For j = 0 To tabellaClientiDB.Rows.Count - 1
                If tabellaClientiExcel.Rows(i).Item("CLIENTE") = tabellaClientiDB.Rows(j).Item("Cliente") Then
                    presente = True
                End If
            Next
            If presente = False Then
                clientiDaInserire += tabellaClientiExcel.Rows(i).Item("CLIENTE").ToString & ";"
            End If
        Next

        Call uploadTemplate(tabella)
        If inserito = False Then
            MsgBox("Importazione interrotta alla riga " & rigaExcel + 2 & " dell'Excel. " & errore, MsgBoxStyle.Critical)
            Exit Sub
        End If
        MsgBox("Le commesse sono state inserite correttamente", MsgBoxStyle.Information)
    End Sub
    Sub scaricaTemplate()
        Dim path As String = Application.StartupPath
        If path.Contains("bin\Debug") Then
            path = path.Replace("bin\Debug", "Template\Template_Commesse.xlsx")
        Else
            path += "\Template\Template_Commesse.xlsx"
        End If
        Try
            My.Computer.FileSystem.CopyFile(path, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/Template_Commesse.xlsx")
        Catch ex As Exception
            MsgBox("Il template è gia sul Desktop", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        MsgBox("Il template è stato salvato sul Desktop con il nome di 'Template_Commesse'. Completalo e fai l'upload", MsgBoxStyle.Information)
    End Sub
    Sub uploadTemplate(tabellaExcel As DataTable)
        If clientiDaInserire <> "" Then
            clientiDaInserire = clientiDaInserire.Substring(0, clientiDaInserire.Length - 1)
            Dim vetClienti() As String = clientiDaInserire.Split(";")
            Call InserisciClienteMassivamente(vetClienti)
            If inserito = False And errore <> "" Then
                MsgBox(errore)
                rigaExcel = 0
                Exit Sub
            End If
        End If
        Call InserisciCommesseMassivamente(tabellaExcel)
    End Sub
    Sub InserisciClienteMassivamente(vetClienti() As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim nRighe As Integer
        Dim strSQL As String = ""

        For i = 0 To vetClienti.Length - 1
            strSQL += "INSERT into Clienti (Cliente) VALUES ('" & vetClienti(i) & "');"
        Next
        cn = New OleDbConnection(strConn)
        cn.Open()
        strSQL = strSQL.Substring(0, strSQL.Length - 1)
        Dim vetStrSQL() As String = StrSQL.Split(";")
        For i = 0 To vetStrSQL.Length - 1
            cmd = New OleDbCommand(vetStrSQL(i), cn)
            Try
                nRighe = cmd.ExecuteNonQuery
            Catch ex As Exception
                cn.Close()
                errore = "Il cliente " & vetClienti(i) & " non è stato inserito correttamente. Codice errore: " & ex.Message
                inserito = False
                Exit Sub
            End Try
        Next

        strSQL = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(strSQL, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        frmModifica.cmbCliente.Items.Clear()
        frmConsuntivazione.cmbCliente.Items.Clear()
        frmCommesse.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
            frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmCommesse.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next
        inserito = True
    End Sub
    Sub InserisciCommesseMassivamente(tabellaExcel As DataTable)
        Dim cliente As String
        Dim CodCliente As String
        Dim commessa As String
        Dim SottoCommessa As String
        Dim fase As String
        Dim SottoFase As String
        Dim nota As String
        Dim link As String
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim nRighe As Integer
        Dim str As String
        Dim strSQL As String = ""

        For i = 0 To tabellaExcel.Rows.Count - 1
            inserito = False
            cliente = tabellaExcel.Rows(i).Item("CLIENTE").ToString
            nota = tabellaExcel.Rows(i).Item("NOTA").ToString
            CodCliente = tabellaExcel.Rows(i).Item("COD#CLIENTE").ToString
            commessa = tabellaExcel.Rows(i).Item("COMMESSA").ToString
            SottoCommessa = tabellaExcel.Rows(i).Item("SOTT#COMMESSA").ToString
            fase = tabellaExcel.Rows(i).Item("FASE").ToString
            SottoFase = tabellaExcel.Rows(i).Item("SOTT#FASE").ToString

            cn = New OleDbConnection(strConn)
            cn.Open()
            str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cliente & "'"
            cmd = New OleDbCommand(str, cn)
            da = New OleDbDataAdapter(cmd)
            tabella.Clear()
            da.Fill(tabella)
            cn.Close()

            Dim vetCommNota(tabella.Rows.Count) As String
            For j = 0 To tabella.Rows.Count - 1
                vetCommNota(j) = tabella.Rows(j).Item("Nota").ToString
            Next

            Dim conta As Integer = 0
            If nota.Contains("Criticità") Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa standard"
                    rigaExcel = i
                    Exit Sub
                End If
            ElseIf nota.Contains("Fixed") Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "Fixed" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa per il Bug Fix"
                    rigaExcel = i
                    Exit Sub
                End If
            ElseIf nota.Contains("Formazione") Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "Formazione" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa per la Formazione"
                    rigaExcel = i
                    Exit Sub
                End If
            ElseIf nota = "" Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa standard"
                    rigaExcel = i
                    Exit Sub
                End If
            End If
            link = "Cliente=" & CodCliente & "&Commessa=" & commessa & "&SottComm=" & SottoCommessa & "&Fase=" & fase & "&SottoFase=" & SottoFase
            If nota = "" Then
                strSQL += "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "',NULL,'" & link & "');"
            Else
                strSQL += "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "','" & nota & "','" & link & "');"
            End If
        Next

        strSQL = strSQL.Substring(0, strSQL.Length - 1)
        Dim vetStrSQL() As String = strSQL.Split(";")

        cn = New OleDbConnection(strConn)
        cn.Open()
        For i = 0 To vetStrSQL.Length - 1
            cmd = New OleDbCommand(vetStrSQL(i), cn)
            Try
                nRighe = cmd.ExecuteNonQuery
            Catch ex As Exception
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                inserito = False
                Exit Sub
            End Try
        Next
        cn.Close()
        inserito = True
    End Sub
    Private Sub rdbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCliente.CheckedChanged
        If rdbCliente.Checked = True Then
            txtCodCliente.Enabled = False
            gboxNota.Enabled = False
            gboxCommessa.Enabled = False
            btnInserisci.Text = "Inserisci Cliente"
        End If
    End Sub

    Private Sub rdbClienteConfig_CheckedChanged(sender As Object, e As EventArgs) Handles rdbClienteConfig.CheckedChanged
        If rdbClienteConfig.Checked = True Then
            txtCodCliente.Enabled = True
            gboxNota.Enabled = True
            gboxCommessa.Enabled = True
            btnInserisci.Text = "Inserisci Cliente e Commessa"
        End If
    End Sub

    Private Sub rdbConfig_CheckedChanged(sender As Object, e As EventArgs) Handles rdbConfig.CheckedChanged
        If rdbConfig.Checked = True Then
            txtCodCliente.Enabled = True
            gboxNota.Enabled = True
            gboxCommessa.Enabled = True
            btnInserisci.Text = "Inserisci Commessa"
        End If
    End Sub
    Private Sub btnClienti_Click(sender As Object, e As EventArgs) Handles btnClienti.Click
        frmClienti.ShowDialog()
    End Sub

    Private Sub btnCommesse_Click(sender As Object, e As EventArgs) Handles btnCommesse.Click
        frmCommesse.ShowDialog()
    End Sub
End Class