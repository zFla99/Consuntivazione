<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsuntivazione
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsuntivazione))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblGiorno = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.TimerVisualizzazione = New System.Windows.Forms.Timer(Me.components)
        Me.lblSfondoColorato = New System.Windows.Forms.Label()
        Me.pnlInserisci = New System.Windows.Forms.Panel()
        Me.btnCarica = New System.Windows.Forms.Label()
        Me.lblBordoCarica = New System.Windows.Forms.Label()
        Me.lblInsNota = New System.Windows.Forms.Label()
        Me.lblInsTempo = New System.Windows.Forms.Label()
        Me.lblInsCliente = New System.Windows.Forms.Label()
        Me.lblInsTicket = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.ckbHome = New System.Windows.Forms.CheckBox()
        Me.cmbNota = New System.Windows.Forms.ComboBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.cmbTempo = New System.Windows.Forms.ComboBox()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.lblAggiungiCliente = New System.Windows.Forms.Label()
        Me.lblBordoTicket = New System.Windows.Forms.Label()
        Me.lblBordoCliente = New System.Windows.Forms.Label()
        Me.lblBordoTempo = New System.Windows.Forms.Label()
        Me.lblBordoNota = New System.Windows.Forms.Label()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.TimerSlide = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblSlide = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCommesseMassive = New System.Windows.Forms.Panel()
        Me.lblCommesseMassive = New System.Windows.Forms.Label()
        Me.pnlTicketMassivi = New System.Windows.Forms.Panel()
        Me.lblTicketMassivi = New System.Windows.Forms.Label()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.pnlSeparatore = New System.Windows.Forms.Panel()
        Me.lblSeparatore = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlImpostazioni = New System.Windows.Forms.Panel()
        Me.lblImpostazioni = New System.Windows.Forms.Label()
        Me.pnlTema = New System.Windows.Forms.Panel()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.pnlDocumentazione = New System.Windows.Forms.Panel()
        Me.lblDocumentazione = New System.Windows.Forms.Label()
        Me.ToolTipMenu = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlOreLavorate = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblOreLavorate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlTicketFatti = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNumTicketFatti = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlClientiSeguiti = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblNumClientiSeguiti = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlDataGrid = New System.Windows.Forms.Panel()
        Me.btnConsuntivaTutto = New System.Windows.Forms.Label()
        Me.btnDividiXCliente = New System.Windows.Forms.Label()
        Me.lblFiltri = New System.Windows.Forms.Label()
        Me.lblGiorno_Mese = New System.Windows.Forms.Label()
        Me.dgvCalendario = New System.Windows.Forms.DataGridView()
        Me.lblFiltriSelezionati = New System.Windows.Forms.Label()
        Me.pnlFiltri = New System.Windows.Forms.Panel()
        Me.lblInsDataAFiltro = New System.Windows.Forms.Label()
        Me.lblInsDataDaFiltro = New System.Windows.Forms.Label()
        Me.lblInsMeseFiltro = New System.Windows.Forms.Label()
        Me.lblInsNotaFiltro = New System.Windows.Forms.Label()
        Me.lblInsConsuntivatoFiltro = New System.Windows.Forms.Label()
        Me.lblInsAnnoFiltro = New System.Windows.Forms.Label()
        Me.lblInsClienteFiltro = New System.Windows.Forms.Label()
        Me.lblInsTicketFiltro = New System.Windows.Forms.Label()
        Me.lblBordoDataAFiltro = New System.Windows.Forms.Label()
        Me.lblBordoDataDaFiltro = New System.Windows.Forms.Label()
        Me.lblBordoNotaFiltro = New System.Windows.Forms.Label()
        Me.lblBordoConsuntivatoFiltro = New System.Windows.Forms.Label()
        Me.lblBordoMeseFiltro = New System.Windows.Forms.Label()
        Me.lblBordoAnnoFiltro = New System.Windows.Forms.Label()
        Me.lblBordoClienteFiltro = New System.Windows.Forms.Label()
        Me.lblBordoTicketFiltro = New System.Windows.Forms.Label()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.ckbDataSelezionata = New System.Windows.Forms.CheckBox()
        Me.cmbNotaFiltro = New System.Windows.Forms.ComboBox()
        Me.cmbClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.dtpDataAFiltro = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataDaFiltro = New System.Windows.Forms.DateTimePicker()
        Me.txtTicketFiltro = New System.Windows.Forms.TextBox()
        Me.lblMesi = New System.Windows.Forms.Label()
        Me.lblConsuntivatoFiltro = New System.Windows.Forms.Label()
        Me.lblDataDaFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.lblDataAFiltro = New System.Windows.Forms.Label()
        Me.lblTicketFiltro = New System.Windows.Forms.Label()
        Me.lblAnno = New System.Windows.Forms.Label()
        Me.txtMese = New System.Windows.Forms.MaskedTextBox()
        Me.txtAnno = New System.Windows.Forms.MaskedTextBox()
        Me.txtConsuntivazioneFiltro = New System.Windows.Forms.MaskedTextBox()
        Me.pnlMensile = New System.Windows.Forms.Panel()
        Me.pnlInserisci.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pnlCommesseMassive.SuspendLayout()
        Me.pnlTicketMassivi.SuspendLayout()
        Me.pnlReport.SuspendLayout()
        Me.pnlSeparatore.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.pnlImpostazioni.SuspendLayout()
        Me.pnlTema.SuspendLayout()
        Me.pnlDocumentazione.SuspendLayout()
        Me.pnlOreLavorate.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTicketFatti.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlClientiSeguiti.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDataGrid.SuspendLayout()
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltri.SuspendLayout()
        Me.pnlMensile.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCliente.Location = New System.Drawing.Point(93, 167)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(110, 25)
        Me.cmbCliente.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCliente.Location = New System.Drawing.Point(18, 167)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente"
        '
        'lblGiorno
        '
        Me.lblGiorno.AutoSize = True
        Me.lblGiorno.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiorno.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGiorno.Location = New System.Drawing.Point(18, 67)
        Me.lblGiorno.Name = "lblGiorno"
        Me.lblGiorno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGiorno.Size = New System.Drawing.Size(57, 20)
        Me.lblGiorno.TabIndex = 10
        Me.lblGiorno.Text = "Giorno"
        '
        'dtpData
        '
        Me.dtpData.CustomFormat = "dd/MM/yyyy"
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpData.Location = New System.Drawing.Point(93, 65)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(110, 23)
        Me.dtpData.TabIndex = 10
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTicket.Location = New System.Drawing.Point(18, 117)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTicket.Size = New System.Drawing.Size(51, 20)
        Me.lblTicket.TabIndex = 12
        Me.lblTicket.Text = "Ticket"
        '
        'txtTicket
        '
        Me.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicket.Location = New System.Drawing.Point(93, 117)
        Me.txtTicket.MaxLength = 10
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTicket.Size = New System.Drawing.Size(110, 23)
        Me.txtTicket.TabIndex = 1
        '
        'TimerVisualizzazione
        '
        Me.TimerVisualizzazione.Interval = 2000
        '
        'lblSfondoColorato
        '
        Me.lblSfondoColorato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSfondoColorato.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblSfondoColorato.Location = New System.Drawing.Point(65, 28)
        Me.lblSfondoColorato.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSfondoColorato.Name = "lblSfondoColorato"
        Me.lblSfondoColorato.Size = New System.Drawing.Size(269, 521)
        Me.lblSfondoColorato.TabIndex = 21
        '
        'pnlInserisci
        '
        Me.pnlInserisci.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlInserisci.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.pnlInserisci.Controls.Add(Me.btnCarica)
        Me.pnlInserisci.Controls.Add(Me.lblBordoCarica)
        Me.pnlInserisci.Controls.Add(Me.lblInsNota)
        Me.pnlInserisci.Controls.Add(Me.lblInsTempo)
        Me.pnlInserisci.Controls.Add(Me.lblInsCliente)
        Me.pnlInserisci.Controls.Add(Me.lblInsTicket)
        Me.pnlInserisci.Controls.Add(Me.lblData)
        Me.pnlInserisci.Controls.Add(Me.ckbHome)
        Me.pnlInserisci.Controls.Add(Me.cmbNota)
        Me.pnlInserisci.Controls.Add(Me.lblNota)
        Me.pnlInserisci.Controls.Add(Me.cmbTempo)
        Me.pnlInserisci.Controls.Add(Me.lblTempo)
        Me.pnlInserisci.Controls.Add(Me.lblGiorno)
        Me.pnlInserisci.Controls.Add(Me.txtTicket)
        Me.pnlInserisci.Controls.Add(Me.lblTicket)
        Me.pnlInserisci.Controls.Add(Me.dtpData)
        Me.pnlInserisci.Controls.Add(Me.lblAggiungiCliente)
        Me.pnlInserisci.Controls.Add(Me.lblCliente)
        Me.pnlInserisci.Controls.Add(Me.cmbCliente)
        Me.pnlInserisci.Controls.Add(Me.lblBordoTicket)
        Me.pnlInserisci.Controls.Add(Me.lblBordoCliente)
        Me.pnlInserisci.Controls.Add(Me.lblBordoTempo)
        Me.pnlInserisci.Controls.Add(Me.lblBordoNota)
        Me.pnlInserisci.Location = New System.Drawing.Point(82, 56)
        Me.pnlInserisci.Name = "pnlInserisci"
        Me.pnlInserisci.Size = New System.Drawing.Size(236, 461)
        Me.pnlInserisci.TabIndex = 22
        '
        'btnCarica
        '
        Me.btnCarica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCarica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCarica.Location = New System.Drawing.Point(55, 362)
        Me.btnCarica.Name = "btnCarica"
        Me.btnCarica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCarica.Size = New System.Drawing.Size(125, 34)
        Me.btnCarica.TabIndex = 27
        Me.btnCarica.Text = "Carica"
        Me.btnCarica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCarica
        '
        Me.lblBordoCarica.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCarica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCarica.ForeColor = System.Drawing.Color.Black
        Me.lblBordoCarica.Location = New System.Drawing.Point(53, 360)
        Me.lblBordoCarica.Name = "lblBordoCarica"
        Me.lblBordoCarica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCarica.Size = New System.Drawing.Size(129, 38)
        Me.lblBordoCarica.TabIndex = 34
        Me.lblBordoCarica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsNota
        '
        Me.lblInsNota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsNota.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInsNota.Location = New System.Drawing.Point(91, 271)
        Me.lblInsNota.Name = "lblInsNota"
        Me.lblInsNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsNota.Size = New System.Drawing.Size(113, 25)
        Me.lblInsNota.TabIndex = 30
        Me.lblInsNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsTempo
        '
        Me.lblInsTempo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsTempo.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsTempo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInsTempo.Location = New System.Drawing.Point(91, 219)
        Me.lblInsTempo.Name = "lblInsTempo"
        Me.lblInsTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsTempo.Size = New System.Drawing.Size(113, 25)
        Me.lblInsTempo.TabIndex = 29
        Me.lblInsTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsCliente
        '
        Me.lblInsCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInsCliente.Location = New System.Drawing.Point(91, 167)
        Me.lblInsCliente.Name = "lblInsCliente"
        Me.lblInsCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCliente.TabIndex = 28
        Me.lblInsCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsTicket
        '
        Me.lblInsTicket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsTicket.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsTicket.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInsTicket.Location = New System.Drawing.Point(91, 117)
        Me.lblInsTicket.Name = "lblInsTicket"
        Me.lblInsTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsTicket.Size = New System.Drawing.Size(113, 23)
        Me.lblInsTicket.TabIndex = 27
        Me.lblInsTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData
        '
        Me.lblData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblData.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblData.Location = New System.Drawing.Point(91, 63)
        Me.lblData.Name = "lblData"
        Me.lblData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblData.Size = New System.Drawing.Size(113, 23)
        Me.lblData.TabIndex = 26
        Me.lblData.Text = "17 Giu, 2023"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ckbHome
        '
        Me.ckbHome.AutoSize = True
        Me.ckbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbHome.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbHome.ForeColor = System.Drawing.SystemColors.Control
        Me.ckbHome.Location = New System.Drawing.Point(93, 311)
        Me.ckbHome.Name = "ckbHome"
        Me.ckbHome.Size = New System.Drawing.Size(59, 20)
        Me.ckbHome.TabIndex = 21
        Me.ckbHome.Text = "Home"
        Me.ckbHome.UseVisualStyleBackColor = True
        '
        'cmbNota
        '
        Me.cmbNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNota.Location = New System.Drawing.Point(93, 271)
        Me.cmbNota.MaxLength = 150
        Me.cmbNota.Name = "cmbNota"
        Me.cmbNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNota.Size = New System.Drawing.Size(110, 25)
        Me.cmbNota.TabIndex = 6
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNota.Location = New System.Drawing.Point(19, 272)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNota.Size = New System.Drawing.Size(43, 20)
        Me.lblNota.TabIndex = 20
        Me.lblNota.Text = "Nota"
        '
        'cmbTempo
        '
        Me.cmbTempo.AutoCompleteCustomSource.AddRange(New String() {"0,25", "0,5", "0,75", "1", "1,25", "1,5", "1,75", "2", "2,25", "2,5", "2,75", "3", "3,25", "3,5", "3,75", "4", "4,25", "4,5", "4,75", "5", "5,25", "5,5", "5,75", "6", "6,25", "6,5", "6,75", "7", "7,25", "7,5", "7,75", "8"})
        Me.cmbTempo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTempo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTempo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTempo.FormattingEnabled = True
        Me.cmbTempo.Location = New System.Drawing.Point(93, 219)
        Me.cmbTempo.MaxLength = 4
        Me.cmbTempo.Name = "cmbTempo"
        Me.cmbTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTempo.Size = New System.Drawing.Size(110, 25)
        Me.cmbTempo.TabIndex = 3
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTempo.Location = New System.Drawing.Point(18, 219)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo.Size = New System.Drawing.Size(55, 20)
        Me.lblTempo.TabIndex = 18
        Me.lblTempo.Text = "Tempo"
        '
        'lblAggiungiCliente
        '
        Me.lblAggiungiCliente.AutoSize = True
        Me.lblAggiungiCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAggiungiCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAggiungiCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAggiungiCliente.Location = New System.Drawing.Point(206, 169)
        Me.lblAggiungiCliente.Name = "lblAggiungiCliente"
        Me.lblAggiungiCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAggiungiCliente.Size = New System.Drawing.Size(19, 20)
        Me.lblAggiungiCliente.TabIndex = 12
        Me.lblAggiungiCliente.Text = "+"
        '
        'lblBordoTicket
        '
        Me.lblBordoTicket.BackColor = System.Drawing.Color.White
        Me.lblBordoTicket.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoTicket.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoTicket.Location = New System.Drawing.Point(91, 118)
        Me.lblBordoTicket.Name = "lblBordoTicket"
        Me.lblBordoTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoTicket.Size = New System.Drawing.Size(113, 23)
        Me.lblBordoTicket.TabIndex = 31
        Me.lblBordoTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCliente
        '
        Me.lblBordoCliente.BackColor = System.Drawing.Color.White
        Me.lblBordoCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCliente.Location = New System.Drawing.Point(91, 170)
        Me.lblBordoCliente.Name = "lblBordoCliente"
        Me.lblBordoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCliente.Size = New System.Drawing.Size(113, 23)
        Me.lblBordoCliente.TabIndex = 32
        Me.lblBordoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoTempo
        '
        Me.lblBordoTempo.BackColor = System.Drawing.Color.White
        Me.lblBordoTempo.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoTempo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoTempo.Location = New System.Drawing.Point(91, 222)
        Me.lblBordoTempo.Name = "lblBordoTempo"
        Me.lblBordoTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoTempo.Size = New System.Drawing.Size(113, 23)
        Me.lblBordoTempo.TabIndex = 33
        Me.lblBordoTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoNota
        '
        Me.lblBordoNota.BackColor = System.Drawing.Color.White
        Me.lblBordoNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoNota.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoNota.Location = New System.Drawing.Point(91, 274)
        Me.lblBordoNota.Name = "lblBordoNota"
        Me.lblBordoNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoNota.Size = New System.Drawing.Size(113, 23)
        Me.lblBordoNota.TabIndex = 4
        Me.lblBordoNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ofdFile
        '
        Me.ofdFile.DefaultExt = "*.xlsx"
        Me.ofdFile.InitialDirectory = "Desktop"
        '
        'TimerSlide
        '
        Me.TimerSlide.Interval = 10
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.lblSlide)
        Me.pnlMenu.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlMenu.Controls.Add(Me.pnlSeparatore)
        Me.pnlMenu.Controls.Add(Me.FlowLayoutPanel2)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(40, 581)
        Me.pnlMenu.TabIndex = 26
        '
        'lblSlide
        '
        Me.lblSlide.BackColor = System.Drawing.Color.Transparent
        Me.lblSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSlide.ForeColor = System.Drawing.Color.White
        Me.lblSlide.Image = Global.Consuntivazione.My.Resources.Resources.menuChiuso_32x32_bianco
        Me.lblSlide.Location = New System.Drawing.Point(3, 3)
        Me.lblSlide.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSlide.Name = "lblSlide"
        Me.lblSlide.Size = New System.Drawing.Size(32, 32)
        Me.lblSlide.TabIndex = 24
        Me.lblSlide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlCommesseMassive)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlTicketMassivi)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlReport)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 35)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(210, 373)
        Me.FlowLayoutPanel1.TabIndex = 103
        '
        'pnlCommesseMassive
        '
        Me.pnlCommesseMassive.Controls.Add(Me.lblCommesseMassive)
        Me.pnlCommesseMassive.Location = New System.Drawing.Point(0, 3)
        Me.pnlCommesseMassive.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlCommesseMassive.Name = "pnlCommesseMassive"
        Me.pnlCommesseMassive.Size = New System.Drawing.Size(200, 42)
        Me.pnlCommesseMassive.TabIndex = 27
        '
        'lblCommesseMassive
        '
        Me.lblCommesseMassive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCommesseMassive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommesseMassive.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCommesseMassive.Image = Global.Consuntivazione.My.Resources.commesse_25x25_bianco
        Me.lblCommesseMassive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCommesseMassive.Location = New System.Drawing.Point(5, 1)
        Me.lblCommesseMassive.Name = "lblCommesseMassive"
        Me.lblCommesseMassive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCommesseMassive.Size = New System.Drawing.Size(180, 40)
        Me.lblCommesseMassive.TabIndex = 101
        Me.lblCommesseMassive.Text = "                 Inserisci Commesse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 Massivamente"
        Me.lblCommesseMassive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTicketMassivi
        '
        Me.pnlTicketMassivi.Controls.Add(Me.lblTicketMassivi)
        Me.pnlTicketMassivi.Location = New System.Drawing.Point(0, 51)
        Me.pnlTicketMassivi.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlTicketMassivi.Name = "pnlTicketMassivi"
        Me.pnlTicketMassivi.Size = New System.Drawing.Size(200, 42)
        Me.pnlTicketMassivi.TabIndex = 27
        '
        'lblTicketMassivi
        '
        Me.lblTicketMassivi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTicketMassivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketMassivi.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTicketMassivi.Image = Global.Consuntivazione.My.Resources.Resources.ticket_25x25_bianco
        Me.lblTicketMassivi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTicketMassivi.Location = New System.Drawing.Point(5, 1)
        Me.lblTicketMassivi.Name = "lblTicketMassivi"
        Me.lblTicketMassivi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTicketMassivi.Size = New System.Drawing.Size(180, 40)
        Me.lblTicketMassivi.TabIndex = 101
        Me.lblTicketMassivi.Text = "                 Inserisci Ticket" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 Massivamente"
        Me.lblTicketMassivi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlReport
        '
        Me.pnlReport.Controls.Add(Me.lblReport)
        Me.pnlReport.Location = New System.Drawing.Point(0, 99)
        Me.pnlReport.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(200, 42)
        Me.pnlReport.TabIndex = 27
        '
        'lblReport
        '
        Me.lblReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.SystemColors.Control
        Me.lblReport.Image = Global.Consuntivazione.My.Resources.Resources.report_25x25_binaco
        Me.lblReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReport.Location = New System.Drawing.Point(5, 1)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReport.Size = New System.Drawing.Size(180, 40)
        Me.lblReport.TabIndex = 101
        Me.lblReport.Text = "                 Report"
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSeparatore
        '
        Me.pnlSeparatore.Controls.Add(Me.lblSeparatore)
        Me.pnlSeparatore.Location = New System.Drawing.Point(0, 408)
        Me.pnlSeparatore.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSeparatore.Name = "pnlSeparatore"
        Me.pnlSeparatore.Size = New System.Drawing.Size(210, 27)
        Me.pnlSeparatore.TabIndex = 102
        '
        'lblSeparatore
        '
        Me.lblSeparatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparatore.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSeparatore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSeparatore.Location = New System.Drawing.Point(2, 0)
        Me.lblSeparatore.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSeparatore.Name = "lblSeparatore"
        Me.lblSeparatore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeparatore.Size = New System.Drawing.Size(200, 15)
        Me.lblSeparatore.TabIndex = 101
        Me.lblSeparatore.Text = "______________________________"
        Me.lblSeparatore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.pnlImpostazioni)
        Me.FlowLayoutPanel2.Controls.Add(Me.pnlTema)
        Me.FlowLayoutPanel2.Controls.Add(Me.pnlDocumentazione)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 435)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(210, 146)
        Me.FlowLayoutPanel2.TabIndex = 103
        '
        'pnlImpostazioni
        '
        Me.pnlImpostazioni.Controls.Add(Me.lblImpostazioni)
        Me.pnlImpostazioni.Location = New System.Drawing.Point(0, 3)
        Me.pnlImpostazioni.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlImpostazioni.Name = "pnlImpostazioni"
        Me.pnlImpostazioni.Size = New System.Drawing.Size(200, 42)
        Me.pnlImpostazioni.TabIndex = 27
        '
        'lblImpostazioni
        '
        Me.lblImpostazioni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblImpostazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpostazioni.ForeColor = System.Drawing.SystemColors.Control
        Me.lblImpostazioni.Image = Global.Consuntivazione.My.Resources.Resources.impostazioni_25x25_bianco
        Me.lblImpostazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblImpostazioni.Location = New System.Drawing.Point(5, 1)
        Me.lblImpostazioni.Name = "lblImpostazioni"
        Me.lblImpostazioni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblImpostazioni.Size = New System.Drawing.Size(180, 40)
        Me.lblImpostazioni.TabIndex = 101
        Me.lblImpostazioni.Text = "                 Impostazioni"
        Me.lblImpostazioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTema
        '
        Me.pnlTema.Controls.Add(Me.lblTema)
        Me.pnlTema.Location = New System.Drawing.Point(0, 51)
        Me.pnlTema.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlTema.Name = "pnlTema"
        Me.pnlTema.Size = New System.Drawing.Size(200, 42)
        Me.pnlTema.TabIndex = 27
        '
        'lblTema
        '
        Me.lblTema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTema.Image = Global.Consuntivazione.My.Resources.Resources.pennello_25x25_bianco
        Me.lblTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTema.Location = New System.Drawing.Point(5, 1)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTema.Size = New System.Drawing.Size(180, 40)
        Me.lblTema.TabIndex = 101
        Me.lblTema.Text = "                 Cambia Tema"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlDocumentazione
        '
        Me.pnlDocumentazione.Controls.Add(Me.lblDocumentazione)
        Me.pnlDocumentazione.Location = New System.Drawing.Point(0, 99)
        Me.pnlDocumentazione.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlDocumentazione.Name = "pnlDocumentazione"
        Me.pnlDocumentazione.Size = New System.Drawing.Size(200, 42)
        Me.pnlDocumentazione.TabIndex = 27
        '
        'lblDocumentazione
        '
        Me.lblDocumentazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDocumentazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDocumentazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentazione.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDocumentazione.Image = Global.Consuntivazione.My.Resources.Resources.documentazione_25x25_bianco
        Me.lblDocumentazione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDocumentazione.Location = New System.Drawing.Point(5, 1)
        Me.lblDocumentazione.Name = "lblDocumentazione"
        Me.lblDocumentazione.Size = New System.Drawing.Size(180, 40)
        Me.lblDocumentazione.TabIndex = 100
        Me.lblDocumentazione.Text = "                 Documentazione"
        Me.lblDocumentazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlOreLavorate
        '
        Me.pnlOreLavorate.BackColor = System.Drawing.SystemColors.Window
        Me.pnlOreLavorate.Controls.Add(Me.PictureBox1)
        Me.pnlOreLavorate.Controls.Add(Me.lblOreLavorate)
        Me.pnlOreLavorate.Controls.Add(Me.Label5)
        Me.pnlOreLavorate.Location = New System.Drawing.Point(514, 9)
        Me.pnlOreLavorate.Name = "pnlOreLavorate"
        Me.pnlOreLavorate.Size = New System.Drawing.Size(241, 64)
        Me.pnlOreLavorate.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consuntivazione.My.Resources.Resources.OreLavorate
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblOreLavorate
        '
        Me.lblOreLavorate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOreLavorate.AutoSize = True
        Me.lblOreLavorate.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOreLavorate.ForeColor = System.Drawing.Color.Black
        Me.lblOreLavorate.Location = New System.Drawing.Point(71, 33)
        Me.lblOreLavorate.Name = "lblOreLavorate"
        Me.lblOreLavorate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOreLavorate.Size = New System.Drawing.Size(17, 20)
        Me.lblOreLavorate.TabIndex = 12
        Me.lblOreLavorate.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(71, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ore Lavorate"
        '
        'pnlTicketFatti
        '
        Me.pnlTicketFatti.BackColor = System.Drawing.SystemColors.Window
        Me.pnlTicketFatti.Controls.Add(Me.PictureBox2)
        Me.pnlTicketFatti.Controls.Add(Me.lblNumTicketFatti)
        Me.pnlTicketFatti.Controls.Add(Me.Label2)
        Me.pnlTicketFatti.Location = New System.Drawing.Point(267, 9)
        Me.pnlTicketFatti.Name = "pnlTicketFatti"
        Me.pnlTicketFatti.Size = New System.Drawing.Size(241, 64)
        Me.pnlTicketFatti.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consuntivazione.My.Resources.Resources.ticket
        Me.PictureBox2.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'lblNumTicketFatti
        '
        Me.lblNumTicketFatti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumTicketFatti.AutoSize = True
        Me.lblNumTicketFatti.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTicketFatti.ForeColor = System.Drawing.Color.Black
        Me.lblNumTicketFatti.Location = New System.Drawing.Point(71, 33)
        Me.lblNumTicketFatti.Name = "lblNumTicketFatti"
        Me.lblNumTicketFatti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumTicketFatti.Size = New System.Drawing.Size(17, 20)
        Me.lblNumTicketFatti.TabIndex = 12
        Me.lblNumTicketFatti.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(71, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ticket Fatti"
        '
        'pnlClientiSeguiti
        '
        Me.pnlClientiSeguiti.BackColor = System.Drawing.SystemColors.Window
        Me.pnlClientiSeguiti.Controls.Add(Me.PictureBox3)
        Me.pnlClientiSeguiti.Controls.Add(Me.lblNumClientiSeguiti)
        Me.pnlClientiSeguiti.Controls.Add(Me.Label4)
        Me.pnlClientiSeguiti.Location = New System.Drawing.Point(13, 9)
        Me.pnlClientiSeguiti.Name = "pnlClientiSeguiti"
        Me.pnlClientiSeguiti.Size = New System.Drawing.Size(248, 64)
        Me.pnlClientiSeguiti.TabIndex = 30
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Consuntivazione.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'lblNumClientiSeguiti
        '
        Me.lblNumClientiSeguiti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumClientiSeguiti.AutoSize = True
        Me.lblNumClientiSeguiti.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumClientiSeguiti.ForeColor = System.Drawing.Color.Black
        Me.lblNumClientiSeguiti.Location = New System.Drawing.Point(71, 33)
        Me.lblNumClientiSeguiti.Name = "lblNumClientiSeguiti"
        Me.lblNumClientiSeguiti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumClientiSeguiti.Size = New System.Drawing.Size(17, 20)
        Me.lblNumClientiSeguiti.TabIndex = 12
        Me.lblNumClientiSeguiti.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(71, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Clienti Seguiti"
        '
        'pnlDataGrid
        '
        Me.pnlDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDataGrid.BackColor = System.Drawing.Color.White
        Me.pnlDataGrid.Controls.Add(Me.btnConsuntivaTutto)
        Me.pnlDataGrid.Controls.Add(Me.btnDividiXCliente)
        Me.pnlDataGrid.Controls.Add(Me.lblFiltri)
        Me.pnlDataGrid.Controls.Add(Me.lblGiorno_Mese)
        Me.pnlDataGrid.Controls.Add(Me.dgvCalendario)
        Me.pnlDataGrid.Location = New System.Drawing.Point(13, 80)
        Me.pnlDataGrid.Name = "pnlDataGrid"
        Me.pnlDataGrid.Size = New System.Drawing.Size(742, 450)
        Me.pnlDataGrid.TabIndex = 28
        '
        'btnConsuntivaTutto
        '
        Me.btnConsuntivaTutto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsuntivaTutto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnConsuntivaTutto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsuntivaTutto.Font = New System.Drawing.Font("Segoe UI Historic", 8.0!)
        Me.btnConsuntivaTutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConsuntivaTutto.Location = New System.Drawing.Point(511, 8)
        Me.btnConsuntivaTutto.Name = "btnConsuntivaTutto"
        Me.btnConsuntivaTutto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConsuntivaTutto.Size = New System.Drawing.Size(97, 19)
        Me.btnConsuntivaTutto.TabIndex = 38
        Me.btnConsuntivaTutto.Text = "Consuntiva Tutto"
        Me.btnConsuntivaTutto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConsuntivaTutto.Visible = False
        '
        'btnDividiXCliente
        '
        Me.btnDividiXCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDividiXCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDividiXCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDividiXCliente.Font = New System.Drawing.Font("Segoe UI Historic", 8.0!)
        Me.btnDividiXCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDividiXCliente.Location = New System.Drawing.Point(614, 8)
        Me.btnDividiXCliente.Name = "btnDividiXCliente"
        Me.btnDividiXCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDividiXCliente.Size = New System.Drawing.Size(97, 19)
        Me.btnDividiXCliente.TabIndex = 36
        Me.btnDividiXCliente.Text = "Dividi per Cliente"
        Me.btnDividiXCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDividiXCliente.Visible = False
        '
        'lblFiltri
        '
        Me.lblFiltri.BackColor = System.Drawing.Color.Transparent
        Me.lblFiltri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFiltri.ForeColor = System.Drawing.Color.White
        Me.lblFiltri.Image = CType(resources.GetObject("lblFiltri.Image"), System.Drawing.Image)
        Me.lblFiltri.Location = New System.Drawing.Point(28, 9)
        Me.lblFiltri.Name = "lblFiltri"
        Me.lblFiltri.Size = New System.Drawing.Size(16, 16)
        Me.lblFiltri.TabIndex = 32
        Me.lblFiltri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFiltri.Visible = False
        '
        'lblGiorno_Mese
        '
        Me.lblGiorno_Mese.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGiorno_Mese.AutoSize = True
        Me.lblGiorno_Mese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGiorno_Mese.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiorno_Mese.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblGiorno_Mese.Location = New System.Drawing.Point(626, 408)
        Me.lblGiorno_Mese.Name = "lblGiorno_Mese"
        Me.lblGiorno_Mese.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGiorno_Mese.Size = New System.Drawing.Size(85, 30)
        Me.lblGiorno_Mese.TabIndex = 35
        Me.lblGiorno_Mese.Text = "Espandi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Visualizzazione"
        Me.lblGiorno_Mese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvCalendario
        '
        Me.dgvCalendario.AllowUserToAddRows = False
        Me.dgvCalendario.AllowUserToDeleteRows = False
        Me.dgvCalendario.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.dgvCalendario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCalendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCalendario.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCalendario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCalendario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCalendario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCalendario.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCalendario.EnableHeadersVisualStyles = False
        Me.dgvCalendario.Location = New System.Drawing.Point(31, 20)
        Me.dgvCalendario.Name = "dgvCalendario"
        Me.dgvCalendario.ReadOnly = True
        Me.dgvCalendario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCalendario.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.dgvCalendario.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCalendario.RowTemplate.Height = 28
        Me.dgvCalendario.Size = New System.Drawing.Size(680, 374)
        Me.dgvCalendario.TabIndex = 17
        '
        'lblFiltriSelezionati
        '
        Me.lblFiltriSelezionati.AutoSize = True
        Me.lblFiltriSelezionati.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFiltriSelezionati.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!)
        Me.lblFiltriSelezionati.Location = New System.Drawing.Point(63, 88)
        Me.lblFiltriSelezionati.Name = "lblFiltriSelezionati"
        Me.lblFiltriSelezionati.Size = New System.Drawing.Size(35, 19)
        Me.lblFiltriSelezionati.TabIndex = 21
        Me.lblFiltriSelezionati.Text = "Filtri"
        Me.lblFiltriSelezionati.Visible = False
        '
        'pnlFiltri
        '
        Me.pnlFiltri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFiltri.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFiltri.Controls.Add(Me.lblInsDataAFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsDataDaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsMeseFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsNotaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsConsuntivatoFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsAnnoFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsClienteFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblInsTicketFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoDataAFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoDataDaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoNotaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoConsuntivatoFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoMeseFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoAnnoFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoClienteFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblBordoTicketFiltro)
        Me.pnlFiltri.Controls.Add(Me.btnCerca)
        Me.pnlFiltri.Controls.Add(Me.ckbDataSelezionata)
        Me.pnlFiltri.Controls.Add(Me.cmbNotaFiltro)
        Me.pnlFiltri.Controls.Add(Me.cmbClienteFiltro)
        Me.pnlFiltri.Controls.Add(Me.dtpDataAFiltro)
        Me.pnlFiltri.Controls.Add(Me.dtpDataDaFiltro)
        Me.pnlFiltri.Controls.Add(Me.txtTicketFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblMesi)
        Me.pnlFiltri.Controls.Add(Me.lblConsuntivatoFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblDataDaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblNotaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblClienteFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblDataAFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblTicketFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblAnno)
        Me.pnlFiltri.Controls.Add(Me.txtMese)
        Me.pnlFiltri.Controls.Add(Me.txtAnno)
        Me.pnlFiltri.Controls.Add(Me.txtConsuntivazioneFiltro)
        Me.pnlFiltri.Location = New System.Drawing.Point(42, 84)
        Me.pnlFiltri.Name = "pnlFiltri"
        Me.pnlFiltri.Size = New System.Drawing.Size(680, 0)
        Me.pnlFiltri.TabIndex = 27
        '
        'lblInsDataAFiltro
        '
        Me.lblInsDataAFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsDataAFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsDataAFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsDataAFiltro.ForeColor = System.Drawing.Color.Gray
        Me.lblInsDataAFiltro.Location = New System.Drawing.Point(519, -139)
        Me.lblInsDataAFiltro.Name = "lblInsDataAFiltro"
        Me.lblInsDataAFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsDataAFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsDataAFiltro.TabIndex = 49
        Me.lblInsDataAFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsDataDaFiltro
        '
        Me.lblInsDataDaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsDataDaFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsDataDaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsDataDaFiltro.ForeColor = System.Drawing.Color.Gray
        Me.lblInsDataDaFiltro.Location = New System.Drawing.Point(519, -189)
        Me.lblInsDataDaFiltro.Name = "lblInsDataDaFiltro"
        Me.lblInsDataDaFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsDataDaFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsDataDaFiltro.TabIndex = 48
        Me.lblInsDataDaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsMeseFiltro
        '
        Me.lblInsMeseFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblInsMeseFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsMeseFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsMeseFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblInsMeseFiltro.Location = New System.Drawing.Point(314, -90)
        Me.lblInsMeseFiltro.Name = "lblInsMeseFiltro"
        Me.lblInsMeseFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsMeseFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsMeseFiltro.TabIndex = 47
        Me.lblInsMeseFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsNotaFiltro
        '
        Me.lblInsNotaFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblInsNotaFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsNotaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsNotaFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblInsNotaFiltro.Location = New System.Drawing.Point(314, -139)
        Me.lblInsNotaFiltro.Name = "lblInsNotaFiltro"
        Me.lblInsNotaFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsNotaFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsNotaFiltro.TabIndex = 46
        Me.lblInsNotaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsConsuntivatoFiltro
        '
        Me.lblInsConsuntivatoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblInsConsuntivatoFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsConsuntivatoFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsConsuntivatoFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblInsConsuntivatoFiltro.Location = New System.Drawing.Point(314, -190)
        Me.lblInsConsuntivatoFiltro.Name = "lblInsConsuntivatoFiltro"
        Me.lblInsConsuntivatoFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsConsuntivatoFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsConsuntivatoFiltro.TabIndex = 45
        Me.lblInsConsuntivatoFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsAnnoFiltro
        '
        Me.lblInsAnnoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInsAnnoFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsAnnoFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsAnnoFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblInsAnnoFiltro.Location = New System.Drawing.Point(100, -90)
        Me.lblInsAnnoFiltro.Name = "lblInsAnnoFiltro"
        Me.lblInsAnnoFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsAnnoFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsAnnoFiltro.TabIndex = 44
        Me.lblInsAnnoFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsClienteFiltro
        '
        Me.lblInsClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInsClienteFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsClienteFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsClienteFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblInsClienteFiltro.Location = New System.Drawing.Point(100, -139)
        Me.lblInsClienteFiltro.Name = "lblInsClienteFiltro"
        Me.lblInsClienteFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsClienteFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsClienteFiltro.TabIndex = 43
        Me.lblInsClienteFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsTicketFiltro
        '
        Me.lblInsTicketFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInsTicketFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsTicketFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsTicketFiltro.ForeColor = System.Drawing.Color.Black
        Me.lblInsTicketFiltro.Location = New System.Drawing.Point(100, -190)
        Me.lblInsTicketFiltro.Name = "lblInsTicketFiltro"
        Me.lblInsTicketFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsTicketFiltro.Size = New System.Drawing.Size(113, 24)
        Me.lblInsTicketFiltro.TabIndex = 35
        Me.lblInsTicketFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoDataAFiltro
        '
        Me.lblBordoDataAFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBordoDataAFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoDataAFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoDataAFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoDataAFiltro.Location = New System.Drawing.Point(519, -139)
        Me.lblBordoDataAFiltro.Name = "lblBordoDataAFiltro"
        Me.lblBordoDataAFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoDataAFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoDataAFiltro.TabIndex = 42
        Me.lblBordoDataAFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoDataDaFiltro
        '
        Me.lblBordoDataDaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBordoDataDaFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoDataDaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoDataDaFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoDataDaFiltro.Location = New System.Drawing.Point(519, -189)
        Me.lblBordoDataDaFiltro.Name = "lblBordoDataDaFiltro"
        Me.lblBordoDataDaFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoDataDaFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoDataDaFiltro.TabIndex = 41
        Me.lblBordoDataDaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoNotaFiltro
        '
        Me.lblBordoNotaFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBordoNotaFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoNotaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoNotaFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoNotaFiltro.Location = New System.Drawing.Point(314, -139)
        Me.lblBordoNotaFiltro.Name = "lblBordoNotaFiltro"
        Me.lblBordoNotaFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoNotaFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoNotaFiltro.TabIndex = 40
        Me.lblBordoNotaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoConsuntivatoFiltro
        '
        Me.lblBordoConsuntivatoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBordoConsuntivatoFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoConsuntivatoFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoConsuntivatoFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoConsuntivatoFiltro.Location = New System.Drawing.Point(314, -190)
        Me.lblBordoConsuntivatoFiltro.Name = "lblBordoConsuntivatoFiltro"
        Me.lblBordoConsuntivatoFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoConsuntivatoFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoConsuntivatoFiltro.TabIndex = 39
        Me.lblBordoConsuntivatoFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoMeseFiltro
        '
        Me.lblBordoMeseFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBordoMeseFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoMeseFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoMeseFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoMeseFiltro.Location = New System.Drawing.Point(314, -90)
        Me.lblBordoMeseFiltro.Name = "lblBordoMeseFiltro"
        Me.lblBordoMeseFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoMeseFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoMeseFiltro.TabIndex = 38
        Me.lblBordoMeseFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoAnnoFiltro
        '
        Me.lblBordoAnnoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBordoAnnoFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoAnnoFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoAnnoFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoAnnoFiltro.Location = New System.Drawing.Point(100, -90)
        Me.lblBordoAnnoFiltro.Name = "lblBordoAnnoFiltro"
        Me.lblBordoAnnoFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoAnnoFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoAnnoFiltro.TabIndex = 37
        Me.lblBordoAnnoFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoClienteFiltro
        '
        Me.lblBordoClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBordoClienteFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoClienteFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoClienteFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoClienteFiltro.Location = New System.Drawing.Point(100, -139)
        Me.lblBordoClienteFiltro.Name = "lblBordoClienteFiltro"
        Me.lblBordoClienteFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoClienteFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoClienteFiltro.TabIndex = 36
        Me.lblBordoClienteFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoTicketFiltro
        '
        Me.lblBordoTicketFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBordoTicketFiltro.BackColor = System.Drawing.Color.Black
        Me.lblBordoTicketFiltro.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoTicketFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoTicketFiltro.Location = New System.Drawing.Point(100, -190)
        Me.lblBordoTicketFiltro.Name = "lblBordoTicketFiltro"
        Me.lblBordoTicketFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoTicketFiltro.Size = New System.Drawing.Size(113, 25)
        Me.lblBordoTicketFiltro.TabIndex = 35
        Me.lblBordoTicketFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCerca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCerca.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnCerca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerca.Location = New System.Drawing.Point(51, -39)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(66, 27)
        Me.btnCerca.TabIndex = 28
        Me.btnCerca.Text = "Cerca"
        Me.btnCerca.UseVisualStyleBackColor = False
        '
        'ckbDataSelezionata
        '
        Me.ckbDataSelezionata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckbDataSelezionata.AutoSize = True
        Me.ckbDataSelezionata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbDataSelezionata.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbDataSelezionata.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckbDataSelezionata.Location = New System.Drawing.Point(521, -84)
        Me.ckbDataSelezionata.Name = "ckbDataSelezionata"
        Me.ckbDataSelezionata.Size = New System.Drawing.Size(104, 20)
        Me.ckbDataSelezionata.TabIndex = 28
        Me.ckbDataSelezionata.Text = "Seleziona Data"
        Me.ckbDataSelezionata.UseVisualStyleBackColor = True
        '
        'cmbNotaFiltro
        '
        Me.cmbNotaFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmbNotaFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbNotaFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNotaFiltro.Items.AddRange(New Object() {"Criticità", "Fixed", "Formazione", "Home"})
        Me.cmbNotaFiltro.Location = New System.Drawing.Point(318, -139)
        Me.cmbNotaFiltro.MaxLength = 20
        Me.cmbNotaFiltro.Name = "cmbNotaFiltro"
        Me.cmbNotaFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNotaFiltro.Size = New System.Drawing.Size(100, 25)
        Me.cmbNotaFiltro.Sorted = True
        Me.cmbNotaFiltro.TabIndex = 14
        '
        'cmbClienteFiltro
        '
        Me.cmbClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbClienteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbClienteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClienteFiltro.Location = New System.Drawing.Point(102, -139)
        Me.cmbClienteFiltro.MaxLength = 30
        Me.cmbClienteFiltro.Name = "cmbClienteFiltro"
        Me.cmbClienteFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbClienteFiltro.Size = New System.Drawing.Size(110, 25)
        Me.cmbClienteFiltro.TabIndex = 12
        '
        'dtpDataAFiltro
        '
        Me.dtpDataAFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataAFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataAFiltro.Enabled = False
        Me.dtpDataAFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataAFiltro.Location = New System.Drawing.Point(523, -138)
        Me.dtpDataAFiltro.Name = "dtpDataAFiltro"
        Me.dtpDataAFiltro.Size = New System.Drawing.Size(102, 23)
        Me.dtpDataAFiltro.TabIndex = 20
        '
        'dtpDataDaFiltro
        '
        Me.dtpDataDaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataDaFiltro.Checked = False
        Me.dtpDataDaFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataDaFiltro.Enabled = False
        Me.dtpDataDaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataDaFiltro.Location = New System.Drawing.Point(523, -187)
        Me.dtpDataDaFiltro.Name = "dtpDataDaFiltro"
        Me.dtpDataDaFiltro.Size = New System.Drawing.Size(102, 23)
        Me.dtpDataDaFiltro.TabIndex = 19
        '
        'txtTicketFiltro
        '
        Me.txtTicketFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTicketFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicketFiltro.Location = New System.Drawing.Point(102, -190)
        Me.txtTicketFiltro.MaxLength = 10
        Me.txtTicketFiltro.Name = "txtTicketFiltro"
        Me.txtTicketFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTicketFiltro.Size = New System.Drawing.Size(110, 23)
        Me.txtTicketFiltro.TabIndex = 1
        '
        'lblMesi
        '
        Me.lblMesi.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMesi.AutoSize = True
        Me.lblMesi.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblMesi.Location = New System.Drawing.Point(262, -90)
        Me.lblMesi.Name = "lblMesi"
        Me.lblMesi.Size = New System.Drawing.Size(46, 20)
        Me.lblMesi.TabIndex = 22
        Me.lblMesi.Text = "Mese"
        Me.lblMesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConsuntivatoFiltro
        '
        Me.lblConsuntivatoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblConsuntivatoFiltro.AutoSize = True
        Me.lblConsuntivatoFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblConsuntivatoFiltro.Location = New System.Drawing.Point(204, -190)
        Me.lblConsuntivatoFiltro.Name = "lblConsuntivatoFiltro"
        Me.lblConsuntivatoFiltro.Size = New System.Drawing.Size(104, 20)
        Me.lblConsuntivatoFiltro.TabIndex = 22
        Me.lblConsuntivatoFiltro.Text = "Consuntivato"
        Me.lblConsuntivatoFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataDaFiltro
        '
        Me.lblDataDaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataDaFiltro.AutoSize = True
        Me.lblDataDaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblDataDaFiltro.Location = New System.Drawing.Point(447, -190)
        Me.lblDataDaFiltro.Name = "lblDataDaFiltro"
        Me.lblDataDaFiltro.Size = New System.Drawing.Size(65, 20)
        Me.lblDataDaFiltro.TabIndex = 22
        Me.lblDataDaFiltro.Text = "Data Da"
        Me.lblDataDaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotaFiltro
        '
        Me.lblNotaFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNotaFiltro.AutoSize = True
        Me.lblNotaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblNotaFiltro.Location = New System.Drawing.Point(265, -139)
        Me.lblNotaFiltro.Name = "lblNotaFiltro"
        Me.lblNotaFiltro.Size = New System.Drawing.Size(43, 20)
        Me.lblNotaFiltro.TabIndex = 22
        Me.lblNotaFiltro.Text = "Nota"
        Me.lblNotaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblClienteFiltro.Location = New System.Drawing.Point(35, -139)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(59, 20)
        Me.lblClienteFiltro.TabIndex = 22
        Me.lblClienteFiltro.Text = "Cliente"
        Me.lblClienteFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataAFiltro
        '
        Me.lblDataAFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataAFiltro.AutoSize = True
        Me.lblDataAFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblDataAFiltro.Location = New System.Drawing.Point(456, -139)
        Me.lblDataAFiltro.Name = "lblDataAFiltro"
        Me.lblDataAFiltro.Size = New System.Drawing.Size(56, 20)
        Me.lblDataAFiltro.TabIndex = 22
        Me.lblDataAFiltro.Text = "Data A"
        Me.lblDataAFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTicketFiltro
        '
        Me.lblTicketFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTicketFiltro.AutoSize = True
        Me.lblTicketFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblTicketFiltro.Location = New System.Drawing.Point(42, -190)
        Me.lblTicketFiltro.Name = "lblTicketFiltro"
        Me.lblTicketFiltro.Size = New System.Drawing.Size(51, 20)
        Me.lblTicketFiltro.TabIndex = 22
        Me.lblTicketFiltro.Text = "Ticket"
        Me.lblTicketFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnno
        '
        Me.lblAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAnno.AutoSize = True
        Me.lblAnno.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblAnno.Location = New System.Drawing.Point(48, -90)
        Me.lblAnno.Name = "lblAnno"
        Me.lblAnno.Size = New System.Drawing.Size(46, 20)
        Me.lblAnno.TabIndex = 22
        Me.lblAnno.Text = "Anno"
        Me.lblAnno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMese
        '
        Me.txtMese.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtMese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMese.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtMese.Location = New System.Drawing.Point(318, -89)
        Me.txtMese.Mask = "99"
        Me.txtMese.Name = "txtMese"
        Me.txtMese.Size = New System.Drawing.Size(100, 23)
        Me.txtMese.TabIndex = 16
        '
        'txtAnno
        '
        Me.txtAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnno.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAnno.Location = New System.Drawing.Point(104, -90)
        Me.txtAnno.Mask = "9999"
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(100, 23)
        Me.txtAnno.TabIndex = 15
        '
        'txtConsuntivazioneFiltro
        '
        Me.txtConsuntivazioneFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtConsuntivazioneFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsuntivazioneFiltro.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtConsuntivazioneFiltro.Location = New System.Drawing.Point(318, -190)
        Me.txtConsuntivazioneFiltro.Mask = "LL"
        Me.txtConsuntivazioneFiltro.Name = "txtConsuntivazioneFiltro"
        Me.txtConsuntivazioneFiltro.Size = New System.Drawing.Size(100, 23)
        Me.txtConsuntivazioneFiltro.TabIndex = 13
        '
        'pnlMensile
        '
        Me.pnlMensile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMensile.BackColor = System.Drawing.Color.Transparent
        Me.pnlMensile.Controls.Add(Me.pnlOreLavorate)
        Me.pnlMensile.Controls.Add(Me.pnlClientiSeguiti)
        Me.pnlMensile.Controls.Add(Me.pnlTicketFatti)
        Me.pnlMensile.Controls.Add(Me.pnlFiltri)
        Me.pnlMensile.Controls.Add(Me.lblFiltriSelezionati)
        Me.pnlMensile.Controls.Add(Me.pnlDataGrid)
        Me.pnlMensile.Location = New System.Drawing.Point(331, 19)
        Me.pnlMensile.Name = "pnlMensile"
        Me.pnlMensile.Size = New System.Drawing.Size(770, 540)
        Me.pnlMensile.TabIndex = 19
        '
        'frmConsuntivazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1120, 581)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlInserisci)
        Me.Controls.Add(Me.lblSfondoColorato)
        Me.Controls.Add(Me.pnlMensile)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1120, 620)
        Me.Name = "frmConsuntivazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consuntivazione - 3.0.0"
        Me.pnlInserisci.ResumeLayout(False)
        Me.pnlInserisci.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pnlCommesseMassive.ResumeLayout(False)
        Me.pnlTicketMassivi.ResumeLayout(False)
        Me.pnlReport.ResumeLayout(False)
        Me.pnlSeparatore.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.pnlImpostazioni.ResumeLayout(False)
        Me.pnlTema.ResumeLayout(False)
        Me.pnlDocumentazione.ResumeLayout(False)
        Me.pnlOreLavorate.ResumeLayout(False)
        Me.pnlOreLavorate.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTicketFatti.ResumeLayout(False)
        Me.pnlTicketFatti.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlClientiSeguiti.ResumeLayout(False)
        Me.pnlClientiSeguiti.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDataGrid.ResumeLayout(False)
        Me.pnlDataGrid.PerformLayout()
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltri.ResumeLayout(False)
        Me.pnlFiltri.PerformLayout()
        Me.pnlMensile.ResumeLayout(False)
        Me.pnlMensile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblGiorno As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents lblTicket As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents TimerVisualizzazione As Timer
    Friend WithEvents lblSfondoColorato As Label
    Friend WithEvents pnlInserisci As Panel
    Friend WithEvents lblAggiungiCliente As Label
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents TimerSlide As Timer
    Friend WithEvents lblDocumentazione As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ckbHome As CheckBox
    Friend WithEvents cmbNota As ComboBox
    Friend WithEvents lblNota As Label
    Friend WithEvents cmbTempo As ComboBox
    Friend WithEvents lblTempo As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblInsNota As Label
    Friend WithEvents lblInsTempo As Label
    Friend WithEvents lblInsCliente As Label
    Friend WithEvents lblInsTicket As Label
    Friend WithEvents lblBordoTicket As Label
    Friend WithEvents lblBordoCliente As Label
    Friend WithEvents lblBordoTempo As Label
    Friend WithEvents lblBordoNota As Label
    Friend WithEvents lblSlide As Label
    Friend WithEvents pnlMenu As FlowLayoutPanel
    Friend WithEvents pnlImpostazioni As Panel
    Friend WithEvents pnlDocumentazione As Panel
    Friend WithEvents lblImpostazioni As Label
    Friend WithEvents pnlTema As Panel
    Friend WithEvents lblTema As Label
    Friend WithEvents pnlTicketMassivi As Panel
    Friend WithEvents lblTicketMassivi As Label
    Friend WithEvents pnlCommesseMassive As Panel
    Friend WithEvents lblCommesseMassive As Label
    Friend WithEvents pnlReport As Panel
    Friend WithEvents lblReport As Label
    Friend WithEvents pnlSeparatore As Panel
    Friend WithEvents lblSeparatore As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ToolTipMenu As ToolTip
    Friend WithEvents pnlOreLavorate As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblOreLavorate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlTicketFatti As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblNumTicketFatti As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlClientiSeguiti As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblNumClientiSeguiti As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlDataGrid As Panel
    Friend WithEvents lblGiorno_Mese As Label
    Friend WithEvents dgvCalendario As DataGridView
    Friend WithEvents lblFiltriSelezionati As Label
    Friend WithEvents pnlFiltri As Panel
    Friend WithEvents btnCerca As Button
    Friend WithEvents pnlMensile As Panel
    Friend WithEvents lblFiltri As Label
    Friend WithEvents lblInsDataAFiltro As Label
    Friend WithEvents lblInsDataDaFiltro As Label
    Friend WithEvents lblInsMeseFiltro As Label
    Friend WithEvents lblInsNotaFiltro As Label
    Friend WithEvents lblInsConsuntivatoFiltro As Label
    Friend WithEvents lblInsAnnoFiltro As Label
    Friend WithEvents lblInsClienteFiltro As Label
    Friend WithEvents lblInsTicketFiltro As Label
    Friend WithEvents lblBordoDataAFiltro As Label
    Friend WithEvents lblBordoDataDaFiltro As Label
    Friend WithEvents lblBordoNotaFiltro As Label
    Friend WithEvents lblBordoConsuntivatoFiltro As Label
    Friend WithEvents lblBordoMeseFiltro As Label
    Friend WithEvents lblBordoAnnoFiltro As Label
    Friend WithEvents lblBordoClienteFiltro As Label
    Friend WithEvents lblBordoTicketFiltro As Label
    Friend WithEvents ckbDataSelezionata As CheckBox
    Friend WithEvents cmbNotaFiltro As ComboBox
    Friend WithEvents cmbClienteFiltro As ComboBox
    Friend WithEvents dtpDataAFiltro As DateTimePicker
    Friend WithEvents dtpDataDaFiltro As DateTimePicker
    Friend WithEvents txtTicketFiltro As TextBox
    Friend WithEvents lblMesi As Label
    Friend WithEvents lblConsuntivatoFiltro As Label
    Friend WithEvents lblDataDaFiltro As Label
    Friend WithEvents lblNotaFiltro As Label
    Friend WithEvents lblClienteFiltro As Label
    Friend WithEvents lblDataAFiltro As Label
    Friend WithEvents lblTicketFiltro As Label
    Friend WithEvents lblAnno As Label
    Friend WithEvents txtMese As MaskedTextBox
    Friend WithEvents txtAnno As MaskedTextBox
    Friend WithEvents txtConsuntivazioneFiltro As MaskedTextBox
    Friend WithEvents btnCarica As Label
    Friend WithEvents lblBordoCarica As Label
    Friend WithEvents btnDividiXCliente As Label
    Friend WithEvents btnConsuntivaTutto As Label
End Class
