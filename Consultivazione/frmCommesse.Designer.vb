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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommesse))
        Me.dgvCommesse = New System.Windows.Forms.DataGridView()
        Me.lblCliente = New System.Windows.Forms.Label()
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
        'lblCliente
        '
        Me.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCliente.Location = New System.Drawing.Point(53, 280)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 21
        Me.lblCliente.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.cmbCliente.Location = New System.Drawing.Point(118, 277)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(110, 25)
        Me.cmbCliente.TabIndex = 1
        '
        'ckbVuota
        '
        Me.ckbVuota.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ckbVuota.AutoSize = True
        Me.ckbVuota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbVuota.Location = New System.Drawing.Point(301, 282)
        Me.ckbVuota.Name = "ckbVuota"
        Me.ckbVuota.Size = New System.Drawing.Size(59, 20)
        Me.ckbVuota.TabIndex = 3
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
        Me.ckbFixed.TabIndex = 3
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
        Me.ckbFormazione.TabIndex = 3
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
        Me.btnCerca.TabIndex = 2
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
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.dgvCommesse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(789, 379)
        Me.MinimumSize = New System.Drawing.Size(789, 379)
        Me.Name = "frmCommesse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Commesse"
        CType(Me.dgvCommesse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCommesse As DataGridView
    Friend WithEvents lblCliente As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents ckbVuota As CheckBox
    Friend WithEvents ckbFixed As CheckBox
    Friend WithEvents ckbFormazione As CheckBox
    Friend WithEvents btnCerca As Button
End Class
