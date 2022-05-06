Imports System.Data.OleDb

Public Class Consuntivazione
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
        cmbCliente.Items.Add("Acerbis")
        cmbCliente.Items.Add("Aspi")
        cmbCliente.Items.Add("Barilla")
        cmbCliente.Items.Add("Bottega Veneta")
        cmbCliente.Items.Add("Ducati")
        cmbCliente.Items.Add("Fiorentini")
        cmbCliente.Items.Add("Fomas")
        cmbCliente.Items.Add("Leroy Merlin")
        cmbCliente.Items.Add("MCZ")
        cmbCliente.Items.Add("OSN")
        cmbCliente.Items.Add("Prima Industrie")
        cmbCliente.Items.Add("Whirlpool")
        cmbCliente.Items.Add("Ynap")

        'Tempo
        cmbTempo.Items.Add("0,25")
        cmbTempo.Items.Add("0,5")
        cmbTempo.Items.Add("0,75")
        cmbTempo.Items.Add("1")
        cmbTempo.Items.Add("1,25")
        cmbTempo.Items.Add("1,5")
        cmbTempo.Items.Add("1,75")
        cmbTempo.Items.Add("2")

    End Sub

    Dim giorno As String
    Dim ticket As String
    Dim cliente As String
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

        dgvCalendario.Columns(1).HeaderText() = "NUM TICKET"
        dgvCalendario.Columns(2).HeaderText() = "TICKET"
        dgvCalendario.Columns(3).HeaderText() = "CLIENTE"
        dgvCalendario.Columns(4).HeaderText() = "TEMPO"
        dgvCalendario.Columns(5).HeaderText() = "DATA"
        dgvCalendario.Columns(6).HeaderText() = "CONSUNTIVATO"
        dgvCalendario.Columns(7).HeaderText() = "ID_RIGA"

        Call AggiornaDG(giornoOggi, False)
    End Sub
    Sub InserisciTicket()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim nRighe As Integer
        Dim StrSQL As String
        Dim duplicato As Boolean = False
        Dim id As String = ""

        If ticket <> "/" Then
            ControlloDoppioniGiornalieri(ticket, duplicato, id)
            If duplicato = True Then
                Call ModificaDuplicato(4, id, tempo)
                Exit Sub
            End If
        End If

        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb")
        Try
            cn.Open()
        Catch ex As Exception
            MsgBox("Errore di connessione. Codice Errore: " & ex.Message)
            Exit Sub
        End Try
        StrSQL = "INSERT into Consultivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO) VALUES ('" & ticket & "','" & cliente & "','" & tempo & "','" & giorno & "','NO')"
        cmd = New OleDbCommand(StrSQL, cn)
        Try
            nRighe = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub

    Sub VisTemp()
        If giorno <> giornoOggi Then
            Call AggiornaDG(giorno, False)
            TimerVisualizzazione.Start()
        End If

    End Sub
    Private Sub TimerVisualizzazione_Tick(sender As Object, e As EventArgs) Handles TimerVisualizzazione.Tick
        If resoconto = False Then
            Call AggiornaDG(giornoOggi, False)
        Else
            lblGiorno_Mese_Click(sender, e)
            btnDividiXCliente_Click(sender, e)
            resoconto = False
        End If
        TimerVisualizzazione.Stop()
    End Sub
    Sub AggiornaDG(ByVal giorno As String, ByVal controllo As Boolean)
        If controllo = True Then
            Call VisTemp()
        End If

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim i As Integer
        Dim somma As Double

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consultivazione WHERE DATA='" & giorno & "' ORDER BY ID"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim ticketLink As DataGridViewLinkCell = New DataGridViewLinkCell
        dgvCalendario.Columns(1).Visible = True
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            ticketLink.Value = tabella.Rows(i).Item("TICKET").ToString
            dgvCalendario.Rows(i + 1).Cells(1).Value = i + 1
            dgvCalendario.Rows(i + 1).Cells(2).Value = ticketLink.Value
            dgvCalendario.Rows(i + 1).Cells(3).Value = tabella.Rows(i).Item("CLIENTE").ToString
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            somma += tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("DATA").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        lblTempoTot.Text = somma
    End Sub
    Private Sub dgvCalendario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalendario.CellClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        If dgvCalendario.Columns(1).Visible = False Then
            If e.ColumnIndex = 6 Then
                Dim ticket As String = dgvCalendario.Rows(e.RowIndex).Cells(2).Value
                ticket = ticket.Replace(",", "%2C")
                Dim data As String = dgvCalendario.Rows(e.RowIndex).Cells(5).Value
                Dim consuntivato As String = dgvCalendario.Rows(e.RowIndex).Cells(6).Value

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

                Dim cliente As String = dgvCalendario.Rows(e.RowIndex).Cells(3).Value
                Dim tempo As String = dgvCalendario.Rows(e.RowIndex).Cells(4).Value.ToString.Replace(",", ".")

                Dim dataInvertitaMatrice(2) As String
                dataInvertitaMatrice = data.Split("/")
                Dim dataInvertita As String = dataInvertitaMatrice(2) & "-" & dataInvertitaMatrice(1) & "-" & dataInvertitaMatrice(0)

                Select Case cliente
                    Case "Acerbis"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=103527&Commessa=20201620&SottComm=CANONE&Fase=&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Aspi"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=102090&Commessa=20170882&SottComm=CANONE&Fase=ANOMALIE&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Barilla"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=101179&Commessa=20211826&SottComm=CANONE&Fase=AMS_SRM&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Bottega Veneta"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=101742&Commessa=20190801&SottComm=CANONE&Fase=NON_FATT&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Ducati"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=103086&Commessa=20220410&SottComm=CANONE&Fase=AMS&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Fiorentini"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=101804&Commessa=20190126&SottComm=CANONE&Fase=ANOMALIE&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Fomas"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=102268&Commessa=20220549&SottComm=CANONE&Fase=&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Leroy Merlin"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=101656&Commessa=20191124&SottComm=CANONE&Fase=124.02&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "MCZ"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=102134&Commessa=20141387&SottComm=CANONE&Fase=ANOMALIE&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "OSN"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=101941&Commessa=20220648&SottComm=CANONE&Fase=&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Prima Industrie"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=102778&Commessa=20181062&SottComm=CANONE&Fase=18106201&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Whirlpool"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=101050&Commessa=20160029&SottComm=CANONE&Fase=AMS&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case "Ynap"
                        Process.Start("http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?Cliente=102090&Commessa=20171266&SottComm=CANONE&Fase=&SottoFase=&Data=" & data & "&Sede=SEDE&Ora=" & dataInvertita & "%2000:00:00.0&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo & "&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0&flag_lavorodacasa=N")
                    Case Else
                        Exit Sub
                End Select
                Call AggiornaConsuntivato(ticket, data, consuntivato)

            End If
            Exit Sub
        Else
            If e.ColumnIndex = 2 Then
                If dgvCalendario.Item(e.ColumnIndex, e.RowIndex).Value.ToString <> "/" Then
                    Process.Start("https://support.tesisquare.com/mantis/mdev/view.php?id=" & dgvCalendario.Item(e.ColumnIndex, e.RowIndex).Value.ToString)
                End If
            End If
            Exit Sub
        End If
    End Sub
    Sub AggiornaConsuntivato(ticket As String, data As String, consuntivato As String)
        Dim numTicket As Integer = ticket.Replace("%2C", "").Length / 7
        Dim ticketVet(numTicket) As String
        ticketVet = Split(ticket, "%2C")

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        For i = 0 To numTicket - 1
            cn.Open()
            str = "UPDATE Consultivazione SET CONSUNTIVATO = '" & consuntivato & "' WHERE TICKET = '" & ticketVet(i) & "' AND DATA = '" & data & "'"
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
        btnDividiXCliente_Click(sender:=New EventArgs, e:=New EventArgs)
    End Sub
    Sub PulisciCampi()
        dtpData.Value = Now
        txtTicket.Text = ""
        cmbCliente.Text = ""
        cmbTempo.Text = ""
        txtTicket.Focus()
    End Sub
    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        If TimerVisualizzazione.Enabled Then
            Exit Sub
        End If
        giorno = dtpData.Text
        Call AggiornaDG(giorno, False)
    End Sub

    Dim resoconto As Boolean = False
    Private Sub dgvCalendario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalendario.CellDoubleClick
        Dim r, c, id As Integer
        r = e.RowIndex
        c = e.ColumnIndex

        If dgvCalendario.Rows(r).Cells(2).Value = "" Then
            Exit Sub
        Else
            giorno = dgvCalendario.Rows(r).Cells(5).Value
        End If

        If e.ColumnIndex = -1 Or e.ColumnIndex = 1 Or e.RowIndex = -1 Then
            If e.ColumnIndex = -1 Then
                If MsgBox("Vuoi eliminare questa riga? Non sarà piu recuperabile", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    id = dgvCalendario.Rows(r).Cells(7).Value
                    Call EliminaRiga(id)
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            Call AggiornaDG(giorno, True)
            Call PulisciCampi()
            Exit Sub
        End If

        If dgvCalendario.Columns(1).Visible = False Then
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

        If MsgBox("Vuoi sostituire il valore di questa cella?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim dato As String = InputBox("Con cosa vuoi cambiare questo valore?")
        Dim colonna As String = dgvCalendario.Columns(c).HeaderText
        id = dgvCalendario.Rows(r).Cells(7).Value

        If colonna = "TEMPO" Then
            If IsNumeric(dato) = False Then
                MsgBox("Inserisci un tempo di risoluzione valido")
                Exit Sub
            End If
            dato = dato.Replace(".", ",")
        End If

        If colonna = "DATA" Then
            If dato.Length <> 10 Then
                MsgBox("Inserisci una data valida. (dd/mm/yyyy)")
                Exit Sub
            End If
            If IsNumeric(dato.Substring(0, 2)) = False Or IsNumeric(dato.Substring(3, 2)) = False Or IsNumeric(dato.Substring(6, 4)) = False Then
                MsgBox("Inserisci una data valida. (dd/mm/yyyy)")
                Exit Sub
            End If
        End If

        giorno = dgvCalendario.Rows(r).Cells(5).Value
        Call ModificaRiga(c, id, dato)
        Call AggiornaDG(giorno, True)
        Call PulisciCampi()
    End Sub
    Sub ModificaRiga(c As Integer, id As Integer, dato As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String
        Dim colonna As String = dgvCalendario.Columns(c).HeaderText
        If colonna = "TEMPO" Then
            colonna += "_RISOLUZIONE"
        End If

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "UPDATE Consultivazione SET " & colonna & "='" & dato & "' WHERE ID = " & id
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
    Sub EliminaRiga(id As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "DELETE * FROM Consultivazione WHERE ID =" & id
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
        If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Giornaliero)" Then
            lblGiorno_Mese.Text = "Totale 
ore di lavoro
(Mensile)"
            pnlInserisci.Visible = False
            lblSfondoBlu.Visible = False
            lstMesi.Visible = True
            lblMesi.Visible = True
            lblResoconto.Visible = True
            btnConsuntivaTutto.Visible = True
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
        Dim color As Color
        Dim converter As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(color)
        Dim str As String
        Dim i As Integer
        Dim somma As Double

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consultivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dgvCalendario.Columns(1).Visible = True
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvCalendario.Rows(i + 1).Cells(1).Value = i + 1
            dgvCalendario.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("TICKET").ToString
            dgvCalendario.Rows(i + 1).Cells(3).Value = tabella.Rows(i).Item("CLIENTE").ToString
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            somma += tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("DATA").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        dgvCalendario.RowsDefaultCellStyle.BackColor = converter.ConvertFromString("255; 255; 255")
        lblTempoTot.Text = somma
    End Sub
    Public Function ControlloDoppioniGiornalieri(ticket As String, ByRef duplicato As Boolean, ByRef id As String)
        For i = 0 To dgvCalendario.Rows.Count - 1
            If ticket = dgvCalendario.Rows(i).Cells(2).Value Then
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

        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consultivazione WHERE ID=" & id
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

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "UPDATE Consultivazione SET " & colonna & "='" & dato + vecchioTempo & "' WHERE ID = " & id
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
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim Mese As String = lstMesi.SelectedIndex + 1
        If lstMesi.SelectedIndex < 10 Then
            Mese = "0" & Mese
        End If

        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT DISTINCT DATA FROM Consultivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows.Count = 0 Then
            MsgBox("Non c'è niente da dividere")
            Exit Sub
        End If

        Dim DateLavorative(tabella.Rows.Count) As String
        For i = 0 To tabella.Rows.Count - 1
            DateLavorative(i) = tabella.Rows(i).Item("DATA").ToString
        Next

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT DISTINCT CLIENTE, DATA FROM Consultivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA, CLIENTE"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim TabellaNoDoppi As Integer = tabella.Rows.Count
        dgvCalendario.RowCount = TabellaNoDoppi + DateLavorative.Length


        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consultivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT * FROM Consultivazione WHERE DATA LIKE '%/" & Mese & "/%' ORDER BY DATA, CLIENTE"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim cliente As String
        Dim clientePrec As String = ""
        Dim ticket As String = ""
        Dim tempo As Double
        Dim tempoTot As Double

        Dim conta As Integer = -1
        Dim j As Integer = 1

        dgvCalendario.Columns(1).Visible = False
        For i = 0 To DateLavorative.Length - 2
            Do
                conta += 1
                If conta <= tabella.Rows.Count - 1 Then

                    cliente = tabella.Rows(conta).Item("CLIENTE").ToString
                    If conta <> 0 Then
                        If cliente = clientePrec Then
                            ticket += "," & tabella.Rows(conta).Item("TICKET").ToString
                            tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
                        Else
                            dgvCalendario.Rows(j).Cells(2).Value = ticket
                            dgvCalendario.Rows(j).Cells(3).Value = clientePrec
                            dgvCalendario.Rows(j).Cells(4).Value = tempo
                            dgvCalendario.Rows(j).Cells(5).Value = DateLavorative(i)
                            dgvCalendario.Rows(j).Cells(6).Value = tabella.Rows(conta - 1).Item("CONSUNTIVATO").ToString

                            tempoTot += tempo
                            tempo = 0
                            j += 1

                            ticket = tabella.Rows(conta).Item("TICKET").ToString
                            tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
                        End If
                    Else
                        ticket = tabella.Rows(conta).Item("TICKET").ToString
                        tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
                    End If


                    clientePrec = tabella.Rows(conta).Item("CLIENTE").ToString
                Else
                    dgvCalendario.Rows(j).Cells(2).Value = ticket
                    dgvCalendario.Rows(j).Cells(3).Value = clientePrec
                    dgvCalendario.Rows(j).Cells(4).Value = tempo
                    dgvCalendario.Rows(j).Cells(5).Value = DateLavorative(i)
                    dgvCalendario.Rows(j).Cells(6).Value = tabella.Rows(conta - 1).Item("CONSUNTIVATO").ToString

                    tempoTot += tempo
                    tempo = 0
                    j += 1
                    'conta = tabella.Rows.Count - 1
                End If
            Loop Until conta > tabella.Rows.Count - 1 OrElse DateLavorative(i) <> tabella.Rows(conta).Item("DATA").ToString

            dgvCalendario.Rows(j).Cells(2).Value = ""
            dgvCalendario.Rows(j).Cells(3).Value = "TOTALE:"
            dgvCalendario.Rows(j).Cells(4).Value = tempoTot
            dgvCalendario.Rows(j).Cells(5).Value = ""
            dgvCalendario.Rows(j).Cells(6).Value = ""

            Dim color As Color
            Dim converter As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(color)
            dgvCalendario.Rows(j).DefaultCellStyle.BackColor = converter.ConvertFromString("51; 136; 202")
            dgvCalendario.Rows(j).DefaultCellStyle.ForeColor = Color.White
            dgvCalendario.Rows(j).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

            If tempoTot < 8 Then
                dgvCalendario.Rows(j).Cells(4).Style.BackColor = converter.ConvertFromString("255; 216; 26")
                dgvCalendario.Rows(j).Cells(4).Style.ForeColor = Color.Black
            ElseIf tempoTot = 8 Then
                dgvCalendario.Rows(j).Cells(4).Style.BackColor = converter.ConvertFromString("60; 202; 51")
                dgvCalendario.Rows(j).Cells(4).Style.ForeColor = Color.Black
            Else
                dgvCalendario.Rows(j).Cells(4).Style.BackColor = converter.ConvertFromString("202; 51; 60")
            End If

            j += 1
            tempoTot = 0
        Next
    End Sub
    Private Sub btnConsuntivaTutto_Click(sender As Object, e As EventArgs) Handles btnConsuntivaTutto.Click
        MsgBox("Coming soon")
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
End Class
