<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInserisciCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInserisciCliente))
        Me.rdbConfig = New System.Windows.Forms.RadioButton()
        Me.rdbCliente = New System.Windows.Forms.RadioButton()
        Me.rdbClienteConfig = New System.Windows.Forms.RadioButton()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.gboxClienti = New System.Windows.Forms.GroupBox()
        Me.lblInsNota = New System.Windows.Forms.Label()
        Me.lblBordoNota = New System.Windows.Forms.Label()
        Me.cmbNota = New System.Windows.Forms.ComboBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblInsCodCliente = New System.Windows.Forms.Label()
        Me.lblBordoCodCliente = New System.Windows.Forms.Label()
        Me.lblCodCliente = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.lblInsCliente = New System.Windows.Forms.Label()
        Me.lblBordoCliente = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.gboxCommessa = New System.Windows.Forms.GroupBox()
        Me.lblInsSottoFase = New System.Windows.Forms.Label()
        Me.lblInsFase = New System.Windows.Forms.Label()
        Me.lblInsSottoCommessa = New System.Windows.Forms.Label()
        Me.lblInsCommessa = New System.Windows.Forms.Label()
        Me.lblSottFase = New System.Windows.Forms.Label()
        Me.lblBordoSottoFase = New System.Windows.Forms.Label()
        Me.lblFase = New System.Windows.Forms.Label()
        Me.lblBordoFase = New System.Windows.Forms.Label()
        Me.lblSottCommessa = New System.Windows.Forms.Label()
        Me.txtSottoFase = New System.Windows.Forms.TextBox()
        Me.lblBordoSottoCommessa = New System.Windows.Forms.Label()
        Me.txtFase = New System.Windows.Forms.TextBox()
        Me.txtSottoCommessa = New System.Windows.Forms.TextBox()
        Me.lblCommessa = New System.Windows.Forms.Label()
        Me.lblBordoCommessa = New System.Windows.Forms.Label()
        Me.txtCommessa = New System.Windows.Forms.TextBox()
        Me.btnAnnulla = New System.Windows.Forms.Label()
        Me.lblBordoAnnulla = New System.Windows.Forms.Label()
        Me.btnInserisci = New System.Windows.Forms.Label()
        Me.lblBordoInserisci = New System.Windows.Forms.Label()
        Me.lblBordoClientiCommesse = New System.Windows.Forms.Label()
        Me.btnClientiCommesse = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gboxClienti.SuspendLayout()
        Me.gboxCommessa.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbConfig
        '
        Me.rdbConfig.AutoSize = True
        Me.rdbConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbConfig.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbConfig.Location = New System.Drawing.Point(447, 71)
        Me.rdbConfig.Name = "rdbConfig"
        Me.rdbConfig.Size = New System.Drawing.Size(89, 20)
        Me.rdbConfig.TabIndex = 22
        Me.rdbConfig.Text = "Solo Config"
        Me.rdbConfig.UseVisualStyleBackColor = True
        '
        'rdbCliente
        '
        Me.rdbCliente.AutoSize = True
        Me.rdbCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbCliente.Location = New System.Drawing.Point(447, 45)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(91, 20)
        Me.rdbCliente.TabIndex = 21
        Me.rdbCliente.Text = "Solo Cliente"
        Me.rdbCliente.UseVisualStyleBackColor = True
        '
        'rdbClienteConfig
        '
        Me.rdbClienteConfig.AutoSize = True
        Me.rdbClienteConfig.Checked = True
        Me.rdbClienteConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbClienteConfig.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbClienteConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rdbClienteConfig.Location = New System.Drawing.Point(447, 19)
        Me.rdbClienteConfig.Name = "rdbClienteConfig"
        Me.rdbClienteConfig.Size = New System.Drawing.Size(115, 20)
        Me.rdbClienteConfig.TabIndex = 20
        Me.rdbClienteConfig.TabStop = True
        Me.rdbClienteConfig.Text = "Cliente + Config"
        Me.rdbClienteConfig.UseVisualStyleBackColor = True
        '
        'ofdFile
        '
        Me.ofdFile.InitialDirectory = "Desktop"
        '
        'gboxClienti
        '
        Me.gboxClienti.Controls.Add(Me.rdbConfig)
        Me.gboxClienti.Controls.Add(Me.lblInsNota)
        Me.gboxClienti.Controls.Add(Me.rdbCliente)
        Me.gboxClienti.Controls.Add(Me.lblBordoNota)
        Me.gboxClienti.Controls.Add(Me.rdbClienteConfig)
        Me.gboxClienti.Controls.Add(Me.cmbNota)
        Me.gboxClienti.Controls.Add(Me.lblNota)
        Me.gboxClienti.Controls.Add(Me.lblInsCodCliente)
        Me.gboxClienti.Controls.Add(Me.lblBordoCodCliente)
        Me.gboxClienti.Controls.Add(Me.lblCodCliente)
        Me.gboxClienti.Controls.Add(Me.txtCodCliente)
        Me.gboxClienti.Controls.Add(Me.lblInsCliente)
        Me.gboxClienti.Controls.Add(Me.lblBordoCliente)
        Me.gboxClienti.Controls.Add(Me.lblCliente)
        Me.gboxClienti.Controls.Add(Me.txtCliente)
        Me.gboxClienti.Location = New System.Drawing.Point(32, 22)
        Me.gboxClienti.Name = "gboxClienti"
        Me.gboxClienti.Size = New System.Drawing.Size(583, 109)
        Me.gboxClienti.TabIndex = 21
        Me.gboxClienti.TabStop = False
        '
        'lblInsNota
        '
        Me.lblInsNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsNota.ForeColor = System.Drawing.Color.Black
        Me.lblInsNota.Location = New System.Drawing.Point(302, 49)
        Me.lblInsNota.Name = "lblInsNota"
        Me.lblInsNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsNota.Size = New System.Drawing.Size(113, 25)
        Me.lblInsNota.TabIndex = 93
        Me.lblInsNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoNota
        '
        Me.lblBordoNota.BackColor = System.Drawing.Color.Silver
        Me.lblBordoNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoNota.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoNota.Location = New System.Drawing.Point(301, 48)
        Me.lblBordoNota.Name = "lblBordoNota"
        Me.lblBordoNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoNota.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoNota.TabIndex = 92
        Me.lblBordoNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbNota
        '
        Me.cmbNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNota.Items.AddRange(New Object() {"Fixed", "Formazione"})
        Me.cmbNota.Location = New System.Drawing.Point(316, 51)
        Me.cmbNota.MaxLength = 20
        Me.cmbNota.Name = "cmbNota"
        Me.cmbNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNota.Size = New System.Drawing.Size(83, 21)
        Me.cmbNota.Sorted = True
        Me.cmbNota.TabIndex = 3
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNota.Location = New System.Drawing.Point(297, 25)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(43, 20)
        Me.lblNota.TabIndex = 91
        Me.lblNota.Text = "Nota"
        Me.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsCodCliente
        '
        Me.lblInsCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCodCliente.ForeColor = System.Drawing.Color.Black
        Me.lblInsCodCliente.Location = New System.Drawing.Point(164, 48)
        Me.lblInsCodCliente.Name = "lblInsCodCliente"
        Me.lblInsCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCodCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCodCliente.TabIndex = 75
        Me.lblInsCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCodCliente
        '
        Me.lblBordoCodCliente.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCodCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCodCliente.Location = New System.Drawing.Point(163, 47)
        Me.lblBordoCodCliente.Name = "lblBordoCodCliente"
        Me.lblBordoCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCodCliente.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCodCliente.TabIndex = 76
        Me.lblBordoCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodCliente
        '
        Me.lblCodCliente.AutoSize = True
        Me.lblCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCodCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodCliente.Location = New System.Drawing.Point(159, 25)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.Size = New System.Drawing.Size(112, 20)
        Me.lblCodCliente.TabIndex = 73
        Me.lblCodCliente.Text = "Codice Cliente"
        Me.lblCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(174, 50)
        Me.txtCodCliente.MaxLength = 10
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodCliente.Size = New System.Drawing.Size(93, 20)
        Me.txtCodCliente.TabIndex = 2
        '
        'lblInsCliente
        '
        Me.lblInsCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCliente.ForeColor = System.Drawing.Color.Black
        Me.lblInsCliente.Location = New System.Drawing.Point(26, 48)
        Me.lblInsCliente.Name = "lblInsCliente"
        Me.lblInsCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCliente.TabIndex = 71
        Me.lblInsCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCliente
        '
        Me.lblBordoCliente.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCliente.Location = New System.Drawing.Point(25, 47)
        Me.lblBordoCliente.Name = "lblBordoCliente"
        Me.lblBordoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCliente.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCliente.TabIndex = 72
        Me.lblBordoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(21, 25)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Location = New System.Drawing.Point(36, 50)
        Me.txtCliente.MaxLength = 10
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(93, 20)
        Me.txtCliente.TabIndex = 1
        '
        'gboxCommessa
        '
        Me.gboxCommessa.Controls.Add(Me.lblInsSottoFase)
        Me.gboxCommessa.Controls.Add(Me.lblInsFase)
        Me.gboxCommessa.Controls.Add(Me.lblInsSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblInsCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblSottFase)
        Me.gboxCommessa.Controls.Add(Me.lblBordoSottoFase)
        Me.gboxCommessa.Controls.Add(Me.lblFase)
        Me.gboxCommessa.Controls.Add(Me.lblBordoFase)
        Me.gboxCommessa.Controls.Add(Me.lblSottCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtSottoFase)
        Me.gboxCommessa.Controls.Add(Me.lblBordoSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtFase)
        Me.gboxCommessa.Controls.Add(Me.txtSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblBordoCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtCommessa)
        Me.gboxCommessa.Location = New System.Drawing.Point(32, 137)
        Me.gboxCommessa.Name = "gboxCommessa"
        Me.gboxCommessa.Size = New System.Drawing.Size(583, 128)
        Me.gboxCommessa.TabIndex = 22
        Me.gboxCommessa.TabStop = False
        '
        'lblInsSottoFase
        '
        Me.lblInsSottoFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsSottoFase.ForeColor = System.Drawing.Color.Black
        Me.lblInsSottoFase.Location = New System.Drawing.Point(406, 83)
        Me.lblInsSottoFase.Name = "lblInsSottoFase"
        Me.lblInsSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsSottoFase.Size = New System.Drawing.Size(113, 25)
        Me.lblInsSottoFase.TabIndex = 96
        Me.lblInsSottoFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsFase
        '
        Me.lblInsFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsFase.ForeColor = System.Drawing.Color.Black
        Me.lblInsFase.Location = New System.Drawing.Point(127, 83)
        Me.lblInsFase.Name = "lblInsFase"
        Me.lblInsFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsFase.Size = New System.Drawing.Size(113, 25)
        Me.lblInsFase.TabIndex = 96
        Me.lblInsFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsSottoCommessa
        '
        Me.lblInsSottoCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsSottoCommessa.ForeColor = System.Drawing.Color.Black
        Me.lblInsSottoCommessa.Location = New System.Drawing.Point(406, 25)
        Me.lblInsSottoCommessa.Name = "lblInsSottoCommessa"
        Me.lblInsSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsSottoCommessa.Size = New System.Drawing.Size(113, 25)
        Me.lblInsSottoCommessa.TabIndex = 96
        Me.lblInsSottoCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsCommessa
        '
        Me.lblInsCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCommessa.ForeColor = System.Drawing.Color.Black
        Me.lblInsCommessa.Location = New System.Drawing.Point(127, 25)
        Me.lblInsCommessa.Name = "lblInsCommessa"
        Me.lblInsCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCommessa.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCommessa.TabIndex = 96
        Me.lblInsCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSottFase
        '
        Me.lblSottFase.AutoSize = True
        Me.lblSottFase.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblSottFase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSottFase.Location = New System.Drawing.Point(318, 85)
        Me.lblSottFase.Name = "lblSottFase"
        Me.lblSottFase.Size = New System.Drawing.Size(81, 20)
        Me.lblSottFase.TabIndex = 94
        Me.lblSottFase.Text = "Sotto Fase"
        Me.lblSottFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoSottoFase
        '
        Me.lblBordoSottoFase.BackColor = System.Drawing.Color.Silver
        Me.lblBordoSottoFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoSottoFase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoSottoFase.Location = New System.Drawing.Point(405, 82)
        Me.lblBordoSottoFase.Name = "lblBordoSottoFase"
        Me.lblBordoSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoSottoFase.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoSottoFase.TabIndex = 97
        Me.lblBordoSottoFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblFase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFase.Location = New System.Drawing.Point(83, 85)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(38, 20)
        Me.lblFase.TabIndex = 94
        Me.lblFase.Text = "Fase"
        Me.lblFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoFase
        '
        Me.lblBordoFase.BackColor = System.Drawing.Color.Silver
        Me.lblBordoFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoFase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoFase.Location = New System.Drawing.Point(126, 82)
        Me.lblBordoFase.Name = "lblBordoFase"
        Me.lblBordoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoFase.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoFase.TabIndex = 97
        Me.lblBordoFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSottCommessa
        '
        Me.lblSottCommessa.AutoSize = True
        Me.lblSottCommessa.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblSottCommessa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSottCommessa.Location = New System.Drawing.Point(271, 27)
        Me.lblSottCommessa.Name = "lblSottCommessa"
        Me.lblSottCommessa.Size = New System.Drawing.Size(128, 20)
        Me.lblSottCommessa.TabIndex = 94
        Me.lblSottCommessa.Text = "Sotto Commessa"
        Me.lblSottCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSottoFase
        '
        Me.txtSottoFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoFase.Location = New System.Drawing.Point(416, 85)
        Me.txtSottoFase.MaxLength = 10
        Me.txtSottoFase.Name = "txtSottoFase"
        Me.txtSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoFase.Size = New System.Drawing.Size(93, 20)
        Me.txtSottoFase.TabIndex = 7
        '
        'lblBordoSottoCommessa
        '
        Me.lblBordoSottoCommessa.BackColor = System.Drawing.Color.Silver
        Me.lblBordoSottoCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoSottoCommessa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoSottoCommessa.Location = New System.Drawing.Point(405, 24)
        Me.lblBordoSottoCommessa.Name = "lblBordoSottoCommessa"
        Me.lblBordoSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoSottoCommessa.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoSottoCommessa.TabIndex = 97
        Me.lblBordoSottoCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFase
        '
        Me.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFase.Location = New System.Drawing.Point(137, 85)
        Me.txtFase.MaxLength = 10
        Me.txtFase.Name = "txtFase"
        Me.txtFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFase.Size = New System.Drawing.Size(93, 20)
        Me.txtFase.TabIndex = 6
        '
        'txtSottoCommessa
        '
        Me.txtSottoCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoCommessa.Location = New System.Drawing.Point(416, 27)
        Me.txtSottoCommessa.MaxLength = 10
        Me.txtSottoCommessa.Name = "txtSottoCommessa"
        Me.txtSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoCommessa.Size = New System.Drawing.Size(93, 20)
        Me.txtSottoCommessa.TabIndex = 5
        '
        'lblCommessa
        '
        Me.lblCommessa.AutoSize = True
        Me.lblCommessa.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCommessa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCommessa.Location = New System.Drawing.Point(35, 27)
        Me.lblCommessa.Name = "lblCommessa"
        Me.lblCommessa.Size = New System.Drawing.Size(85, 20)
        Me.lblCommessa.TabIndex = 94
        Me.lblCommessa.Text = "Commessa"
        Me.lblCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCommessa
        '
        Me.lblBordoCommessa.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCommessa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCommessa.Location = New System.Drawing.Point(126, 24)
        Me.lblBordoCommessa.Name = "lblBordoCommessa"
        Me.lblBordoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCommessa.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCommessa.TabIndex = 97
        Me.lblBordoCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCommessa
        '
        Me.txtCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommessa.Location = New System.Drawing.Point(137, 27)
        Me.txtCommessa.MaxLength = 10
        Me.txtCommessa.Name = "txtCommessa"
        Me.txtCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommessa.Size = New System.Drawing.Size(93, 20)
        Me.txtCommessa.TabIndex = 4
        '
        'btnAnnulla
        '
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.ForeColor = System.Drawing.Color.Black
        Me.btnAnnulla.Location = New System.Drawing.Point(515, 275)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 29)
        Me.btnAnnulla.TabIndex = 9
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoAnnulla
        '
        Me.lblBordoAnnulla.BackColor = System.Drawing.Color.Silver
        Me.lblBordoAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoAnnulla.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoAnnulla.Location = New System.Drawing.Point(514, 274)
        Me.lblBordoAnnulla.Name = "lblBordoAnnulla"
        Me.lblBordoAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoAnnulla.Size = New System.Drawing.Size(102, 31)
        Me.lblBordoAnnulla.TabIndex = 104
        Me.lblBordoAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInserisci
        '
        Me.btnInserisci.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInserisci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInserisci.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserisci.ForeColor = System.Drawing.Color.White
        Me.btnInserisci.Location = New System.Drawing.Point(282, 275)
        Me.btnInserisci.Name = "btnInserisci"
        Me.btnInserisci.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnInserisci.Size = New System.Drawing.Size(227, 29)
        Me.btnInserisci.TabIndex = 8
        Me.btnInserisci.Text = "Inserisci Cliente e Commessa"
        Me.btnInserisci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoInserisci
        '
        Me.lblBordoInserisci.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblBordoInserisci.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoInserisci.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoInserisci.Location = New System.Drawing.Point(281, 274)
        Me.lblBordoInserisci.Name = "lblBordoInserisci"
        Me.lblBordoInserisci.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoInserisci.Size = New System.Drawing.Size(229, 31)
        Me.lblBordoInserisci.TabIndex = 105
        Me.lblBordoInserisci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoClientiCommesse
        '
        Me.lblBordoClientiCommesse.BackColor = System.Drawing.Color.Silver
        Me.lblBordoClientiCommesse.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoClientiCommesse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoClientiCommesse.Location = New System.Drawing.Point(33, 274)
        Me.lblBordoClientiCommesse.Name = "lblBordoClientiCommesse"
        Me.lblBordoClientiCommesse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoClientiCommesse.Size = New System.Drawing.Size(175, 31)
        Me.lblBordoClientiCommesse.TabIndex = 104
        Me.lblBordoClientiCommesse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientiCommesse
        '
        Me.btnClientiCommesse.BackColor = System.Drawing.SystemColors.Control
        Me.btnClientiCommesse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientiCommesse.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientiCommesse.ForeColor = System.Drawing.Color.Black
        Me.btnClientiCommesse.Location = New System.Drawing.Point(34, 275)
        Me.btnClientiCommesse.Name = "btnClientiCommesse"
        Me.btnClientiCommesse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClientiCommesse.Size = New System.Drawing.Size(173, 29)
        Me.btnClientiCommesse.TabIndex = 10
        Me.btnClientiCommesse.Text = "Commesse e Clienti Attivi"
        Me.btnClientiCommesse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInserisciCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 342)
        Me.Controls.Add(Me.btnClientiCommesse)
        Me.Controls.Add(Me.lblBordoClientiCommesse)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.lblBordoAnnulla)
        Me.Controls.Add(Me.btnInserisci)
        Me.Controls.Add(Me.lblBordoInserisci)
        Me.Controls.Add(Me.gboxClienti)
        Me.Controls.Add(Me.gboxCommessa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(650, 342)
        Me.Name = "frmInserisciCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inserisci Cliente"
        Me.TopMost = True
        Me.gboxClienti.ResumeLayout(False)
        Me.gboxClienti.PerformLayout()
        Me.gboxCommessa.ResumeLayout(False)
        Me.gboxCommessa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdbCliente As RadioButton
    Friend WithEvents rdbClienteConfig As RadioButton
    Friend WithEvents rdbConfig As RadioButton
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents gboxClienti As GroupBox
    Friend WithEvents lblInsCodCliente As Label
    Friend WithEvents lblBordoCodCliente As Label
    Friend WithEvents lblCodCliente As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents lblInsCliente As Label
    Friend WithEvents lblBordoCliente As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblInsNota As Label
    Friend WithEvents lblBordoNota As Label
    Friend WithEvents cmbNota As ComboBox
    Friend WithEvents lblNota As Label
    Friend WithEvents gboxCommessa As GroupBox
    Friend WithEvents lblInsSottoFase As Label
    Friend WithEvents lblInsFase As Label
    Friend WithEvents lblInsSottoCommessa As Label
    Friend WithEvents lblInsCommessa As Label
    Friend WithEvents lblSottFase As Label
    Friend WithEvents lblBordoSottoFase As Label
    Friend WithEvents lblFase As Label
    Friend WithEvents lblBordoFase As Label
    Friend WithEvents lblSottCommessa As Label
    Friend WithEvents txtSottoFase As TextBox
    Friend WithEvents lblBordoSottoCommessa As Label
    Friend WithEvents txtFase As TextBox
    Friend WithEvents txtSottoCommessa As TextBox
    Friend WithEvents lblCommessa As Label
    Friend WithEvents lblBordoCommessa As Label
    Friend WithEvents txtCommessa As TextBox
    Friend WithEvents btnAnnulla As Label
    Friend WithEvents lblBordoAnnulla As Label
    Friend WithEvents btnInserisci As Label
    Friend WithEvents lblBordoInserisci As Label
    Friend WithEvents lblBordoClientiCommesse As Label
    Friend WithEvents btnClientiCommesse As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
