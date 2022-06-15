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
        Me.Label3.Location = New System.Drawing.Point(18, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(86, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cliente"
        '
        'txtCommessa
        '
        Me.txtCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommessa.Location = New System.Drawing.Point(171, 32)
        Me.txtCommessa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCommessa.MaxLength = 30
        Me.txtCommessa.Name = "txtCommessa"
        Me.txtCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommessa.Size = New System.Drawing.Size(164, 26)
        Me.txtCommessa.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Commessa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(406, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(183, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sotto Commessa"
        '
        'txtSottoCommessa
        '
        Me.txtSottoCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoCommessa.Location = New System.Drawing.Point(608, 32)
        Me.txtSottoCommessa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSottoCommessa.MaxLength = 30
        Me.txtSottoCommessa.Name = "txtSottoCommessa"
        Me.txtSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoCommessa.Size = New System.Drawing.Size(164, 26)
        Me.txtSottoCommessa.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(56, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(406, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(116, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Sotto Fase"
        '
        'txtFase
        '
        Me.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFase.Location = New System.Drawing.Point(171, 102)
        Me.txtFase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFase.MaxLength = 30
        Me.txtFase.Name = "txtFase"
        Me.txtFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFase.Size = New System.Drawing.Size(164, 26)
        Me.txtFase.TabIndex = 15
        '
        'txtSottoFase
        '
        Me.txtSottoFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoFase.Location = New System.Drawing.Point(608, 102)
        Me.txtSottoFase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSottoFase.MaxLength = 30
        Me.txtSottoFase.Name = "txtSottoFase"
        Me.txtSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoFase.Size = New System.Drawing.Size(164, 26)
        Me.txtSottoFase.TabIndex = 15
        '
        'btnInserisci
        '
        Me.btnInserisci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInserisci.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnInserisci.Location = New System.Drawing.Point(438, 372)
        Me.btnInserisci.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInserisci.Name = "btnInserisci"
        Me.btnInserisci.Size = New System.Drawing.Size(374, 62)
        Me.btnInserisci.TabIndex = 17
        Me.btnInserisci.Text = "Inserisci Cliente e Commessa"
        Me.btnInserisci.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Location = New System.Drawing.Point(198, 38)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCliente.MaxLength = 30
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(164, 26)
        Me.txtCliente.TabIndex = 15
        '
        'rdbFormazione
        '
        Me.rdbFormazione.AutoSize = True
        Me.rdbFormazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbFormazione.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFormazione.ForeColor = System.Drawing.Color.Black
        Me.rdbFormazione.Location = New System.Drawing.Point(20, 100)
        Me.rdbFormazione.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdbFormazione.Name = "rdbFormazione"
        Me.rdbFormazione.Size = New System.Drawing.Size(131, 28)
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
        Me.rdbFixed.Location = New System.Drawing.Point(20, 60)
        Me.rdbFixed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdbFixed.Name = "rdbFixed"
        Me.rdbFixed.Size = New System.Drawing.Size(79, 28)
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
        Me.rdbVuota.Location = New System.Drawing.Point(20, 20)
        Me.rdbVuota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdbVuota.Name = "rdbVuota"
        Me.rdbVuota.Size = New System.Drawing.Size(84, 28)
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
        Me.Label6.Location = New System.Drawing.Point(18, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(163, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Codice Cliente"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(198, 83)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodCliente.MaxLength = 30
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodCliente.Size = New System.Drawing.Size(164, 26)
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
        Me.gboxCliente.Location = New System.Drawing.Point(39, 11)
        Me.gboxCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboxCliente.Name = "gboxCliente"
        Me.gboxCliente.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboxCliente.Size = New System.Drawing.Size(582, 151)
        Me.gboxCliente.TabIndex = 20
        Me.gboxCliente.TabStop = False
        '
        'rdbConfig
        '
        Me.rdbConfig.AutoSize = True
        Me.rdbConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbConfig.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbConfig.ForeColor = System.Drawing.Color.Black
        Me.rdbConfig.Location = New System.Drawing.Point(399, 100)
        Me.rdbConfig.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdbConfig.Name = "rdbConfig"
        Me.rdbConfig.Size = New System.Drawing.Size(132, 28)
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
        Me.rdbCliente.Location = New System.Drawing.Point(399, 60)
        Me.rdbCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(136, 28)
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
        Me.rdbClienteConfig.Location = New System.Drawing.Point(399, 20)
        Me.rdbClienteConfig.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdbClienteConfig.Name = "rdbClienteConfig"
        Me.rdbClienteConfig.Size = New System.Drawing.Size(171, 28)
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
        Me.gboxNota.Location = New System.Drawing.Point(630, 11)
        Me.gboxNota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboxNota.Name = "gboxNota"
        Me.gboxNota.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboxNota.Size = New System.Drawing.Size(225, 152)
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
        Me.gboxCommessa.Location = New System.Drawing.Point(39, 183)
        Me.gboxCommessa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboxCommessa.Name = "gboxCommessa"
        Me.gboxCommessa.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gboxCommessa.Size = New System.Drawing.Size(816, 163)
        Me.gboxCommessa.TabIndex = 22
        Me.gboxCommessa.TabStop = False
        '
        'btnClienti
        '
        Me.btnClienti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClienti.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnClienti.Location = New System.Drawing.Point(39, 372)
        Me.btnClienti.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClienti.Name = "btnClienti"
        Me.btnClienti.Size = New System.Drawing.Size(106, 62)
        Me.btnClienti.TabIndex = 17
        Me.btnClienti.Text = "Clienti"
        Me.btnClienti.UseVisualStyleBackColor = True
        '
        'btnCommesse
        '
        Me.btnCommesse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCommesse.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnCommesse.Location = New System.Drawing.Point(154, 372)
        Me.btnCommesse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCommesse.Name = "btnCommesse"
        Me.btnCommesse.Size = New System.Drawing.Size(160, 62)
        Me.btnCommesse.TabIndex = 17
        Me.btnCommesse.Text = "Commesse"
        Me.btnCommesse.UseVisualStyleBackColor = True
        '
        'frmInserisciCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 449)
        Me.Controls.Add(Me.btnCommesse)
        Me.Controls.Add(Me.btnClienti)
        Me.Controls.Add(Me.btnInserisci)
        Me.Controls.Add(Me.gboxCommessa)
        Me.Controls.Add(Me.gboxNota)
        Me.Controls.Add(Me.gboxCliente)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(904, 505)
        Me.MinimumSize = New System.Drawing.Size(904, 505)
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
