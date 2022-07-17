Imports System.Data.OleDb
Public Class frmInserisciCliente
    ReadOnly strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Consuntivazione\published\Database\Consuntivazione.accdb"
    Private Sub frmInserisciCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pulisciCampi()
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