<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.dtpDataDa = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataA = New System.Windows.Forms.DateTimePicker()
        Me.lblGiorno = New System.Windows.Forms.Label()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.btnOggi = New System.Windows.Forms.Button()
        Me.btn7Giorni = New System.Windows.Forms.Button()
        Me.btnMeseCorrente = New System.Windows.Forms.Button()
        Me.pnlTicketFatti = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNumTicket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlOreLavorate = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblOreLavorate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlClientiSeguiti = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNumClienti = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chtTicketTotali = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTicketPerCliente = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlOreExtra = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblOreExtra = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlDGV = New System.Windows.Forms.Panel()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.lblDataDa = New System.Windows.Forms.Label()
        Me.lblDataA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlTicketFatti.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOreLavorate.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlClientiSeguiti.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTicketTotali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTicketPerCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOreExtra.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDGV.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDataDa
        '
        Me.dtpDataDa.CustomFormat = "dd MMM, yyyy"
        Me.dtpDataDa.Enabled = False
        Me.dtpDataDa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataDa.Location = New System.Drawing.Point(126, 15)
        Me.dtpDataDa.Name = "dtpDataDa"
        Me.dtpDataDa.Size = New System.Drawing.Size(110, 20)
        Me.dtpDataDa.TabIndex = 11
        '
        'dtpDataA
        '
        Me.dtpDataA.CustomFormat = "dd MMM, yyyy"
        Me.dtpDataA.Enabled = False
        Me.dtpDataA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataA.Location = New System.Drawing.Point(259, 16)
        Me.dtpDataA.Name = "dtpDataA"
        Me.dtpDataA.Size = New System.Drawing.Size(110, 20)
        Me.dtpDataA.TabIndex = 11
        '
        'lblGiorno
        '
        Me.lblGiorno.AutoSize = True
        Me.lblGiorno.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!)
        Me.lblGiorno.ForeColor = System.Drawing.Color.Black
        Me.lblGiorno.Location = New System.Drawing.Point(10, 8)
        Me.lblGiorno.Name = "lblGiorno"
        Me.lblGiorno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGiorno.Size = New System.Drawing.Size(108, 28)
        Me.lblGiorno.TabIndex = 12
        Me.lblGiorno.Text = "Dashboard"
        '
        'btnCustom
        '
        Me.btnCustom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCustom.BackColor = System.Drawing.SystemColors.Control
        Me.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustom.Font = New System.Drawing.Font("Segoe UI Symbol", 9.5!)
        Me.btnCustom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCustom.Location = New System.Drawing.Point(885, 12)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCustom.Size = New System.Drawing.Size(112, 29)
        Me.btnCustom.TabIndex = 13
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.UseVisualStyleBackColor = False
        '
        'btnOggi
        '
        Me.btnOggi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOggi.BackColor = System.Drawing.SystemColors.Control
        Me.btnOggi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOggi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnOggi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOggi.Font = New System.Drawing.Font("Segoe UI Symbol", 9.5!)
        Me.btnOggi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOggi.Location = New System.Drawing.Point(549, 12)
        Me.btnOggi.Name = "btnOggi"
        Me.btnOggi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOggi.Size = New System.Drawing.Size(112, 29)
        Me.btnOggi.TabIndex = 13
        Me.btnOggi.Text = "Oggi"
        Me.btnOggi.UseVisualStyleBackColor = False
        '
        'btn7Giorni
        '
        Me.btn7Giorni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn7Giorni.BackColor = System.Drawing.SystemColors.Control
        Me.btn7Giorni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn7Giorni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btn7Giorni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7Giorni.Font = New System.Drawing.Font("Segoe UI Symbol", 9.5!)
        Me.btn7Giorni.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn7Giorni.Location = New System.Drawing.Point(661, 12)
        Me.btn7Giorni.Name = "btn7Giorni"
        Me.btn7Giorni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn7Giorni.Size = New System.Drawing.Size(112, 29)
        Me.btn7Giorni.TabIndex = 13
        Me.btn7Giorni.Text = "Ultimi 7 Giorni"
        Me.btn7Giorni.UseVisualStyleBackColor = False
        '
        'btnMeseCorrente
        '
        Me.btnMeseCorrente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMeseCorrente.BackColor = System.Drawing.SystemColors.Control
        Me.btnMeseCorrente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMeseCorrente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnMeseCorrente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeseCorrente.Font = New System.Drawing.Font("Segoe UI Symbol", 9.5!)
        Me.btnMeseCorrente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMeseCorrente.Location = New System.Drawing.Point(773, 12)
        Me.btnMeseCorrente.Name = "btnMeseCorrente"
        Me.btnMeseCorrente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMeseCorrente.Size = New System.Drawing.Size(112, 29)
        Me.btnMeseCorrente.TabIndex = 13
        Me.btnMeseCorrente.Text = "Mese Corrente"
        Me.btnMeseCorrente.UseVisualStyleBackColor = False
        '
        'pnlTicketFatti
        '
        Me.pnlTicketFatti.BackColor = System.Drawing.SystemColors.Window
        Me.pnlTicketFatti.Controls.Add(Me.PictureBox2)
        Me.pnlTicketFatti.Controls.Add(Me.lblNumTicket)
        Me.pnlTicketFatti.Controls.Add(Me.Label1)
        Me.pnlTicketFatti.Location = New System.Drawing.Point(263, 52)
        Me.pnlTicketFatti.Name = "pnlTicketFatti"
        Me.pnlTicketFatti.Size = New System.Drawing.Size(241, 64)
        Me.pnlTicketFatti.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Consuntivazione.My.Resources.Resources.ticket
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'lblNumTicket
        '
        Me.lblNumTicket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumTicket.AutoSize = True
        Me.lblNumTicket.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTicket.ForeColor = System.Drawing.Color.Black
        Me.lblNumTicket.Location = New System.Drawing.Point(72, 33)
        Me.lblNumTicket.Name = "lblNumTicket"
        Me.lblNumTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumTicket.Size = New System.Drawing.Size(17, 20)
        Me.lblNumTicket.TabIndex = 12
        Me.lblNumTicket.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(72, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ticket Fatti"
        '
        'pnlOreLavorate
        '
        Me.pnlOreLavorate.BackColor = System.Drawing.SystemColors.Window
        Me.pnlOreLavorate.Controls.Add(Me.PictureBox4)
        Me.pnlOreLavorate.Controls.Add(Me.lblOreLavorate)
        Me.pnlOreLavorate.Controls.Add(Me.Label3)
        Me.pnlOreLavorate.Location = New System.Drawing.Point(510, 52)
        Me.pnlOreLavorate.Name = "pnlOreLavorate"
        Me.pnlOreLavorate.Size = New System.Drawing.Size(241, 64)
        Me.pnlOreLavorate.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Consuntivazione.My.Resources.Resources.OreLavorate
        Me.PictureBox4.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'lblOreLavorate
        '
        Me.lblOreLavorate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOreLavorate.AutoSize = True
        Me.lblOreLavorate.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOreLavorate.ForeColor = System.Drawing.Color.Black
        Me.lblOreLavorate.Location = New System.Drawing.Point(72, 33)
        Me.lblOreLavorate.Name = "lblOreLavorate"
        Me.lblOreLavorate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOreLavorate.Size = New System.Drawing.Size(17, 20)
        Me.lblOreLavorate.TabIndex = 12
        Me.lblOreLavorate.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(72, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ore Lavorate"
        '
        'pnlClientiSeguiti
        '
        Me.pnlClientiSeguiti.BackColor = System.Drawing.SystemColors.Window
        Me.pnlClientiSeguiti.Controls.Add(Me.PictureBox1)
        Me.pnlClientiSeguiti.Controls.Add(Me.lblNumClienti)
        Me.pnlClientiSeguiti.Controls.Add(Me.Label5)
        Me.pnlClientiSeguiti.Location = New System.Drawing.Point(16, 52)
        Me.pnlClientiSeguiti.Name = "pnlClientiSeguiti"
        Me.pnlClientiSeguiti.Size = New System.Drawing.Size(241, 64)
        Me.pnlClientiSeguiti.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Consuntivazione.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblNumClienti
        '
        Me.lblNumClienti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumClienti.AutoSize = True
        Me.lblNumClienti.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumClienti.ForeColor = System.Drawing.Color.Black
        Me.lblNumClienti.Location = New System.Drawing.Point(71, 33)
        Me.lblNumClienti.Name = "lblNumClienti"
        Me.lblNumClienti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumClienti.Size = New System.Drawing.Size(17, 20)
        Me.lblNumClienti.TabIndex = 12
        Me.lblNumClienti.Text = "0"
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
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Clienti Seguiti"
        '
        'chtTicketTotali
        '
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI Variable Small", 9.0!)
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.LabelStyle.Format = "dd MMM"
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.MajorTickMark.Size = 2.0!
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Segoe UI Variable Small", 11.0!)
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Variable Small", 9.0!)
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorTickMark.LineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.chtTicketTotali.ChartAreas.Add(ChartArea1)
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.MaximumAutoSize = 0!
        Legend1.Name = "Legend1"
        Me.chtTicketTotali.Legends.Add(Legend1)
        Me.chtTicketTotali.Location = New System.Drawing.Point(16, 122)
        Me.chtTicketTotali.Name = "chtTicketTotali"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtTicketTotali.Series.Add(Series1)
        Me.chtTicketTotali.Size = New System.Drawing.Size(601, 256)
        Me.chtTicketTotali.TabIndex = 14
        Me.chtTicketTotali.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title1.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Ticket Fatti"
        Title1.Text = "Ticket Fatti"
        Me.chtTicketTotali.Titles.Add(Title1)
        '
        'chtTicketPerCliente
        '
        Me.chtTicketPerCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.chtTicketPerCliente.ChartAreas.Add(ChartArea2)
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend2.Font = New System.Drawing.Font("Segoe UI Variable Small", 9.0!)
        Legend2.ForeColor = System.Drawing.Color.Gray
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.chtTicketPerCliente.Legends.Add(Legend2)
        Me.chtTicketPerCliente.Location = New System.Drawing.Point(623, 122)
        Me.chtTicketPerCliente.Name = "chtTicketPerCliente"
        Me.chtTicketPerCliente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chtTicketPerCliente.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.LightSeaGreen}
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Series2.BackSecondaryColor = System.Drawing.Color.LightPink
        Series2.BorderColor = System.Drawing.Color.White
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Color = System.Drawing.Color.MediumSlateBlue
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtTicketPerCliente.Series.Add(Series2)
        Me.chtTicketPerCliente.Size = New System.Drawing.Size(375, 418)
        Me.chtTicketPerCliente.TabIndex = 15
        Me.chtTicketPerCliente.Text = "Chart2"
        Title2.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title2.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!)
        Title2.Name = "Top 6 Clienti"
        Title2.Text = "Top 6 Clienti"
        Me.chtTicketPerCliente.Titles.Add(Title2)
        '
        'pnlOreExtra
        '
        Me.pnlOreExtra.BackColor = System.Drawing.SystemColors.Window
        Me.pnlOreExtra.Controls.Add(Me.PictureBox3)
        Me.pnlOreExtra.Controls.Add(Me.lblOreExtra)
        Me.pnlOreExtra.Controls.Add(Me.Label6)
        Me.pnlOreExtra.Location = New System.Drawing.Point(757, 52)
        Me.pnlOreExtra.Name = "pnlOreExtra"
        Me.pnlOreExtra.Size = New System.Drawing.Size(241, 64)
        Me.pnlOreExtra.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Consuntivazione.My.Resources.Resources.OreExtra
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'lblOreExtra
        '
        Me.lblOreExtra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOreExtra.AutoSize = True
        Me.lblOreExtra.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOreExtra.ForeColor = System.Drawing.Color.Black
        Me.lblOreExtra.Location = New System.Drawing.Point(72, 33)
        Me.lblOreExtra.Name = "lblOreExtra"
        Me.lblOreExtra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOreExtra.Size = New System.Drawing.Size(17, 20)
        Me.lblOreExtra.TabIndex = 12
        Me.lblOreExtra.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(72, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ore Extra"
        '
        'pnlDGV
        '
        Me.pnlDGV.BackColor = System.Drawing.SystemColors.Window
        Me.pnlDGV.Controls.Add(Me.dgvReport)
        Me.pnlDGV.Location = New System.Drawing.Point(16, 384)
        Me.pnlDGV.Name = "pnlDGV"
        Me.pnlDGV.Size = New System.Drawing.Size(601, 155)
        Me.pnlDGV.TabIndex = 0
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AllowUserToResizeRows = False
        Me.dgvReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReport.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReport.EnableHeadersVisualStyles = False
        Me.dgvReport.GridColor = System.Drawing.Color.Silver
        Me.dgvReport.Location = New System.Drawing.Point(9, 7)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.RowTemplate.Height = 27
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.Size = New System.Drawing.Size(583, 141)
        Me.dgvReport.TabIndex = 18
        '
        'lblDataDa
        '
        Me.lblDataDa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataDa.ForeColor = System.Drawing.Color.Gray
        Me.lblDataDa.Location = New System.Drawing.Point(126, 14)
        Me.lblDataDa.Name = "lblDataDa"
        Me.lblDataDa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDataDa.Size = New System.Drawing.Size(110, 20)
        Me.lblDataDa.TabIndex = 13
        Me.lblDataDa.Text = "17 Giu, 2023"
        Me.lblDataDa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataA
        '
        Me.lblDataA.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataA.ForeColor = System.Drawing.Color.Gray
        Me.lblDataA.Location = New System.Drawing.Point(259, 15)
        Me.lblDataA.Name = "lblDataA"
        Me.lblDataA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDataA.Size = New System.Drawing.Size(110, 20)
        Me.lblDataA.TabIndex = 16
        Me.lblDataA.Text = "17 Giu, 2023"
        Me.lblDataA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(236, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 557)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDataA)
        Me.Controls.Add(Me.lblDataDa)
        Me.Controls.Add(Me.chtTicketPerCliente)
        Me.Controls.Add(Me.chtTicketTotali)
        Me.Controls.Add(Me.pnlDGV)
        Me.Controls.Add(Me.pnlClientiSeguiti)
        Me.Controls.Add(Me.pnlTicketFatti)
        Me.Controls.Add(Me.pnlOreExtra)
        Me.Controls.Add(Me.pnlOreLavorate)
        Me.Controls.Add(Me.btnMeseCorrente)
        Me.Controls.Add(Me.btn7Giorni)
        Me.Controls.Add(Me.btnOggi)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.lblGiorno)
        Me.Controls.Add(Me.dtpDataA)
        Me.Controls.Add(Me.dtpDataDa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1030, 596)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report"
        Me.pnlTicketFatti.ResumeLayout(False)
        Me.pnlTicketFatti.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOreLavorate.ResumeLayout(False)
        Me.pnlOreLavorate.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlClientiSeguiti.ResumeLayout(False)
        Me.pnlClientiSeguiti.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTicketTotali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTicketPerCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOreExtra.ResumeLayout(False)
        Me.pnlOreExtra.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDGV.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDataDa As DateTimePicker
    Friend WithEvents dtpDataA As DateTimePicker
    Friend WithEvents lblGiorno As Label
    Friend WithEvents btnCustom As Button
    Friend WithEvents btnOggi As Button
    Friend WithEvents btn7Giorni As Button
    Friend WithEvents btnMeseCorrente As Button
    Friend WithEvents pnlTicketFatti As Panel
    Friend WithEvents lblNumTicket As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlOreLavorate As Panel
    Friend WithEvents lblOreLavorate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlClientiSeguiti As Panel
    Friend WithEvents lblNumClienti As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chtTicketTotali As DataVisualization.Charting.Chart
    Friend WithEvents chtTicketPerCliente As DataVisualization.Charting.Chart
    Friend WithEvents pnlOreExtra As Panel
    Friend WithEvents lblOreExtra As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlDGV As Panel
    Friend WithEvents lblDataDa As Label
    Friend WithEvents lblDataA As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgvReport As DataGridView
End Class
