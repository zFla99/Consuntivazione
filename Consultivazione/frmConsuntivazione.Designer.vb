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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.pnlFiltri = New System.Windows.Forms.Panel()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.ckbDataSelezionata = New System.Windows.Forms.CheckBox()
        Me.cmbNotaFiltro = New System.Windows.Forms.ComboBox()
        Me.cmbConsuntivazioneFiltro = New System.Windows.Forms.ComboBox()
        Me.cmbClienteFiltro = New System.Windows.Forms.ComboBox()
        Me.dtpDataAFiltro = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataDaFiltro = New System.Windows.Forms.DateTimePicker()
        Me.txtTicketFiltro = New System.Windows.Forms.TextBox()
        Me.nudAnno = New System.Windows.Forms.NumericUpDown()
        Me.lblMesi = New System.Windows.Forms.Label()
        Me.lstMesi = New System.Windows.Forms.ListBox()
        Me.lblConsuntivatoFiltro = New System.Windows.Forms.Label()
        Me.lblDataDaFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.lblDataAFiltro = New System.Windows.Forms.Label()
        Me.lblTicketFiltro = New System.Windows.Forms.Label()
        Me.lblAnno = New System.Windows.Forms.Label()
        Me.lblFiltri = New System.Windows.Forms.Label()
        Me.btnConsuntivaTutto = New System.Windows.Forms.Button()
        Me.btnDividiXCliente = New System.Windows.Forms.Button()
        Me.lblFiltriSelezionati = New System.Windows.Forms.Label()
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
        Me.imgImpostazioni = New System.Windows.Forms.Label()
        Me.lblSeparatore = New System.Windows.Forms.Label()
        Me.imgDocumentazione = New System.Windows.Forms.Label()
        Me.lblDocumentazione = New System.Windows.Forms.Label()
        Me.imgTema = New System.Windows.Forms.Label()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.imgTicketMassivi = New System.Windows.Forms.Label()
        Me.imgCommesseMassive = New System.Windows.Forms.Label()
        Me.lblTicketMssivi = New System.Windows.Forms.Label()
        Me.lblCommesseMassive = New System.Windows.Forms.Label()
        Me.lblImpostazioni = New System.Windows.Forms.Label()
        Me.TimerSlide = New System.Windows.Forms.Timer(Me.components)
        Me.lblSlide = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMensile.SuspendLayout()
        Me.pnlFiltri.SuspendLayout()
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
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.dgvCalendario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCalendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCalendario.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCalendario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCalendario.Location = New System.Drawing.Point(45, 55)
        Me.dgvCalendario.Name = "dgvCalendario"
        Me.dgvCalendario.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.dgvCalendario.RowsDefaultCellStyle = DataGridViewCellStyle3
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
        Me.lblTempoTot.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.lblTempoTot.Location = New System.Drawing.Point(686, 524)
        Me.lblTempoTot.Name = "lblTempoTot"
        Me.lblTempoTot.Size = New System.Drawing.Size(13, 15)
        Me.lblTempoTot.TabIndex = 18
        Me.lblTempoTot.Text = "0"
        '
        'lblGiorno_Mese
        '
        Me.lblGiorno_Mese.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGiorno_Mese.AutoSize = True
        Me.lblGiorno_Mese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGiorno_Mese.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.lblGiorno_Mese.Location = New System.Drawing.Point(604, 507)
        Me.lblGiorno_Mese.Name = "lblGiorno_Mese"
        Me.lblGiorno_Mese.Size = New System.Drawing.Size(73, 45)
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
        Me.pnlMensile.Controls.Add(Me.pnlFiltri)
        Me.pnlMensile.Controls.Add(Me.lblGiorno_Mese)
        Me.pnlMensile.Controls.Add(Me.lblTempoTot)
        Me.pnlMensile.Controls.Add(Me.dgvCalendario)
        Me.pnlMensile.Controls.Add(Me.lblFiltri)
        Me.pnlMensile.Controls.Add(Me.btnConsuntivaTutto)
        Me.pnlMensile.Controls.Add(Me.btnDividiXCliente)
        Me.pnlMensile.Controls.Add(Me.lblFiltriSelezionati)
        Me.pnlMensile.Location = New System.Drawing.Point(327, 0)
        Me.pnlMensile.Name = "pnlMensile"
        Me.pnlMensile.Size = New System.Drawing.Size(770, 566)
        Me.pnlMensile.TabIndex = 19
        '
        'pnlFiltri
        '
        Me.pnlFiltri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFiltri.Controls.Add(Me.btnCerca)
        Me.pnlFiltri.Controls.Add(Me.ckbDataSelezionata)
        Me.pnlFiltri.Controls.Add(Me.cmbNotaFiltro)
        Me.pnlFiltri.Controls.Add(Me.cmbConsuntivazioneFiltro)
        Me.pnlFiltri.Controls.Add(Me.cmbClienteFiltro)
        Me.pnlFiltri.Controls.Add(Me.dtpDataAFiltro)
        Me.pnlFiltri.Controls.Add(Me.dtpDataDaFiltro)
        Me.pnlFiltri.Controls.Add(Me.txtTicketFiltro)
        Me.pnlFiltri.Controls.Add(Me.nudAnno)
        Me.pnlFiltri.Controls.Add(Me.lblMesi)
        Me.pnlFiltri.Controls.Add(Me.lstMesi)
        Me.pnlFiltri.Controls.Add(Me.lblConsuntivatoFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblDataDaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblNotaFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblClienteFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblDataAFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblTicketFiltro)
        Me.pnlFiltri.Controls.Add(Me.lblAnno)
        Me.pnlFiltri.Location = New System.Drawing.Point(45, 1)
        Me.pnlFiltri.Name = "pnlFiltri"
        Me.pnlFiltri.Size = New System.Drawing.Size(680, 0)
        Me.pnlFiltri.TabIndex = 27
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCerca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCerca.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnCerca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerca.Location = New System.Drawing.Point(55, -40)
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
        Me.ckbDataSelezionata.Location = New System.Drawing.Point(533, -36)
        Me.ckbDataSelezionata.Name = "ckbDataSelezionata"
        Me.ckbDataSelezionata.Size = New System.Drawing.Size(104, 20)
        Me.ckbDataSelezionata.TabIndex = 28
        Me.ckbDataSelezionata.Text = "Seleziona Data"
        Me.ckbDataSelezionata.UseVisualStyleBackColor = True
        '
        'cmbNotaFiltro
        '
        Me.cmbNotaFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmbNotaFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNotaFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNotaFiltro.Items.AddRange(New Object() {"Criticità", "Fixed", "Formazione", "Home"})
        Me.cmbNotaFiltro.Location = New System.Drawing.Point(341, -79)
        Me.cmbNotaFiltro.MaxLength = 20
        Me.cmbNotaFiltro.Name = "cmbNotaFiltro"
        Me.cmbNotaFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNotaFiltro.Size = New System.Drawing.Size(91, 25)
        Me.cmbNotaFiltro.Sorted = True
        Me.cmbNotaFiltro.TabIndex = 27
        '
        'cmbConsuntivazioneFiltro
        '
        Me.cmbConsuntivazioneFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmbConsuntivazioneFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbConsuntivazioneFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConsuntivazioneFiltro.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmbConsuntivazioneFiltro.Location = New System.Drawing.Point(341, -110)
        Me.cmbConsuntivazioneFiltro.MaxLength = 2
        Me.cmbConsuntivazioneFiltro.Name = "cmbConsuntivazioneFiltro"
        Me.cmbConsuntivazioneFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConsuntivazioneFiltro.Size = New System.Drawing.Size(57, 25)
        Me.cmbConsuntivazioneFiltro.Sorted = True
        Me.cmbConsuntivazioneFiltro.TabIndex = 27
        '
        'cmbClienteFiltro
        '
        Me.cmbClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbClienteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClienteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClienteFiltro.Location = New System.Drawing.Point(118, -81)
        Me.cmbClienteFiltro.MaxLength = 30
        Me.cmbClienteFiltro.Name = "cmbClienteFiltro"
        Me.cmbClienteFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbClienteFiltro.Size = New System.Drawing.Size(110, 25)
        Me.cmbClienteFiltro.TabIndex = 27
        '
        'dtpDataAFiltro
        '
        Me.dtpDataAFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataAFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataAFiltro.Enabled = False
        Me.dtpDataAFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataAFiltro.Location = New System.Drawing.Point(533, -79)
        Me.dtpDataAFiltro.Name = "dtpDataAFiltro"
        Me.dtpDataAFiltro.Size = New System.Drawing.Size(102, 23)
        Me.dtpDataAFiltro.TabIndex = 10
        '
        'dtpDataDaFiltro
        '
        Me.dtpDataDaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataDaFiltro.Checked = False
        Me.dtpDataDaFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataDaFiltro.Enabled = False
        Me.dtpDataDaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataDaFiltro.Location = New System.Drawing.Point(533, -110)
        Me.dtpDataDaFiltro.Name = "dtpDataDaFiltro"
        Me.dtpDataDaFiltro.Size = New System.Drawing.Size(102, 23)
        Me.dtpDataDaFiltro.TabIndex = 10
        '
        'txtTicketFiltro
        '
        Me.txtTicketFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTicketFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicketFiltro.Location = New System.Drawing.Point(118, -110)
        Me.txtTicketFiltro.MaxLength = 10
        Me.txtTicketFiltro.Name = "txtTicketFiltro"
        Me.txtTicketFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTicketFiltro.Size = New System.Drawing.Size(110, 23)
        Me.txtTicketFiltro.TabIndex = 1
        '
        'nudAnno
        '
        Me.nudAnno.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.nudAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAnno.Enabled = False
        Me.nudAnno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nudAnno.Location = New System.Drawing.Point(131, -38)
        Me.nudAnno.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.nudAnno.Minimum = New Decimal(New Integer() {2022, 0, 0, 0})
        Me.nudAnno.Name = "nudAnno"
        Me.nudAnno.Size = New System.Drawing.Size(55, 23)
        Me.nudAnno.TabIndex = 23
        Me.nudAnno.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'lblMesi
        '
        Me.lblMesi.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMesi.AutoSize = True
        Me.lblMesi.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblMesi.Location = New System.Drawing.Point(197, -38)
        Me.lblMesi.Name = "lblMesi"
        Me.lblMesi.Size = New System.Drawing.Size(49, 20)
        Me.lblMesi.TabIndex = 22
        Me.lblMesi.Text = "Mese:"
        Me.lblMesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMesi
        '
        Me.lstMesi.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lstMesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMesi.ColumnWidth = 30
        Me.lstMesi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstMesi.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMesi.ItemHeight = 17
        Me.lstMesi.Items.AddRange(New Object() {"   1", "   2", "   3", "   4", "   5", "   6", "   7", "   8", "   9", "  10", "  11", "  12"})
        Me.lstMesi.Location = New System.Drawing.Point(252, -36)
        Me.lstMesi.MultiColumn = True
        Me.lstMesi.Name = "lstMesi"
        Me.lstMesi.Size = New System.Drawing.Size(365, 19)
        Me.lstMesi.TabIndex = 20
        '
        'lblConsuntivatoFiltro
        '
        Me.lblConsuntivatoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblConsuntivatoFiltro.AutoSize = True
        Me.lblConsuntivatoFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblConsuntivatoFiltro.Location = New System.Drawing.Point(228, -109)
        Me.lblConsuntivatoFiltro.Name = "lblConsuntivatoFiltro"
        Me.lblConsuntivatoFiltro.Size = New System.Drawing.Size(107, 20)
        Me.lblConsuntivatoFiltro.TabIndex = 22
        Me.lblConsuntivatoFiltro.Text = "Consuntivato:"
        Me.lblConsuntivatoFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataDaFiltro
        '
        Me.lblDataDaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataDaFiltro.AutoSize = True
        Me.lblDataDaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblDataDaFiltro.Location = New System.Drawing.Point(459, -109)
        Me.lblDataDaFiltro.Name = "lblDataDaFiltro"
        Me.lblDataDaFiltro.Size = New System.Drawing.Size(68, 20)
        Me.lblDataDaFiltro.TabIndex = 22
        Me.lblDataDaFiltro.Text = "Data Da:"
        Me.lblDataDaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotaFiltro
        '
        Me.lblNotaFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNotaFiltro.AutoSize = True
        Me.lblNotaFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblNotaFiltro.Location = New System.Drawing.Point(228, -79)
        Me.lblNotaFiltro.Name = "lblNotaFiltro"
        Me.lblNotaFiltro.Size = New System.Drawing.Size(46, 20)
        Me.lblNotaFiltro.TabIndex = 22
        Me.lblNotaFiltro.Text = "Nota:"
        Me.lblNotaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblClienteFiltro.Location = New System.Drawing.Point(51, -79)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(62, 20)
        Me.lblClienteFiltro.TabIndex = 22
        Me.lblClienteFiltro.Text = "Cliente:"
        Me.lblClienteFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataAFiltro
        '
        Me.lblDataAFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataAFiltro.AutoSize = True
        Me.lblDataAFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblDataAFiltro.Location = New System.Drawing.Point(459, -79)
        Me.lblDataAFiltro.Name = "lblDataAFiltro"
        Me.lblDataAFiltro.Size = New System.Drawing.Size(59, 20)
        Me.lblDataAFiltro.TabIndex = 22
        Me.lblDataAFiltro.Text = "Data A:"
        Me.lblDataAFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTicketFiltro
        '
        Me.lblTicketFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTicketFiltro.AutoSize = True
        Me.lblTicketFiltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblTicketFiltro.Location = New System.Drawing.Point(51, -109)
        Me.lblTicketFiltro.Name = "lblTicketFiltro"
        Me.lblTicketFiltro.Size = New System.Drawing.Size(54, 20)
        Me.lblTicketFiltro.TabIndex = 22
        Me.lblTicketFiltro.Text = "Ticket:"
        Me.lblTicketFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnno
        '
        Me.lblAnno.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAnno.AutoSize = True
        Me.lblAnno.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblAnno.Location = New System.Drawing.Point(76, -38)
        Me.lblAnno.Name = "lblAnno"
        Me.lblAnno.Size = New System.Drawing.Size(49, 20)
        Me.lblAnno.TabIndex = 22
        Me.lblAnno.Text = "Anno:"
        Me.lblAnno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFiltri
        '
        Me.lblFiltri.BackColor = System.Drawing.Color.Transparent
        Me.lblFiltri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFiltri.ForeColor = System.Drawing.Color.White
        Me.lblFiltri.Image = CType(resources.GetObject("lblFiltri.Image"), System.Drawing.Image)
        Me.lblFiltri.Location = New System.Drawing.Point(42, 30)
        Me.lblFiltri.Name = "lblFiltri"
        Me.lblFiltri.Size = New System.Drawing.Size(16, 16)
        Me.lblFiltri.TabIndex = 26
        Me.lblFiltri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFiltri.Visible = False
        '
        'btnConsuntivaTutto
        '
        Me.btnConsuntivaTutto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConsuntivaTutto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnConsuntivaTutto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsuntivaTutto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsuntivaTutto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnConsuntivaTutto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConsuntivaTutto.Location = New System.Drawing.Point(322, 504)
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
        Me.btnDividiXCliente.Location = New System.Drawing.Point(64, 504)
        Me.btnDividiXCliente.Name = "btnDividiXCliente"
        Me.btnDividiXCliente.Size = New System.Drawing.Size(153, 51)
        Me.btnDividiXCliente.TabIndex = 5
        Me.btnDividiXCliente.Text = "Dividi per Cliente"
        Me.btnDividiXCliente.UseVisualStyleBackColor = False
        Me.btnDividiXCliente.Visible = False
        '
        'lblFiltriSelezionati
        '
        Me.lblFiltriSelezionati.AutoSize = True
        Me.lblFiltriSelezionati.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiltriSelezionati.Location = New System.Drawing.Point(63, 28)
        Me.lblFiltriSelezionati.Name = "lblFiltriSelezionati"
        Me.lblFiltriSelezionati.Size = New System.Drawing.Size(0, 19)
        Me.lblFiltriSelezionati.TabIndex = 21
        Me.lblFiltriSelezionati.Visible = False
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
        Me.btnCancellaFiltri.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancellaFiltri.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
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
        Me.pnlMenu.Controls.Add(Me.imgImpostazioni)
        Me.pnlMenu.Controls.Add(Me.lblSeparatore)
        Me.pnlMenu.Controls.Add(Me.imgDocumentazione)
        Me.pnlMenu.Controls.Add(Me.lblDocumentazione)
        Me.pnlMenu.Controls.Add(Me.imgTema)
        Me.pnlMenu.Controls.Add(Me.lblTema)
        Me.pnlMenu.Controls.Add(Me.imgTicketMassivi)
        Me.pnlMenu.Controls.Add(Me.imgCommesseMassive)
        Me.pnlMenu.Controls.Add(Me.lblTicketMssivi)
        Me.pnlMenu.Controls.Add(Me.lblCommesseMassive)
        Me.pnlMenu.Controls.Add(Me.lblImpostazioni)
        Me.pnlMenu.Location = New System.Drawing.Point(-1, -1)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(0, 585)
        Me.pnlMenu.TabIndex = 25
        '
        'imgImpostazioni
        '
        Me.imgImpostazioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgImpostazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgImpostazioni.ForeColor = System.Drawing.SystemColors.Control
        Me.imgImpostazioni.Image = CType(resources.GetObject("imgImpostazioni.Image"), System.Drawing.Image)
        Me.imgImpostazioni.Location = New System.Drawing.Point(15, 512)
        Me.imgImpostazioni.Name = "imgImpostazioni"
        Me.imgImpostazioni.Size = New System.Drawing.Size(36, 36)
        Me.imgImpostazioni.TabIndex = 102
        Me.imgImpostazioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSeparatore
        '
        Me.lblSeparatore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeparatore.AutoSize = True
        Me.lblSeparatore.ForeColor = System.Drawing.Color.White
        Me.lblSeparatore.Location = New System.Drawing.Point(18, 335)
        Me.lblSeparatore.Name = "lblSeparatore"
        Me.lblSeparatore.Size = New System.Drawing.Size(158, 17)
        Me.lblSeparatore.TabIndex = 4
        Me.lblSeparatore.Text = "______________________________"
        '
        'imgDocumentazione
        '
        Me.imgDocumentazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgDocumentazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgDocumentazione.ForeColor = System.Drawing.SystemColors.Control
        Me.imgDocumentazione.Image = CType(resources.GetObject("imgDocumentazione.Image"), System.Drawing.Image)
        Me.imgDocumentazione.Location = New System.Drawing.Point(15, 372)
        Me.imgDocumentazione.Name = "imgDocumentazione"
        Me.imgDocumentazione.Size = New System.Drawing.Size(36, 36)
        Me.imgDocumentazione.TabIndex = 100
        Me.imgDocumentazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDocumentazione
        '
        Me.lblDocumentazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDocumentazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentazione.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDocumentazione.Location = New System.Drawing.Point(0, 360)
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
        Me.imgTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgTema.ForeColor = System.Drawing.SystemColors.Control
        Me.imgTema.Image = CType(resources.GetObject("imgTema.Image"), System.Drawing.Image)
        Me.imgTema.Location = New System.Drawing.Point(15, 442)
        Me.imgTema.Name = "imgTema"
        Me.imgTema.Size = New System.Drawing.Size(36, 36)
        Me.imgTema.TabIndex = 100
        Me.imgTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTema
        '
        Me.lblTema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.imgTicketMassivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgTicketMassivi.ForeColor = System.Drawing.SystemColors.Control
        Me.imgTicketMassivi.Image = CType(resources.GetObject("imgTicketMassivi.Image"), System.Drawing.Image)
        Me.imgTicketMassivi.Location = New System.Drawing.Point(15, 132)
        Me.imgTicketMassivi.Name = "imgTicketMassivi"
        Me.imgTicketMassivi.Size = New System.Drawing.Size(36, 36)
        Me.imgTicketMassivi.TabIndex = 100
        Me.imgTicketMassivi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgCommesseMassive
        '
        Me.imgCommesseMassive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgCommesseMassive.ForeColor = System.Drawing.SystemColors.Control
        Me.imgCommesseMassive.Image = CType(resources.GetObject("imgCommesseMassive.Image"), System.Drawing.Image)
        Me.imgCommesseMassive.Location = New System.Drawing.Point(18, 202)
        Me.imgCommesseMassive.Name = "imgCommesseMassive"
        Me.imgCommesseMassive.Size = New System.Drawing.Size(36, 36)
        Me.imgCommesseMassive.TabIndex = 100
        Me.imgCommesseMassive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTicketMssivi
        '
        Me.lblTicketMssivi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblTicketMssivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblCommesseMassive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'lblImpostazioni
        '
        Me.lblImpostazioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImpostazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpostazioni.ForeColor = System.Drawing.SystemColors.Control
        Me.lblImpostazioni.Location = New System.Drawing.Point(0, 500)
        Me.lblImpostazioni.Name = "lblImpostazioni"
        Me.lblImpostazioni.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.lblImpostazioni.Size = New System.Drawing.Size(199, 60)
        Me.lblImpostazioni.TabIndex = 101
        Me.lblImpostazioni.Text = "Impostazioni"
        Me.lblImpostazioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerSlide
        '
        Me.TimerSlide.Interval = 10
        '
        'lblSlide
        '
        Me.lblSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSlide.ForeColor = System.Drawing.Color.White
        Me.lblSlide.Image = CType(resources.GetObject("lblSlide.Image"), System.Drawing.Image)
        Me.lblSlide.Location = New System.Drawing.Point(2, 2)
        Me.lblSlide.Name = "lblSlide"
        Me.lblSlide.Size = New System.Drawing.Size(32, 32)
        Me.lblSlide.TabIndex = 24
        Me.lblSlide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
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
        Me.pnlFiltri.ResumeLayout(False)
        Me.pnlFiltri.PerformLayout()
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
    Friend WithEvents lblFiltriSelezionati As Label
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
    Friend WithEvents lblFiltri As Label
    Friend WithEvents pnlFiltri As Panel
    Friend WithEvents cmbConsuntivazioneFiltro As ComboBox
    Friend WithEvents cmbClienteFiltro As ComboBox
    Friend WithEvents txtTicketFiltro As TextBox
    Friend WithEvents lblConsuntivatoFiltro As Label
    Friend WithEvents lblDataDaFiltro As Label
    Friend WithEvents lblNotaFiltro As Label
    Friend WithEvents lblClienteFiltro As Label
    Friend WithEvents lblDataAFiltro As Label
    Friend WithEvents lblTicketFiltro As Label
    Friend WithEvents cmbNotaFiltro As ComboBox
    Friend WithEvents dtpDataAFiltro As DateTimePicker
    Friend WithEvents dtpDataDaFiltro As DateTimePicker
    Friend WithEvents ckbDataSelezionata As CheckBox
    Friend WithEvents btnCerca As Button
    Friend WithEvents imgImpostazioni As Label
    Friend WithEvents lblImpostazioni As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
