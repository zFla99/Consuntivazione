<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommesse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCommesse = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.ckbVuota = New System.Windows.Forms.CheckBox()
        Me.ckbFixed = New System.Windows.Forms.CheckBox()
        Me.ckbFormazione = New System.Windows.Forms.CheckBox()
        Me.btnCerca = New System.Windows.Forms.Button()
        CType(Me.dgvCommesse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCommesse
        '
        Me.dgvCommesse.AllowUserToAddRows = False
        Me.dgvCommesse.AllowUserToDeleteRows = False
        Me.dgvCommesse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCommesse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCommesse.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCommesse.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCommesse.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCommesse.Location = New System.Drawing.Point(12, 12)
        Me.dgvCommesse.Name = "dgvCommesse"
        Me.dgvCommesse.ReadOnly = True
        Me.dgvCommesse.Size = New System.Drawing.Size(749, 236)
        Me.dgvCommesse.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.Location = New System.Drawing.Point(118, 280)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(110, 21)
        Me.cmbCliente.TabIndex = 20
        '
        'ckbVuota
        '
        Me.ckbVuota.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ckbVuota.AutoSize = True
        Me.ckbVuota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbVuota.Location = New System.Drawing.Point(301, 282)
        Me.ckbVuota.Name = "ckbVuota"
        Me.ckbVuota.Size = New System.Drawing.Size(59, 20)
        Me.ckbVuota.TabIndex = 22
        Me.ckbVuota.Text = "Vuota"
        Me.ckbVuota.UseVisualStyleBackColor = True
        '
        'ckbFixed
        '
        Me.ckbFixed.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ckbFixed.AutoSize = True
        Me.ckbFixed.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbFixed.Location = New System.Drawing.Point(366, 282)
        Me.ckbFixed.Name = "ckbFixed"
        Me.ckbFixed.Size = New System.Drawing.Size(54, 20)
        Me.ckbFixed.TabIndex = 22
        Me.ckbFixed.Text = "Fixed"
        Me.ckbFixed.UseVisualStyleBackColor = True
        '
        'ckbFormazione
        '
        Me.ckbFormazione.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ckbFormazione.AutoSize = True
        Me.ckbFormazione.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbFormazione.Location = New System.Drawing.Point(426, 282)
        Me.ckbFormazione.Name = "ckbFormazione"
        Me.ckbFormazione.Size = New System.Drawing.Size(89, 20)
        Me.ckbFormazione.TabIndex = 22
        Me.ckbFormazione.Text = "Formazione"
        Me.ckbFormazione.UseVisualStyleBackColor = True
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCerca.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 12.0!)
        Me.btnCerca.Location = New System.Drawing.Point(581, 269)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(107, 40)
        Me.btnCerca.TabIndex = 23
        Me.btnCerca.Text = "Cerca"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'frmCommesse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 340)
        Me.Controls.Add(Me.btnCerca)
        Me.Controls.Add(Me.ckbFormazione)
        Me.Controls.Add(Me.ckbFixed)
        Me.Controls.Add(Me.ckbVuota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.dgvCommesse)
        Me.MinimumSize = New System.Drawing.Size(789, 379)
        Me.Name = "frmCommesse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCommesse"
        CType(Me.dgvCommesse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCommesse As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents ckbVuota As CheckBox
    Friend WithEvents ckbFixed As CheckBox
    Friend WithEvents ckbFormazione As CheckBox
    Friend WithEvents btnCerca As Button
End Class
