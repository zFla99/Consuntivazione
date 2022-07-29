Imports System.Data.OleDb
Imports System.IO
Public Class frmCommesse
    ReadOnly strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Altro\Consuntivazione\published\Database\Consuntivazione.accdb"
    Private Sub frmCommesse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCommesse.RowCount = 2
        dgvCommesse.ColumnCount = 9
        dgvCommesse.Rows(0).Visible = False
        dgvCommesse.Columns(0).Visible = False
        dgvCommesse.Columns(8).Visible = False
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

                    ckbVuota.ForeColor = ColorTranslator.FromHtml(value)
                    ckbFixed.ForeColor = ColorTranslator.FromHtml(value)
                    ckbFormazione.ForeColor = ColorTranslator.FromHtml(value)
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
    Private Sub cmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCliente.KeyPress
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

        If colonna = "COD.CLIENTE" Then
            link = "Cliente=" & dato & "&Commessa=" & commessa & "&SottComm=" & sottCommessa & "&Fase=" & fase & "&SottoFase=" & sottFase
        ElseIf colonna = "COMMESSA" Then
            link = "Cliente=" & codCliente & "&Commessa=" & dato & "&SottComm=" & sottCommessa & "&Fase=" & fase & "&SottoFase=" & sottFase
        ElseIf colonna = "SOTT.COMMESSA" Then
            link = "Cliente=" & codCliente & "&Commessa=" & commessa & "&SottComm=" & dato & "&Fase=" & fase & "&SottoFase=" & sottFase
        ElseIf colonna = "FASE" Then
            link = "Cliente=" & codCliente & "&Commessa=" & commessa & "&SottComm=" & sottCommessa & "&Fase=" & dato & "&SottoFase=" & sottFase
        Else
            link = "Cliente=" & codCliente & "&Commessa=" & commessa & "&SottComm=" & sottCommessa & "&Fase=" & fase & "&SottoFase=" & dato
        End If


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE LinkGR SET Link = '" & link & "' WHERE ID = " & dgvCommesse.Rows(r).Cells(8).Value
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
    Sub eliminaCommessa(r As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE * FROM LinkGR WHERE ID = " & dgvCommesse.Rows(r).Cells(8).Value
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
    Private Sub dgvCommesse_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCommesse.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex = -1 Then
                Exit Sub
            End If
            If e.ColumnIndex = -1 Then
                If MsgBox("Vuoi eliminare questa commessa? (non sarà recuperabile)", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                Else
                    eliminaCommessa(e.RowIndex)
                End If
            ElseIf e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
                frmConsuntivazione.tabellaCondivisa = "LinkGR"
                frmConsuntivazione.colonnaCondivisa = dgvCommesse.Columns(e.ColumnIndex).HeaderText
                frmConsuntivazione.idCondiviso = dgvCommesse.Rows(e.RowIndex).Cells(8).Value
                frmConsuntivazione.rigaCondivisa = e.RowIndex
                frmModifica.ShowDialog()
            Else
                Dim dato As String = InputBox("Modifica la " & dgvCommesse.Columns(e.ColumnIndex).HeaderText)
                dato = dato.Replace("'", "")
                If dgvCommesse.Columns(e.ColumnIndex).HeaderText = "COD.CLIENTE" Or dgvCommesse.Columns(e.ColumnIndex).HeaderText = "COMMESSA" Or dgvCommesse.Columns(e.ColumnIndex).HeaderText = "SOTT.COMMESSA" Then
                    If dato = "" Or dato.Length > frmInserisciCliente.txtCommessa.MaxLength Then
                        MsgBox("Dato inserito non valido (Max. " & frmInserisciCliente.txtCommessa.MaxLength & " car.)")
                        Exit Sub
                    End If
                Else
                    If dato.Length > frmInserisciCliente.txtCommessa.MaxLength Then
                        MsgBox("Dato inserito non valido (Max. " & frmInserisciCliente.txtCommessa.MaxLength & " car.)")
                        Exit Sub
                    End If
                End If
                modificaCommessa(dato, e.RowIndex, e.ColumnIndex)
            End If
            aggiornaDG()
        End If
    End Sub

    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        Dim cliente As String = cmbCliente.Text
        Dim vuota As Boolean = ckbVuota.Checked
        Dim fixed As Boolean = ckbFixed.Checked
        Dim formazione As Boolean = ckbFormazione.Checked

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String = ""

        cn = New OleDbConnection(strConn)
        cn.Open()
        If cliente = "" And ((vuota = True And fixed = True And formazione = True) Or (vuota = False And fixed = False And formazione = False)) Then
            str = "SELECT * FROM LinkGR ORDER BY Cliente, Nota"
        ElseIf cliente <> "" And ((vuota = True And fixed = True And formazione = True) Or (vuota = False And fixed = False And formazione = False)) Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' ORDER BY Cliente, Nota"
        ElseIf cliente = "" And vuota = True And fixed = False And formazione = False Then
            str = "SELECT * FROM LinkGR WHERE Nota IS NULL ORDER BY Cliente, Nota"
        ElseIf cliente = "" And vuota = True And fixed = True And formazione = False Then
            str = "SELECT * FROM LinkGR WHERE Nota IS NULL OR Nota = 'Fixed' ORDER BY Cliente, Nota"
        ElseIf cliente = "" And vuota = True And fixed = False And formazione = True Then
            str = "SELECT * FROM LinkGR WHERE Nota IS NULL OR Nota = 'Formazione' ORDER BY Cliente, Nota"
        ElseIf cliente = "" And vuota = False And fixed = True And formazione = False Then
            str = "SELECT * FROM LinkGR WHERE Nota = 'Fixed' ORDER BY Cliente, Nota"
        ElseIf cliente = "" And vuota = False And fixed = True And formazione = True Then
            str = "SELECT * FROM LinkGR WHERE Nota = 'Formazione' OR Nota = 'Fixed' ORDER BY Cliente, Nota"
        ElseIf cliente = "" And vuota = False And fixed = False And formazione = True Then
            str = "SELECT * FROM LinkGR WHERE Nota = 'Formazione' ORDER BY Cliente, Nota"

        ElseIf cliente <> "" And vuota = True And fixed = False And formazione = False Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' AND Nota IS NULL ORDER BY Cliente, Nota"
        ElseIf cliente <> "" And vuota = True And fixed = True And formazione = False Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' AND (Nota IS NULL OR Nota = 'Fixed') ORDER BY Cliente, Nota"
        ElseIf cliente <> "" And vuota = True And fixed = False And formazione = True Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' AND (Nota IS NULL OR Nota = 'Formazione') ORDER BY Cliente, Nota"
        ElseIf cliente <> "" And vuota = False And fixed = True And formazione = False Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' AND Nota = 'Fixed' ORDER BY Cliente, Nota"
        ElseIf cliente <> "" And vuota = False And fixed = True And formazione = True Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' AND (Nota = 'Formazione' OR Nota = 'Fixed') ORDER BY Cliente, Nota"
        ElseIf cliente <> "" And vuota = False And fixed = False And formazione = True Then
            str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' AND Nota = 'Formazione' ORDER BY Cliente, Nota"
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

    Private Sub cmbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCerca_Click(sender, e)
        End If
    End Sub
End Class