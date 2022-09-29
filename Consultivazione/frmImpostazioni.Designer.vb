<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImpostazioni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpostazioni))
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.btnApplica = New System.Windows.Forms.Button()
        Me.lblPathDB = New System.Windows.Forms.Label()
        Me.txtPathDB = New System.Windows.Forms.TextBox()
        Me.lblOpenFolderDB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ofdPath
        '
        Me.ofdPath.InitialDirectory = "Documents"
        '
        'btnAnnulla
        '
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnAnnulla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnnulla.Location = New System.Drawing.Point(33, 130)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(138, 33)
        Me.btnAnnulla.TabIndex = 1
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = False
        '
        'btnApplica
        '
        Me.btnApplica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnApplica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnApplica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnApplica.Location = New System.Drawing.Point(305, 130)
        Me.btnApplica.Name = "btnApplica"
        Me.btnApplica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnApplica.Size = New System.Drawing.Size(138, 33)
        Me.btnApplica.TabIndex = 15
        Me.btnApplica.Text = "Applica"
        Me.btnApplica.UseVisualStyleBackColor = False
        '
        'lblPathDB
        '
        Me.lblPathDB.AutoSize = True
        Me.lblPathDB.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPathDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPathDB.Location = New System.Drawing.Point(16, 33)
        Me.lblPathDB.Name = "lblPathDB"
        Me.lblPathDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPathDB.Size = New System.Drawing.Size(67, 20)
        Me.lblPathDB.TabIndex = 11
        Me.lblPathDB.Text = "Path DB:"
        '
        'txtPathDB
        '
        Me.txtPathDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPathDB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPathDB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.txtPathDB.Location = New System.Drawing.Point(112, 32)
        Me.txtPathDB.MaxLength = 1000
        Me.txtPathDB.Name = "txtPathDB"
        Me.txtPathDB.ReadOnly = True
        Me.txtPathDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPathDB.Size = New System.Drawing.Size(314, 23)
        Me.txtPathDB.TabIndex = 12
        '
        'lblOpenFolderDB
        '
        Me.lblOpenFolderDB.AutoSize = True
        Me.lblOpenFolderDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOpenFolderDB.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenFolderDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpenFolderDB.Location = New System.Drawing.Point(427, 33)
        Me.lblOpenFolderDB.Name = "lblOpenFolderDB"
        Me.lblOpenFolderDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOpenFolderDB.Size = New System.Drawing.Size(26, 20)
        Me.lblOpenFolderDB.TabIndex = 1
        Me.lblOpenFolderDB.Text = "[x]"
        '
        'frmImpostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 175)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnApplica)
        Me.Controls.Add(Me.lblOpenFolderDB)
        Me.Controls.Add(Me.txtPathDB)
        Me.Controls.Add(Me.lblPathDB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(485, 214)
        Me.MinimumSize = New System.Drawing.Size(485, 214)
        Me.Name = "frmImpostazioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Impostazioni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents btnAnnulla As Button
    Friend WithEvents btnApplica As Button
    Friend WithEvents lblPathDB As Label
    Friend WithEvents txtPathDB As TextBox
    Friend WithEvents lblOpenFolderDB As Label
End Class
