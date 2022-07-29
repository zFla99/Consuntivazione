<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInserisciCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInserisciCliente))
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCommessa = New System.Windows.Forms.TextBox()
        Me.lblCommessa = New System.Windows.Forms.Label()
        Me.lblSottCommessa = New System.Windows.Forms.Label()
        Me.txtSottoCommessa = New System.Windows.Forms.TextBox()
        Me.lblFase = New System.Windows.Forms.Label()
        Me.lblSottFase = New System.Windows.Forms.Label()
        Me.txtFase = New System.Windows.Forms.TextBox()
        Me.txtSottoFase = New System.Windows.Forms.TextBox()
        Me.btnInserisci = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.rdbFormazione = New System.Windows.Forms.RadioButton()
        Me.rdbFixed = New System.Windows.Forms.RadioButton()
        Me.rdbVuota = New System.Windows.Forms.RadioButton()
        Me.lblCodCliente = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.gboxCliente = New System.Windows.Forms.GroupBox()
        Me.rdbConfig = New System.Windows.Forms.RadioButton()
        Me.rdbCliente = New System.Windows.Forms.RadioButton()
        Me.rdbClienteConfig = New System.Windows.Forms.RadioButton()
        Me.gboxNota = New System.Windows.Forms.GroupBox()
        Me.rdbAltro = New System.Windows.Forms.RadioButton()
        Me.gboxCommessa = New System.Windows.Forms.GroupBox()
        Me.btnClienti = New System.Windows.Forms.Button()
        Me.btnCommesse = New System.Windows.Forms.Button()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.gboxCliente.SuspendLayout()
        Me.gboxNota.SuspendLayout()
        Me.gboxCommessa.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCliente.Location = New System.Drawing.Point(12, 25)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 14
        Me.lblCliente.Text = "Cliente"
        '
        'txtCommessa
        '
        Me.txtCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommessa.Location = New System.Drawing.Point(133, 21)
        Me.txtCommessa.MaxLength = 30
        Me.txtCommessa.Name = "txtCommessa"
        Me.txtCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommessa.Size = New System.Drawing.Size(110, 20)
        Me.txtCommessa.TabIndex = 3
        '
        'lblCommessa
        '
        Me.lblCommessa.AutoSize = True
        Me.lblCommessa.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommessa.ForeColor = System.Drawing.Color.Black
        Me.lblCommessa.Location = New System.Drawing.Point(42, 21)
        Me.lblCommessa.Name = "lblCommessa"
        Me.lblCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCommessa.Size = New System.Drawing.Size(85, 20)
        Me.lblCommessa.TabIndex = 16
        Me.lblCommessa.Text = "Commessa"
        '
        'lblSottCommessa
        '
        Me.lblSottCommessa.AutoSize = True
        Me.lblSottCommessa.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSottCommessa.ForeColor = System.Drawing.Color.Black
        Me.lblSottCommessa.Location = New System.Drawing.Point(290, 21)
        Me.lblSottCommessa.Name = "lblSottCommessa"
        Me.lblSottCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSottCommessa.Size = New System.Drawing.Size(128, 20)
        Me.lblSottCommessa.TabIndex = 16
        Me.lblSottCommessa.Text = "Sotto Commessa"
        '
        'txtSottoCommessa
        '
        Me.txtSottoCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoCommessa.Location = New System.Drawing.Point(424, 21)
        Me.txtSottoCommessa.MaxLength = 30
        Me.txtSottoCommessa.Name = "txtSottoCommessa"
        Me.txtSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoCommessa.Size = New System.Drawing.Size(110, 20)
        Me.txtSottoCommessa.TabIndex = 4
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFase.ForeColor = System.Drawing.Color.Black
        Me.lblFase.Location = New System.Drawing.Point(42, 66)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFase.Size = New System.Drawing.Size(38, 20)
        Me.lblFase.TabIndex = 16
        Me.lblFase.Text = "Fase"
        '
        'lblSottFase
        '
        Me.lblSottFase.AutoSize = True
        Me.lblSottFase.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSottFase.ForeColor = System.Drawing.Color.Black
        Me.lblSottFase.Location = New System.Drawing.Point(290, 66)
        Me.lblSottFase.Name = "lblSottFase"
        Me.lblSottFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSottFase.Size = New System.Drawing.Size(81, 20)
        Me.lblSottFase.TabIndex = 16
        Me.lblSottFase.Text = "Sotto Fase"
        '
        'txtFase
        '
        Me.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFase.Location = New System.Drawing.Point(133, 66)
        Me.txtFase.MaxLength = 30
        Me.txtFase.Name = "txtFase"
        Me.txtFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFase.Size = New System.Drawing.Size(110, 20)
        Me.txtFase.TabIndex = 5
        '
        'txtSottoFase
        '
        Me.txtSottoFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoFase.Location = New System.Drawing.Point(424, 66)
        Me.txtSottoFase.MaxLength = 30
        Me.txtSottoFase.Name = "txtSottoFase"
        Me.txtSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoFase.Size = New System.Drawing.Size(110, 20)
        Me.txtSottoFase.TabIndex = 6
        '
        'btnInserisci
        '
        Me.btnInserisci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInserisci.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnInserisci.Location = New System.Drawing.Point(350, 242)
        Me.btnInserisci.Name = "btnInserisci"
        Me.btnInserisci.Size = New System.Drawing.Size(249, 40)
        Me.btnInserisci.TabIndex = 7
        Me.btnInserisci.Text = "Inserisci Cliente e Commessa"
        Me.btnInserisci.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Location = New System.Drawing.Point(132, 25)
        Me.txtCliente.MaxLength = 30
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(110, 20)
        Me.txtCliente.TabIndex = 1
        '
        'rdbFormazione
        '
        Me.rdbFormazione.AutoSize = True
        Me.rdbFormazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFormazione.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFormazione.ForeColor = System.Drawing.Color.Black
        Me.rdbFormazione.Location = New System.Drawing.Point(91, 29)
        Me.rdbFormazione.Name = "rdbFormazione"
        Me.rdbFormazione.Size = New System.Drawing.Size(88, 20)
        Me.rdbFormazione.TabIndex = 11
        Me.rdbFormazione.Text = "Formazione"
        Me.rdbFormazione.UseVisualStyleBackColor = True
        '
        'rdbFixed
        '
        Me.rdbFixed.AutoSize = True
        Me.rdbFixed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFixed.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFixed.ForeColor = System.Drawing.Color.Black
        Me.rdbFixed.Location = New System.Drawing.Point(13, 55)
        Me.rdbFixed.Name = "rdbFixed"
        Me.rdbFixed.Size = New System.Drawing.Size(53, 20)
        Me.rdbFixed.TabIndex = 11
        Me.rdbFixed.Text = "Fixed"
        Me.rdbFixed.UseVisualStyleBackColor = True
        '
        'rdbVuota
        '
        Me.rdbVuota.AutoSize = True
        Me.rdbVuota.Checked = True
        Me.rdbVuota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbVuota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbVuota.ForeColor = System.Drawing.Color.Black
        Me.rdbVuota.Location = New System.Drawing.Point(13, 29)
        Me.rdbVuota.Name = "rdbVuota"
        Me.rdbVuota.Size = New System.Drawing.Size(58, 20)
        Me.rdbVuota.TabIndex = 11
        Me.rdbVuota.TabStop = True
        Me.rdbVuota.Text = "Vuota"
        Me.rdbVuota.UseVisualStyleBackColor = True
        '
        'lblCodCliente
        '
        Me.lblCodCliente.AutoSize = True
        Me.lblCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCodCliente.Location = New System.Drawing.Point(12, 54)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodCliente.Size = New System.Drawing.Size(112, 20)
        Me.lblCodCliente.TabIndex = 14
        Me.lblCodCliente.Text = "Codice Cliente"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(132, 54)
        Me.txtCodCliente.MaxLength = 30
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodCliente.Size = New System.Drawing.Size(110, 20)
        Me.txtCodCliente.TabIndex = 2
        '
        'gboxCliente
        '
        Me.gboxCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxCliente.Controls.Add(Me.rdbConfig)
        Me.gboxCliente.Controls.Add(Me.rdbCliente)
        Me.gboxCliente.Controls.Add(Me.txtCodCliente)
        Me.gboxCliente.Controls.Add(Me.rdbClienteConfig)
        Me.gboxCliente.Controls.Add(Me.txtCliente)
        Me.gboxCliente.Controls.Add(Me.lblCodCliente)
        Me.gboxCliente.Controls.Add(Me.lblCliente)
        Me.gboxCliente.Location = New System.Drawing.Point(26, 7)
        Me.gboxCliente.Name = "gboxCliente"
        Me.gboxCliente.Size = New System.Drawing.Size(388, 98)
        Me.gboxCliente.TabIndex = 20
        Me.gboxCliente.TabStop = False
        '
        'rdbConfig
        '
        Me.rdbConfig.AutoSize = True
        Me.rdbConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbConfig.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbConfig.ForeColor = System.Drawing.Color.Black
        Me.rdbConfig.Location = New System.Drawing.Point(266, 65)
        Me.rdbConfig.Name = "rdbConfig"
        Me.rdbConfig.Size = New System.Drawing.Size(89, 20)
        Me.rdbConfig.TabIndex = 10
        Me.rdbConfig.Text = "Solo Config"
        Me.rdbConfig.UseVisualStyleBackColor = True
        '
        'rdbCliente
        '
        Me.rdbCliente.AutoSize = True
        Me.rdbCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbCliente.ForeColor = System.Drawing.Color.Black
        Me.rdbCliente.Location = New System.Drawing.Point(266, 39)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(91, 20)
        Me.rdbCliente.TabIndex = 10
        Me.rdbCliente.Text = "Solo Cliente"
        Me.rdbCliente.UseVisualStyleBackColor = True
        '
        'rdbClienteConfig
        '
        Me.rdbClienteConfig.AutoSize = True
        Me.rdbClienteConfig.Checked = True
        Me.rdbClienteConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbClienteConfig.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbClienteConfig.ForeColor = System.Drawing.Color.Black
        Me.rdbClienteConfig.Location = New System.Drawing.Point(266, 13)
        Me.rdbClienteConfig.Name = "rdbClienteConfig"
        Me.rdbClienteConfig.Size = New System.Drawing.Size(115, 20)
        Me.rdbClienteConfig.TabIndex = 10
        Me.rdbClienteConfig.TabStop = True
        Me.rdbClienteConfig.Text = "Cliente + Config"
        Me.rdbClienteConfig.UseVisualStyleBackColor = True
        '
        'gboxNota
        '
        Me.gboxNota.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxNota.Controls.Add(Me.rdbFormazione)
        Me.gboxNota.Controls.Add(Me.rdbVuota)
        Me.gboxNota.Controls.Add(Me.rdbAltro)
        Me.gboxNota.Controls.Add(Me.rdbFixed)
        Me.gboxNota.Location = New System.Drawing.Point(420, 7)
        Me.gboxNota.Name = "gboxNota"
        Me.gboxNota.Size = New System.Drawing.Size(189, 99)
        Me.gboxNota.TabIndex = 21
        Me.gboxNota.TabStop = False
        '
        'rdbAltro
        '
        Me.rdbAltro.AutoSize = True
        Me.rdbAltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbAltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbAltro.ForeColor = System.Drawing.Color.Black
        Me.rdbAltro.Location = New System.Drawing.Point(91, 55)
        Me.rdbAltro.Name = "rdbAltro"
        Me.rdbAltro.Size = New System.Drawing.Size(53, 20)
        Me.rdbAltro.TabIndex = 11
        Me.rdbAltro.Text = "Altro"
        Me.rdbAltro.UseVisualStyleBackColor = True
        '
        'gboxCommessa
        '
        Me.gboxCommessa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxCommessa.Controls.Add(Me.txtSottoFase)
        Me.gboxCommessa.Controls.Add(Me.txtSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtFase)
        Me.gboxCommessa.Controls.Add(Me.txtCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblSottFase)
        Me.gboxCommessa.Controls.Add(Me.lblFase)
        Me.gboxCommessa.Controls.Add(Me.lblSottCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblCommessa)
        Me.gboxCommessa.Location = New System.Drawing.Point(26, 119)
        Me.gboxCommessa.Name = "gboxCommessa"
        Me.gboxCommessa.Size = New System.Drawing.Size(583, 106)
        Me.gboxCommessa.TabIndex = 22
        Me.gboxCommessa.TabStop = False
        '
        'btnClienti
        '
        Me.btnClienti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClienti.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnClienti.Location = New System.Drawing.Point(42, 242)
        Me.btnClienti.Name = "btnClienti"
        Me.btnClienti.Size = New System.Drawing.Size(71, 40)
        Me.btnClienti.TabIndex = 8
        Me.btnClienti.Text = "Clienti"
        Me.btnClienti.UseVisualStyleBackColor = True
        '
        'btnCommesse
        '
        Me.btnCommesse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCommesse.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnCommesse.Location = New System.Drawing.Point(119, 242)
        Me.btnCommesse.Name = "btnCommesse"
        Me.btnCommesse.Size = New System.Drawing.Size(107, 40)
        Me.btnCommesse.TabIndex = 9
        Me.btnCommesse.Text = "Commesse"
        Me.btnCommesse.UseVisualStyleBackColor = True
        '
        'ofdFile
        '
        Me.ofdFile.InitialDirectory = "Desktop"
        '
        'frmInserisciCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 303)
        Me.Controls.Add(Me.btnCommesse)
        Me.Controls.Add(Me.btnClienti)
        Me.Controls.Add(Me.btnInserisci)
        Me.Controls.Add(Me.gboxCommessa)
        Me.Controls.Add(Me.gboxNota)
        Me.Controls.Add(Me.gboxCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(650, 342)
        Me.MinimumSize = New System.Drawing.Size(650, 342)
        Me.Name = "frmInserisciCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inserisci Cliente"
        Me.gboxCliente.ResumeLayout(False)
        Me.gboxCliente.PerformLayout()
        Me.gboxNota.ResumeLayout(False)
        Me.gboxNota.PerformLayout()
        Me.gboxCommessa.ResumeLayout(False)
        Me.gboxCommessa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCommessa As TextBox
    Friend WithEvents lblCommessa As Label
    Friend WithEvents lblSottCommessa As Label
    Friend WithEvents txtSottoCommessa As TextBox
    Friend WithEvents lblFase As Label
    Friend WithEvents lblSottFase As Label
    Friend WithEvents txtFase As TextBox
    Friend WithEvents txtSottoFase As TextBox
    Friend WithEvents btnInserisci As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents rdbFormazione As RadioButton
    Friend WithEvents rdbFixed As RadioButton
    Friend WithEvents rdbVuota As RadioButton
    Friend WithEvents lblCodCliente As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents gboxCliente As GroupBox
    Friend WithEvents gboxNota As GroupBox
    Friend WithEvents gboxCommessa As GroupBox
    Friend WithEvents rdbCliente As RadioButton
    Friend WithEvents rdbClienteConfig As RadioButton
    Friend WithEvents rdbConfig As RadioButton
    Friend WithEvents btnClienti As Button
    Friend WithEvents btnCommesse As Button
    Friend WithEvents rdbAltro As RadioButton
    Friend WithEvents ofdFile As OpenFileDialog
End Class
