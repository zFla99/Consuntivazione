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

    Public idCommessa As Integer
    Public tabellaCondivisa As String
    Public dgvModificaCommessaClick As Boolean = False

    Dim conun As Integer
    Private Sub dgvCommesse_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCommesse.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex = -1 Then
                Exit Sub
            End If
            If e.ColumnIndex = 0 Then
                conun += 1
                tabellaCondivisa = "LinkGR"
                idCommessa = dgvCommesse.Rows(e.RowIndex).Cells(8).Value
                frmModificaCommessa.id = idCommessa
                dgvModificaCommessaClick = True
                frmModificaCommessa.Show()
            End If
        End If
    End Sub

    'Private Sub Cerca(sender As Object, e As EventArgs)
    '    Dim cliente As String = "" 'cmbCliente.Text

    '    Dim cn As OleDbConnection
    '    Dim cmd As OleDbCommand
    '    Dim da As OleDbDataAdapter
    '    Dim tabella As New DataTable
    '    Dim str As String

    '    cn = New OleDbConnection(strConn)
    '    cn.Open()
    '    If cliente = "" Then
    '        str = "SELECT * FROM LinkGR ORDER BY Cliente, Nota"
    '    Else
    '        str = "SELECT * FROM LinkGR WHERE Cliente = '" & cliente & "' ORDER BY Cliente, Nota"
    '    End If
    '    cmd = New OleDbCommand(str, cn)
    '    da = New OleDbDataAdapter(cmd)
    '    tabella.Clear()
    '    da.Fill(tabella)
    '    cn.Close()

    '    Dim numR = tabella.Rows.Count

    '    Dim vetCodCliente(numR) As String
    '    Dim vetCommessa(numR) As String
    '    Dim vetSottCommessa(numR) As String
    '    Dim vetFase(numR) As String
    '    Dim vetSottFase(numR) As String

    '    For i = 0 To tabella.Rows.Count - 1
    '        Dim vetLink() As String = tabella.Rows(i).Item("Link").ToString.Split("&")
    '        vetCodCliente(i) = vetLink(0).Replace("Cliente=", "")
    '        vetCommessa(i) = vetLink(1).Replace("Commessa=", "")
    '        vetSottCommessa(i) = vetLink(2).Replace("SottComm=", "")
    '        vetFase(i) = vetLink(3).Replace("Fase=", "")
    '        vetSottFase(i) = vetLink(4).Replace("SottoFase=", "")
    '    Next

    '    dgvCommesse.RowCount = 1
    '    dgvCommesse.RowCount = tabella.Rows.Count + 1
    '    For i = 0 To tabella.Rows.Count - 1
    '        dgvCommesse.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("Cliente").ToString
    '        dgvCommesse.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("Nota").ToString
    '        dgvCommesse.Rows(i + 1).Cells(3).Value = vetCodCliente(i)
    '        dgvCommesse.Rows(i + 1).Cells(4).Value = vetCommessa(i)
    '        dgvCommesse.Rows(i + 1).Cells(5).Value = vetSottCommessa(i)
    '        dgvCommesse.Rows(i + 1).Cells(6).Value = vetFase(i)
    '        dgvCommesse.Rows(i + 1).Cells(7).Value = vetSottFase(i)
    '        dgvCommesse.Rows(i + 1).Cells(8).Value = tabella.Rows(i).Item("ID").ToString
    '    Next
    'End Sub

    Public sfondoNeroClick As Boolean
    Public chiudiTutto As Boolean = False
    Private Async Sub txtCommesseHidden_LostFocus(sender As Object, e As EventArgs) Handles txtCommesseHidden.LostFocus, dgvCommesse.LostFocus, Me.LostFocus
        If Not Me.Visible Or Not frmClienti.Visible Or frmClienti.dgvModificaClienteClick Or dgvModificaCommessaClick Then
            Exit Sub
        End If

        Dim frmClientiAttivo As Boolean = frmClienti.controllaFormAttivo()
        Dim frmCommesseAttivo As Boolean = controllaFormAttivo()
        sfondoNeroClick = False

        Await Task.Delay(1)
        If (chiudiTutto Or frmClienti.chiudiTutto) Or (Not frmClientiAttivo And Not frmCommesseAttivo) Then
            If Not frmInserisciCliente.Visible Then
                Me.Close()
                frmClienti.Close()
                If Not sfondoNeroClick Or Not frmClienti.sfondoNeroClick Then
                    frmInserisciCliente.Close()
                End If
            End If
        End If
    End Sub
End Class