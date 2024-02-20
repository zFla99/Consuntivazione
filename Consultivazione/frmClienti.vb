Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmClienti
    ReadOnly strConn As String = frmConsuntivazione.strConn
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
    Private Sub frmClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imageColumn As New DataGridViewImageColumn()
        dgvClienti.Columns.Add(imageColumn)

        dgvClienti.RowCount = 2
        dgvClienti.ColumnCount = 3
        dgvClienti.Rows(0).Visible = False
        dgvClienti.Columns(2).Visible = False

        dgvClienti.Columns(0).HeaderText() = ""
        dgvClienti.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvClienti.Columns(0).Width = 30
        dgvClienti.Columns(0).Resizable = DataGridViewTriState.False

        dgvClienti.Columns(1).HeaderText() = "CLIENTE"
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
        locationX += (frmConsuntivazione.Width / 2) - (Me.Width / 2) - (frmCommesse.Width / 2)

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
        str = "SELECT * FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dgvClienti.RowCount = 1
        dgvClienti.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvClienti.Rows(i + 1).Cells(0).Value = Consuntivazione.My.Resources.Resources.edit_16x16_nero
            dgvClienti.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("Cliente").ToString
            dgvClienti.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("ID").ToString
        Next
    End Sub
    Public dgvModificaClienteClick As Boolean = False
    Public idCliente As Integer
    Private Sub dgvCalendario_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClienti.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex = -1 Then
                Exit Sub
            End If
            If e.ColumnIndex = 0 Then
                idCliente = dgvClienti.Rows(e.RowIndex).Cells(2).Value
                frmModificaCliente.id = idCliente
                dgvModificaClienteClick = True
                frmModificaCliente.Show()
            End If
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
        For i = 0 To tabella.Rows.Count - 1
            frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbClienteFiltro.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next
    End Sub

    Public sfondoNeroClick As Boolean
    Public chiudiTutto As Boolean = False
    Public Async Sub txtClientiHidden_LostFocus(sender As Object, e As EventArgs) Handles txtClientiHidden.LostFocus, dgvClienti.LostFocus, Me.LostFocus
        If Not Me.Visible Or Not frmCommesse.Visible Or dgvModificaClienteClick Or frmCommesse.dgvModificaCommessaClick Then
            Exit Sub
        End If

        Dim frmClientiAttivo As Boolean = controllaFormAttivo()
        Dim frmCommesseAttivo As Boolean = frmCommesse.controllaFormAttivo()
        sfondoNeroClick = False

        Await Task.Delay(1)
        If (chiudiTutto Or frmCommesse.chiudiTutto) Or (Not frmClientiAttivo And Not frmCommesseAttivo) Then
            If Not frmInserisciCliente.Visible Then
                Me.Close()
                frmCommesse.Close()
                If Not sfondoNeroClick Or Not frmCommesse.sfondoNeroClick Then
                    frmInserisciCliente.Close()
                End If
            End If
        End If
    End Sub
End Class