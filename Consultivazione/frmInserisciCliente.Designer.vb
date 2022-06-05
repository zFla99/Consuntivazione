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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCommessa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSottoCommessa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFase = New System.Windows.Forms.TextBox()
        Me.txtSottoFase = New System.Windows.Forms.TextBox()
        Me.btnInserisci = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.rdbFormazione = New System.Windows.Forms.RadioButton()
        Me.rdbFixed = New System.Windows.Forms.RadioButton()
        Me.rdbVuota = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.gboxCliente = New System.Windows.Forms.GroupBox()
        Me.rdbConfig = New System.Windows.Forms.RadioButton()
        Me.rdbCliente = New System.Windows.Forms.RadioButton()
        Me.rdbClienteConfig = New System.Windows.Forms.RadioButton()
        Me.gboxNota = New System.Windows.Forms.GroupBox()
        Me.gboxCommessa = New System.Windows.Forms.GroupBox()
        Me.btnClienti = New System.Windows.Forms.Button()
        Me.btnCommesse = New System.Windows.Forms.Button()
        Me.gboxCliente.SuspendLayout()
        Me.gboxNota.SuspendLayout()
        Me.gboxCommessa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cliente"
        '
        'txtCommessa
        '
        Me.txtCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommessa.Location = New System.Drawing.Point(114, 21)
        Me.txtCommessa.MaxLength = 20
        Me.txtCommessa.Name = "txtCommessa"
        Me.txtCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommessa.Size = New System.Drawing.Size(110, 20)
        Me.txtCommessa.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Commessa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(271, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sotto Commessa"
        '
        'txtSottoCommessa
        '
        Me.txtSottoCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoCommessa.Location = New System.Drawing.Point(405, 21)
        Me.txtSottoCommessa.MaxLength = 20
        Me.txtSottoCommessa.Name = "txtSottoCommessa"
        Me.txtSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoCommessa.Size = New System.Drawing.Size(110, 20)
        Me.txtSottoCommessa.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(271, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Sotto Fase"
        '
        'txtFase
        '
        Me.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFase.Location = New System.Drawing.Point(114, 66)
        Me.txtFase.MaxLength = 20
        Me.txtFase.Name = "txtFase"
        Me.txtFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFase.Size = New System.Drawing.Size(110, 20)
        Me.txtFase.TabIndex = 15
        '
        'txtSottoFase
        '
        Me.txtSottoFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoFase.Location = New System.Drawing.Point(405, 66)
        Me.txtSottoFase.MaxLength = 20
        Me.txtSottoFase.Name = "txtSottoFase"
        Me.txtSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoFase.Size = New System.Drawing.Size(110, 20)
        Me.txtSottoFase.TabIndex = 15
        '
        'btnInserisci
        '
        Me.btnInserisci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInserisci.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnInserisci.Location = New System.Drawing.Point(292, 242)
        Me.btnInserisci.Name = "btnInserisci"
        Me.btnInserisci.Size = New System.Drawing.Size(249, 40)
        Me.btnInserisci.TabIndex = 17
        Me.btnInserisci.Text = "Inserisci Cliente e Commessa"
        Me.btnInserisci.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Location = New System.Drawing.Point(132, 25)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(110, 20)
        Me.txtCliente.TabIndex = 15
        '
        'rdbFormazione
        '
        Me.rdbFormazione.AutoSize = True
        Me.rdbFormazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFormazione.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFormazione.ForeColor = System.Drawing.Color.Black
        Me.rdbFormazione.Location = New System.Drawing.Point(13, 65)
        Me.rdbFormazione.Name = "rdbFormazione"
        Me.rdbFormazione.Size = New System.Drawing.Size(88, 20)
        Me.rdbFormazione.TabIndex = 18
        Me.rdbFormazione.Text = "Formazione"
        Me.rdbFormazione.UseVisualStyleBackColor = True
        '
        'rdbFixed
        '
        Me.rdbFixed.AutoSize = True
        Me.rdbFixed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFixed.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFixed.ForeColor = System.Drawing.Color.Black
        Me.rdbFixed.Location = New System.Drawing.Point(13, 39)
        Me.rdbFixed.Name = "rdbFixed"
        Me.rdbFixed.Size = New System.Drawing.Size(53, 20)
        Me.rdbFixed.TabIndex = 19
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
        Me.rdbVuota.Location = New System.Drawing.Point(13, 13)
        Me.rdbVuota.Name = "rdbVuota"
        Me.rdbVuota.Size = New System.Drawing.Size(58, 20)
        Me.rdbVuota.TabIndex = 19
        Me.rdbVuota.TabStop = True
        Me.rdbVuota.Text = "Vuota"
        Me.rdbVuota.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Codice Cliente"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(132, 54)
        Me.txtCodCliente.MaxLength = 20
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodCliente.Size = New System.Drawing.Size(110, 20)
        Me.txtCodCliente.TabIndex = 15
        '
        'gboxCliente
        '
        Me.gboxCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxCliente.Controls.Add(Me.rdbConfig)
        Me.gboxCliente.Controls.Add(Me.rdbCliente)
        Me.gboxCliente.Controls.Add(Me.txtCodCliente)
        Me.gboxCliente.Controls.Add(Me.rdbClienteConfig)
        Me.gboxCliente.Controls.Add(Me.txtCliente)
        Me.gboxCliente.Controls.Add(Me.Label6)
        Me.gboxCliente.Controls.Add(Me.Label3)
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
        Me.rdbConfig.TabIndex = 18
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
        Me.rdbCliente.TabIndex = 18
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
        Me.rdbClienteConfig.TabIndex = 19
        Me.rdbClienteConfig.TabStop = True
        Me.rdbClienteConfig.Text = "Cliente + Config"
        Me.rdbClienteConfig.UseVisualStyleBackColor = True
        '
        'gboxNota
        '
        Me.gboxNota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxNota.Controls.Add(Me.rdbFormazione)
        Me.gboxNota.Controls.Add(Me.rdbVuota)
        Me.gboxNota.Controls.Add(Me.rdbFixed)
        Me.gboxNota.Location = New System.Drawing.Point(420, 7)
        Me.gboxNota.Name = "gboxNota"
        Me.gboxNota.Size = New System.Drawing.Size(150, 99)
        Me.gboxNota.TabIndex = 21
        Me.gboxNota.TabStop = False
        '
        'gboxCommessa
        '
        Me.gboxCommessa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxCommessa.Controls.Add(Me.txtSottoFase)
        Me.gboxCommessa.Controls.Add(Me.txtSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtFase)
        Me.gboxCommessa.Controls.Add(Me.txtCommessa)
        Me.gboxCommessa.Controls.Add(Me.Label5)
        Me.gboxCommessa.Controls.Add(Me.Label2)
        Me.gboxCommessa.Controls.Add(Me.Label1)
        Me.gboxCommessa.Controls.Add(Me.Label4)
        Me.gboxCommessa.Location = New System.Drawing.Point(26, 119)
        Me.gboxCommessa.Name = "gboxCommessa"
        Me.gboxCommessa.Size = New System.Drawing.Size(544, 106)
        Me.gboxCommessa.TabIndex = 22
        Me.gboxCommessa.TabStop = False
        '
        'btnClienti
        '
        Me.btnClienti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClienti.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnClienti.Location = New System.Drawing.Point(26, 242)
        Me.btnClienti.Name = "btnClienti"
        Me.btnClienti.Size = New System.Drawing.Size(71, 40)
        Me.btnClienti.TabIndex = 17
        Me.btnClienti.Text = "Clienti"
        Me.btnClienti.UseVisualStyleBackColor = True
        '
        'btnCommesse
        '
        Me.btnCommesse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCommesse.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnCommesse.Location = New System.Drawing.Point(103, 242)
        Me.btnCommesse.Name = "btnCommesse"
        Me.btnCommesse.Size = New System.Drawing.Size(107, 40)
        Me.btnCommesse.TabIndex = 17
        Me.btnCommesse.Text = "Commesse"
        Me.btnCommesse.UseVisualStyleBackColor = True
        '
        'frmInserisciCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 309)
        Me.Controls.Add(Me.btnCommesse)
        Me.Controls.Add(Me.btnClienti)
        Me.Controls.Add(Me.btnInserisci)
        Me.Controls.Add(Me.gboxCommessa)
        Me.Controls.Add(Me.gboxNota)
        Me.Controls.Add(Me.gboxCliente)
        Me.MaximumSize = New System.Drawing.Size(610, 348)
        Me.MinimumSize = New System.Drawing.Size(610, 348)
        Me.Name = "frmInserisciCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmInserisciCliente"
        Me.gboxCliente.ResumeLayout(False)
        Me.gboxCliente.PerformLayout()
        Me.gboxNota.ResumeLayout(False)
        Me.gboxNota.PerformLayout()
        Me.gboxCommessa.ResumeLayout(False)
        Me.gboxCommessa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtCommessa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSottoCommessa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFase As TextBox
    Friend WithEvents txtSottoFase As TextBox
    Friend WithEvents btnInserisci As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents rdbFormazione As RadioButton
    Friend WithEvents rdbFixed As RadioButton
    Friend WithEvents rdbVuota As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents gboxCliente As GroupBox
    Friend WithEvents gboxNota As GroupBox
    Friend WithEvents gboxCommessa As GroupBox
    Friend WithEvents rdbCliente As RadioButton
    Friend WithEvents rdbClienteConfig As RadioButton
    Friend WithEvents rdbConfig As RadioButton
    Friend WithEvents btnClienti As Button
    Friend WithEvents btnCommesse As Button
End Class
