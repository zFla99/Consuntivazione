Imports System.Data.OleDb

Public Class frmConsuntivazione
    Dim giornoOggi As String = Now.ToShortDateString
    Public Sub Consuntivazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call caricaClientiTempo()
        Call DataGrid()
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
    End Sub
    Private Sub Consuntivazione_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        lblSfondoBlu.Width = 265 + pnlInserisci.Location.X + 20
    End Sub
    Private Sub Consuntivazione_Click(sender As Object, e As EventArgs) Handles Me.Click
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
    End Sub
    Private Sub lblSfondoBlu_Click(sender As Object, e As EventArgs) Handles lblSfondoBlu.Click
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
    End Sub
    Sub caricaClientiTempo()
        'Clienti
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        cmbCliente.Items.Clear()
        frmModifica.cmbCliente.Items.Clear()
        frmCommesse.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
            cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmCommesse.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next

        'Tempo
        cmbTempo.Items.Clear()
        cmbTempo.Items.Add("0,25")
        cmbTempo.Items.Add("0,5")
        cmbTempo.Items.Add("0,75")
        cmbTempo.Items.Add("1")
        cmbTempo.Items.Add("1,25")
        cmbTempo.Items.Add("1,5")
        cmbTempo.Items.Add("1,75")
        cmbTempo.Items.Add("2")

    End Sub
    Sub RedimDGV()
        dgvCalendario.Columns(5).Width = dgvCalendario.Width * 17 / 100
    End Sub
    Dim giorno As String
    Dim ticket As String
    Dim cliente As String
    Dim nota As String
    Dim tempo As Double
    Private Sub btnCarica_Click(sender As Object, e As EventArgs) Handles btnCarica.Click
        If txtTicket.Text = "" Then
            MsgBox("Inserisci un Ticket")
            txtTicket.Focus()
            Exit Sub
        End If
        If cmbCliente.Text = "" Then
            MsgBox("Inserisci un Cliente")
            cmbCliente.Focus()
            Exit Sub
        End If
        If cmbTempo.Text = "" Then
            MsgBox("Inserisci un tempo di risoluzione")
            cmbTempo.Focus()
            Exit Sub
        ElseIf IsNumeric(cmbTempo.Text) = False Then
            MsgBox("Inserisci un tempo di risoluzione valido")
            Exit Sub
        End If

        ticket = txtTicket.Text
        cliente = cmbCliente.Text
        tempo = cmbTempo.Text.Replace(".", ",")
        giorno = dtpData.Text

        Call InserisciTicket()
        Call AggiornaDG(giorno, True)
        Call PulisciCampi()
    End Sub
    Sub DataGrid()
        dgvCalendario.RowCount = 2
        dgvCalendario.ColumnCount = 8
        dgvCalendario.Rows(0).Visible = False
        dgvCalendario.Columns(0).Visible = False
        dgvCalendario.Columns(7).Visible = False

        dgvCalendario.Columns(1).HeaderText() = "TICKET"
        dgvCalendario.Columns(2).HeaderText() = "CLIENTE"
        dgvCalendario.Columns(3).HeaderText() = "TEMPO"
        dgvCalendario.Columns(4).HeaderText() = "DATA"
        dgvCalendario.Columns(5).HeaderText() = "CONSUNTIVATO"
        dgvCalendario.Columns(6).HeaderText() = "NOTA"
        dgvCalendario.Columns(7).HeaderText() = "ID_RIGA"

        Call AggiornaDG(giornoOggi, False)
    End Sub
    Sub InserisciTicket()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim nRighe As Integer
        Dim StrSQL As String
        Dim duplicato As Boolean = False
        Dim id As String = ""

        If ticket <> "/" Then
            ControlloDoppioniGiornalieri(ticket, duplicato, id)
            If duplicato = True Then
                Call ModificaDuplicato(3, id, tempo)
                Exit Sub
            End If
        End If

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
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
        If ckbHome.Checked = True Then
            nota = "Home"
        Else
            nota = ""
        End If

        If rdbCriticita.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa standard")
                Exit Sub
            End If
            If nota = "" Then
                nota = "Criticità"
            Else
                nota += ", Criticità"
            End If
        ElseIf rdbFixed.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Fixed" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa per il Bug Fix")
                Exit Sub
            End If

            If nota = "" Then
                nota = "Fixed"
            Else
                nota += ", Fixed"
            End If
        ElseIf rdbFormazione.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Formazione" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa per la Formazione")
                Exit Sub
            End If
            If nota = "" Then
                nota = "Formazione"
            Else
                nota += ", Formazione"
            End If
        Else
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa standard")
                Exit Sub
            End If
        End If

        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb")
        Try
            cn.Open()
        Catch ex As Exception
            MsgBox("Errore di connessione. Codice Errore: " & ex.Message)
            Exit Sub
        End Try
        If nota = "" Then
            StrSQL = "INSERT into Consuntivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO, NOTA) VALUES ('" & ticket & "','" & cliente & "','" & tempo & "','" & giorno & "','NO',NULL)"
        Else
            StrSQL = "INSERT into Consuntivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO, NOTA) VALUES ('" & ticket & "','" & cliente & "','" & tempo & "','" & giorno & "','NO','" & nota & "')"
        End If
        cmd = New OleDbCommand(StrSQL, cn)
        Try
            nRighe = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
            cn.Close()
            Exit Sub
        End Try
        cn.Close()

        cn.Open()
        str = "SELECT MAX(ID) AS ID_MAX FROM Consuntivazione"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        id = tabella.Rows(0).Item("ID_MAX")
        Call modificaTutteNote(id)
    End Sub
    Sub modificaTutteNote(id As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT DATA, NOTA, ID FROM Consuntivazione WHERE DATA ='" & giorno & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim numGiorni As Integer = tabella.Rows.Count - 1
        Dim vetNota(numGiorni) As String
        Dim notaID As String = ""
        Dim contiene As Boolean = False

        For i = 0 To numGiorni
            vetNota(i) = tabella.Rows(i).Item("NOTA").ToString
            If tabella.Rows(i).Item("ID") = id Then
                notaID = vetNota(i)
            End If
        Next

        If notaID.Contains("Home") Then
            contiene = True
        End If

        For i = 0 To numGiorni
            If tabella.Rows(i).Item("ID") <> id Then
                cn.Open()
                If contiene = True Then
                    If vetNota(i).ToString = "" Then
                        nota = "Home"
                    ElseIf vetNota(i).ToString.Contains("Home") Then
                        nota = vetNota(i)
                    Else
                        nota = "Home, " & vetNota(i)
                    End If
                Else
                    If vetNota(i).ToString = "Home" Then
                        nota = ""
                    Else
                        nota = vetNota(i).ToString.Replace("Home, ", "")
                    End If
                End If
                If nota = "" Then
                    str = "UPDATE Consuntivazione SET NOTA = NULL WHERE ID = " & tabella.Rows(i).Item("ID")
                Else
                    str = "UPDATE Consuntivazione SET NOTA ='" & nota & "' WHERE ID = " & tabella.Rows(i).Item("ID")
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
            End If
        Next
    End Sub
    Sub VisTemp()
        If giorno <> giornoOggi Then
            noSpam = True
            Call AggiornaDG(giorno, False)
            TimerVisualizzazione.Start()
        End If

    End Sub
    Private Sub TimerVisualizzazione_Tick(sender As Object, e As EventArgs) Handles TimerVisualizzazione.Tick
        If resoconto = False Then
            Call AggiornaDG(giornoOggi, False)
        Else
            noSpam = False
            lblGiorno_Mese_Click(sender, e)
            btnDividiXCliente_Click(sender, e)
            resoconto = False
        End If
        noSpam = False
        TimerVisualizzazione.Stop()
    End Sub
    Sub AggiornaDG(ByVal giorno As String, ByVal controllo As Boolean)
        If controllo = True Then
            Call VisTemp()
            Exit Sub
        End If

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim i As Integer
        Dim somma As Double

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE DATA='" & giorno & "' ORDER BY ID"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim ticketLink As DataGridViewLinkCell = New DataGridViewLinkCell
        dgvCalendario.RowCount = 1
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            ticketLink.Value = tabella.Rows(i).Item("TICKET").ToString
            dgvCalendario.Rows(i + 1).Cells(1).Value = ticketLink.Value
            dgvCalendario.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("CLIENTE").ToString
            dgvCalendario.Rows(i + 1).Cells(3).Value = tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            somma += tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("DATA").ToString
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("NOTA").ToString
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        lblTempoTot.Text = somma
        Call RedimDGV()
    End Sub

    Sub AggiornaConsuntivato(ticket As String, data As String, consuntivato As String)
        Dim vetNumTicket() As String = ticket.Split("%2C")
        Dim numTicket As Integer = vetNumTicket.Length
        Dim ticketVet(numTicket) As String
        ticketVet = Split(ticket, "%2C")

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        For i = 0 To numTicket - 1
            cn.Open()
            If ticketVet(i) = "Criticità" Then
                str = "UPDATE Consuntivazione SET CONSUNTIVATO = '" & consuntivato & "' WHERE TICKET = '/' AND DATA = '" & data & "'"
            Else
                str = "UPDATE Consuntivazione SET CONSUNTIVATO = '" & consuntivato & "' WHERE TICKET = '" & ticketVet(i) & "' AND DATA = '" & data & "'"
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
        Next
        Call RedimDGV()
        btnDividiXCliente.Text = "Dividi per Cliente"
        btnDividiXCliente_Click(sender:=New EventArgs, e:=New EventArgs)
    End Sub
    Sub PulisciCampi()
        dtpData.Value = Now
        txtTicket.Text = ""
        cmbCliente.Text = ""
        cmbTempo.Text = ""
        txtTicket.Focus()
        btnCancellaFiltri_Click(sender:=New EventArgs, e:=New EventArgs)
    End Sub
    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        If TimerVisualizzazione.Enabled Then
            Exit Sub
        End If
        giorno = dtpData.Text
        Call AggiornaDG(giorno, False)
    End Sub

    Dim resoconto As Boolean = False
    Dim noSpam As Boolean = False
    Private Sub dgvCalendario_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCalendario.CellMouseDown
        If noSpam = True Then
            Exit Sub
        End If

        If e.Button = MouseButtons.Left Then
            clickSinistro(sender, e)
        ElseIf e.Button = MouseButtons.Right Then
            clickDestro(sender, e)
        End If
    End Sub

    Sub clickSinistro(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex = -1 Then
            Exit Sub
        End If

        If btnDividiXCliente.Text = "Ritorna al Mese" Then
            If e.ColumnIndex = 5 Then
                Dim ticket As String = dgvCalendario.Rows(e.RowIndex).Cells(1).Value
                ticket = ticket.Replace(",", "%2C")
                Dim data As String = dgvCalendario.Rows(e.RowIndex).Cells(4).Value
                Dim consuntivato As String = dgvCalendario.Rows(e.RowIndex).Cells(5).Value

                If consuntivato = "SI" Then
                    If MsgBox("Risulta gia consuntivato. Vuoi rimettere a 'NO'?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        consuntivato = "NO"
                        Call AggiornaConsuntivato(ticket, data, consuntivato)
                        Exit Sub
                    End If
                    Exit Sub
                ElseIf consuntivato = "NO" Then
                    consuntivato = "SI"
                Else
                    Exit Sub
                End If
                Dim cliente As String = dgvCalendario.Rows(e.RowIndex).Cells(2).Value
                Dim tempo As String = dgvCalendario.Rows(e.RowIndex).Cells(3).Value.ToString.Replace(",", ".")
                Dim nota As String = dgvCalendario.Rows(e.RowIndex).Cells(6).Value

                Dim home As String = "SEDE"
                If nota.Contains("Home") Then
                    home = "SW"
                    nota.Replace("Home ,", "")
                End If

                Dim dataInvertitaMatrice(2) As String
                dataInvertitaMatrice = data.Split("/")
                Dim dataInvertita As String = dataInvertitaMatrice(2) & "-" & dataInvertitaMatrice(1) & "-" & dataInvertitaMatrice(0)
                Dim link As String = "http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?"

                Dim cn As OleDbConnection
                Dim cmd As OleDbCommand
                Dim da As OleDbDataAdapter
                Dim tabella As New DataTable
                Dim str As String

                str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
                cn = New OleDbConnection(str)
                cn.Open()
                If nota = "" Or nota = "Home" Then
                    str = "SELECT Link FROM LinkGR WHERE Cliente ='" & cliente & "' AND Nota IS NULL"
                Else
                    str = "SELECT Link FROM LinkGR WHERE Cliente ='" & cliente & "' AND Nota='" & nota & "'"
                End If
                cmd = New OleDbCommand(str, cn)
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()

                link += tabella.Rows(0).Item("Link").ToString

                link += "&Data=" & data & "&Sede=" & home & "&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0"
                If home = "SEDE" Then
                    link += "&flag_lavorodacasa=N"
                Else
                    link += "&flag_lavorodacasa=Y"
                End If
                Process.Start(link)
                Call AggiornaConsuntivato(ticket, data, consuntivato)
            End If
        Else
            If e.ColumnIndex = 1 Then
                If dgvCalendario.Item(e.ColumnIndex, e.RowIndex).Value.ToString <> "/" Then
                    Process.Start("https://support.tesisquare.com/mantis/mdev/view.php?id=" & dgvCalendario.Item(e.ColumnIndex, e.RowIndex).Value.ToString)
                End If
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub
    Sub clickDestro(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Dim r, c, id As Integer
        r = e.RowIndex
        c = e.ColumnIndex

        If dgvCalendario.Rows(r).Cells(1).Value = "" Then
            Exit Sub
        Else
            giorno = dgvCalendario.Rows(r).Cells(4).Value
        End If

        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then
            If e.ColumnIndex = -1 And btnDividiXCliente.Text = "Dividi per Cliente" And e.RowIndex <> -1 Then
                If MsgBox("Vuoi eliminare questa riga? Non sarà piu recuperabile", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    id = dgvCalendario.Rows(r).Cells(7).Value
                    Call EliminaRiga(id)
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Mensile)" Then
                Call AggiornaDGMensile(giorno.Substring(3, 2))
            Else
                Call AggiornaDG(giorno, True)
                Call PulisciCampi()
            End If
            Exit Sub
        End If

        If btnDividiXCliente.Text = "Ritorna al Mese" Then
            If MsgBox("Qui non puoi modificare. Vuoi essere reindirizzato al giorno?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                lblGiorno_Mese_Click(sender, e)
                dtpData.Text = giorno
                Call AggiornaDG(giorno, False)
                resoconto = True
                Exit Sub
            Else
                Exit Sub
            End If
        End If

        Dim colonna As String = dgvCalendario.Columns(c).HeaderText
        If colonna = "TICKET" Then
            If MsgBox("Vuoi sostituire il valore di questa cella?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        id = dgvCalendario.Rows(r).Cells(7).Value
        giorno = dgvCalendario.Rows(r).Cells(4).Value
        giornoCondiviso = giorno

        Call ModificaRiga(c, r, id)
        If annulla = True Then
            annulla = False
            Exit Sub
        End If
        If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Mensile)" Then
            Call AggiornaDGMensile(giorno.Substring(3, 2))
        Else
            Call AggiornaDG(giorno, True)
            Call PulisciCampi()
        End If
    End Sub

    Public Shared tabellaCondivisa As String
    Public Shared colonnaCondivisa As String
    Public Shared clienteCondiviso As String
    Public Shared giornoCondiviso As String
    Public Shared idCondiviso As String
    Public Shared annulla As Boolean = False
    Sub ModificaRiga(c As Integer, r As Integer, id As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String
        tabellaCondivisa = "Consuntivazione"
        colonnaCondivisa = dgvCalendario.Columns(c).HeaderText
        clienteCondiviso = dgvCalendario.Rows(r).Cells(2).Value
        idCondiviso = id

        If colonnaCondivisa <> "TICKET" And colonnaCondivisa <> "CONSUNTIVATO" Then
            frmModifica.ShowDialog()
            Exit Sub
        Else
            Dim dato As String
            If colonnaCondivisa = "TICKET" Then
                dato = InputBox("Inserisci un numero ticket")
                annulla = True
                Exit Sub
            Else
                dato = dgvCalendario.Rows(r).Cells(c).Value
                If dato = "NO" Then
                    dato = "SI"
                Else
                    dato = "NO"
                End If
            End If

            str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
            cn = New OleDbConnection(str)
            cn.Open()
            str = "UPDATE Consuntivazione SET " & colonnaCondivisa & "='" & dato & "' WHERE ID = " & id
            cmd = New OleDbCommand(str, cn)
            Try
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                Exit Sub
            End Try
            cn.Close()
        End If
    End Sub
    Sub EliminaRiga(id As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "DELETE * FROM Consuntivazione WHERE ID =" & id
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

    Private Sub lblGiorno_Mese_Click(sender As Object, e As EventArgs) Handles lblGiorno_Mese.Click
        If noSpam = True Then
            Exit Sub
        End If
        If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Giornaliero)" Then
            lblGiorno_Mese.Text = "Totale 
ore di lavoro
(Mensile)"
            Call PulisciCampi()
            pnlInserisci.Visible = False
            lblSfondoBlu.Visible = False
            lstMesi.Visible = True
            lblMesi.Visible = True
            lblResoconto.Visible = True
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnDividiXCliente.Visible = True

            pnlMensile.Left = 0
            pnlMensile.Width = pnlMensile.Parent.Width
            'pnlMensile.Left = (pnlMensile.Parent.Width \ 2) - (pnlMensile.Width \ 2)
            Dim Mese As String
            If resoconto = False Then
                Mese = giornoOggi.Substring(3, 2)
            Else
                Mese = giorno.Substring(3, 2)
            End If
            lstMesi.SelectedIndex = Mese.Replace(0, "") - 1
            Call AggiornaDGMensile(Mese)
        Else
            lblGiorno_Mese.Text = "Totale 
ore di lavoro
(Giornaliero)"
            pnlInserisci.Visible = True
            lblSfondoBlu.Visible = True
            lstMesi.Visible = False
            lblMesi.Visible = False
            lblResoconto.Visible = False
            btnConsuntivaTutto.Visible = False
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnDividiXCliente.Visible = False

            pnlMensile.Location = New Point((pnlInserisci.Location.X + pnlInserisci.Width) + 40, (pnlMensile.Parent.Height \ 2) - (pnlMensile.Height \ 2) - 20)
            Call AggiornaDG(giornoOggi, False)
            pnlMensile.Width = 750
        End If
    End Sub
    Sub AggiornaDGMensile(Mese As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim i As Integer
        Dim somma As Double

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dgvCalendario.RowCount = 1
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvCalendario.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("TICKET").ToString
            dgvCalendario.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("CLIENTE").ToString
            dgvCalendario.Rows(i + 1).Cells(3).Value = tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            somma += tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("DATA").ToString
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("NOTA").ToString
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        lblTempoTot.Text = somma
        btnDividiXCliente.Text = "Dividi per Cliente"
        btnConsuntivaTutto.Visible = False
        Call RedimDGV()
    End Sub
    Public Function ControlloDoppioniGiornalieri(ticket As String, ByRef duplicato As Boolean, ByRef id As String)
        For i = 0 To dgvCalendario.Rows.Count - 1
            If ticket = dgvCalendario.Rows(i).Cells(1).Value Then
                duplicato = True
                id = dgvCalendario.Rows(i).Cells(7).Value
            End If
        Next
        Return (duplicato, id)
    End Function
    Sub ModificaDuplicato(c As Integer, id As Integer, dato As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable

        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE ID=" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim vecchioTempo As Double = tabella.Rows(0).Item("TEMPO_RISOLUZIONE")
        Dim colonna As String = dgvCalendario.Columns(c).HeaderText
        If colonna = "TEMPO" Then
            colonna += "_RISOLUZIONE"
        End If

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "UPDATE Consuntivazione SET " & colonna & "='" & dato + vecchioTempo & "' WHERE ID = " & id
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

    Private Sub lstMesi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMesi.SelectedIndexChanged
        Dim Mese As String = lstMesi.SelectedItem.ToString.Trim
        If Mese.Length = 1 Then
            Mese = "0" + Mese
        End If
        Call AggiornaDGMensile(Mese)
    End Sub

    Private Sub btnDividiXCliente_Click(sender As Object, e As EventArgs) Handles btnDividiXCliente.Click
        If btnDividiXCliente.Text = "Dividi per Cliente" Then
            btnDividiXCliente.Text = "Ritorna al Mese"
            btnConsuntivaTutto.Visible = True
        Else
            lstMesi_SelectedIndexChanged(sender, e)
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnConsuntivaTutto.Visible = False
            Exit Sub
        End If

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim Mese As String = lstMesi.SelectedIndex + 1
        If lstMesi.SelectedIndex < 10 Then
            Mese = "0" & Mese
        End If

        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT DISTINCT DATA FROM Consuntivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows.Count = 0 Then
            MsgBox("Non c'è niente da dividere")
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnConsuntivaTutto.Visible = False
            Exit Sub
        End If

        Dim DateLavorative(tabella.Rows.Count) As String
        For i = 0 To tabella.Rows.Count - 1
            DateLavorative(i) = tabella.Rows(i).Item("DATA").ToString
        Next

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT DISTINCT CLIENTE, DATA, NOTA, COUNT(*) AS NUM_TICKET FROM Consuntivazione WHERE DATA LIKE '%/" & Mese & "/%' GROUP BY DATA, CLIENTE, NOTA ORDER BY DATA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim TabellaNoDoppi As Integer = tabella.Rows.Count
        Dim cliente As String
        Dim clientePrec As String = ""
        Dim data As String
        Dim dataPrec As String = ""
        Dim nota As String

        For i = 0 To tabella.Rows.Count - 1
            cliente = tabella.Rows(i).Item("CLIENTE").ToString
            data = tabella.Rows(i).Item("DATA").ToString
            nota = tabella.Rows(i).Item("NOTA").ToString

            If i > 0 Then
                If cliente = clientePrec And data = dataPrec And nota.Contains("Criticità") = True Then
                    TabellaNoDoppi -= 1
                End If
            End If

            clientePrec = cliente
            dataPrec = data
        Next

        dgvCalendario.RowCount = TabellaNoDoppi + DateLavorative.Length

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA, CLIENTE, NOTA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        cliente = ""
        clientePrec = ""
        nota = ""
        Dim notaPrec As String = ""
        Dim ticket As String = ""
        Dim tempo As Double
        Dim tempoTot As Double

        Dim conta As Integer = -1
        Dim j As Integer = 1

        For i = 0 To DateLavorative.Length - 2
            Do
                conta += 1
                If conta <= tabella.Rows.Count - 1 Then 'AndAlso DateLavorative(i) <> tabella.Rows(conta).Item("DATA").ToString

                    cliente = tabella.Rows(conta).Item("CLIENTE").ToString
                    nota = tabella.Rows(conta).Item("NOTA").ToString
                    If conta <> 0 Then
                        If cliente = clientePrec And (nota = notaPrec Or nota.Contains("Criticità")) AndAlso DateLavorative(i) = tabella.Rows(conta).Item("DATA").ToString Then
                            If nota.Contains("Criticità") Then
                                ticket += "," & "Criticità"
                                If nota.Contains("Home") Then
                                    nota = nota.Remove(4, nota.Length - 4)
                                End If
                            Else
                                ticket += "," & tabella.Rows(conta).Item("TICKET").ToString
                            End If
                            tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
                        Else
                            dgvCalendario.Rows(j).Cells(1).Value = ticket
                            dgvCalendario.Rows(j).Cells(2).Value = clientePrec
                            dgvCalendario.Rows(j).Cells(3).Value = tempo
                            dgvCalendario.Rows(j).Cells(4).Value = DateLavorative(i)
                            dgvCalendario.Rows(j).Cells(5).Value = tabella.Rows(conta - 1).Item("CONSUNTIVATO").ToString
                            If notaPrec.Contains("Criticità") Then
                                If notaPrec.Contains("Home") Then
                                    notaPrec = notaPrec.Replace(", Criticità", "")
                                    dgvCalendario.Rows(j).Cells(6).Value = notaPrec
                                Else
                                    dgvCalendario.Rows(j).Cells(6).Value = ""
                                End If
                            Else
                                dgvCalendario.Rows(j).Cells(6).Value = notaPrec
                            End If

                            tempoTot += tempo
                            tempo = 0
                            j += 1

                            If nota.Contains("Criticità") Then
                                ticket = "Criticità"
                            Else
                                ticket = tabella.Rows(conta).Item("TICKET").ToString
                            End If
                            tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
                        End If
                    Else
                        If nota.Contains("Criticità") Then
                            ticket = "Criticità"
                        Else
                            ticket = tabella.Rows(conta).Item("TICKET").ToString
                        End If
                        tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
                    End If


                    clientePrec = tabella.Rows(conta).Item("CLIENTE").ToString
                    notaPrec = tabella.Rows(conta).Item("NOTA").ToString
                Else
                    dgvCalendario.Rows(j).Cells(1).Value = ticket
                    dgvCalendario.Rows(j).Cells(2).Value = clientePrec
                    dgvCalendario.Rows(j).Cells(3).Value = tempo
                    dgvCalendario.Rows(j).Cells(4).Value = DateLavorative(i)
                    dgvCalendario.Rows(j).Cells(5).Value = tabella.Rows(conta - 1).Item("CONSUNTIVATO").ToString
                    If notaPrec.Contains("Criticità") Then
                        If notaPrec.Contains("Home") Then
                            notaPrec = notaPrec.Replace(", Criticità", "")
                            dgvCalendario.Rows(j).Cells(6).Value = notaPrec
                        Else
                            dgvCalendario.Rows(j).Cells(6).Value = ""
                        End If
                    Else
                        dgvCalendario.Rows(j).Cells(6).Value = notaPrec
                    End If

                    tempoTot += tempo
                    tempo = 0
                    j += 1
                    'conta = tabella.Rows.Count - 1
                End If
            Loop Until conta > tabella.Rows.Count - 1 OrElse DateLavorative(i) <> tabella.Rows(conta).Item("DATA").ToString

            dgvCalendario.Rows(j).Cells(1).Value = ""
            dgvCalendario.Rows(j).Cells(2).Value = "TOTALE:"
            dgvCalendario.Rows(j).Cells(3).Value = tempoTot
            dgvCalendario.Rows(j).Cells(4).Value = ""
            dgvCalendario.Rows(j).Cells(5).Value = ""
            dgvCalendario.Rows(j).Cells(6).Value = ""

            Dim color As Color
            Dim converter As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(color)
            dgvCalendario.Rows(j).DefaultCellStyle.BackColor = converter.ConvertFromString("51; 136; 202")
            dgvCalendario.Rows(j).DefaultCellStyle.ForeColor = Color.White
            dgvCalendario.Rows(j).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

            If tempoTot < 8 Then
                dgvCalendario.Rows(j).Cells(3).Style.BackColor = converter.ConvertFromString("255; 216; 26")
                dgvCalendario.Rows(j).Cells(3).Style.ForeColor = Color.Black
            ElseIf tempoTot = 8 Then
                dgvCalendario.Rows(j).Cells(3).Style.BackColor = converter.ConvertFromString("60; 202; 51")
                dgvCalendario.Rows(j).Cells(3).Style.ForeColor = Color.Black
            Else
                dgvCalendario.Rows(j).Cells(3).Style.BackColor = converter.ConvertFromString("202; 51; 60")
            End If

            j += 1
            tempoTot = 0
        Next
    End Sub
    Dim vetRConsuntivare() As Integer
    Dim RDC As Integer = 0
    Private Sub btnConsuntivaTutto_Click(sender As Object, e As EventArgs) Handles btnConsuntivaTutto.Click
        If MsgBox("Sei sicuro di voler consuntivare TUTTE le righe?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim conta As Integer = 0
        For i = 0 To dgvCalendario.Rows.Count - 1
            If dgvCalendario.Rows(i).Cells(5).Value = "NO" Then
                conta += 1
            End If
        Next

        If conta = 0 Then
            MsgBox("Non ci sono righe da consuntivare")
            Exit Sub
        End If

        ReDim vetRConsuntivare(conta)
        conta = 0
        For i = 0 To dgvCalendario.Rows.Count - 1
            If dgvCalendario.Rows(i).Cells(5).Value = "NO" Then
                vetRConsuntivare(conta) = i
                conta += 1
            End If
        Next
        RDC = conta
        TimerConsuntiva.Start()
    End Sub
    Dim CCons As Integer = 0
    Private Sub TimerConsuntiva_Tick(sender As Object, e As EventArgs) Handles TimerConsuntiva.Tick
        If RDC = CCons Then
            RDC = 0
            CCons = 0
            TimerConsuntiva.Stop()
            Exit Sub
        End If
        clickSinistro(sender, New DataGridViewCellMouseEventArgs(5, vetRConsuntivare(CCons), 0, 0, New MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)))
        CCons += 1
    End Sub

    Private Sub txtTicket_TextChanged(sender As Object, e As KeyEventArgs) Handles txtTicket.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCarica_Click(sender, e)
        End If
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCarica_Click(sender, e)
        End If
    End Sub

    Private Sub cmbTempo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTempo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCarica_Click(sender, e)
        End If
    End Sub

    Private Sub btnCancellaFiltri_Click(sender As Object, e As EventArgs) Handles btnCancellaFiltri.Click
        rdbCriticita.Checked = False
        rdbFixed.Checked = False
        rdbFormazione.Checked = False
    End Sub

    Private Sub lblAggiungiCliente_Click(sender As Object, e As EventArgs) Handles lblAggiungiCliente.Click
        frmInserisciCliente.ShowDialog()
    End Sub
End Class