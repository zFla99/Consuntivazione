<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifica))
        Me.ckbHome = New System.Windows.Forms.CheckBox()
        Me.lblInsConsuntivatoSI = New System.Windows.Forms.Label()
        Me.lblInsCliente = New System.Windows.Forms.Label()
        Me.lblInsTicket = New System.Windows.Forms.Label()
        Me.lblBordoConsuntivato = New System.Windows.Forms.Label()
        Me.lblBordoCliente = New System.Windows.Forms.Label()
        Me.lblBordoTicket = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.lblConsuntivato = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblBordoData = New System.Windows.Forms.Label()
        Me.lblInsData = New System.Windows.Forms.Label()
        Me.lblInsNota = New System.Windows.Forms.Label()
        Me.lblBordoNota = New System.Windows.Forms.Label()
        Me.cmbNota = New System.Windows.Forms.ComboBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblInsTempo = New System.Windows.Forms.Label()
        Me.lblBordoTempo = New System.Windows.Forms.Label()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.lblInsExtra = New System.Windows.Forms.Label()
        Me.lblBordoExtra = New System.Windows.Forms.Label()
        Me.lblExtra = New System.Windows.Forms.Label()
        Me.lblInsConsuntivatoNO = New System.Windows.Forms.Label()
        Me.txtExtra = New System.Windows.Forms.MaskedTextBox()
        Me.btnModifica = New System.Windows.Forms.Label()
        Me.lblBordoModifica = New System.Windows.Forms.Label()
        Me.lblBordoAnnulla = New System.Windows.Forms.Label()
        Me.btnAnnulla = New System.Windows.Forms.Label()
        Me.lblBordoElimina = New System.Windows.Forms.Label()
        Me.btnElimina = New System.Windows.Forms.Label()
        Me.txtTempo = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'ckbHome
        '
        Me.ckbHome.AutoSize = True
        Me.ckbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbHome.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ckbHome.Location = New System.Drawing.Point(502, 144)
        Me.ckbHome.Name = "ckbHome"
        Me.ckbHome.Size = New System.Drawing.Size(59, 20)
        Me.ckbHome.TabIndex = 13
        Me.ckbHome.Text = "Home"
        Me.ckbHome.UseVisualStyleBackColor = True
        '
        'lblInsConsuntivatoSI
        '
        Me.lblInsConsuntivatoSI.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsConsuntivatoSI.ForeColor = System.Drawing.Color.Black
        Me.lblInsConsuntivatoSI.Location = New System.Drawing.Point(503, 49)
        Me.lblInsConsuntivatoSI.Name = "lblInsConsuntivatoSI"
        Me.lblInsConsuntivatoSI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsConsuntivatoSI.Size = New System.Drawing.Size(56, 25)
        Me.lblInsConsuntivatoSI.TabIndex = 78
        Me.lblInsConsuntivatoSI.Text = "SI"
        Me.lblInsConsuntivatoSI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsCliente
        '
        Me.lblInsCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCliente.ForeColor = System.Drawing.Color.Black
        Me.lblInsCliente.Location = New System.Drawing.Point(63, 114)
        Me.lblInsCliente.Name = "lblInsCliente"
        Me.lblInsCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCliente.TabIndex = 76
        Me.lblInsCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsTicket
        '
        Me.lblInsTicket.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsTicket.ForeColor = System.Drawing.Color.Black
        Me.lblInsTicket.Location = New System.Drawing.Point(63, 46)
        Me.lblInsTicket.Name = "lblInsTicket"
        Me.lblInsTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsTicket.Size = New System.Drawing.Size(113, 25)
        Me.lblInsTicket.TabIndex = 67
        Me.lblInsTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoConsuntivato
        '
        Me.lblBordoConsuntivato.BackColor = System.Drawing.Color.Silver
        Me.lblBordoConsuntivato.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoConsuntivato.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoConsuntivato.Location = New System.Drawing.Point(502, 48)
        Me.lblBordoConsuntivato.Name = "lblBordoConsuntivato"
        Me.lblBordoConsuntivato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoConsuntivato.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoConsuntivato.TabIndex = 72
        Me.lblBordoConsuntivato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCliente
        '
        Me.lblBordoCliente.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCliente.Location = New System.Drawing.Point(62, 113)
        Me.lblBordoCliente.Name = "lblBordoCliente"
        Me.lblBordoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCliente.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCliente.TabIndex = 69
        Me.lblBordoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoTicket
        '
        Me.lblBordoTicket.BackColor = System.Drawing.Color.Silver
        Me.lblBordoTicket.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoTicket.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoTicket.Location = New System.Drawing.Point(62, 45)
        Me.lblBordoTicket.Name = "lblBordoTicket"
        Me.lblBordoTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoTicket.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoTicket.TabIndex = 68
        Me.lblBordoTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCliente.Location = New System.Drawing.Point(69, 115)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(99, 21)
        Me.cmbCliente.TabIndex = 2
        '
        'txtTicket
        '
        Me.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicket.Location = New System.Drawing.Point(73, 48)
        Me.txtTicket.MaxLength = 10
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTicket.Size = New System.Drawing.Size(93, 20)
        Me.txtTicket.TabIndex = 1
        '
        'lblConsuntivato
        '
        Me.lblConsuntivato.AutoSize = True
        Me.lblConsuntivato.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblConsuntivato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConsuntivato.Location = New System.Drawing.Point(498, 23)
        Me.lblConsuntivato.Name = "lblConsuntivato"
        Me.lblConsuntivato.Size = New System.Drawing.Size(104, 20)
        Me.lblConsuntivato.TabIndex = 64
        Me.lblConsuntivato.Text = "Consuntivato"
        Me.lblConsuntivato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(58, 91)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 61
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTicket.Location = New System.Drawing.Point(58, 23)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(51, 20)
        Me.lblTicket.TabIndex = 0
        Me.lblTicket.Text = "Ticket"
        Me.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblData.Location = New System.Drawing.Point(281, 23)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(42, 20)
        Me.lblData.TabIndex = 63
        Me.lblData.Text = "Data"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpData
        '
        Me.dtpData.Checked = False
        Me.dtpData.CustomFormat = "dd/MM/yyyy"
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpData.Location = New System.Drawing.Point(295, 49)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(97, 20)
        Me.dtpData.TabIndex = 56
        '
        'lblBordoData
        '
        Me.lblBordoData.BackColor = System.Drawing.Color.Silver
        Me.lblBordoData.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoData.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoData.Location = New System.Drawing.Point(286, 45)
        Me.lblBordoData.Name = "lblBordoData"
        Me.lblBordoData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoData.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoData.TabIndex = 74
        Me.lblBordoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsData
        '
        Me.lblInsData.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsData.ForeColor = System.Drawing.Color.Black
        Me.lblInsData.Location = New System.Drawing.Point(287, 46)
        Me.lblInsData.Name = "lblInsData"
        Me.lblInsData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsData.Size = New System.Drawing.Size(113, 25)
        Me.lblInsData.TabIndex = 81
        Me.lblInsData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsNota
        '
        Me.lblInsNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsNota.ForeColor = System.Drawing.Color.Black
        Me.lblInsNota.Location = New System.Drawing.Point(503, 115)
        Me.lblInsNota.Name = "lblInsNota"
        Me.lblInsNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsNota.Size = New System.Drawing.Size(113, 25)
        Me.lblInsNota.TabIndex = 89
        Me.lblInsNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoNota
        '
        Me.lblBordoNota.BackColor = System.Drawing.Color.Silver
        Me.lblBordoNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoNota.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoNota.Location = New System.Drawing.Point(502, 114)
        Me.lblBordoNota.Name = "lblBordoNota"
        Me.lblBordoNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoNota.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoNota.TabIndex = 88
        Me.lblBordoNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbNota
        '
        Me.cmbNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNota.Items.AddRange(New Object() {"Criticità", "Fixed", "Formazione"})
        Me.cmbNota.Location = New System.Drawing.Point(517, 117)
        Me.cmbNota.MaxLength = 20
        Me.cmbNota.Name = "cmbNota"
        Me.cmbNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNota.Size = New System.Drawing.Size(83, 21)
        Me.cmbNota.Sorted = True
        Me.cmbNota.TabIndex = 5
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNota.Location = New System.Drawing.Point(498, 91)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(43, 20)
        Me.lblNota.TabIndex = 87
        Me.lblNota.Text = "Nota"
        Me.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsTempo
        '
        Me.lblInsTempo.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsTempo.ForeColor = System.Drawing.Color.Black
        Me.lblInsTempo.Location = New System.Drawing.Point(287, 114)
        Me.lblInsTempo.Name = "lblInsTempo"
        Me.lblInsTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsTempo.Size = New System.Drawing.Size(53, 25)
        Me.lblInsTempo.TabIndex = 93
        Me.lblInsTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoTempo
        '
        Me.lblBordoTempo.BackColor = System.Drawing.Color.Silver
        Me.lblBordoTempo.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoTempo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoTempo.Location = New System.Drawing.Point(286, 113)
        Me.lblBordoTempo.Name = "lblBordoTempo"
        Me.lblBordoTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoTempo.Size = New System.Drawing.Size(55, 27)
        Me.lblBordoTempo.TabIndex = 92
        Me.lblBordoTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblTempo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTempo.Location = New System.Drawing.Point(281, 91)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(55, 20)
        Me.lblTempo.TabIndex = 91
        Me.lblTempo.Text = "Tempo"
        Me.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsExtra
        '
        Me.lblInsExtra.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsExtra.ForeColor = System.Drawing.Color.Black
        Me.lblInsExtra.Location = New System.Drawing.Point(348, 114)
        Me.lblInsExtra.Name = "lblInsExtra"
        Me.lblInsExtra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsExtra.Size = New System.Drawing.Size(53, 25)
        Me.lblInsExtra.TabIndex = 96
        Me.lblInsExtra.Text = "0"
        Me.lblInsExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoExtra
        '
        Me.lblBordoExtra.BackColor = System.Drawing.Color.Silver
        Me.lblBordoExtra.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoExtra.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoExtra.Location = New System.Drawing.Point(347, 113)
        Me.lblBordoExtra.Name = "lblBordoExtra"
        Me.lblBordoExtra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoExtra.Size = New System.Drawing.Size(55, 27)
        Me.lblBordoExtra.TabIndex = 95
        Me.lblBordoExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExtra
        '
        Me.lblExtra.AutoSize = True
        Me.lblExtra.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblExtra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblExtra.Location = New System.Drawing.Point(344, 91)
        Me.lblExtra.Name = "lblExtra"
        Me.lblExtra.Size = New System.Drawing.Size(44, 20)
        Me.lblExtra.TabIndex = 97
        Me.lblExtra.Text = "Extra"
        Me.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsConsuntivatoNO
        '
        Me.lblInsConsuntivatoNO.BackColor = System.Drawing.Color.Silver
        Me.lblInsConsuntivatoNO.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsConsuntivatoNO.ForeColor = System.Drawing.Color.Black
        Me.lblInsConsuntivatoNO.Location = New System.Drawing.Point(560, 49)
        Me.lblInsConsuntivatoNO.Name = "lblInsConsuntivatoNO"
        Me.lblInsConsuntivatoNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsConsuntivatoNO.Size = New System.Drawing.Size(56, 25)
        Me.lblInsConsuntivatoNO.TabIndex = 98
        Me.lblInsConsuntivatoNO.Text = "NO"
        Me.lblInsConsuntivatoNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtExtra
        '
        Me.txtExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtra.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtExtra.Location = New System.Drawing.Point(356, 116)
        Me.txtExtra.Mask = "9L9"
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Size = New System.Drawing.Size(37, 20)
        Me.txtExtra.TabIndex = 4
        '
        'btnModifica
        '
        Me.btnModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifica.ForeColor = System.Drawing.Color.White
        Me.btnModifica.Location = New System.Drawing.Point(63, 178)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModifica.Size = New System.Drawing.Size(100, 25)
        Me.btnModifica.TabIndex = 100
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoModifica
        '
        Me.lblBordoModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblBordoModifica.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoModifica.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoModifica.Location = New System.Drawing.Point(62, 177)
        Me.lblBordoModifica.Name = "lblBordoModifica"
        Me.lblBordoModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoModifica.Size = New System.Drawing.Size(102, 27)
        Me.lblBordoModifica.TabIndex = 101
        Me.lblBordoModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoAnnulla
        '
        Me.lblBordoAnnulla.BackColor = System.Drawing.Color.Silver
        Me.lblBordoAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoAnnulla.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoAnnulla.Location = New System.Drawing.Point(168, 177)
        Me.lblBordoAnnulla.Name = "lblBordoAnnulla"
        Me.lblBordoAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoAnnulla.Size = New System.Drawing.Size(102, 27)
        Me.lblBordoAnnulla.TabIndex = 101
        Me.lblBordoAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnnulla
        '
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.ForeColor = System.Drawing.Color.Black
        Me.btnAnnulla.Location = New System.Drawing.Point(169, 178)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 25)
        Me.btnAnnulla.TabIndex = 100
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoElimina
        '
        Me.lblBordoElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBordoElimina.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoElimina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoElimina.Location = New System.Drawing.Point(501, 176)
        Me.lblBordoElimina.Name = "lblBordoElimina"
        Me.lblBordoElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoElimina.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoElimina.TabIndex = 101
        Me.lblBordoElimina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnElimina
        '
        Me.btnElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnElimina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElimina.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElimina.ForeColor = System.Drawing.Color.White
        Me.btnElimina.Location = New System.Drawing.Point(502, 177)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnElimina.Size = New System.Drawing.Size(113, 25)
        Me.btnElimina.TabIndex = 100
        Me.btnElimina.Text = "Elimina"
        Me.btnElimina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTempo
        '
        Me.txtTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTempo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtTempo.Location = New System.Drawing.Point(295, 116)
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(37, 20)
        Me.txtTempo.TabIndex = 3
        '
        'frmModifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 232)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.lblBordoElimina)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.lblBordoAnnulla)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.lblBordoModifica)
        Me.Controls.Add(Me.lblInsConsuntivatoNO)
        Me.Controls.Add(Me.lblExtra)
        Me.Controls.Add(Me.lblInsExtra)
        Me.Controls.Add(Me.lblBordoExtra)
        Me.Controls.Add(Me.lblInsTempo)
        Me.Controls.Add(Me.lblBordoTempo)
        Me.Controls.Add(Me.lblTempo)
        Me.Controls.Add(Me.lblInsNota)
        Me.Controls.Add(Me.lblBordoNota)
        Me.Controls.Add(Me.cmbNota)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblInsData)
        Me.Controls.Add(Me.ckbHome)
        Me.Controls.Add(Me.lblInsConsuntivatoSI)
        Me.Controls.Add(Me.lblInsCliente)
        Me.Controls.Add(Me.lblInsTicket)
        Me.Controls.Add(Me.lblBordoData)
        Me.Controls.Add(Me.lblBordoConsuntivato)
        Me.Controls.Add(Me.lblBordoCliente)
        Me.Controls.Add(Me.lblBordoTicket)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblConsuntivato)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.txtExtra)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.txtTempo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModifica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ckbHome As CheckBox
    Friend WithEvents lblInsConsuntivatoSI As Label
    Friend WithEvents lblInsCliente As Label
    Friend WithEvents lblInsTicket As Label
    Friend WithEvents lblBordoConsuntivato As Label
    Friend WithEvents lblBordoCliente As Label
    Friend WithEvents lblBordoTicket As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents lblConsuntivato As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblTicket As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents lblBordoData As Label
    Friend WithEvents lblInsData As Label
    Friend WithEvents lblInsNota As Label
    Friend WithEvents lblBordoNota As Label
    Friend WithEvents cmbNota As ComboBox
    Friend WithEvents lblNota As Label
    Friend WithEvents lblInsTempo As Label
    Friend WithEvents lblBordoTempo As Label
    Friend WithEvents lblTempo As Label
    Friend WithEvents lblInsExtra As Label
    Friend WithEvents lblBordoExtra As Label
    Friend WithEvents lblExtra As Label
    Friend WithEvents lblInsConsuntivatoNO As Label
    Friend WithEvents txtExtra As MaskedTextBox
    Friend WithEvents btnModifica As Label
    Friend WithEvents lblBordoModifica As Label
    Friend WithEvents lblBordoAnnulla As Label
    Friend WithEvents btnAnnulla As Label
    Friend WithEvents lblBordoElimina As Label
    Friend WithEvents btnElimina As Label
    Friend WithEvents txtTempo As MaskedTextBox
End Class
