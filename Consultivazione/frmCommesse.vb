Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmCommesse
    ReadOnly strConn As String = frmConsuntivazione.strConn
    ReadOnly logCommesseClienti As String = frmConsuntivazione.logCommesseClienti
    Dim dataOraLog As String = ""
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
    Private Sub frmCommesse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imageColumn As New DataGridViewImageColumn()
        dgvCommesse.Columns.Add(imageColumn)

        dgvCommesse.RowCount = 2
        dgvCommesse.ColumnCount = 9
        dgvCommesse.Rows(0).Visible = False
        dgvCommesse.Columns(8).Visible = False

        dgvCommesse.Columns(0).HeaderText() = ""
        dgvCommesse.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCommesse.Columns(0).Width = 30
        dgvCommesse.Columns(0).Resizable = DataGridViewTriState.False

        dgvCommesse.Columns(1).HeaderText() = "CLIENTE"
        dgvCommesse.Columns(2).HeaderText() = "NOTA"
        dgvCommesse.Columns(3).HeaderText() = "COD.CLIENTE"
        dgvCommesse.Columns(4).HeaderText() = "COMMESSA"
        dgvCommesse.Columns(5).HeaderText() = "SOTT.COMMESSA"
        dgvCommesse.Columns(6).HeaderText() = "FASE"
        dgvCommesse.Columns(7).HeaderText() = "SOTT.FASE"
        dgvCommesse.Columns(8).HeaderText() = "ID"
        aggiornaDG()
        impostaConfig()
        impostaLocation()
        arrotondaBordi()
    End Sub
    Sub arrotondaBordi()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 15, 15))
    End Sub
    Sub impostaLocation()
        Dim locationY As Integer = frmConsuntivazione.Location.Y + 31
        Dim locationX As Integer = frmConsuntivazione.Location.X + 8
        locationY += (frmConsuntivazione.Height / 2) - Me.Height / 2 - 10
        locationX += (frmConsuntivazione.Width / 2) + (frmClienti.Width / 2) - (Me.Width / 2) + 5

        Me.Location = New Point(locationX, locationY)
    End Sub
    Sub impostaSfondoNero()
        frmSfondoNero.BringToFront()
        Me.BringToFront()
    End Sub
    Function controllaFormAttivo()
        Dim formAttivo As Boolean = False
        For Each control As Control In Me.Controls
            If control.ContainsFocus Then
                formAttivo = True
                Exit For
            End If
        Next
        Return formAttivo
    End Function

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
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Sub aggiornaDG()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM LinkGR ORDER BY Cliente, Nota"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim numR = tabella.Rows.Count

        Dim vetCodCliente(numR) As String
        Dim vetCommessa(numR) As String
        Dim vetSottCommessa(numR) As String
        Dim vetFase(numR) As String
        Dim vetSottFase(numR) As String

        For i = 0 To tabella.Rows.Count - 1
            Dim vetLink() As String = tabella.Rows(i).Item("Link").ToString.Split("&")
            vetCodCliente(i) = vetLink(0).Replace("Cliente=", "")
            vetCommessa(i) = vetLink(1).Replace("Commessa=", "")
            vetSottCommessa(i) = vetLink(2).Replace("SottComm=", "")
            vetFase(i) = vetLink(3).Replace("Fase=", "")
            vetSottFase(i) = vetLink(4).Replace("SottoFase=", "")
        Next

        dgvCommesse.RowCount = 1
        dgvCommesse.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvCommesse.Rows(i + 1).Cells(0).Value = Consuntivazione.My.Resources.Resources.edit_16x16_nero
            dgvCommesse.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("Cliente").ToString
            dgvCommesse.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("Nota").ToString
            dgvCommesse.Rows(i + 1).Cells(3).Value = vetCodCliente(i)
            dgvCommesse.Rows(i + 1).Cells(4).Value = vetCommessa(i)
            dgvCommesse.Rows(i + 1).Cells(5).Value = vetSottCommessa(i)
            dgvCommesse.Rows(i + 1).Cells(6).Value = vetFase(i)
            dgvCommesse.Rows(i + 1).Cells(7).Value = vetSottFase(i)
            dgvCommesse.Rows(i + 1).Cells(8).Value = tabella.Rows(i).Item("ID").ToString
        Next
    End Sub
    Private Sub cmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Sub modificaCommessa(dato As String, r As Integer, c As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String
        Dim colonna As String = dgvCommesse.Columns(c).HeaderText
        Dim codCliente As String = dgvCommesse.Rows(r).Cells(3).Value
        Dim commessa As String = dgvCommesse.Rows(r).Cells(4).Value
        Dim sottCommessa As String = dgvCommesse.Rows(r).Cells(5).Value
        Dim fase As String = dgvCommesse.Rows(r).Cells(6).Value
        Dim sottFase As String = dgvCommesse.Rows(r).Cells(7).Value
        Dim link As String

        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            If colonna = "COD.CLIENTE" Then
                link = "Cliente=" & dato & "&Commessa=" & commessa & "&SottComm=" & sottCommessa & "&Fase=" & fase & "&SottoFase=" & sottFase
                logFile.WriteLine(dataOraLog + "Modifica '" & colonna & "' da '" & codCliente & "' a '" & dato & "' per l'ID '" & dgvCommesse.Rows(r).Cells(8).Value & "'")
            ElseIf colonna = "COMMESSA" Then
                link = "Cliente=" & codCliente & "&Commessa=" & dato & "&SottComm=" & sottCommessa & "&Fase=" & fase & "&SottoFase=" & sottFase
                logFile.WriteLine(dataOraLog + "Modifica '" & colonna & "' da '" & commessa & "' a '" & dato & "' per l'ID '" & dgvCommesse.Rows(r).Cells(8).Value & "'")
            ElseIf colonna = "SOTT.COMMESSA" Then
                link = "Cliente=" & codCliente & "&Commessa=" & commessa & "&SottComm=" & dato & "&Fase=" & fase & "&SottoFase=" & sottFase
                logFile.WriteLine(dataOraLog + "Modifica '" & colonna & "' da '" & sottCommessa & "' a '" & dato & "' per l'ID '" & dgvCommesse.Rows(r).Cells(8).Value & "'")
            ElseIf colonna = "FASE" Then
                link = "Cliente=" & codCliente & "&Commessa=" & commessa & "&SottComm=" & sottCommessa & "&Fase=" & dato & "&SottoFase=" & sottFase
                logFile.WriteLine(dataOraLog + "Modifica '" & colonna & "' da '" & fase & "' a '" & dato & "' per l'ID '" & dgvCommesse.Rows(r).Cells(8).Value & "'")
            Else
                link = "Cliente=" & codCliente & "&Commessa=" & commessa & "&SottComm=" & sottCommessa & "&Fase=" & fase & "&SottoFase=" & dato
                logFile.WriteLine(dataOraLog + "Modifica '" & colonna & "' da '" & sottFase & "' a '" & dato & "' per l'ID '" & dgvCommesse.Rows(r).Cells(8).Value & "'")
            End If
            logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
        End Using

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE LinkGR SET Link = '" & link & "' WHERE ID = " & dgvCommesse.Rows(r).Cells(8).Value
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
                logFile.WriteLine(dataOraLog + "Errore. Modifica non effettuata per il seguente motivo: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
            End Using
            MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Sub eliminaCommessa(r As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE * FROM LinkGR WHERE ID = " & dgvCommesse.Rows(r).Cells(8).Value
        cmd = New OleDbCommand(str, cn)

        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            Try
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                Exit Sub
            End Try
            cn.Close()
            logFile.WriteLine(dataOraLog + "Camcellata correttamente commessa con id " & dgvCommesse.Rows(r).Cells(8).Value)
            logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
        End Using
    End Sub
    Private Sub dgvCommesse_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCommesse.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex = -1 Then
                Exit Sub
            End If

            dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
            Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
                logFile.WriteLine(dataOraLog + "------------------------------------------")
                logFile.WriteLine(dataOraLog + "Inizio scrittura log Commesse:")
            End Using
            If e.ColumnIndex = -1 Then
                If MsgBox("Vuoi eliminare questa commessa? (non sarà recuperabile)", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
                        logFile.WriteLine(dataOraLog + "Nessuna modifica effettuata")
                        logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
                    End Using
                    Exit Sub
                Else
                    eliminaCommessa(e.RowIndex)
                End If
            ElseIf e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
                frmConsuntivazione.tabellaCondivisa = "LinkGR"
                'frmConsuntivazione.colonnaCondivisa = dgvCommesse.Columns(e.ColumnIndex).HeaderText
                frmConsuntivazione.idCondiviso = dgvCommesse.Rows(e.RowIndex).Cells(8).Value
                frmConsuntivazione.rigaCondivisa = e.RowIndex
                frmModifica.ShowDialog()
            Else
                Dim dato As String = InputBox("Modifica la " & dgvCommesse.Columns(e.ColumnIndex).HeaderText)
                dato = dato.Replace("'", "")
                Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
                    If dgvCommesse.Columns(e.ColumnIndex).HeaderText = "COD.CLIENTE" Or dgvCommesse.Columns(e.ColumnIndex).HeaderText = "COMMESSA" Or dgvCommesse.Columns(e.ColumnIndex).HeaderText = "SOTT.COMMESSA" Then
                        If dato = "" Or dato.Length > frmInserisciCliente.txtCommessa.MaxLength Then
                            logFile.WriteLine(dataOraLog + "Dato inserito non valido (Max. " & frmInserisciCliente.txtCommessa.MaxLength & " car.)")
                            logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                            logFile.Close()
                            MsgBox("Dato inserito non valido (Max. " & frmInserisciCliente.txtCommessa.MaxLength & " car.)")
                            Exit Sub
                        End If
                    Else
                        If dato.Length > frmInserisciCliente.txtCommessa.MaxLength Then
                            logFile.WriteLine(dataOraLog + "Dato inserito non valido (Max. " & frmInserisciCliente.txtCommessa.MaxLength & " car.)")
                            logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                            logFile.Close()
                            MsgBox("Dato inserito non valido (Max. " & frmInserisciCliente.txtCommessa.MaxLength & " car.)")
                            Exit Sub
                        End If
                    End If
                End Using
                modificaCommessa(dato, e.RowIndex, e.ColumnIndex)
            End If
            aggiornaDG()
        End If
    End Sub

    Private Sub Cerca(sender As Object, e As EventArgs)
        Dim cliente As String = "" 'cmbCliente.Text

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        If cliente = "" Then
            str = "SELECT * FROM LinkGR ORDER BY Cliente, Nota"
        Else
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' ORDER BY Cliente, Nota"
        End If
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim numR = tabella.Rows.Count

        Dim vetCodCliente(numR) As String
        Dim vetCommessa(numR) As String
        Dim vetSottCommessa(numR) As String
        Dim vetFase(numR) As String
        Dim vetSottFase(numR) As String

        For i = 0 To tabella.Rows.Count - 1
            Dim vetLink() As String = tabella.Rows(i).Item("Link").ToString.Split("&")
            vetCodCliente(i) = vetLink(0).Replace("Cliente=", "")
            vetCommessa(i) = vetLink(1).Replace("Commessa=", "")
            vetSottCommessa(i) = vetLink(2).Replace("SottComm=", "")
            vetFase(i) = vetLink(3).Replace("Fase=", "")
            vetSottFase(i) = vetLink(4).Replace("SottoFase=", "")
        Next

        dgvCommesse.RowCount = 1
        dgvCommesse.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvCommesse.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("Cliente").ToString
            dgvCommesse.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("Nota").ToString
            dgvCommesse.Rows(i + 1).Cells(3).Value = vetCodCliente(i)
            dgvCommesse.Rows(i + 1).Cells(4).Value = vetCommessa(i)
            dgvCommesse.Rows(i + 1).Cells(5).Value = vetSottCommessa(i)
            dgvCommesse.Rows(i + 1).Cells(6).Value = vetFase(i)
            dgvCommesse.Rows(i + 1).Cells(7).Value = vetSottFase(i)
            dgvCommesse.Rows(i + 1).Cells(8).Value = tabella.Rows(i).Item("ID").ToString
        Next
    End Sub
    Private Async Sub txtCommesseHidden_LostFocus(sender As Object, e As EventArgs) Handles txtCommesseHidden.LostFocus, dgvCommesse.LostFocus, Me.LostFocus
        If Not Me.Visible Or Not frmClienti.Visible Then
            Exit Sub
        End If

        Dim frmClientiAttivo As Boolean = frmClienti.controllaFormAttivo()
        Dim frmCommesseAttivo As Boolean = controllaFormAttivo()
        frmClienti.sfondoNeroClick = False

        Await Task.Delay(1)
        If Not frmClientiAttivo And Not frmCommesseAttivo Then
            If Not frmInserisciCliente.Visible Then
                Me.Close()
                frmClienti.Close()
                If Not frmClienti.sfondoNeroClick Then
                    frmInserisciCliente.Close()
                End If
            End If
        End If
    End Sub
End Class