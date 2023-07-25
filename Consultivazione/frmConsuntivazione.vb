Imports System.IO
Imports System.Data.OleDb
Imports System.Net
Imports System.Xml
Imports System.Runtime.InteropServices

Public Class frmConsuntivazione
    ReadOnly giornoOggi As String = Now.ToShortDateString
    Public strConn As String
    Public fileConfig As String
    Public modDebug As Boolean = False

    Dim logPath As String
    Dim logLoad As String
    Dim logTicket As String
    Dim logConsuntivaTutto As String
    Public logModifica As String
    Public logConfig As String
    Public logCommesseClienti As String
    Public logInsMassivTicket As String
    Public logInsMassivComm As String

    Public dataOraLog As String = ""
    Dim updatePath As String = Application.ExecutablePath.Replace("Consuntivazione.exe", "CheckUpdates.exe")

    Public Sub Consuntivazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modDebug = Application.StartupPath.EndsWith("Debug")

        inizializzazioneLogPath()

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log Consuntivazione Load:")
        End Using
        If Not controlloPathConfig() OrElse Not controlloPathDB() Then
            Using logFile As New System.IO.StreamWriter(logLoad, True)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Consuntivazione Load - KO")
            End Using
            Me.Close()
            Exit Sub
        End If
        impostaConfig()

        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "Verifica Aggiornamenti:")
        End Using

        Dim processName As String = Path.GetFileNameWithoutExtension(updatePath)
        If CheckForUpdates() Then
            If Process.GetProcessesByName(processName).Length = 0 Then
                Process.Start(updatePath)
            End If
            If obbligatorio Then
                Me.Close()
                Exit Sub
            End If
        End If

        caricaClientiTempo()
        DataGrid()
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
        lblTicketMssivi.BackColor = lblSfondoColorato.BackColor

        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "Fine scrittura log Consuntivazione Load - OK")
        End Using
    End Sub

    Sub inizializzazioneLogPath()
        If modDebug Then
            logPath = Application.StartupPath.Replace("\bin\Debug", "\Log")
        Else
            logPath = Application.StartupPath + "\Resources\Log"
        End If

        If Not Directory.Exists(logPath) Then
            Directory.CreateDirectory(logPath)
        End If

        logLoad = logPath + "\ApplicationLoad.log"
        If Not File.Exists(logLoad) Then
            Using fs As FileStream = File.Create(logLoad)
            End Using
        End If

        logTicket = logPath + "\InsTicket.log"
        If Not File.Exists(logTicket) Then
            Using fs As FileStream = File.Create(logTicket)
            End Using
        End If

        logConsuntivaTutto = logPath + "\ConsuntivaTutto.log"
        If Not File.Exists(logConsuntivaTutto) Then
            Using fs As FileStream = File.Create(logConsuntivaTutto)
            End Using
        End If

        logModifica = logPath + "\ModifTicket.log"
        If Not File.Exists(logModifica) Then
            Using fs As FileStream = File.Create(logModifica)
            End Using
        End If

        logConfig = logPath + "\Config.log"
        If Not File.Exists(logConfig) Then
            Using fs As FileStream = File.Create(logConfig)
            End Using
        End If

        logCommesseClienti = logPath + "\CommesseClienti.log"
        If Not File.Exists(logCommesseClienti) Then
            Using fs As FileStream = File.Create(logCommesseClienti)
            End Using
        End If

        logInsMassivComm = logPath + "\InsMassivComm.log"
        If Not File.Exists(logInsMassivComm) Then
            Using fs As FileStream = File.Create(logInsMassivComm)
            End Using
        End If

        logInsMassivTicket = logPath + "\InsMassivTicket.log"
        If Not File.Exists(logInsMassivTicket) Then
            Using fs As FileStream = File.Create(logInsMassivTicket)
            End Using
        End If
    End Sub

    Dim currentVersion As String = "0.0.0.0"
    Dim latestVersion As String = "0.0.0.0"
    Dim obbligatorio As Boolean = True
    Function CheckForUpdates()
        Dim xmlURL As String = "https://raw.githubusercontent.com/zFla99/Consuntivazione_Portable/main/versione.xml"
        Dim client As New WebClient()
        Dim data As String = client.DownloadString(xmlURL)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.LoadXml(data)
        latestVersion = xmlDoc.SelectSingleNode("//version").InnerText
        obbligatorio = xmlDoc.SelectSingleNode("//mandatory").InnerText

        If latestVersion > currentVersion Then
            Using logFile As New System.IO.StreamWriter(logLoad, True)
                logFile.WriteLine(dataOraLog + "Nuovo aggiornamento disponibile: " & latestVersion)
                logFile.WriteLine(dataOraLog + "Fine Aggiornamenti - OK")
            End Using
            Return True
        Else
            Using logFile As New System.IO.StreamWriter(logLoad, True)
                logFile.WriteLine(dataOraLog + "Nessun aggiornamento disponibile")
                logFile.WriteLine(dataOraLog + "Fine Aggiornamenti - OK")
            End Using
            Return False
        End If
    End Function

    Function controlloPathConfig() As Boolean
        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "Inizio controllo path config:")

            fileConfig = If(modDebug, Application.StartupPath.Replace("\bin\Debug", "\Config\config.ini"), Application.StartupPath + "\Resources\Config\config.ini")

            If Not File.Exists(fileConfig) Then
                logFile.WriteLine(dataOraLog + "Errore: Il file di config.ini non è stato trovato nella cartella Resources del progetto")
                logFile.Close()
                MsgBox("Il file di config.ini non è stato trovato nella cartella Resources del progetto.", MsgBoxStyle.Critical)
                Return False
            End If
            logFile.WriteLine(dataOraLog + "Fiine controllo path config - OK")
        End Using
        Return True
    End Function

    Function controlloPathDB() As Boolean
        Dim sr As New StreamReader(fileConfig)
        Dim appoggio As String = sr.ReadLine
        Dim selezionaModifica As String = ""
        Dim path As String = ""

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "Inizio controllo path DB:")
            Do
                If appoggio.StartsWith("[") Then
                    selezionaModifica = appoggio.Replace("[", "")
                    selezionaModifica = selezionaModifica.Replace("]", "")
                    appoggio = sr.ReadLine()
                End If
                If selezionaModifica = "ConfigImp" Then
                    Dim index As Integer = appoggio.IndexOf("=") + 1
                    Dim value As String = appoggio.Substring(index, appoggio.Length - index)

                    If appoggio.Contains("DB_PATH") Then
                        path = value
                        If path = "" Then
                            If modDebug = True Then
                                strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath.Replace("\bin\Debug", "\Database\Consuntivazione.accdb")
                            Else
                                strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath + "\Resources\Database\Consuntivazione.accdb"
                            End If
                            'strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Altro\Consuntivazione\published\Database\Consuntivazione.accdb"
                        Else
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & path
                        End If
                    End If
                End If
                appoggio = sr.ReadLine()
            Loop Until appoggio = Nothing

            sr.Close()
            Dim pathFile As String
            pathFile = strConn.Substring(47, strConn.Length - 47)
            If pathFile.EndsWith("Consuntivazione.accdb") = False Then
                logFile.WriteLine(dataOraLog + "Errore: Il file selezionato non è il Database di 'Consuntivazione.accdb")
                logFile.Close()
                MsgBox("Il file selezionato non è il Database di 'Consuntivazione.accdb'. 
Cambialo!", MsgBoxStyle.Critical)
                frmImpostazioni.ShowDialog()
                Return False
            End If
            If File.Exists(pathFile) = False Then
                logFile.WriteLine(dataOraLog + "Errore: Database non trovato nel seguente path: " & pathFile & ".")
                logFile.Close()
                MsgBox("Database non trovato nel seguente path: " & pathFile & ".
Cambialo!", MsgBoxStyle.Critical)
                frmImpostazioni.ShowDialog()
                Return False
            End If
            If path = "" Then
                frmImpostazioni.applicaModifiche(pathFile)
            End If
            logFile.WriteLine(dataOraLog + "Fine controllo path DB - OK")
        End Using
        Return True
    End Function

    Public coloreIcone As String = ""
    Public AggAutDettaglio As Boolean
    Public AggAutGiornoAttuale As Boolean
    Sub impostaConfig()
        Dim sr As New StreamReader(fileConfig)
        Dim appoggio As String = sr.ReadLine
        Dim selezionaModifica As String = ""

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "Inizio impostazione config:")
            Do
                If appoggio.StartsWith("[") Then
                    selezionaModifica = appoggio.Replace("[", "")
                    selezionaModifica = selezionaModifica.Replace("]", "")
                    appoggio = sr.ReadLine()
                End If
                If selezionaModifica = "ApplicationInfo" Then
                    Dim index As Integer = appoggio.IndexOf("=") + 1
                    Dim value As String = appoggio.Substring(index, appoggio.Length - index)
                    If appoggio.Contains("Versione") Then
                        currentVersion = value
                        Me.Text = "Consuntivazione - " & currentVersion.Substring(0, currentVersion.Length - 2)
                    End If
                End If
                If selezionaModifica = "ItemColor" Then
                    Dim index As Integer = appoggio.IndexOf("=") + 1
                    Dim value As String = appoggio.Substring(index, appoggio.Length - index)

                    If appoggio.Contains("InserisciMenu_BackColor") Then
                        lblSfondoColorato.BackColor = ColorTranslator.FromHtml(value)
                        lblSlide.BackColor = ColorTranslator.FromHtml(value)
                        pnlInserisci.BackColor = ColorTranslator.FromHtml(value)
                        pnlMenu.BackColor = ColorTranslator.FromHtml(value)

                        logFile.WriteLine(dataOraLog + "Impostati colori [InserisciMenu_BackColor]")
                    ElseIf appoggio.Contains("InserisciMenu_ForeColor") Then
                        lblGiorno.ForeColor = ColorTranslator.FromHtml(value)
                        lblTicket.ForeColor = ColorTranslator.FromHtml(value)
                        lblCliente.ForeColor = ColorTranslator.FromHtml(value)
                        lblAggiungiCliente.ForeColor = ColorTranslator.FromHtml(value)
                        lblTempo.ForeColor = ColorTranslator.FromHtml(value)
                        lblNota.ForeColor = ColorTranslator.FromHtml(value)
                        ckbHome.ForeColor = ColorTranslator.FromHtml(value)

                        lblTicketMssivi.ForeColor = ColorTranslator.FromHtml(value)
                        lblCommesseMassive.ForeColor = ColorTranslator.FromHtml(value)
                        lblSeparatore.ForeColor = ColorTranslator.FromHtml(value)
                        lblTema.ForeColor = ColorTranslator.FromHtml(value)
                        lblDocumentazione.ForeColor = ColorTranslator.FromHtml(value)
                        lblImpostazioni.ForeColor = ColorTranslator.FromHtml(value)

                        logFile.WriteLine(dataOraLog + "Impostati colori [InserisciMenu_ForeColor]")
                    ElseIf appoggio.Contains("Form_BackColor") Then
                        Me.BackColor = ColorTranslator.FromHtml(value)

                        Dim red As Integer = ColorTranslator.FromHtml(value).R
                        Dim green As Integer = ColorTranslator.FromHtml(value).G
                        Dim blu As Integer = ColorTranslator.FromHtml(value).B

                        Call colorHover(red, green, blu)
                        pnlFiltri.BackColor = Color.FromArgb(red, green, blu)

                        Dim t As Double = ColorTranslator.FromHtml(value).GetBrightness
                        If t <= 0.41 Then
                            lblFiltri.Image = Consuntivazione.My.Resources.Resources.menuChiuso_16x16_bianco
                        Else
                            lblFiltri.Image = Consuntivazione.My.Resources.Resources.menuChiuso_16x16_nero
                        End If

                        logFile.WriteLine(dataOraLog + "Impostati colori [Form_BackColor]")
                    ElseIf appoggio.Contains("From_ForeColor") Then
                        lblFiltriSelezionati.ForeColor = ColorTranslator.FromHtml(value)
                        lblGiorno_Mese.ForeColor = ColorTranslator.FromHtml(value)
                        lblTempoTot.ForeColor = ColorTranslator.FromHtml(value)

                        lblTicketFiltro.ForeColor = ColorTranslator.FromHtml(value)
                        lblClienteFiltro.ForeColor = ColorTranslator.FromHtml(value)
                        lblConsuntivatoFiltro.ForeColor = ColorTranslator.FromHtml(value)
                        lblNotaFiltro.ForeColor = ColorTranslator.FromHtml(value)
                        lblDataDaFiltro.ForeColor = ColorTranslator.FromHtml(value)
                        lblDataAFiltro.ForeColor = ColorTranslator.FromHtml(value)
                        lblAnno.ForeColor = ColorTranslator.FromHtml(value)
                        lblMesi.ForeColor = ColorTranslator.FromHtml(value)

                        logFile.WriteLine(dataOraLog + "Impostati colori [From_ForeColor]")
                    End If
                End If
                If selezionaModifica = "IconColor" Then
                    If appoggio.Contains("IconsColor") Then
                        If appoggio.Contains("white") Then
                            imgCommesseMassive.Image = Consuntivazione.My.Resources.Resources.commesse_32x32_bianco
                            imgDocumentazione.Image = Consuntivazione.My.Resources.Resources.documentazione_32x32_bianco
                            imgTema.Image = Consuntivazione.My.Resources.Resources.pennello_32x32_bianco
                            imgTicketMassivi.Image = Consuntivazione.My.Resources.Resources.ticket_32x32_bianco
                            imgImpostazioni.Image = Consuntivazione.My.Resources.Resources.impostazioni_32x32_bianco
                            lblSlide.Image = Consuntivazione.My.Resources.Resources.menuChiuso_32x32_bianco
                            coloreIcone = "white"
                        Else
                            imgCommesseMassive.Image = Consuntivazione.My.Resources.Resources.commesse_32x32_nero
                            imgDocumentazione.Image = Consuntivazione.My.Resources.Resources.documentazione_32x32_nero
                            imgTema.Image = Consuntivazione.My.Resources.Resources.pennello_32x32_nero
                            imgTicketMassivi.Image = Consuntivazione.My.Resources.Resources.ticket_32x32_nero
                            imgImpostazioni.Image = Consuntivazione.My.Resources.Resources.impostazioni_32x32_nero
                            lblSlide.Image = Consuntivazione.My.Resources.Resources.menuChiuso_32x32_nero
                            coloreIcone = "black"
                        End If
                    End If

                    logFile.WriteLine(dataOraLog + "Impostate icone [IconColor]")
                End If
                If selezionaModifica = "ConfigImp" Then
                    Dim index As Integer = appoggio.IndexOf("=") + 1
                    Dim value As String = appoggio.Substring(index, appoggio.Length - index)
                    If appoggio.Contains("AggAutGiornoAttuale") Then
                        AggAutGiornoAttuale = value
                        logFile.WriteLine(dataOraLog + "Impostate impostazioni [AggAutGiornoAttuale]")
                    ElseIf appoggio.Contains("AggAutDettaglio") Then
                        AggAutDettaglio = value
                        logFile.WriteLine(dataOraLog + "Impostate impostazioni [AggAutDettaglio]")
                    End If
                End If
                appoggio = sr.ReadLine()
            Loop Until appoggio = Nothing
            sr.Close()
            logFile.WriteLine(dataOraLog + "Fine impostazione config - OK")
        End Using
    End Sub
    Private Sub Consuntivazione_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        frmSfondoNero.Location = New Point(Me.Location.X + 206, Me.Location.Y + 31)
        If Me.Width > Me.MinimumSize.Width Then
            frmSfondoNero.Size = New Size(Me.Width - 214, Me.Height - 39)
        Else
            frmSfondoNero.Size = New Size(Me.Width - 216, Me.Height - 39)
        End If
    End Sub
    Private Sub frmConsuntivazione_Move(sender As Object, e As EventArgs) Handles Me.Move
        frmSfondoNero.Location = New Point(Me.Location.X + 206, Me.Location.Y + 31)
        If Me.Width > Me.MinimumSize.Width Then
            frmSfondoNero.Size = New Size(Me.Width - 214, Me.Height - 39)
        Else
            frmSfondoNero.Size = New Size(Me.Width - 216, Me.Height - 39)
        End If
    End Sub
    Private Sub frmConsuntivazione_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If pnlMenu.Width = 200 Then
            lblSlide_Click(sender, e)
        End If
    End Sub
    Private Sub Consuntivazione_Click(sender As Object, e As EventArgs) Handles Me.Click
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
        If menuFiltriChiuso = False Then
            lblFiltri_Click(sender, e)
        End If
    End Sub
    Private Sub pnlMensile_Click(sender As Object, e As EventArgs) Handles pnlMensile.Click
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
        If menuFiltriChiuso = False Then
            lblFiltri_Click(sender, e)
        End If
    End Sub
    Private Sub pnlInserisci_Click(sender As Object, e As EventArgs) Handles pnlInserisci.Click
        dgvCalendario.ClearSelection()
        txtTicket.Focus()
    End Sub
    Private Sub lblSfondoBlu_Click(sender As Object, e As EventArgs) Handles lblSfondoColorato.Click
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

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logLoad, True)
            logFile.WriteLine(dataOraLog + "Inizio caricamento Clienti e Tempo:")
            Try
                cn = New OleDbConnection(strConn)
                cn.Open()
                str = "Select Cliente FROM Clienti ORDER BY Cliente"
                cmd = New OleDbCommand(str, cn)
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.Close()
                Exit Sub
            End Try

            cmbCliente.Items.Clear()
            cmbClienteFiltro.Items.Clear()
            frmModifica.cmbCliente.Items.Clear()
            frmCommesse.cmbCliente.Items.Clear()
            For i = 0 To tabella.Rows.Count - 1
                cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
                cmbClienteFiltro.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
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

            logFile.WriteLine(dataOraLog + "Fine caricamento Clienti e Tempo - OK")
        End Using
    End Sub
    Sub RedimDGV()
        dgvCalendario.Columns(5).Width = dgvCalendario.Width * 17 / 100
    End Sub
    Dim giorno As String
    Dim ticket As String
    Dim cliente As String
    Dim nota As String
    Dim tempo As Double
    Private Sub txtTicket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTicket.KeyPress, txtTicketFiltro.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46))) AndAlso e.KeyChar <> "/" AndAlso e.KeyChar <> "C" AndAlso e.KeyChar <> "c") Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCliente.KeyPress, cmbClienteFiltro.KeyPress, cmbConsuntivazioneFiltro.KeyPress, cmbNotaFiltro.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "," Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub cmbTempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTempo.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46))) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmbNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNota.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "," Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub

    Dim notaExtra As String = ""
    Private Sub BtnCarica_Click(sender As Object, e As EventArgs) Handles btnCarica.Click

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

        ticket = txtTicket.Text.Replace("'", "").Trim.ToUpper
        If ticket.Contains("/") Then
            ticket = "/"
        End If
        cliente = StrConv(cmbCliente.Text.Replace("'", "").Trim, VbStrConv.ProperCase)
        tempo = cmbTempo.Text.Replace(".", ",").Trim
        giorno = dtpData.Text

        If tempo + CDbl(lblTempoTot.Text) > 8 Then
            Dim tempo1 As Double = 8 - CDbl(lblTempoTot.Text)
            Dim tempo2 As Double = tempo - tempo1
            For i = 1 To dgvCalendario.Rows.Count - 1
                Dim notaRiga As String = dgvCalendario.Rows(i).Cells(6).Value
                If notaRiga.ToLower.Contains("extra") Then
                    Dim indice As Integer = notaRiga.IndexOf("(") + 1
                    notaRiga = notaRiga.Replace(")", "")
                    tempo2 -= CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                End If
            Next
            notaExtra = "Extra(" & tempo2 & ")"
        End If

        Call InserisciTicket()
        Call AggiornaDG(giorno, AggAutGiornoAttuale)
        Call PulisciCampi()
    End Sub
    Sub DataGrid()
        dgvCalendario.RowCount = 2
        dgvCalendario.ColumnCount = 8
        dgvCalendario.Rows(0).Visible = False
        dgvCalendario.Columns(0).Visible = False
        dgvCalendario.Columns(7).Visible = False

        dgvCalendario.Columns(1).HeaderText() = "TICKET"
        dgvCalendario.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCalendario.Columns(2).HeaderText() = "CLIENTE"
        dgvCalendario.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCalendario.Columns(3).HeaderText() = "TEMPO"
        dgvCalendario.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCalendario.Columns(4).HeaderText() = "DATA"
        dgvCalendario.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCalendario.Columns(5).HeaderText() = "CONSUNTIVATO"
        dgvCalendario.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCalendario.Columns(6).HeaderText() = "NOTA"
        dgvCalendario.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvCalendario.Columns(7).HeaderText() = "ID_RIGA"
        dgvCalendario.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable

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

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logTicket, True)
            logFile.WriteLine(dataOraLog + "--------------------------")
            logFile.WriteLine(dataOraLog + "Inizio inserimento ticket:")
        End Using

        If ticket <> "/" Then
            ControlloDoppioniGiornalieri(ticket, duplicato, id)
            If duplicato = True Then
                Call ModificaDuplicato(3, id, tempo)
                Exit Sub
            End If
        End If

        Using logFile As New System.IO.StreamWriter(logTicket, True)
            cn = New OleDbConnection(strConn)
            Try
                ' Utilizzo di parametri per evitare l'iniezione SQL
                cn.Open()
                str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = ?"
                cmd = New OleDbCommand(str, cn)
                cmd.Parameters.AddWithValue("Cliente", cliente)
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                Exit Sub
            End Try

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

            Dim notaInput As String
            notaInput = cmbNota.Text.Trim.ToLower
            notaInput = notaInput.Replace("'", "")
            notaInput = notaInput.Replace(",", "")
            notaInput = StrConv(notaInput, VbStrConv.ProperCase)

            If notaInput = "Criticità" Then
                For i = 0 To tabella.Rows.Count - 1
                    If vetCommNota(i) = "" Then
                        conta += 1
                    End If
                Next
                If nota = "" Then
                    nota = "Criticità"
                Else
                    nota += ", Criticità"
                End If
            ElseIf notaInput = "" Then
                For i = 0 To tabella.Rows.Count - 1
                    If vetCommNota(i) = "" Then
                        conta += 1
                    End If
                Next
            End If

            If notaInput <> "" And notaInput <> "Criticità" Then
                If notaInput.Length > 150 Then
                    MsgBox("Nota non valida (Max 150 car.)", MsgBoxStyle.Exclamation)
                    logFile.WriteLine(dataOraLog + "Errore: Nota non valida (Max 150 car.)")
                    logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                    logFile.Close()
                    Exit Sub
                ElseIf notaInput.ToLower.Contains("criticità") Or notaInput.ToLower.Contains("home") Then
                    MsgBox("Nota non valida (non puo essere uno dei valori gia predefiniti)", MsgBoxStyle.Exclamation)
                    logFile.WriteLine(dataOraLog + "Errore: Nota non valida (non puo essere uno dei valori gia predefiniti)")
                    logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                    logFile.Close()
                    Exit Sub
                ElseIf notaInput.ToLower.Contains("extra") Then
                    MsgBox("Nota non valida (in fase di inserimento, la nota extra viene settata in automatico)", MsgBoxStyle.Exclamation)
                    logFile.WriteLine(dataOraLog + "Errore: Nota non valida (in fase di inserimento, la nota extra viene settata in automatico)")
                    logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                    logFile.Close()
                    Exit Sub
                End If

                For i = 0 To tabella.Rows.Count - 1
                    If vetCommNota(i) = notaInput Then
                        conta += 1
                    End If
                Next

                If conta > 1 And nota <> "" Then
                    MsgBox("Non è consentito inserire 2 commesse nelle note!", MsgBoxStyle.Exclamation)
                    logFile.WriteLine(dataOraLog + "Errore: Non è consentito inserire 2 commesse nelle note!")
                    logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                    logFile.Close()
                    Exit Sub
                End If

                If nota = "" Then
                    nota = notaInput
                Else
                    nota += ", " & notaInput
                End If
            End If

            If conta = 0 And notaInput <> "" Then
                For i = 0 To tabella.Rows.Count - 1
                    If vetCommNota(i) = "" Then
                        conta += 1
                    End If
                Next
            End If
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa standard", MsgBoxStyle.Exclamation)
                logFile.WriteLine(dataOraLog + "Errore: " & cliente & " non ha la commessa standard")
                logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                logFile.Close()
                Exit Sub
            End If

            If notaExtra <> "" Then
                Dim tempoExtra As String
                Dim vetDividiNota() As String
                If nota.ToLower.Contains("extra(") Then
                    vetDividiNota = nota.Split("(")
                    tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
                    nota = nota.Replace("Extra(" & tempoExtra & ")", "")
                End If

                If nota = "" Then
                    nota = notaExtra
                Else
                    nota += ", " + notaExtra
                End If

                notaExtra = ""
            End If

            ' Utilizzo di parametri per evitare l'iniezione SQL e riduzione del numero di chiamate al database raggruppando le query quando possibile.
            Try
                cn.Open()
                cmd.Parameters.Clear()

                If nota = "" Then
                    StrSQL = "INSERT into Consuntivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO, NOTA) VALUES (?, ?, ?, ?, 'NO', NULL)"
                Else
                    StrSQL = "INSERT into Consuntivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO, NOTA) VALUES (?, ?, ?, ?, 'NO', ?)"
                End If

                cmd.CommandText = StrSQL
                cmd.Parameters.AddWithValue("TICKET", ticket)
                cmd.Parameters.AddWithValue("CLIENTE", cliente)
                cmd.Parameters.AddWithValue("TEMPO_RISOLUZIONE", tempo)
                cmd.Parameters.AddWithValue("DATA", giorno)

                If nota <> "" Then
                    cmd.Parameters.AddWithValue("NOTA", nota)
                End If

                nRighe = cmd.ExecuteNonQuery()

                str = "SELECT MAX(ID) AS ID_MAX FROM Consuntivazione"
                cmd.CommandText = str
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()

                id = tabella.Rows(0).Item("ID_MAX")
            Catch ex As Exception
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                logFile.Close()
                Exit Sub
            End Try

            logFile.WriteLine(dataOraLog + "Inserito [Ticket: " & ticket & "] - [Cliente: " & cliente & "] - [Tempo: " & tempo & "] - [Data: " & giorno & "] - [Nota: " & If(nota = "", "''", nota) & "]")
        End Using
        Call modificaTutteNote(id)
    End Sub


    Sub modificaTutteNote(id As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        Using logFile As New System.IO.StreamWriter(logTicket, True)
            cn = New OleDbConnection(strConn)
            Try
                cn.Open()
                str = "SELECT DATA, NOTA, ID FROM Consuntivazione WHERE DATA =#" & giorno & "#"
                cmd = New OleDbCommand(str, cn)
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                Exit Sub
            End Try

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
                    If contiene Then
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
                        logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                        logFile.WriteLine(dataOraLog + "Fine inserimento ticket - KO")
                        logFile.Close()
                        MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                        Exit Sub
                    End Try
                    cn.Close()
                End If
            Next
            If contiene Then
                logFile.WriteLine(dataOraLog + "Impostato Home in tutte le note del " & giorno)
            Else
                logFile.WriteLine(dataOraLog + "Rimosso Home in tutte le note del " & giorno)
            End If
            logFile.WriteLine(dataOraLog + "Fine inserimento ticket - OK")
        End Using
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

    Dim sommaExtra As Double = 0
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
        Dim extra As Double = 0
        Dim dataGiorno As Date = giorno

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE DATA=#" & Format(dataGiorno, "MM/dd/yyyy") & "# ORDER BY ID"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim ticketLink As New DataGridViewLinkCell
        dgvCalendario.RowCount = 1
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            ticketLink.Value = tabella.Rows(i).Item("TICKET").ToString
            dgvCalendario.Rows(i + 1).Cells(1).Value = ticketLink.Value
            dgvCalendario.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("CLIENTE").ToString
            dgvCalendario.Rows(i + 1).Cells(3).Value = tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            somma += tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "")
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("NOTA").ToString
            If tabella.Rows(i).Item("NOTA").ToString.Contains("Extra") = True Then
                Dim tempoExtra As String
                Dim vetDividiNota() As String
                vetDividiNota = tabella.Rows(i).Item("NOTA").ToString.Split("(")
                tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
                extra += tempoExtra
            End If
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        lblTempoTot.Text = somma
        sommaExtra = extra
        Call RedimDGV()
    End Sub

    Sub AggiornaConsuntivato(cliente As String, ticket As String, data As Date, consuntivato As String)
        Dim vetNumTicket() As String = ticket.Split("%2C")
        Dim numTicket As Integer = vetNumTicket.Length
        Dim ticketVet() As String
        ticketVet = Split(ticket, "%2C")

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        For i = 0 To numTicket - 1
            cn.Open()
            If ticketVet(i) = "Criticità" Then
                str = "UPDATE Consuntivazione SET CONSUNTIVATO = '" & consuntivato & "' WHERE TICKET = '/' AND DATA = #" & Format(data, "MM/dd/yyyy") & "# AND CLIENTE = '" & cliente & "'"
            Else
                str = "UPDATE Consuntivazione SET CONSUNTIVATO = '" & consuntivato & "' WHERE TICKET = '" & ticketVet(i) & "' AND DATA = #" & Format(data, "MM/dd/yyyy") & "# AND CLIENTE = '" & cliente & "'"
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
    End Sub
    Sub PulisciCampi()
        If AggAutGiornoAttuale = True Then
            dtpData.Value = Now
        End If
        txtTicket.Text = ""
        cmbCliente.Text = ""
        cmbTempo.Text = ""
        cmbNota.Text = ""
        txtTicket.Focus()
    End Sub
    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        If aggiornaByData = False Then
            Exit Sub
        End If
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
                Dim cliente As String = dgvCalendario.Rows(e.RowIndex).Cells(2).Value
                ticket = ticket.Replace(",", "%2C")
                Dim data As String = dgvCalendario.Rows(e.RowIndex).Cells(4).Value
                Dim consuntivato As String = dgvCalendario.Rows(e.RowIndex).Cells(5).Value

                If consuntivato = "SI" Then
                    If MsgBox("Risulta gia consuntivato. Vuoi rimettere a 'NO'?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        consuntivato = "NO"
                        Call AggiornaConsuntivato(cliente, ticket, data, consuntivato)
                        dgvCalendario.Rows(e.RowIndex).Cells(5).Value = consuntivato
                        Exit Sub
                    End If
                    Exit Sub
                ElseIf consuntivato = "NO" Then
                    consuntivato = "SI"
                Else
                    Exit Sub
                End If

                dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
                Using logFile As New System.IO.StreamWriter(logConsuntivaTutto, True)
                    If RDC > 0 Then
                        logFile.WriteLine(dataOraLog + "--------------------------")
                        logFile.WriteLine(dataOraLog + "Inizio consuntivazione ticket:")
                        logFile.WriteLine(dataOraLog + "Ticket da consuntivare: 1")
                    End If

                    Dim tempo As String = dgvCalendario.Rows(e.RowIndex).Cells(3).Value.ToString.Replace(",", ".")
                    Dim nota As String = dgvCalendario.Rows(e.RowIndex).Cells(6).Value

                    Dim home As String = "SEDE"
                    If nota.Contains("Home") Then
                        home = "SW"
                        nota = nota.Replace("Home, ", "")
                    End If

                    Dim extra As Boolean = False
                    Dim tempoExtra As String = ""
                    Dim vetDividiNota() As String
                    If nota.ToLower.Contains("extra(") Then
                        vetDividiNota = nota.Split("(")
                        tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
                        nota = nota.Replace("Extra(" & tempoExtra & ")", "")
                        tempoExtra = tempoExtra.Replace(",", ".")
                        extra = True
                    End If

                    Dim vetNota() = nota.Split(",")
                    For i = 0 To vetNota.Length - 1
                        If vetNota(i).ToLower.Trim = "fixed" Then
                            nota = "Fixed"
                        ElseIf vetNota(i).ToLower.Trim = "formazione" Then
                            nota = "Formazione"
                        End If
                    Next

                    Dim dataInvertitaMatrice() As String
                    dataInvertitaMatrice = data.Split("/")
                    Dim dataInvertita As String = dataInvertitaMatrice(2) & "-" & dataInvertitaMatrice(1) & "-" & dataInvertitaMatrice(0)
                    Dim link As String = "http://goldenring.tesisquare.com/client/procedure/ra/fra080formoremese.cfm?"

                    Dim cn As OleDbConnection
                    Dim cmd As OleDbCommand
                    Dim da As OleDbDataAdapter
                    Dim tabella As New DataTable
                    Dim str As String


                    cn = New OleDbConnection(strConn)
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

                    link += "&Data=" & data & "&Sede=" & home & "&Ora=" & dataInvertita & "%2000:00:00.0&Oreviaggio=0&Indrec=0&Note=" & ticket & "&CentroCosto=&IdProcedura=%20&AnnoRichiesta=0&IDRichiesta=0&OreDiRecupero=0"

                    If extra = True And tempoExtra = tempo Then
                        link += "&Orelav=" & tempoExtra & "&OreStra=" & tempoExtra & "&OreOrd=0"
                    ElseIf extra = True And tempoExtra <> tempo Then
                        link += "&Orelav=" & tempo & "&OreStra=" & tempoExtra & "&OreOrd=" & CStr(CDbl(tempo.Replace(".", ",")) - CDbl(tempoExtra.Replace(".", ","))).Replace(",", ".")
                    Else
                        link += "&Orelav=" & tempo & "&OreStra=0&OreOrd=" & tempo
                    End If

                    If home = "SEDE" Then
                        link += "&flag_lavorodacasa=N"
                    Else
                        link += "&flag_lavorodacasa=Y"
                    End If

                    Process.Start(link)

                    Call AggiornaConsuntivato(cliente, ticket, data, consuntivato)
                    dgvCalendario.Rows(e.RowIndex).Cells(5).Value = consuntivato
                    If RDC > 0 Then
                        logFile.WriteLine("Consuntivato [Ticket: " & ticket.Replace("%2C", ",") & "] - [Cliente: " & cliente & "] - [Tempo: " & If(IsNumeric(tempo), tempo, "0") & "] - TempoExtra: [" & If(IsNumeric(tempoExtra), tempoExtra, "0") & "] - [Data: " & data & "] - [Nota: " & If(nota = "", "''", nota) & "] - [Luogo: " & home & "]")
                    Else
                        logFile.WriteLine(dataOraLog & "1/1 - Consuntivato [Ticket: " & ticket.Replace("%2C", ",") & "] - [Cliente: " & cliente & "] - [Tempo: " & If(IsNumeric(tempo), tempo, "0") & "] - TempoExtra: [" & If(IsNumeric(tempoExtra), tempoExtra, "0") & "] - [Data: " & data & "] - [Nota: " & If(nota = "", "''", nota) & "] - [Luogo: " & home & "]")
                        logFile.WriteLine(dataOraLog + "Fine consuntivazione ticket - OK")
                    End If
                End Using
            End If
        Else
            If e.ColumnIndex = 1 Then
                If dgvCalendario.Item(e.ColumnIndex, e.RowIndex).Value.ToString <> "/" Then
                    Process.Start("https://hda.tesisquare.com/HDAPortal/#/WSCView/Detail/" & dgvCalendario.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "$entity=Incident")
                End If
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub

    Dim vetRConsuntivare() As Integer
    Dim RDC As Integer = 0
    Private Async Sub BtnConsuntivaTutto_Click(sender As Object, e As EventArgs) Handles btnConsuntivaTutto.Click
        If MsgBox("Sei sicuro di voler consuntivare TUTTE le righe?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logConsuntivaTutto, True)
            logFile.WriteLine(dataOraLog + "--------------------------")
            logFile.WriteLine(dataOraLog + "Inizio consuntivazione ticket:")

            Dim conta As Integer = 0
            For i = 0 To dgvCalendario.Rows.Count - 1
                If dgvCalendario.Rows(i).Cells(5).Value = "NO" Then
                    conta += 1
                End If
            Next

            If conta = 0 Then
                MsgBox("Non ci sono righe da consuntivare")
                logFile.WriteLine(dataOraLog + "Non ci sono righe da consuntivare")
                logFile.WriteLine(dataOraLog + "Fine consuntivazione ticket - OK")
                logFile.Close()
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
            logFile.WriteLine(dataOraLog + "Ticket da consuntivare: " & RDC)
        End Using

        For CCons = 0 To RDC - 1
            Using logFile As New System.IO.StreamWriter(logConsuntivaTutto, True)
                Try
                    logFile.Write(dataOraLog & CCons + 1 & "/" & RDC & " - ")
                    logFile.Close()
                    clickSinistro(sender, New DataGridViewCellMouseEventArgs(5, vetRConsuntivare(CCons), 0, 0, New MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)))
                Catch ex As Exception
                    logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                    logFile.WriteLine(dataOraLog + "Fine consuntivazione ticket - KO")
                    logFile.Close()
                    MsgBox("Errore: " & ex.Message & ". Chiedere a Flavio")
                    RDC = 0
                    Exit Sub
                End Try
            End Using

            ' Attendi un secondo prima di eseguire il codice successivo
            Await Task.Delay(1500)
        Next

        ' Esegui il codice finale quando il ciclo for è terminato
        RDC = 0
        MsgBox("Consuntivazione Ticket Completata")
        Using logFile As New System.IO.StreamWriter(logConsuntivaTutto, True)
            logFile.WriteLine(dataOraLog + "Fine consuntivazione ticket - OK")
        End Using
    End Sub

    Sub clickDestro(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Dim r, c, id As Integer
        r = e.RowIndex
        c = e.ColumnIndex

        If r = -1 OrElse dgvCalendario.Rows(r).Cells(1).Value = "" Then
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
            If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Dettaglio)" Then
                Call AggiornaDGMensile(giorno.Substring(3, 2), giorno.Substring(6, 4))
            Else
                Call AggiornaDG(giorno, AggAutGiornoAttuale)
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
        ElseIf lblFiltriSelezionati.Visible = True And dgvCalendario.Columns(e.ColumnIndex).HeaderText() = "TEMPO" Then
            If MsgBox("Qui non puoi modificare. Vuoi essere reindirizzato al giorno?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                lblGiorno_Mese_Click(sender, e)
                dtpData.Text = giorno
                Call AggiornaDG(giorno, False)
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
        If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Dettaglio)" Then
            If AggAutDettaglio = True Then
                Call AggiornaDGMensile(giorno.Substring(3, 2), giorno.Substring(6, 4))
            End If
        Else
            Call AggiornaDG(giorno, AggAutGiornoAttuale)
            Call PulisciCampi()
        End If
    End Sub

    Public Shared tabellaCondivisa As String
    Public Shared colonnaCondivisa As String
    Public Shared clienteCondiviso As String
    Public Shared giornoCondiviso As String
    Public Shared rigaCondivisa As Integer
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
        rigaCondivisa = r
        idCondiviso = id

        If colonnaCondivisa <> "TICKET" And colonnaCondivisa <> "CONSUNTIVATO" Then
            frmModifica.ShowDialog()
            Exit Sub
        Else
            Dim dato As String
            If colonnaCondivisa = "TICKET" Then
                dato = InputBox("Inserisci un numero ticket")
                dato = dato.Replace("'", "").Trim.ToUpper
                If dato = "" Or dato.Length > txtTicket.MaxLength Then
                    MsgBox("Ticket non valido (Max " & txtTicket.MaxLength & " car.)")
                    annulla = True
                    Exit Sub
                End If
            Else
                dato = dgvCalendario.Rows(r).Cells(c).Value
                If dato = "NO" Then
                    dato = "SI"
                Else
                    dato = "NO"
                End If
            End If


            cn = New OleDbConnection(strConn)
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
            If AggAutDettaglio = False Then
                dgvCalendario.Rows(r).Cells(c).Value = dato
            End If
        End If
    End Sub
    Sub EliminaRiga(id As Integer)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logModifica, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log Modifica:")

            cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE * FROM Consuntivazione WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        Try
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine Modifica - KO")
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                Exit Sub
            End Try
            cn.Close()
            logFile.WriteLine(dataOraLog + "Cancellata riga con ID: '" & id & "'")
            logFile.WriteLine(dataOraLog + "Fine Modifica - OK")
        End Using
    End Sub
    Dim aggiornaByData = True
    Private Sub lblGiorno_Mese_Click(sender As Object, e As EventArgs) Handles lblGiorno_Mese.Click
        If noSpam = True Then
            Exit Sub
        End If
        If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Giornaliero)" Then
            lblGiorno_Mese.Text = "Totale 
