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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsuntivazione))
        Me.dgvCalendario = New System.Windows.Forms.DataGridView()
        Me.btnCarica = New System.Windows.Forms.Button()
        Me.cmbTempo = New System.Windows.Forms.ComboBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.lblGiorno = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.TimerVisualizzazione = New System.Windows.Forms.Timer(Me.components)
        Me.lblTempoTot = New System.Windows.Forms.Label()
        Me.lblGiorno_Mese = New System.Windows.Forms.Label()
        Me.pnlMensile = New System.Windows.Forms.Panel()
        Me.nudAnno = New System.Windows.Forms.NumericUpDown()
        Me.lstMesi = New System.Windows.Forms.ListBox()
        Me.lblResoconto = New System.Windows.Forms.Label()
        Me.lblAnno = New System.Windows.Forms.Label()
        Me.lblMesi = New System.Windows.Forms.Label()
        Me.btnConsuntivaTutto = New System.Windows.Forms.Button()
        Me.btnDividiXCliente = New System.Windows.Forms.Button()
        Me.lblSfondoColorato = New System.Windows.Forms.Label()
        Me.pnlInserisci = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancellaFiltri = New System.Windows.Forms.Button()
        Me.rdbFormazione = New System.Windows.Forms.RadioButton()
        Me.ckbAltro = New System.Windows.Forms.CheckBox()
        Me.ckbHome = New System.Windows.Forms.CheckBox()
        Me.rdbFixed = New System.Windows.Forms.RadioButton()
        Me.rdbCriticita = New System.Windows.Forms.RadioButton()
        Me.lblAggiungiCliente = New System.Windows.Forms.Label()
        Me.TimerConsuntiva = New System.Windows.Forms.Timer(Me.components)
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.lblSeparatore = New System.Windows.Forms.Label()
        Me.imgDocumentazione = New System.Windows.Forms.Label()
        Me.lblDocumentazione = New System.Windows.Forms.Label()
        Me.imgTema = New System.Windows.Forms.Label()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.imgTicketMassivi = New System.Windows.Forms.Label()
        Me.imgCommesseMassive = New System.Windows.Forms.Label()
        Me.lblTicketMssivi = New System.Windows.Forms.Label()
        Me.lblCommesseMassive = New System.Windows.Forms.Label()
        Me.TimerSlide = New System.Windows.Forms.Timer(Me.components)
        Me.lblSlide = New System.Windows.Forms.Label()
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMensile.SuspendLayout()
        CType(Me.nudAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInserisci.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCalendario
        '
        Me.dgvCalendario.AllowUserToAddRows = False
        Me.dgvCalendario.AllowUserToDeleteRows = False
        Me.dgvCalendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCalendario.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCalendario.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCalendario.Location = New System.Drawing.Point(45, 46)
        Me.dgvCalendario.MinimumSize = New System.Drawing.Size(660, 426)
        Me.dgvCalendario.Name = "dgvCalendario"
        Me.dgvCalendario.ReadOnly = True
        Me.dgvCalendario.Size = New System.Drawing.Size(680, 426)
        Me.dgvCalendario.TabIndex = 17
        '
        'btnCarica
        '
        Me.btnCarica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCarica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnCarica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCarica.Location = New System.Drawing.Point(68, 251)
        Me.btnCarica.Name = "btnCarica"
        Me.btnCarica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCarica.Size = New System.Drawing.Size(138, 49)
        Me.btnCarica.TabIndex = 5
        Me.btnCarica.Text = "Carica"
        Me.btnCarica.UseVisualStyleBackColor = False
        '
        'cmbTempo
        '
        Me.cmbTempo.AutoCompleteCustomSource.AddRange(New String() {"0,25", "0,5", "0,75", "1", "1,25", "1,5", "1,75", "2", "2,25", "2,5", "2,75", "3", "3,25", "3,5", "3,75", "4", "4,25", "4,5", "4,75", "5", "5,25", "5,5", "5,75", "6", "6,25", "6,5", "6,75", "7", "7,25", "7,5", "7,75", "8"})
        Me.cmbTempo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTempo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTempo.FormattingEnabled = True
        Me.cmbTempo.Location = New System.Drawing.Point(112, 187)
        Me.cmbTempo.MaxLength = 4
        Me.cmbTempo.Name = "cmbTempo"
        Me.cmbTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTempo.Size = New System.Drawing.Size(110, 25)
        Me.cmbTempo.TabIndex = 4
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.Location = New System.Drawing.Point(112, 137)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(110, 25)
        Me.cmbCliente.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCliente.Location = New System.Drawing.Point(37, 137)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente"
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTempo.Location = New System.Drawing.Point(37, 187)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo.Size = New System.Drawing.Size(55, 20)
        Me.lblTempo.TabIndex = 11
        Me.lblTempo.Text = "Tempo"
        '
        'lblGiorno
        '
        Me.lblGiorno.AutoSize = True
        Me.lblGiorno.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiorno.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGiorno.Location = New System.Drawing.Point(37, 37)
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
        Me.dtpData.Location = New System.Drawing.Point(112, 35)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(102, 23)
        Me.dtpData.TabIndex = 10
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTicket.Location = New System.Drawing.Point(37, 87)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTicket.Size = New System.Drawing.Size(51, 20)
        Me.lblTicket.TabIndex = 12
        Me.lblTicket.Text = "Ticket"
        '
        'txtTicket
        '
        Me.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicket.Location = New System.Drawing.Point(112, 87)
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
        'lblTempoTot
        '
        Me.lblTempoTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTempoTot.AutoSize = True
        Me.lblTempoTot.Location = New System.Drawing.Point(685, 505)
        Me.lblTempoTot.Name = "lblTempoTot"
        Me.lblTempoTot.Size = New System.Drawing.Size(15, 17)
        Me.lblTempoTot.TabIndex = 18
        Me.lblTempoTot.Text = "0"
        '
        'lblGiorno_Mese
        '
        Me.lblGiorno_Mese.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGiorno_Mese.AutoSize = True
        Me.lblGiorno_Mese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGiorno_Mese.Location = New System.Drawing.Point(586, 488)
        Me.lblGiorno_Mese.Name = "lblGiorno_Mese"
        Me.lblGiorno_Mese.Size = New System.Drawing.Size(84, 51)
        Me.lblGiorno_Mese.TabIndex = 18
        Me.lblGiorno_Mese.Text = "Totale " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ore di lavoro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Giornaliero)"
        Me.lblGiorno_Mese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMensile
        '
        Me.pnlMensile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMensile.BackColor = System.Drawing.Color.Transparent
        Me.pnlMensile.Controls.Add(Me.nudAnno)
        Me.pnlMensile.Controls.Add(Me.lstMesi)
        Me.pnlMensile.Controls.Add(Me.lblResoconto)
        Me.pnlMensile.Controls.Add(Me.lblAnno)
        Me.pnlMensile.Controls.Add(Me.lblMesi)
        Me.pnlMensile.Controls.Add(Me.lblGiorno_Mese)
        Me.pnlMensile.Controls.Add(Me.lblTempoTot)
        Me.pnlMensile.Controls.Add(Me.dgvCalendario)
        Me.pnlMensile.Controls.Add(Me.btnConsuntivaTutto)
        Me.pnlMensile.Controls.Add(Me.btnDividiXCliente)
        Me.pnlMensile.Location = New System.Drawing.Point(327, 15)
        Me.pnlMensile.Name = "pnlMensile"
        Me.pnlMensile.Size = New System.Drawing.Size(770, 550)
        Me.pnlMensile.TabIndex = 19
        '
        'nudAnno
        '
        Me.nudAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAnno.Enabled = False
        Me.nudAnno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nudAnno.Location = New System.Drawing.Point(234, 17)
        Me.nudAnno.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.nudAnno.Minimum = New Decimal(New Integer() {2022, 0, 0, 0})
        Me.nudAnno.Name = "nudAnno"
        Me.nudAnno.Size = New System.Drawing.Size(55, 23)
        Me.nudAnno.TabIndex = 23
        Me.nudAnno.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        Me.nudAnno.Visible = False
        '
        'lstMesi
        '
        Me.lstMesi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMesi.ColumnWidth = 30
        Me.lstMesi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstMesi.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMesi.ItemHeight = 17
        Me.lstMesi.Items.AddRange(New Object() {"   1", "   2", "   3", "   4", "   5", "   6", "   7", "   8", "   9", "  10", "  11", "  12"})
        Me.lstMesi.Location = New System.Drawing.Point(354, 22)
        Me.lstMesi.MultiColumn = True
        Me.lstMesi.Name = "lstMesi"
        Me.lstMesi.Size = New System.Drawing.Size(365, 19)
        Me.lstMesi.TabIndex = 20
        Me.lstMesi.Visible = False
        '
        'lblResoconto
        '
        Me.lblResoconto.AutoSize = True
        Me.lblResoconto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblResoconto.Location = New System.Drawing.Point(39, 14)
        Me.lblResoconto.Name = "lblResoconto"
        Me.lblResoconto.Size = New System.Drawing.Size(109, 27)
        Me.lblResoconto.TabIndex = 21
        Me.lblResoconto.Text = "Resoconto"
        Me.lblResoconto.Visible = False
        '
        'lblAnno
        '
        Me.lblAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnno.AutoSize = True
        Me.lblAnno.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblAnno.Location = New System.Drawing.Point(179, 20)
        Me.lblAnno.Name = "lblAnno"
        Me.lblAnno.Size = New System.Drawing.Size(49, 20)
        Me.lblAnno.TabIndex = 22
        Me.lblAnno.Text = "Anno:"
        Me.lblAnno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnno.Visible = False
        '
        'lblMesi
        '
        Me.lblMesi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMesi.AutoSize = True
        Me.lblMesi.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblMesi.Location = New System.Drawing.Point(299, 20)
        Me.lblMesi.Name = "lblMesi"
        Me.lblMesi.Size = New System.Drawing.Size(49, 20)
        Me.lblMesi.TabIndex = 22
        Me.lblMesi.Text = "Mese:"
        Me.lblMesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMesi.Visible = False
        '
        'btnConsuntivaTutto
        '
        Me.btnConsuntivaTutto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConsuntivaTutto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnConsuntivaTutto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsuntivaTutto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsuntivaTutto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnConsuntivaTutto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConsuntivaTutto.Location = New System.Drawing.Point(322, 488)
        Me.btnConsuntivaTutto.Name = "btnConsuntivaTutto"
        Me.btnConsuntivaTutto.Size = New System.Drawing.Size(147, 51)
        Me.btnConsuntivaTutto.TabIndex = 5
        Me.btnConsuntivaTutto.Text = "Consuntiva Tutto"
        Me.btnConsuntivaTutto.UseVisualStyleBackColor = False
        Me.btnConsuntivaTutto.Visible = False
        '
        'btnDividiXCliente
        '
        Me.btnDividiXCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDividiXCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDividiXCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDividiXCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDividiXCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnDividiXCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDividiXCliente.Location = New System.Drawing.Point(64, 488)
        Me.btnDividiXCliente.Name = "btnDividiXCliente"
        Me.btnDividiXCliente.Size = New System.Drawing.Size(153, 51)
        Me.btnDividiXCliente.TabIndex = 5
        Me.btnDividiXCliente.Text = "Dividi per Cliente"
        Me.btnDividiXCliente.UseVisualStyleBackColor = False
        Me.btnDividiXCliente.Visible = False
        '
        'lblSfondoColorato
        '
        Me.lblSfondoColorato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSfondoColorato.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblSfondoColorato.Location = New System.Drawing.Point(-1, -1)
        Me.lblSfondoColorato.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSfondoColorato.Name = "lblSfondoColorato"
        Me.lblSfondoColorato.Size = New System.Drawing.Size(320, 585)
        Me.lblSfondoColorato.TabIndex = 21
        '
        'pnlInserisci
        '
        Me.pnlInserisci.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlInserisci.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.pnlInserisci.Controls.Add(Me.GroupBox1)
        Me.pnlInserisci.Controls.Add(Me.lblGiorno)
        Me.pnlInserisci.Controls.Add(Me.txtTicket)
        Me.pnlInserisci.Controls.Add(Me.lblTicket)
        Me.pnlInserisci.Controls.Add(Me.dtpData)
        Me.pnlInserisci.Controls.Add(Me.lblAggiungiCliente)
        Me.pnlInserisci.Controls.Add(Me.lblCliente)
        Me.pnlInserisci.Controls.Add(Me.btnCarica)
        Me.pnlInserisci.Controls.Add(Me.cmbCliente)
        Me.pnlInserisci.Controls.Add(Me.cmbTempo)
        Me.pnlInserisci.Controls.Add(Me.lblTempo)
        Me.pnlInserisci.Location = New System.Drawing.Point(26, 55)
        Me.pnlInserisci.Name = "pnlInserisci"
        Me.pnlInserisci.Size = New System.Drawing.Size(265, 482)
        Me.pnlInserisci.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancellaFiltri)
        Me.GroupBox1.Controls.Add(Me.rdbFormazione)
        Me.GroupBox1.Controls.Add(Me.ckbAltro)
        Me.GroupBox1.Controls.Add(Me.ckbHome)
        Me.GroupBox1.Controls.Add(Me.rdbFixed)
        Me.GroupBox1.Controls.Add(Me.rdbCriticita)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 319)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 155)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btnCancellaFiltri
        '
        Me.btnCancellaFiltri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancellaFiltri.Location = New System.Drawing.Point(16, 120)
        Me.btnCancellaFiltri.Name = "btnCancellaFiltri"
        Me.btnCancellaFiltri.Size = New System.Drawing.Size(181, 25)
        Me.btnCancellaFiltri.TabIndex = 6
        Me.btnCancellaFiltri.Text = "Cancella Filtri"
        Me.btnCancellaFiltri.UseVisualStyleBackColor = True
        '
        'rdbFormazione
        '
        Me.rdbFormazione.AutoSize = True
        Me.rdbFormazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFormazione.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFormazione.ForeColor = System.Drawing.SystemColors.Control
        Me.rdbFormazione.Location = New System.Drawing.Point(16, 68)
        Me.rdbFormazione.Name = "rdbFormazione"
        Me.rdbFormazione.Size = New System.Drawing.Size(88, 20)
        Me.rdbFormazione.TabIndex = 14
        Me.rdbFormazione.TabStop = True
        Me.rdbFormazione.Text = "Formazione"
        Me.rdbFormazione.UseVisualStyleBackColor = True
        '
        'ckbAltro
        '
        Me.ckbAltro.AutoSize = True
        Me.ckbAltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbAltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbAltro.ForeColor = System.Drawing.SystemColors.Control
        Me.ckbAltro.Location = New System.Drawing.Point(16, 94)
        Me.ckbAltro.Name = "ckbAltro"
        Me.ckbAltro.Size = New System.Drawing.Size(54, 20)
        Me.ckbAltro.TabIndex = 14
        Me.ckbAltro.Text = "Altro"
        Me.ckbAltro.UseVisualStyleBackColor = True
        '
        'ckbHome
        '
        Me.ckbHome.AutoSize = True
        Me.ckbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbHome.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbHome.ForeColor = System.Drawing.SystemColors.Control
        Me.ckbHome.Location = New System.Drawing.Point(138, 58)
        Me.ckbHome.Name = "ckbHome"
        Me.ckbHome.Size = New System.Drawing.Size(59, 20)
        Me.ckbHome.TabIndex = 14
        Me.ckbHome.Text = "Home"
        Me.ckbHome.UseVisualStyleBackColor = True
        '
        'rdbFixed
        '
        Me.rdbFixed.AutoSize = True
        Me.rdbFixed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFixed.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFixed.ForeColor = System.Drawing.SystemColors.Control
        Me.rdbFixed.Location = New System.Drawing.Point(16, 42)
        Me.rdbFixed.Name = "rdbFixed"
        Me.rdbFixed.Size = New System.Drawing.Size(53, 20)
        Me.rdbFixed.TabIndex = 14
        Me.rdbFixed.TabStop = True
        Me.rdbFixed.Text = "Fixed"
        Me.rdbFixed.UseVisualStyleBackColor = True
        '
        'rdbCriticita
        '
        Me.rdbCriticita.AutoSize = True
        Me.rdbCriticita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCriticita.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbCriticita.ForeColor = System.Drawing.SystemColors.Control
        Me.rdbCriticita.Location = New System.Drawing.Point(16, 16)
        Me.rdbCriticita.Name = "rdbCriticita"
        Me.rdbCriticita.Size = New System.Drawing.Size(70, 20)
        Me.rdbCriticita.TabIndex = 14
        Me.rdbCriticita.TabStop = True
        Me.rdbCriticita.Text = "Criticità"
        Me.rdbCriticita.UseVisualStyleBackColor = True
        '
        'lblAggiungiCliente
        '
        Me.lblAggiungiCliente.AutoSize = True
        Me.lblAggiungiCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAggiungiCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAggiungiCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAggiungiCliente.Location = New System.Drawing.Point(225, 139)
        Me.lblAggiungiCliente.Name = "lblAggiungiCliente"
        Me.lblAggiungiCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAggiungiCliente.Size = New System.Drawing.Size(19, 20)
        Me.lblAggiungiCliente.TabIndex = 12
        Me.lblAggiungiCliente.Text = "+"
        '
        'TimerConsuntiva
        '
        Me.TimerConsuntiva.Interval = 1500
        '
        'ofdFile
        '
        Me.ofdFile.DefaultExt = "*.xlsx"
        Me.ofdFile.InitialDirectory = "Desktop"
        '
        'pnlMenu
        '
        Me.pnlMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.lblSeparatore)
        Me.pnlMenu.Controls.Add(Me.imgDocumentazione)
        Me.pnlMenu.Controls.Add(Me.lblDocumentazione)
        Me.pnlMenu.Controls.Add(Me.imgTema)
        Me.pnlMenu.Controls.Add(Me.lblTema)
        Me.pnlMenu.Controls.Add(Me.imgTicketMassivi)
        Me.pnlMenu.Controls.Add(Me.imgCommesseMassive)
        Me.pnlMenu.Controls.Add(Me.lblTicketMssivi)
        Me.pnlMenu.Controls.Add(Me.lblCommesseMassive)
        Me.pnlMenu.Location = New System.Drawing.Point(-1, -1)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(0, 585)
        Me.pnlMenu.TabIndex = 25
        '
        'lblSeparatore
        '
        Me.lblSeparatore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeparatore.AutoSize = True
        Me.lblSeparatore.ForeColor = System.Drawing.Color.White
        Me.lblSeparatore.Location = New System.Drawing.Point(18, 400)
        Me.lblSeparatore.Name = "lblSeparatore"
        Me.lblSeparatore.Size = New System.Drawing.Size(158, 17)
        Me.lblSeparatore.TabIndex = 4
        Me.lblSeparatore.Text = "______________________________"
        '
        'imgDocumentazione
        '
        Me.imgDocumentazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgDocumentazione.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgDocumentazione.ForeColor = System.Drawing.SystemColors.Control
        Me.imgDocumentazione.Image = Global.Consuntivazione.My.Resources.Resources.documentazione_32x32_bianco
        Me.imgDocumentazione.Location = New System.Drawing.Point(15, 511)
        Me.imgDocumentazione.Name = "imgDocumentazione"
        Me.imgDocumentazione.Size = New System.Drawing.Size(36, 36)
        Me.imgDocumentazione.TabIndex = 100
        Me.imgDocumentazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDocumentazione
        '
        Me.lblDocumentazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDocumentazione.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentazione.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDocumentazione.Location = New System.Drawing.Point(0, 500)
        Me.lblDocumentazione.Name = "lblDocumentazione"
        Me.lblDocumentazione.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.lblDocumentazione.Size = New System.Drawing.Size(199, 60)
        Me.lblDocumentazione.TabIndex = 100
        Me.lblDocumentazione.Text = "Documentazione"
        Me.lblDocumentazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgTema
        '
        Me.imgTema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgTema.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgTema.ForeColor = System.Drawing.SystemColors.Control
        Me.imgTema.Image = Global.Consuntivazione.My.Resources.Resources.pennello_32x32_bianco
        Me.imgTema.Location = New System.Drawing.Point(15, 441)
        Me.imgTema.Name = "imgTema"
        Me.imgTema.Size = New System.Drawing.Size(36, 36)
        Me.imgTema.TabIndex = 100
        Me.imgTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTema
        '
        Me.lblTema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTema.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTema.Location = New System.Drawing.Point(0, 430)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.lblTema.Size = New System.Drawing.Size(199, 60)
        Me.lblTema.TabIndex = 100
        Me.lblTema.Text = "Cambia Tema"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgTicketMassivi
        '
        Me.imgTicketMassivi.BackColor = System.Drawing.Color.Transparent
        Me.imgTicketMassivi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgTicketMassivi.ForeColor = System.Drawing.SystemColors.Control
        Me.imgTicketMassivi.Image = Global.Consuntivazione.My.Resources.Resources.ticket_32x32_bianco
        Me.imgTicketMassivi.Location = New System.Drawing.Point(15, 131)
        Me.imgTicketMassivi.Name = "imgTicketMassivi"
        Me.imgTicketMassivi.Size = New System.Drawing.Size(36, 36)
        Me.imgTicketMassivi.TabIndex = 100
        Me.imgTicketMassivi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgCommesseMassive
        '
        Me.imgCommesseMassive.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgCommesseMassive.ForeColor = System.Drawing.SystemColors.Control
        Me.imgCommesseMassive.Image = Global.Consuntivazione.My.Resources.Resources.commesse_32x32_bianco
        Me.imgCommesseMassive.Location = New System.Drawing.Point(18, 201)
        Me.imgCommesseMassive.Name = "imgCommesseMassive"
        Me.imgCommesseMassive.Size = New System.Drawing.Size(36, 36)
        Me.imgCommesseMassive.TabIndex = 100
        Me.imgCommesseMassive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTicketMssivi
        '
        Me.lblTicketMssivi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblTicketMssivi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketMssivi.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTicketMssivi.Location = New System.Drawing.Point(0, 120)
        Me.lblTicketMssivi.Name = "lblTicketMssivi"
        Me.lblTicketMssivi.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.lblTicketMssivi.Size = New System.Drawing.Size(199, 60)
        Me.lblTicketMssivi.TabIndex = 100
        Me.lblTicketMssivi.Text = "Inserisci Ticket" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Massivamente"
        Me.lblTicketMssivi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCommesseMassive
        '
        Me.lblCommesseMassive.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommesseMassive.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCommesseMassive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCommesseMassive.Location = New System.Drawing.Point(0, 190)
        Me.lblCommesseMassive.Name = "lblCommesseMassive"
        Me.lblCommesseMassive.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.lblCommesseMassive.Size = New System.Drawing.Size(199, 60)
        Me.lblCommesseMassive.TabIndex = 100
        Me.lblCommesseMassive.Text = "Inserisci Commesse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Massivamente"
        Me.lblCommesseMassive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerSlide
        '
        Me.TimerSlide.Interval = 1
        '
        'lblSlide
        '
        Me.lblSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSlide.ForeColor = System.Drawing.Color.White
        Me.lblSlide.Image = Global.Consuntivazione.My.Resources.Resources.menuChiuso_32x32_bianco
        Me.lblSlide.Location = New System.Drawing.Point(2, 2)
        Me.lblSlide.Name = "lblSlide"
        Me.lblSlide.Size = New System.Drawing.Size(32, 32)
        Me.lblSlide.TabIndex = 24
        Me.lblSlide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmConsuntivazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1104, 581)
        Me.Controls.Add(Me.lblSlide)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlInserisci)
        Me.Controls.Add(Me.pnlMensile)
        Me.Controls.Add(Me.lblSfondoColorato)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1120, 620)
        Me.Name = "frmConsuntivazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consuntivazione"
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMensile.ResumeLayout(False)
        Me.pnlMensile.PerformLayout()
        CType(Me.nudAnno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInserisci.ResumeLayout(False)
        Me.pnlInserisci.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCalendario As DataGridView
    Friend WithEvents btnCarica As Button
    Friend WithEvents cmbTempo As ComboBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblTempo As Label
    Friend WithEvents lblGiorno As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents lblTicket As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents TimerVisualizzazione As Timer
    Friend WithEvents lblTempoTot As Label
    Friend WithEvents lblGiorno_Mese As Label
    Friend WithEvents pnlMensile As Panel
    Friend WithEvents lblResoconto As Label
    Friend WithEvents lblMesi As Label
    Friend WithEvents lstMesi As ListBox
    Friend WithEvents btnConsuntivaTutto As Button
    Friend WithEvents btnDividiXCliente As Button
    Friend WithEvents lblSfondoColorato As Label
    Friend WithEvents pnlInserisci As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbFormazione As RadioButton
    Friend WithEvents rdbFixed As RadioButton
    Friend WithEvents rdbCriticita As RadioButton
    Friend WithEvents ckbHome As CheckBox
    Friend WithEvents btnCancellaFiltri As Button
    Friend WithEvents TimerConsuntiva As Timer
    Friend WithEvents lblAggiungiCliente As Label
    Friend WithEvents ckbAltro As CheckBox
    Friend WithEvents nudAnno As NumericUpDown
    Friend WithEvents lblAnno As Label
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents lblSlide As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents TimerSlide As Timer
    Friend WithEvents lblDocumentazione As Label
    Friend WithEvents lblTema As Label
    Friend WithEvents lblTicketMssivi As Label
    Friend WithEvents lblCommesseMassive As Label
    Friend WithEvents imgDocumentazione As Label
    Friend WithEvents imgTema As Label
    Friend WithEvents imgTicketMassivi As Label
    Friend WithEvents imgCommesseMassive As Label
    Friend WithEvents lblSeparatore As Label
End Class
