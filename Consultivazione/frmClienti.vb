Imports System.Data.OleDb
Public Class frmClienti
    Private Sub frmClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCalendario.RowCount = 2
        dgvCalendario.ColumnCount = 3
        dgvCalendario.Rows(0).Visible = False
        dgvCalendario.Columns(0).Visible = False
        dgvCalendario.Columns(2).Visible = False
        dgvCalendario.Columns(1).HeaderText() = "CLIENTE"
        aggiornaDG()
    End Sub
    Sub aggiornaDG()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Clienti"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dgvCalendario.RowCount = 1
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvCalendario.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("Cliente").ToString
            dgvCalendario.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("ID").ToString
        Next
    End Sub
    Private Sub dgvCalendario_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCalendario.CellMouseDown
        If e.Button = MouseButtons.Left Then
            frmConsuntivazione.colonnaCondivisa = "CLIENTE"
            frmModifica.ShowDialog()
            aggiornaDG()
        End If
    End Sub
End Class