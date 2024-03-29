﻿Imports System.Data.OleDb
Imports System.IO
Public Class frmClienti
    ReadOnly strConn As String = frmConsuntivazione.strConn
    Private Sub frmClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClienti.RowCount = 2
        dgvClienti.ColumnCount = 3
        dgvClienti.Rows(0).Visible = False
        dgvClienti.Columns(0).Visible = False
        dgvClienti.Columns(2).Visible = False
        dgvClienti.Columns(1).HeaderText() = "CLIENTE"
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
        str = "SELECT * FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dgvClienti.RowCount = 1
        dgvClienti.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvClienti.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("Cliente").ToString
            dgvClienti.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("ID").ToString
        Next
    End Sub
    Sub modificaCliente(cliente As String, r As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE Clienti SET Cliente = '" & cliente & "' WHERE ID = " & dgvClienti.Rows(r).Cells(2).Value
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
    Sub eliminaCliente(r As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE * FROM Clienti WHERE ID = " & dgvClienti.Rows(r).Cells(2).Value
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
    Private Sub dgvCalendario_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClienti.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex = -1 Then
                Exit Sub
            End If
            If e.ColumnIndex = -1 Then
                If MsgBox("Vuoi eliminare questo cliente? (non sarà recuperabile)", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                Else
                    eliminaCliente(e.RowIndex)
                End If
            Else
                If MsgBox("Vuoi modificare questo cliente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If

                Dim cliente As String = InputBox("Inserisci un cliente:")
                cliente = cliente.Replace("'", "")
                If cliente = "" Or cliente.Length > frmConsuntivazione.cmbCliente.MaxLength Then
                    MsgBox("Nome Cliente non valido (Max " & frmConsuntivazione.cmbCliente.MaxLength & " car.)")
                    Exit Sub
                End If

                modificaCliente(cliente, e.RowIndex)
                modificaCmbClienti()
            End If
            aggiornaDG()
        End If
    End Sub
    Sub modificaCmbClienti()
        'Clienti
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String


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
        frmConsuntivazione.cmbClienteFiltro.Items.Clear()
        frmCommesse.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
            frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbClienteFiltro.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmCommesse.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next
    End Sub
End Class