ore di lavoro
(Dettaglio)"
            Call PulisciCampi()
            pnlInserisci.Visible = False
            lblSfondoColorato.Visible = False
            lblSlide.Visible = False
            pnlMenu.Width = 0
            lstMesi.Visible = True
            lblMesi.Visible = True
            lblAnno.Visible = True
            nudAnno.Visible = True
            nudAnno.Enabled = True
            lblFiltri.Visible = True
            pnlFiltri.Visible = True
            dtpDataDaFiltro.Value = Now().AddYears(-2)
            dtpDataAFiltro.Value = Now()
            lblFiltriSelezionati.Visible = True
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnDividiXCliente.Visible = True

            pnlMensile.Left = 0
            pnlMensile.Width = Me.Width - 15
            pnlFiltri.Width = dgvCalendario.Width
            Dim Mese As String
            Dim Anno As Integer
            If resoconto = False Then
                Mese = giornoOggi.Substring(3, 2)
                Anno = giornoOggi.Substring(6, 4)
            Else
                Mese = giorno.Substring(3, 2)
                Anno = giorno.Substring(6, 4)
            End If
            If Mese < 10 Then
                lstMesi.SelectedIndex = Mese.Replace(0, "") - 1
            Else
                lstMesi.SelectedIndex = Mese - 1
            End If
            nudAnno.Value = Anno
            Call AggiornaDGMensile(Mese, Anno)

            lblFiltriSelezionati.Text = "Anno: " & Anno & "   -   Mese: " & Mese
            strWhere = "WHERE Month(DATA) = " & Mese & " AND Year(DATA) = " & Anno
        Else
            lblGiorno_Mese.Text = "Totale 
