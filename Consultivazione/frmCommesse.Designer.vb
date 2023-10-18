<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommesse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommesse))
        Me.dgvCommesse = New System.Windows.Forms.DataGridView()
        Me.txtCommesseHidden = New System.Windows.Forms.TextBox()
        CType(Me.dgvCommesse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCommesse
        '
        Me.dgvCommesse.AllowUserToAddRows = False
        Me.dgvCommesse.AllowUserToDeleteRows = False
        Me.dgvCommesse.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.dgvCommesse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCommesse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCommesse.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCommesse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCommesse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCommesse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCommesse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCommesse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCommesse.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCommesse.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCommesse.EnableHeadersVisualStyles = False
        Me.dgvCommesse.Location = New System.Drawing.Point(12, 12)
        Me.dgvCommesse.Name = "dgvCommesse"
        Me.dgvCommesse.ReadOnly = True
        Me.dgvCommesse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCommesse.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!)
        Me.dgvCommesse.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCommesse.RowTemplate.Height = 28
        Me.dgvCommesse.Size = New System.Drawing.Size(765, 276)
        Me.dgvCommesse.TabIndex = 19
        '
        'txtCommesseHidden
        '
        Me.txtCommesseHidden.Location = New System.Drawing.Point(338, 146)
        Me.txtCommesseHidden.Name = "txtCommesseHidden"
        Me.txtCommesseHidden.Size = New System.Drawing.Size(100, 20)
        Me.txtCommesseHidden.TabIndex = 20
        Me.txtCommesseHidden.Visible = False
        '
        'frmCommesse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 300)
        Me.Controls.Add(Me.dgvCommesse)
        Me.Controls.Add(Me.txtCommesseHidden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommesse"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Commesse"
        Me.TopMost = True
        CType(Me.dgvCommesse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCommesse As DataGridView
    Friend WithEvents txtCommesseHidden As TextBox
End Class
