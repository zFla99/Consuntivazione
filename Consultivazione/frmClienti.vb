Imports System.Data.OleDb
Public Class frmClienti
    ReadOnly strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Consuntivazione\published\Database\Consuntivazione.accdb"
    Private Sub frmClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClienti.RowCount = 2
        dgvClienti.ColumnCount = 3
        dgvClienti.Rows(0).Visible = False
        dgvClienti.Columns(0).Visible = False
        dgvClienti.Columns(2).Visible = False
        dgvClienti.Columns(1).HeaderText() = "CLIENTE"
        aggiornaDG()
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
        If e.Button = MouseButtons.Left Then
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
            End If
            aggiornaDG()
        End If
    End Sub
End Class