ore di lavoro
(Giornaliero)"
            pnlInserisci.Visible = True
            lblSfondoColorato.Visible = True
            lblSlide.Visible = True
            lblSlide.Left = 2
            lstMesi.Visible = False
            lblMesi.Visible = False
            lblAnno.Visible = False
            nudAnno.Visible = False
            nudAnno.Enabled = False

            pnlFiltri.Visible = False
            If menuFiltriChiuso = False Then
                lblFiltri_Click(sender, e)
            End If
            lblFiltri.Visible = False
            lblFiltriSelezionati.Visible = False
            txtTicketFiltro.Clear()
            cmbClienteFiltro.Text = ""
            cmbNotaFiltro.Text = ""
            cmbConsuntivazioneFiltro.Text = ""

            btnConsuntivaTutto.Visible = False
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnDividiXCliente.Visible = False

            pnlMensile.Location = New Point((pnlInserisci.Location.X + pnlInserisci.Width) + 30, 0)
            aggiornaByData = False
            dtpData.Value = giornoOggi
            AggiornaDG(giornoOggi, False)
            aggiornaByData = True

            pnlMensile.Width = Me.Width - lblSfondoColorato.Width - 35
            pnlFiltri.Width = pnlMensile.Width
        End If
    End Sub
    Sub AggiornaDGMensile(Mese As String, Anno As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim i As Integer
        Dim somma As Double
        Dim extra As Double


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE DATA LIKE '%/" & Mese & "/" & Anno & "' ORDER BY DATA, CLIENTE, NOTA"
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
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "")
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("NOTA").ToString
            If tabella.Rows(i).Item("NOTA").ToString.Contains("Extra") = True Then
                Dim tempoExtra As String
                Dim vetDividiNota() As String
                vetDividiNota = tabella.Rows(i).Item("NOTA").ToString.Split("(")
                tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
                extra += tempoExtra
            End If
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        lblTempoTot.Text = somma
        sommaExtra = extra
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
        Dim str As String

        Using logFile As New System.IO.StreamWriter(logTicket, True)
            cn = New OleDbConnection(strConn)
            logFile.WriteLine(dataOraLog + "Modifica Ticket")
            Try
                cn.Open()
                str = "SELECT * FROM Consuntivazione WHERE ID=" & id
                cmd = New OleDbCommand(str, cn)
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                Exit Sub
            End Try

            Dim vecchioTempo As Double = tabella.Rows(0).Item("TEMPO_RISOLUZIONE")
            Dim colonna As String = dgvCalendario.Columns(c).HeaderText
            If colonna = "TEMPO" Then
                colonna += "_RISOLUZIONE"
            End If

            Try
                cn.Open()
                str = "UPDATE Consuntivazione SET " & colonna & "='" & dato + vecchioTempo & "' WHERE ID = " & id
                cmd = New OleDbCommand(str, cn)
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                Exit Sub
            End Try
            cn.Close()
            logFile.WriteLine(dataOraLog + "Modificato tempo del ticket " & tabella.Rows(0).Item("TICKET") & " da " & vecchioTempo & " a " & dato)
            logFile.WriteLine(dataOraLog + "Fine inserimento ticket - OK")
        End Using
    End Sub

    Private Sub btnDividiXCliente_Click(sender As Object, e As EventArgs) Handles btnDividiXCliente.Click
        If btnDividiXCliente.Text = "Dividi per Cliente" Then
            btnDividiXCliente.Text = "Ritorna al Mese"
            btnConsuntivaTutto.Visible = True
        Else
            BtnCerca_Click(sender, e)
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnConsuntivaTutto.Visible = False
            Exit Sub
        End If

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT DISTINCT DATA FROM Consuntivazione " & strWhere & " ORDER BY DATA"
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
            DateLavorative(i) = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "")
        Next


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente, Nota, Link FROM LinkGR WHERE Nota IS NOT NULL OR Link LIKE '%Commessa=/%' ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim vetClienteComm(tabella.Rows.Count) As String
        Dim vetNotaComm(tabella.Rows.Count) As String
        Dim vetLinkComm(tabella.Rows.Count) As String
        For i = 0 To tabella.Rows.Count - 1
            vetClienteComm(i) = tabella.Rows(i).Item("Cliente").ToString
            vetNotaComm(i) = tabella.Rows(i).Item("Nota").ToString
            vetLinkComm(i) = tabella.Rows(i).Item("Link").ToString
        Next


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT DISTINCT CLIENTE, DATA, NOTA, COUNT(*) AS NUM_TICKET FROM Consuntivazione " & strWhere & " GROUP BY DATA, CLIENTE, NOTA ORDER BY DATA"
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
        Dim nota As String = ""
        Dim notaPrec As String = ""
        Dim comm As Boolean = False
        Dim notaComm As String = ""
        Dim commPrec As Boolean = False
        Dim notaCommPrec As String

        Call riordinaTabella(vetClienteComm, vetNotaComm, tabella, notaComm)

        For i = 0 To tabella.Rows.Count - 1
            cliente = tabella.Rows(i).Item("CLIENTE").ToString
            data = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "")
            nota = tabella.Rows(i).Item("NOTA").ToString

            comm = False
            For k = 0 To vetClienteComm.Length - 2
                If vetClienteComm(k) = cliente And nota.Contains(vetNotaComm(k)) And vetLinkComm(k).Contains("Commessa=/") And data = dataPrec And tabella.Rows.Count - 1 > 0 Then
                    TabellaNoDoppi -= 1
                ElseIf vetClienteComm(k) = cliente And nota.Contains(vetNotaComm(k)) Then
                    If vetNotaComm(k) = "" And nota = "" Then
                            comm = True
                            notaComm = vetClienteComm(k)
                        ElseIf vetNotaComm(k) <> "" Then
                            comm = True
                            notaComm = vetClienteComm(k)
                        End If
                    End If
            Next

            If i > 0 Then
                If cliente = clientePrec And data = dataPrec And comm = commPrec Then
                    If nota = notaPrec Or comm = False Then
                        TabellaNoDoppi -= 1
                    End If
                End If
            End If

            clientePrec = cliente
            dataPrec = data
            commPrec = comm

            notaComm = ""
        Next

        dgvCalendario.RowCount = TabellaNoDoppi + DateLavorative.Length

        Dim nuovaTabella As New DataTable


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM Consuntivazione " & strWhere & " ORDER BY DATA, CLIENTE, NOTA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        nuovaTabella.Clear()
        tabella.Clear()
        da.Fill(tabella)
        da.Fill(nuovaTabella)
        cn.Close()

        Call controllaNota(tabella, nuovaTabella)

        clientePrec = ""
        Dim ticket As String = ""
        Dim tempo As Double
        Dim tempoTot As Double
        Dim sommaTempoExtra As Double
        Dim notaExtraBoolean As Boolean = False
        Dim noComm As Boolean
        notaComm = ""
        notaCommPrec = ""

        Dim conta As Integer = -1
        Dim j As Integer = 1

        Call riordinaTabella(vetClienteComm, vetNotaComm, tabella, notaComm)

        For i = 0 To DateLavorative.Length - 2
            Do
                conta += 1
                If conta <= tabella.Rows.Count - 1 Then
                    cliente = tabella.Rows(conta).Item("CLIENTE").ToString
                    nota = tabella.Rows(conta).Item("NOTA").ToString
                    comm = CheckComm(vetClienteComm, vetNotaComm, cliente, nota, notaComm)
                    noComm = CheckNoComm(vetClienteComm, vetNotaComm, vetLinkComm, cliente, nota)
                    If conta <> 0 Then
                        If CheckIfSameClient(cliente, clientePrec, noComm) And (CheckIfSameNota(nota, notaPrec, comm, commPrec, noComm, notaComm, notaCommPrec) Or comm = False) AndAlso DateLavorative(i) = tabella.Rows(conta).Item("DATA").ToString.Replace(" 00:00:00", "") Then
                            UpdateTicketAndTempo(nota, tabella, conta, ticket, tempo, noComm)
                        Else
                            UpdateDgvCalendario(j, ticket, clientePrec, tempo, DateLavorative(i), tabella.Rows(conta - 1).Item("CONSUNTIVATO").ToString)
                            UpdateDgvCalendarioNota(j, notaPrec, commPrec)
                            UpdateDgvCalendarioExtra(j, notaExtraBoolean, notaPrec)
                            ResetVariables(sommaTempoExtra, tempoTot, tempo)
                            UpdateTicketAndTempo(nota, tabella, conta, ticket, tempo, noComm)
                        End If
                        UpdateExtra(nota, sommaTempoExtra, notaExtraBoolean)
                    Else
                        UpdateTicketAndTempo(nota, tabella, conta, ticket, tempo, noComm)
                    End If

                    commPrec = comm
                    If Not noComm Then
                        clientePrec = cliente
                        If commPrec Then
                            notaPrec = nota
                        ElseIf nota.StartsWith("Home") Then
                            notaPrec = "Home"
                        Else
                            notaPrec = ""
                        End If
                        notaCommPrec = notaComm
                        notaComm = ""
                    End If
                Else
                    UpdateDgvCalendario(j, ticket, clientePrec, tempo, DateLavorative(i), tabella.Rows(conta - 1).Item("CONSUNTIVATO").ToString)
                    UpdateDgvCalendarioNota(j, notaPrec, comm)
                    UpdateDgvCalendarioExtra(j, notaExtraBoolean, notaPrec)
                    ResetVariables(sommaTempoExtra, tempoTot, tempo)
                End If
            Loop Until conta > tabella.Rows.Count - 1 OrElse DateLavorative(i) <> tabella.Rows(conta).Item("DATA").ToString.Replace(" 00:00:00", "")

            UpdateDgvCalendarioTotale(j, tempoTot)
            j += 1
            tempoTot = 0
        Next

        If menuFiltriChiuso = False Then
            lblFiltri_Click(sender, e)
        End If
    End Sub

    Sub riordinaTabella(vetClienteComm() As String, vetNotaComm() As String, ByRef tabella As DataTable, ByRef notaComm As String)
        Dim c As String
        Dim n As String
        Dim conta As Integer = 0

        ' Ottieni l'elenco delle date univoche nella tabella
        Dim dateUnivoche = tabella.AsEnumerable().[Select](Function(row) row.Field(Of DateTime)("DATA").Date).Distinct().ToList()

        ' Ciclo For per ogni giorno del mese
        For Each dataUnivoca In dateUnivoche
            ' Filtra la tabella per la data corrente e crea una copia della raccolta di righe
            Dim righeDataCorrente = tabella.AsEnumerable().Where(Function(row) row.Field(Of DateTime)("DATA").Date = dataUnivoca).ToList()

            ' Trova l'indice dell'ultima riga per la data corrente
            Dim ultimaRigaDataCorrente = tabella.Rows.IndexOf(righeDataCorrente.Last())

            ' Ciclo For per ogni ticket del giorno
            For Each riga In righeDataCorrente
                c = riga.Field(Of String)("CLIENTE")
                n = If(riga.Field(Of String)("NOTA"), "")

                If CheckComm(vetClienteComm, vetNotaComm, c, n, notaComm) Then
                    Dim newRow As DataRow = tabella.NewRow()
                    newRow.ItemArray = riga.ItemArray
                    tabella.Rows.Remove(riga)
                    tabella.Rows.InsertAt(newRow, ultimaRigaDataCorrente)
                End If
            Next
        Next
    End Sub

    ' DA TENERE
    'Sub riordinaTabella_DA_AGGIUSTARE(vetClienteComm() As String, vetNotaComm() As String, ByRef tabella As DataTable, ByRef notaComm As String)
    '    Dim g As String
    '    Dim c As String
    '    Dim n As String
    '    Dim conta As Integer = 0

    '    ' Ottieni l'elenco delle date univoche nella tabella
    '    Dim dateUnivoche = tabella.AsEnumerable().[Select](Function(row) row.Field(Of DateTime)("DATA").Date).Distinct().ToList()

    '    ' Ciclo For per ogni giorno del mese
    '    For Each dataUnivoca In dateUnivoche
    '        ' Filtra la tabella per la data corrente e crea una copia della raccolta di righe
    '        Dim righeDataCorrente = tabella.AsEnumerable().Where(Function(row) row.Field(Of DateTime)("DATA").Date = dataUnivoca).ToList()

    '        ' Ottieni l'elenco dei clienti univoci per la data corrente
    '        Dim clientiUnivoci = righeDataCorrente.[Select](Function(row) row.Field(Of String)("CLIENTE")).Distinct().ToList()

    '        ' Ciclo For per ogni cliente del giorno
    '        For Each clienteUnivoco In clientiUnivoci
    '            ' Filtra le righe per il cliente corrente e crea una copia della raccolta di righe
    '            Try
    '                Dim righeClienteCorrente = righeDataCorrente.Where(Function(row) row.Field(Of String)("CLIENTE") = clienteUnivoco).ToList()


    '                ' Trova l'indice dell'ultima riga per il cliente corrente
    '                Dim ultimaRigaClienteCorrente = tabella.Rows.IndexOf(righeClienteCorrente.Last())

    '                ' Crea una lista per memorizzare le righe da spostare
    '                Dim righeDaSpostare As New List(Of DataRow)

    '                ' Ciclo For per ogni ticket del cliente
    '                For Each riga In righeClienteCorrente.ToList()
    '                    c = riga.Field(Of String)("CLIENTE")
    '                    If riga.Field(Of String)("NOTA") Is Nothing Then
    '                        n = ""
    '                    Else
    '                        n = riga.Field(Of String)("NOTA")
    '                    End If
    '                    If CheckComm(vetClienteComm, vetNotaComm, c, n, notaComm) Then
    '                        ' Aggiungi la riga alla lista delle righe da spostare
    '                        righeDaSpostare.Add(riga)
    '                    End If
    '                Next

    '                ' Sposta le righe dalla lista delle righe da spostare alla fine dei ticket del cliente per il giorno corrente
    '                For Each riga In righeDaSpostare
    '                    Dim newRow As DataRow = tabella.NewRow()
    '                    newRow.ItemArray = riga.ItemArray

    '                    ' Rimuovi la riga corrente dalla tabella prima di accedere ai suoi dati
    '                    tabella.Rows.Remove(riga)

    '                    tabella.Rows.InsertAt(newRow, ultimaRigaClienteCorrente)
    '                Next
    '            Catch ex As Exception
    '                MsgBox(ex.Message & " Data: " & dataUnivoca & " Cliente: " & clienteUnivoco & ". Chiedere a Flavio di verificare")
    '                Exit Sub
    '            End Try
    '        Next
    '    Next
    'End Sub


    Function CheckComm(vetClienteComm() As String, vetNotaComm() As String, cliente As String, nota As String, ByRef notaComm As String) As Boolean
        Dim comm As Boolean = False
        For k = 0 To vetClienteComm.Length - 2
            If vetClienteComm(k) = cliente And nota.Contains(vetNotaComm(k)) Then
                If vetNotaComm(k) = "" And nota = "" Then
                    comm = True
                    notaComm = vetClienteComm(k)
                ElseIf vetNotaComm(k) <> "" Then
                    comm = True
                    notaComm = vetClienteComm(k)
                End If
            End If
        Next
        Return comm
    End Function
    Function CheckNoComm(vetClienteComm() As String, vetNotaComm() As String, vetLinkComm() As String, cliente As String, nota As String) As Boolean
        Dim comm As Boolean = False
        For k = 0 To vetClienteComm.Length - 2
            If vetClienteComm(k) = cliente And nota.Contains(vetNotaComm(k)) And vetLinkComm(k).Contains("Commessa=/") Then
                comm = True
            End If
        Next
        Return comm
    End Function

    Function CheckIfSameClient(cliente As String, clientePrec As String, noComm As Boolean) As Boolean
        Return (cliente = clientePrec Or noComm = True)
    End Function

    Function CheckIfSameNota(nota As String, notaPrec As String, comm As Boolean, commPrec As Boolean, noComm As Boolean, notaComm As String, notaCommPrec As String) As Boolean
        If comm And commPrec And Not noComm Then
            Return (notaComm = notaCommPrec And nota = notaPrec)
        Else
            Return nota = notaPrec
        End If
    End Function

    Sub UpdateTicketAndTempo(ByRef nota As String, tabella As DataTable, conta As Integer, ByRef ticket As String, ByRef tempo As Double, noComm As Boolean)
        If nota.Contains("Criticità") Then
            ticket += "," & "Criticità"
        Else
            If tabella.Rows(conta).Item("TICKET").ToString = "/" And tabella.Rows(conta).Item("NOTA").ToString.Replace("Home", "").Replace(",", "").Trim <> "" Then
                ticket += "," & tabella.Rows(conta).Item("NOTA").ToString.Replace("Home", "").Replace(",", "").Trim
            Else
                If noComm Then
                    ticket += "," & tabella.Rows(conta).Item("CLIENTE").ToString
                Else
                    ticket += "," & tabella.Rows(conta).Item("TICKET").ToString
                End If
            End If
        End If

            tempo += tabella.Rows(conta).Item("TEMPO_RISOLUZIONE").ToString
    End Sub

    Sub UpdateDgvCalendario(row As Integer, ByRef ticket As String, cliente As String, ByRef tempo As Double, dataLavorativa As String, consuntivato As String)
        If ticket.StartsWith(",") Then
            ticket = ticket.Substring(1, ticket.Length - 1)
        End If

        dgvCalendario.Rows(row).Cells(1).Value = ticket
        dgvCalendario.Rows(row).Cells(2).Value = cliente
        dgvCalendario.Rows(row).Cells(3).Value = tempo
        dgvCalendario.Rows(row).Cells(4).Value = dataLavorativa
        dgvCalendario.Rows(row).Cells(5).Value = consuntivato

        ticket = ""
    End Sub
    Sub UpdateDgvCalendarioNota(row As Integer, ByRef notaPrec As String, comm As Boolean)
        If notaPrec.Contains("Criticità") Then
            If notaPrec.Contains("Home") Then
                notaPrec = notaPrec.Replace(", Criticità", "")
                dgvCalendario.Rows(row).Cells(6).Value = notaPrec
            Else
                dgvCalendario.Rows(row).Cells(6).Value = ""
            End If
        ElseIf notaPrec.ToLower.Contains("extra") = False Then
            If notaPrec.Contains("Home") Or comm = True Then
                dgvCalendario.Rows(row).Cells(6).Value = notaPrec
            Else
                dgvCalendario.Rows(row).Cells(6).Value = ""
            End If
        End If
    End Sub
    Sub UpdateDgvCalendarioExtra(ByRef row As Integer, ByRef notaExtraBoolean As Boolean, notaPrec As String)
        If notaExtraBoolean = True Then
            notaExtraBoolean = False
            If notaPrec.ToLower.Contains("extra") Then
                Dim indice As Integer = notaPrec.IndexOf("(") + 1
                Dim tempoNotaPrec = notaPrec.Substring(indice, notaPrec.Length - indice - 1)
                notaPrec = notaPrec.Replace("Extra(" & tempoNotaPrec & ")", "")
            End If
            If notaPrec = "" Or notaPrec.Trim = "Criticità," Then
                dgvCalendario.Rows(row).Cells(6).Value = notaExtra
            Else
                If notaPrec.Trim.EndsWith(",") Then
                    dgvCalendario.Rows(row).Cells(6).Value = notaPrec.Trim & " " & notaExtra
                Else
                    dgvCalendario.Rows(row).Cells(6).Value = notaPrec & ", " & notaExtra
                End If
            End If
        End If
        row += 1
    End Sub
    Sub ResetVariables(ByRef sommaTempoExtra As Double, ByRef tempoTot As Double, ByRef tempo As Double)
        sommaTempoExtra = 0
        tempoTot += tempo
        tempo = 0
    End Sub
    Sub UpdateExtra(ByRef nota As String, ByRef sommaTempoExtra As Double, ByRef notaExtraBoolean As Boolean)
        If nota.ToLower.Contains("extra(") Then
            Dim tempoExtra As String
            Dim vetDividiNota() As String
            vetDividiNota = nota.Split("(")
            tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
            sommaTempoExtra += tempoExtra
            notaExtra = "Extra(" & sommaTempoExtra & ")"
            nota = nota.Replace("Extra(" & tempoExtra & ")", notaExtra)
            notaExtraBoolean = True
        End If
    End Sub
    Sub UpdateDgvCalendarioTotale(row As Integer, tempoTot As Double)

        dgvCalendario.Rows(row).Cells(1).Value = ""
        dgvCalendario.Rows(row).Cells(2).Value = "TOTALE:"
        dgvCalendario.Rows(row).Cells(3).Value = tempoTot
        dgvCalendario.Rows(row).Cells(4).Value = ""
        dgvCalendario.Rows(row).Cells(5).Value = ""
        dgvCalendario.Rows(row).Cells(6).Value = ""

        Dim color As Color
        Dim converter As System.ComponentModel.TypeConverter = System.ComponentModel.TypeDescriptor.GetConverter(color)
        dgvCalendario.Rows(row).DefaultCellStyle.BackColor = converter.ConvertFromString("51; 136; 202")
        dgvCalendario.Rows(row).DefaultCellStyle.ForeColor = Color.White
        dgvCalendario.Rows(row).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

        If tempoTot < 8 Then
            dgvCalendario.Rows(row).Cells(3).Style.BackColor = converter.ConvertFromString("255; 216; 26")
            dgvCalendario.Rows(row).Cells(3).Style.ForeColor = Color.Black
        ElseIf tempoTot = 8 Then
            dgvCalendario.Rows(row).Cells(3).Style.BackColor = converter.ConvertFromString("60; 202; 51")
            dgvCalendario.Rows(row).Cells(3).Style.ForeColor = Color.Black
        Else
            dgvCalendario.Rows(row).Cells(3).Style.BackColor = converter.ConvertFromString("202; 51; 60")
        End If
    End Sub

    Sub controllaNota(ByRef tabella As DataTable, nuovaTabella As DataTable)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tab As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT DISTINCT Nota FROM LinkGR WHERE Nota IS NOT NULL"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tab.Clear()
        da.Fill(tab)
        cn.Close()

        Dim rTab As Integer = tab.Rows.Count - 1
        Dim vetNote(rTab) As String

        For i = 0 To rTab
            vetNote(i) = tab.Rows(i).Item("Nota").ToString
        Next

        Dim rTabella As Integer = tabella.Rows.Count - 1
        Dim rInserite As Integer = 0
        Dim rDaInserire As String = ""
        Dim daInserire As Boolean = False
        Dim c As String = tabella.Rows(0).Item("CLIENTE").ToString
        Dim d As String = tabella.Rows(0).Item("DATA").ToString
        Dim n As String = tabella.Rows(0).Item("NOTA").ToString

        For i = 0 To rTabella
            If c = tabella.Rows(i).Item("CLIENTE").ToString And d = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "") Then
                For j = 0 To rTab
                    If tabella.Rows(i).Item("NOTA").ToString.Contains(vetNote(j)) Then
                        If rDaInserire = "" Then
                            rDaInserire = i
                        Else
                            rDaInserire += "," & i
                        End If
                        daInserire = True
                    End If
                Next
                If daInserire = False Then
                    nuovaTabella.Rows(rInserite).Item("ID") = tabella.Rows(i).Item("ID")
                    nuovaTabella.Rows(rInserite).Item("TICKET") = tabella.Rows(i).Item("TICKET")
                    nuovaTabella.Rows(rInserite).Item("CLIENTE") = tabella.Rows(i).Item("CLIENTE")
                    nuovaTabella.Rows(rInserite).Item("TEMPO_RISOLUZIONE") = tabella.Rows(i).Item("TEMPO_RISOLUZIONE")
                    nuovaTabella.Rows(rInserite).Item("DATA") = tabella.Rows(i).Item("DATA")
                    nuovaTabella.Rows(rInserite).Item("CONSUNTIVATO") = tabella.Rows(i).Item("CONSUNTIVATO")
                    nuovaTabella.Rows(rInserite).Item("NOTA") = tabella.Rows(i).Item("NOTA")

                    rInserite += 1
                End If
                daInserire = False
            Else
                If rDaInserire <> "" Then
                    Dim vetRDaInserire() As String
                    vetRDaInserire = rDaInserire.Split(",")
                    For k = 0 To vetRDaInserire.Length - 1
                        nuovaTabella.Rows(rInserite).Item("ID") = tabella.Rows(vetRDaInserire(k)).Item("ID")
                        nuovaTabella.Rows(rInserite).Item("TICKET") = tabella.Rows(vetRDaInserire(k)).Item("TICKET")
                        nuovaTabella.Rows(rInserite).Item("CLIENTE") = tabella.Rows(vetRDaInserire(k)).Item("CLIENTE")
                        nuovaTabella.Rows(rInserite).Item("TEMPO_RISOLUZIONE") = tabella.Rows(vetRDaInserire(k)).Item("TEMPO_RISOLUZIONE")
                        nuovaTabella.Rows(rInserite).Item("DATA") = tabella.Rows(vetRDaInserire(k)).Item("DATA")
                        nuovaTabella.Rows(rInserite).Item("CONSUNTIVATO") = tabella.Rows(vetRDaInserire(k)).Item("CONSUNTIVATO")
                        nuovaTabella.Rows(rInserite).Item("NOTA") = tabella.Rows(vetRDaInserire(k)).Item("NOTA")
                        rInserite += 1
                    Next
                End If
                c = tabella.Rows(i).Item("CLIENTE").ToString
                d = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "")
                rDaInserire = ""
                For j = 0 To rTab
                    If tabella.Rows(i).Item("NOTA").ToString.Contains(vetNote(j)) Then
                        If rDaInserire = "" Then
                            rDaInserire = i
                        Else
                            rDaInserire += "," & i
                        End If
                        daInserire = True
                    End If
                Next
                If daInserire = False Then
                    nuovaTabella.Rows(rInserite).Item("ID") = tabella.Rows(i).Item("ID")
                    nuovaTabella.Rows(rInserite).Item("TICKET") = tabella.Rows(i).Item("TICKET")
                    nuovaTabella.Rows(rInserite).Item("CLIENTE") = tabella.Rows(i).Item("CLIENTE")
                    nuovaTabella.Rows(rInserite).Item("TEMPO_RISOLUZIONE") = tabella.Rows(i).Item("TEMPO_RISOLUZIONE")
                    nuovaTabella.Rows(rInserite).Item("DATA") = tabella.Rows(i).Item("DATA")
                    nuovaTabella.Rows(rInserite).Item("CONSUNTIVATO") = tabella.Rows(i).Item("CONSUNTIVATO")
                    nuovaTabella.Rows(rInserite).Item("NOTA") = tabella.Rows(i).Item("NOTA")

                    rInserite += 1
                End If
                daInserire = False
            End If
        Next
        If rDaInserire <> "" Then
            Dim vetRDaInserire() As String
            vetRDaInserire = rDaInserire.Split(",")
            For k = 0 To vetRDaInserire.Length - 1
                nuovaTabella.Rows(rInserite).Item("ID") = tabella.Rows(vetRDaInserire(k)).Item("ID")
                nuovaTabella.Rows(rInserite).Item("TICKET") = tabella.Rows(vetRDaInserire(k)).Item("TICKET")
                nuovaTabella.Rows(rInserite).Item("CLIENTE") = tabella.Rows(vetRDaInserire(k)).Item("CLIENTE")
                nuovaTabella.Rows(rInserite).Item("TEMPO_RISOLUZIONE") = tabella.Rows(vetRDaInserire(k)).Item("TEMPO_RISOLUZIONE")
                nuovaTabella.Rows(rInserite).Item("DATA") = tabella.Rows(vetRDaInserire(k)).Item("DATA")
                nuovaTabella.Rows(rInserite).Item("CONSUNTIVATO") = tabella.Rows(vetRDaInserire(k)).Item("CONSUNTIVATO")
                nuovaTabella.Rows(rInserite).Item("NOTA") = tabella.Rows(vetRDaInserire(k)).Item("NOTA")
                rInserite += 1
            Next
        End If
        tabella = nuovaTabella

    End Sub

    Private Sub txtTicket_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTicket.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCarica_Click(sender, e)
        End If
    End Sub
    Private Sub txtTicketFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTicketFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCerca_Click(sender, e)
        End If
    End Sub

    Private Sub cmbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCarica_Click(sender, e)
        End If
    End Sub
    Private Sub cmbClienteFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbClienteFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCerca_Click(sender, e)
        End If
    End Sub
    Private Sub cmbTempo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTempo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCarica_Click(sender, e)
        End If
    End Sub
    Private Sub cmbNota_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbNota.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCarica_Click(sender, e)
        End If
    End Sub

    Private Sub cmbConsuntivazioneFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbConsuntivazioneFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCerca_Click(sender, e)
        End If
    End Sub
    Private Sub cmbNotaFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbNotaFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnCerca_Click(sender, e)
        End If
    End Sub

    Private Sub lblAggiungiCliente_Click(sender As Object, e As EventArgs) Handles lblAggiungiCliente.Click
        frmInserisciCliente.ShowDialog()
    End Sub

    Private Sub lblDocumentazione_Click(sender As Object, e As EventArgs) Handles lblDocumentazione.Click, imgDocumentazione.Click
        Dim path As String = Application.StartupPath
        If path.EndsWith("Debug") Then
            path = path.Replace("bin\Debug", "Documentazione\documentazione.html")
        Else
            path += "\Resources\Documentazione\documentazione.html"
        End If
        Process.Start(path)
    End Sub

    Private Sub lblTicketMssivi_Click(sender As Object, e As EventArgs) Handles lblTicketMssivi.Click, imgTicketMassivi.Click
        Dim msgResult As MsgBoxResult = MsgBox("Vuoi scaricare il Template per l'inserimento massivo?", MsgBoxStyle.YesNoCancel)
        If msgResult = MsgBoxResult.Yes Then
            Call scaricaTemplate()
            Exit Sub
        ElseIf msgResult = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        ofdFile.ShowDialog()

        Dim filePath As String = ofdFile.FileName

        If filePath.EndsWith("Template_Ticket.xlsx") = False Then
            MsgBox("Seleziona il template scaricato", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim cnStr As String
        Dim cn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable

        cnStr = String.Format("Provider=Microsoft.Ace.Oledb.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filePath)
        cn = New OleDbConnection(cnStr)
        cn.Open()
        da = New OleDbDataAdapter("SELECT * FROM [Ticket$] WHERE TICKET IS NOT NULL 
                                                            AND CLIENTE IS NOT NULL 
                                                            AND TEMPO IS NOT NULL 
                                                            AND DATA IS NOT NULL
                                                            AND CONSUNTIVATO IS NOT NULL", cn)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logInsMassivTicket, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log InsMassivTicket:")
            If tabella.Rows.Count = 0 Then
                logFile.WriteLine(dataOraLog + "Il template è vuoto")
                logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivTicket - OK")
                MsgBox("Il template è vuoto")
                Exit Sub
            End If
        End Using

        Dim cmd As OleDbCommand
        Dim str As String
        Dim tabellaClientiDB As New DataTable

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabellaClientiDB.Clear()
        da.Fill(tabellaClientiDB)
        cn.Close()

        Dim tabellaClientiExcel As New DataTable

        cn = New OleDbConnection(cnStr)
        cn.Open()
        da = New OleDbDataAdapter("SELECT DISTINCT CLIENTE FROM [Ticket$] WHERE CLIENTE IS NOT NULL", cn)
        tabellaClientiExcel.Clear()
        da.Fill(tabellaClientiExcel)
        cn.Close()

        Using logFile As New System.IO.StreamWriter(logInsMassivTicket, True)
            logFile.WriteLine(dataOraLog + "Inizio controllo clienti:")
            Dim presente As Boolean = False
            For i = 0 To tabellaClientiExcel.Rows.Count - 1
                For j = 0 To tabellaClientiDB.Rows.Count - 1
                    If tabellaClientiExcel.Rows(i).Item("CLIENTE") = tabellaClientiDB.Rows(j).Item("Cliente") Then
                        presente = True
                    End If
                Next
                If presente = False Then
                    logFile.WriteLine(dataOraLog + "Il cliente " & tabellaClientiExcel.Rows(i).Item("CLIENTE") & " non è presente a sistema. Importazione interrotta")
                    logFile.WriteLine(dataOraLog + "Fine controllo clienti - KO")
                    logFile.Close()
                    MsgBox("Il cliente " & tabellaClientiExcel.Rows(i).Item("CLIENTE") & " non è presente a sistema. Importazione interrotta", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Next
            logFile.WriteLine(dataOraLog + "Fine controllo clienti - OK")
        End Using

        Call uploadTemplate(tabella)
        Using logFile As New System.IO.StreamWriter(logInsMassivTicket, True)
            If inserito = False Then
                logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivTicket - KO")
                MsgBox("Importazione interrotta alla riga " & rigaExcel + 2 & " dell'Excel. " & errore, MsgBoxStyle.Critical)
                Exit Sub
            End If
            logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivTicket - OK")
        End Using
        Call AggiornaDG(giornoOggi, False)
        MsgBox("I ticket sono stati inseriti correttamente", MsgBoxStyle.Information)
    End Sub
    Sub scaricaTemplate()
        Dim path As String = Application.StartupPath
        If path.EndsWith("Debug") Then
            path = path.Replace("bin\Debug", "Template\Template_Ticket.xlsx")
        Else
            path += "\Resources\Template\Template_Ticket.xlsx"
        End If
        Try
            My.Computer.FileSystem.CopyFile(path, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/Template_Ticket.xlsx")
        Catch ex As Exception
            MsgBox("Il template non è stato trasferito perche " + ex.Message, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        MsgBox("Il template è stato salvato sul Desktop con il nome di 'Template_Ticket'. Completalo e fai l'upload", MsgBoxStyle.Information)
    End Sub
    Dim inserito As Boolean
    Dim rigaExcel As Integer = 0
    Dim errore As String = ""
    Sub uploadTemplate(tabellaExcel As DataTable)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim nRighe As Integer
        Dim StrSQL As String = ""
        Dim consuntivato As String
        Dim vetTicketDaIns(tabellaExcel.Rows.Count) As String

        Using logFile As New System.IO.StreamWriter(logInsMassivTicket, True)
            logFile.WriteLine(dataOraLog + "Inizio scrittura ticket:")
            logFile.WriteLine(dataOraLog + "Ticket da inserire: " & tabellaExcel.Rows.Count)
            For i = 0 To tabellaExcel.Rows.Count - 1
                inserito = False
                ticket = tabellaExcel.Rows(i).Item("TICKET")
                cliente = tabellaExcel.Rows(i).Item("CLIENTE")
                tempo = tabellaExcel.Rows(i).Item("TEMPO")
                giorno = tabellaExcel.Rows(i).Item("DATA")
                consuntivato = tabellaExcel.Rows(i).Item("CONSUNTIVATO")
                nota = tabellaExcel.Rows(i).Item("NOTA").ToString

                cn = New OleDbConnection(strConn)
                cn.Open()
                str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cliente & "'"
                cmd = New OleDbCommand(str, cn)
                da = New OleDbDataAdapter(cmd)
                tabella.Clear()
                da.Fill(tabella)
                cn.Close()

                Dim vetCommNota(tabella.Rows.Count) As String
                For j = 0 To tabella.Rows.Count - 1
                    vetCommNota(j) = tabella.Rows(j).Item("Nota").ToString
                Next

                Dim conta As Integer = 0
                If nota.Contains("Criticità") Then
                    For j = 0 To tabella.Rows.Count - 1
                        If vetCommNota(j) = "" Then
                            conta += 1
                        End If
                    Next
                    If conta = 0 Then
                        logFile.WriteLine(dataOraLog + "Il cliente " & cliente & " non ha la commessa standard")
                        logFile.WriteLine(dataOraLog + "Fine scrittura ticket - KO")
                        logFile.Close()
                        errore = "Il cliente " & cliente & " non ha la commessa standard"
                        rigaExcel = i
                        Exit Sub
                    End If
                ElseIf nota.Contains("Fixed") Then
                    For j = 0 To tabella.Rows.Count - 1
                        If vetCommNota(j) = "Fixed" Then
                            conta += 1
                        End If
                    Next
                    If conta = 0 Then
                        logFile.WriteLine(dataOraLog + "Il cliente " & cliente & " non ha la commessa per il Bug Fix")
                        logFile.WriteLine(dataOraLog + "Fine scrittura ticket - KO")
                        logFile.Close()
                        errore = "Il cliente " & cliente & " non ha la commessa per il Bug Fix"
                        rigaExcel = i
                        Exit Sub
                    End If
                ElseIf nota.Contains("Formazione") Then
                    For j = 0 To tabella.Rows.Count - 1
                        If vetCommNota(j) = "Formazione" Then
                            conta += 1
                        End If
                    Next
                    If conta = 0 Then
                        logFile.WriteLine(dataOraLog + "Il cliente " & cliente & " non ha la commessa per la Formazione")
                        logFile.WriteLine(dataOraLog + "Fine scrittura ticket - KO")
                        logFile.Close()
                        errore = "Il cliente " & cliente & " non ha la commessa per la Formazione"
                        rigaExcel = i
                        Exit Sub
                    End If
                Else
                    For j = 0 To tabella.Rows.Count - 1
                        If vetCommNota(j) = "" Then
                            conta += 1
                        End If
                    Next
                    If conta = 0 Then
                        logFile.WriteLine(dataOraLog + "Il cliente " & cliente & " non ha la commessa standard")
                        logFile.WriteLine(dataOraLog + "Fine scrittura ticket - KO")
                        logFile.Close()
                        errore = "Il cliente " & cliente & " non ha la commessa standard"
                        rigaExcel = i
                        Exit Sub
                    End If
                End If
                If nota = "" Then
                    StrSQL += "INSERT into Consuntivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO, NOTA) VALUES ('" & ticket & "','" & cliente & "','" & tempo & "','" & giorno & "','" & consuntivato & "',NULL);"
                Else
                    StrSQL += "INSERT into Consuntivazione (TICKET, CLIENTE, TEMPO_RISOLUZIONE, DATA, CONSUNTIVATO, NOTA) VALUES ('" & ticket & "','" & cliente & "','" & tempo & "','" & giorno & "','" & consuntivato & "','" & nota & "');"
                End If
                vetTicketDaIns(i) = "Inserito [TICKET: '" & ticket & "'] " & "[CLIENTE: '" & cliente & "'] " & "[TEMPO_RISOLUZIONE: '" & tempo & "'] " & "[DATA: '" & giorno & "'] " & "[CONSUNTIVATO: '" & consuntivato & "'] " & "[NOTA: '" & If(nota <> "", nota, "NULL") & "']"
                inserito = True
            Next

            cn = New OleDbConnection(strConn)
            cn.Open()
            StrSQL = StrSQL.Substring(0, StrSQL.Length - 1)
            Dim vetStrSQL() As String = StrSQL.Split(";")
            For i = 0 To vetStrSQL.Length - 1
                cmd = New OleDbCommand(vetStrSQL(i), cn)
                Try
                    nRighe = cmd.ExecuteNonQuery
                Catch ex As Exception
                    logFile.WriteLine(dataOraLog + "Operazione non conclusa con successo. Codice errore: " & ex.Message)
                    logFile.WriteLine(dataOraLog + "Fine scrittura ticket - KO")
                    MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                    cn.Close()
                    inserito = False
                    Exit Sub
                End Try
                logFile.WriteLine(dataOraLog & i + 1 & "/" & vetStrSQL(i).Length & " " & vetTicketDaIns(i))
            Next
        End Using
        cn.Close()
        inserito = True
    End Sub

    Dim menuChiuso As Boolean = True
    Public Sub lblSlide_Click(sender As Object, e As EventArgs) Handles lblSlide.Click
        If pnlMenu.Width = 0 Then
            menuChiuso = True
            frmSfondoNero.Show()
            frmSfondoNero.Location = New Point(Me.Location.X + 8, Me.Location.Y + 31) 'X = + 206
            If Me.Width > Me.MinimumSize.Width Then
                frmSfondoNero.Size = New Size(Me.Width - 14, Me.Height - 39) 'width = - 214
            Else
                frmSfondoNero.Size = New Size(Me.Width - 16, Me.Height - 39) 'width = - 216
            End If
        Else
            menuChiuso = False
            frmSfondoNero.Close()
        End If
        Me.Activate()
        TimerSlide.Start()
    End Sub

    Private Sub TimerSlide_Tick(sender As Object, e As EventArgs) Handles TimerSlide.Tick
        If menuChiuso = True Then
            pnlMenu.Width += 20
            If lblSlide.Left < 168 Then
                lblSlide.Left += 16.5
            End If
            frmSfondoNero.Left += 20
            frmSfondoNero.Width -= 20
            If pnlMenu.Width = 200 Then
                If coloreIcone = "white" Then
                    lblSlide.Image = Consuntivazione.My.Resources.Resources.menuAperto_32x32_bianco
                Else
                    lblSlide.Image = Consuntivazione.My.Resources.Resources.menuAperto_32x32_nero
                End If
                frmSfondoNero.Left = Me.Location.X + 206
                If Me.Width > Me.MinimumSize.Width Then
                    frmSfondoNero.Width = Me.Width - 214
                Else
                    frmSfondoNero.Width = Me.Width - 216
                End If
                TimerSlide.Stop()
            End If
        Else
            pnlMenu.Width -= 20
            lblSlide.Left -= 16.5
            If pnlMenu.Width = 0 Then
                If coloreIcone = "white" Then
                    lblSlide.Image = Consuntivazione.My.Resources.Resources.menuChiuso_32x32_bianco
                Else
                    lblSlide.Image = Consuntivazione.My.Resources.Resources.menuChiuso_32x32_nero
                End If
                TimerSlide.Stop()
            End If
        End If
    End Sub

    Private Sub lblCommesseMassive_Click(sender As Object, e As EventArgs) Handles lblCommesseMassive.Click, imgCommesseMassive.Click
        frmInserisciCliente.InserisciMassivamente()
    End Sub
    Private Sub lblTema_Click(sender As Object, e As MouseEventArgs) Handles lblTema.Click, imgTema.Click
        frmTema.ShowDialog()
        If frmTema.coloriModificati = True Then
            Me.Close()
        End If
    End Sub
    Private Sub lblImpostazioni_Click(sender As Object, e As EventArgs) Handles lblImpostazioni.Click, imgImpostazioni.Click
        frmImpostazioni.ShowDialog()
        If frmImpostazioni.modifica = True Or frmImpostazioni.trasferito = True Then
            Me.Close()
        End If
    End Sub
    Sub colorHover(ByRef red As Integer, ByRef green As Integer, ByRef blu As Integer)
        If red - 20 <= 0 Then
            red = 0
        Else
            red -= 20
        End If

        If green - 20 <= 0 Then
            green = 0
        Else
            green -= 20
        End If

        If blu - 20 <= 0 Then
            blu = 0
        Else
            blu -= 20
        End If
    End Sub
    Private Sub lblTicketMssivi_MouseHover(sender As Object, e As EventArgs) Handles lblTicketMssivi.MouseHover, imgTicketMassivi.MouseHover
        Dim red As Integer = lblTicketMssivi.BackColor.R
        Dim green As Integer = lblTicketMssivi.BackColor.G
        Dim blu As Integer = lblTicketMssivi.BackColor.B

        Call colorHover(red, green, blu)

        lblTicketMssivi.BackColor = Color.FromArgb(red, green, blu)
        imgTicketMassivi.BackColor = Color.FromArgb(red, green, blu)
    End Sub

    Private Sub lblTicketMssivi_MouseLeave(sender As Object, e As EventArgs) Handles lblTicketMssivi.MouseLeave, imgTicketMassivi.MouseLeave
        lblTicketMssivi.BackColor = lblSfondoColorato.BackColor
        imgTicketMassivi.BackColor = lblSfondoColorato.BackColor
    End Sub

    Private Sub lblCommesseMassive_MouseHover(sender As Object, e As EventArgs) Handles lblCommesseMassive.MouseHover, imgCommesseMassive.MouseHover
        Dim red As Integer = lblCommesseMassive.BackColor.R
        Dim green As Integer = lblCommesseMassive.BackColor.G
        Dim blu As Integer = lblCommesseMassive.BackColor.B

        Call colorHover(red, green, blu)

        lblCommesseMassive.BackColor = Color.FromArgb(red, green, blu)
        imgCommesseMassive.BackColor = Color.FromArgb(red, green, blu)
    End Sub

    Private Sub lblCommesseMassive_MouseLeave(sender As Object, e As EventArgs) Handles lblCommesseMassive.MouseLeave, imgCommesseMassive.MouseLeave
        lblCommesseMassive.BackColor = lblSfondoColorato.BackColor
        imgCommesseMassive.BackColor = lblSfondoColorato.BackColor
    End Sub
    Private Sub lblTema_MouseHover(sender As Object, e As EventArgs) Handles lblTema.MouseHover, imgTema.MouseHover
        Dim red As Integer = lblTema.BackColor.R
        Dim green As Integer = lblTema.BackColor.G
        Dim blu As Integer = lblTema.BackColor.B

        Call colorHover(red, green, blu)

        lblTema.BackColor = Color.FromArgb(red, green, blu)
        imgTema.BackColor = Color.FromArgb(red, green, blu)
    End Sub

    Private Sub lblTema_MouseLeave(sender As Object, e As EventArgs) Handles lblTema.MouseLeave, imgTema.MouseLeave
        lblTema.BackColor = lblSfondoColorato.BackColor
        imgTema.BackColor = lblSfondoColorato.BackColor
    End Sub

    Private Sub lblImpostazioni_MouseHover(sender As Object, e As EventArgs) Handles lblImpostazioni.MouseHover, imgImpostazioni.MouseHover
        Dim red As Integer = lblImpostazioni.BackColor.R
        Dim green As Integer = lblImpostazioni.BackColor.G
        Dim blu As Integer = lblImpostazioni.BackColor.B

        Call colorHover(red, green, blu)

        lblImpostazioni.BackColor = Color.FromArgb(red, green, blu)
        imgImpostazioni.BackColor = Color.FromArgb(red, green, blu)
    End Sub

    Private Sub lblImpostazioni_MouseLeave(sender As Object, e As EventArgs) Handles lblImpostazioni.MouseLeave, imgImpostazioni.MouseLeave
        lblImpostazioni.BackColor = lblSfondoColorato.BackColor
        imgImpostazioni.BackColor = lblSfondoColorato.BackColor
    End Sub

    Private Sub lblDocumentazione_MouseHover(sender As Object, e As EventArgs) Handles lblDocumentazione.MouseHover, imgDocumentazione.MouseHover
        Dim red As Integer = lblDocumentazione.BackColor.R
        Dim green As Integer = lblDocumentazione.BackColor.G
        Dim blu As Integer = lblDocumentazione.BackColor.B

        Call colorHover(red, green, blu)

        lblDocumentazione.BackColor = Color.FromArgb(red, green, blu)
        imgDocumentazione.BackColor = Color.FromArgb(red, green, blu)
    End Sub

    Private Sub lblDocumentazione_MouseLeave(sender As Object, e As EventArgs) Handles lblDocumentazione.MouseLeave, imgDocumentazione.MouseLeave
        lblDocumentazione.BackColor = lblSfondoColorato.BackColor
        imgDocumentazione.BackColor = lblSfondoColorato.BackColor
    End Sub
    Dim menuFiltriChiuso As Boolean = True
    Private Sub lblFiltri_Click(sender As Object, e As EventArgs) Handles lblFiltri.Click
        If pnlFiltri.Height = 0 Then
            menuFiltriChiuso = False
            pnlFiltri.Top = 10
            pnlFiltri.Height = 130
            lblFiltri.Top += 130
            lblFiltriSelezionati.Top += 130
            dgvCalendario.Height -= 130
            dgvCalendario.Top += 130
        Else
            menuFiltriChiuso = True
            pnlFiltri.Top = 0
            pnlFiltri.Height = 0
            lblFiltri.Top -= 130
            lblFiltriSelezionati.Top -= 130
            dgvCalendario.Height += 130
            dgvCalendario.Top -= 130
        End If
    End Sub
    Private Sub ckbDataSelezionata_CheckedChanged(sender As Object, e As EventArgs) Handles ckbDataSelezionata.CheckedChanged
        If ckbDataSelezionata.Checked = True Then
            dtpDataDaFiltro.Enabled = True
            dtpDataAFiltro.Enabled = True
            nudAnno.Enabled = False
            lstMesi.Enabled = False
        Else
            dtpDataDaFiltro.Enabled = False
            dtpDataAFiltro.Enabled = False
            nudAnno.Enabled = True
            lstMesi.Enabled = True
        End If
    End Sub

    Dim strWhere As String = ""
    Private Sub BtnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        If btnDividiXCliente.Text = "Ritorna al Mese" Then
            btnDividiXCliente.Text = "Dividi per Cliente"
            btnConsuntivaTutto.Visible = False
        End If

        Dim filtriSel As String = ""
        If txtTicketFiltro.Text <> "" Then
            filtriSel += "Ticket: " & txtTicketFiltro.Text & ";"
        End If
        If cmbClienteFiltro.Text <> "" Then
            filtriSel += "Cliente: " & cmbClienteFiltro.Text & ";"
        End If
        If cmbConsuntivazioneFiltro.Text <> "" Then
            filtriSel += "Consuntivato: " & cmbConsuntivazioneFiltro.Text & ";"
        End If
        If cmbNotaFiltro.Text <> "" Then
            filtriSel += "Nota: " & cmbNotaFiltro.Text & ";"
        End If
        If ckbDataSelezionata.Checked = True Then
            filtriSel += "Data Da: " & dtpDataDaFiltro.Text & ";"
            filtriSel += "Data A: " & dtpDataAFiltro.Text & ";"
        Else
            Dim mese As String = lstMesi.SelectedItem.ToString.Trim
            If mese.Length = 1 Then
                mese = "0" + mese
            End If

            filtriSel += "Anno: " & nudAnno.Text & ";"
            filtriSel += "Mese: " & mese & ";"
        End If

        If filtriSel.EndsWith(";") Then
            filtriSel = filtriSel.Substring(0, filtriSel.Length - 1)
        End If
        lblFiltriSelezionati.Text = filtriSel.Replace(";", "   -   ")

        Dim vetFiltri() As String = filtriSel.Split(";")
        Dim indice As Integer
        strWhere = ""
        For i = 0 To vetFiltri.Length - 1
            If vetFiltri(i).Contains("Ticket") Then
                indice = vetFiltri(i).IndexOf(":")
                strWhere += "AND Ticket = '" & vetFiltri(i).Substring(indice + 2, vetFiltri(i).Length - (indice + 2)) & "' "
            End If
            If vetFiltri(i).Contains("Cliente") Then
                indice = vetFiltri(i).IndexOf(":")
                strWhere += "AND Cliente = '" & vetFiltri(i).Substring(indice + 2, vetFiltri(i).Length - (indice + 2)) & "' "
            End If
            If vetFiltri(i).Contains("Consuntivato") Then
                indice = vetFiltri(i).IndexOf(":")
                strWhere += "AND Consuntivato = '" & vetFiltri(i).Substring(indice + 2, vetFiltri(i).Length - (indice + 2)) & "' "
            End If
            If vetFiltri(i).Contains("Nota") Then
                indice = vetFiltri(i).IndexOf(":")
                strWhere += "AND Nota LIKE '%" & vetFiltri(i).Substring(indice + 2, vetFiltri(i).Length - (indice + 2)) & "%' "
            End If
            If vetFiltri(i).Contains("Data Da") Then
                strWhere += "AND Data BETWEEN #" & Format(dtpDataDaFiltro.Value, "MM/dd/yyyy") & "# AND #" & Format(dtpDataAFiltro.Value, "MM/dd/yyyy") & "#"
            End If
            If vetFiltri(i).Contains("Anno") Then
                Dim mese As String = lstMesi.SelectedItem.ToString.Trim
                If mese.Length = 1 Then
                    mese = "0" + mese
                End If
                strWhere += "AND Data LIKE '%/" & mese & "/" & nudAnno.Value & "' "
            End If
        Next
        If strWhere.Trim.StartsWith("AND") Then
            strWhere = strWhere.Substring(4, strWhere.Length - 4)
        End If
        strWhere = "WHERE " + strWhere
        Call visualizzaFiltri(strWhere, dtpDataDaFiltro.Value.ToString, dtpDataAFiltro.Value.ToString)
        If menuFiltriChiuso = False Then
            lblFiltri_Click(sender, e)
        End If
    End Sub
    Sub visualizzaFiltri(strWhere As String, dataDa As String, dataA As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM Consuntivazione " & strWhere & " ORDER BY DATA, CLIENTE, NOTA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim giornoDa As Integer = dataDa.Substring(0, 2)
        Dim meseDa As Integer = dataDa.Substring(3, 2)
        Dim annoDa As Integer = dataDa.Substring(6, 4)

        Dim giornoA As Integer = dataA.Substring(0, 2)
        Dim meseA As Integer = dataA.Substring(3, 2)
        Dim annoA As Integer = dataA.Substring(6, 4)

        Dim somma As Double = 0
        Dim extra As Double = 0
        dgvCalendario.RowCount = 1
        dgvCalendario.RowCount = tabella.Rows.Count + 1
        For i = 0 To tabella.Rows.Count - 1
            dgvCalendario.Rows(i + 1).Cells(1).Value = tabella.Rows(i).Item("TICKET").ToString
            dgvCalendario.Rows(i + 1).Cells(2).Value = tabella.Rows(i).Item("CLIENTE").ToString
            dgvCalendario.Rows(i + 1).Cells(3).Value = tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            somma += tabella.Rows(i).Item("TEMPO_RISOLUZIONE").ToString
            dgvCalendario.Rows(i + 1).Cells(4).Value = tabella.Rows(i).Item("DATA").ToString.Replace(" 00:00:00", "")
            dgvCalendario.Rows(i + 1).Cells(5).Value = tabella.Rows(i).Item("CONSUNTIVATO").ToString
            dgvCalendario.Rows(i + 1).Cells(6).Value = tabella.Rows(i).Item("NOTA").ToString
            If tabella.Rows(i).Item("NOTA").ToString.Contains("Extra") = True Then
                Dim tempoExtra As String
                Dim vetDividiNota() As String
                vetDividiNota = tabella.Rows(i).Item("NOTA").ToString.Split("(")
                tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
                extra += tempoExtra
            End If
            dgvCalendario.Rows(i + 1).Cells(7).Value = tabella.Rows(i).Item("ID").ToString
        Next
        lblTempoTot.Text = somma
        sommaExtra = extra
        Call RedimDGV()
    End Sub
    Private Sub lblTempoTot_MouseHover(sender As Object, e As EventArgs) Handles lblTempoTot.MouseHover
        ToolTip1.Active = True
        If lblGiorno_Mese.Text.Trim = "Totale " & vbCrLf & "ore di lavoro" & vbCrLf & "(Giornaliero)" Then
            If sommaExtra > 0 And CDbl(lblTempoTot.Text) < 8 Then
                ToolTip1.SetToolTip(lblTempoTot, "Num. Ticket: " & dgvCalendario.RowCount - 1 & vbCrLf & "Tempo Extra: " & sommaExtra & vbCrLf & "Tempo Rimasto: " & 8 - CDbl(lblTempoTot.Text))
            ElseIf sommaExtra > 0 Then
                ToolTip1.SetToolTip(lblTempoTot, "Num. Ticket: " & dgvCalendario.RowCount - 1 & vbCrLf & "Tempo Extra: " & sommaExtra)
            ElseIf CDbl(lblTempoTot.Text) < 8 Then
                ToolTip1.SetToolTip(lblTempoTot, "Num. Ticket: " & dgvCalendario.RowCount - 1 & vbCrLf & "Tempo Rimasto: " & 8 - lblTempoTot.Text)
            Else
                ToolTip1.SetToolTip(lblTempoTot, "Num. Ticket: " & dgvCalendario.RowCount - 1)
            End If
        Else
            If sommaExtra > 0 Then
                ToolTip1.SetToolTip(lblTempoTot, "Num. Ticket: " & dgvCalendario.RowCount - 1 & vbCrLf & "Tempo Extra: " & sommaExtra & vbCrLf & "Tempo Ordinario: " & CDbl(lblTempoTot.Text) - sommaExtra)
            Else
                ToolTip1.Active = False
            End If
        End If
    End Sub

    Private Sub cmbCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedValueChanged
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim cliente As String = cmbCliente.Text

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Nota FROM LinkGR WHERE Cliente = '" & cliente & "' ORDER BY Nota"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        cmbNota.Items.Clear()

        For i = 0 To tabella.Rows.Count() - 1
            cmbNota.Items.Add(tabella.Rows(i).Item("Nota"))
        Next
    End Sub

    Private Sub frmConsuntivazione_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not obbligatorio Then
            Dim processName As String = Path.GetFileNameWithoutExtension(updatePath)
            Dim processes() As Process = Process.GetProcessesByName(processName)
            For Each p As Process In processes
                p.Kill()
            Next
        End If
    End Sub
End Class