<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMessaggio
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
        Me.lblMessaggio = New System.Windows.Forms.Label()
        Me.btnAnnulla = New System.Windows.Forms.Label()
        Me.lblBordoAnnulla = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Label()
        Me.lblBordoNo = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Label()
        Me.lblBordoSi = New System.Windows.Forms.Label()
        Me.txtHidden = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMessaggio
        '
        Me.lblMessaggio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMessaggio.AutoSize = True
        Me.lblMessaggio.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblMessaggio.Location = New System.Drawing.Point(32, 35)
        Me.lblMessaggio.MaximumSize = New System.Drawing.Size(313, 100)
        Me.lblMessaggio.MinimumSize = New System.Drawing.Size(313, 20)
        Me.lblMessaggio.Name = "lblMessaggio"
        Me.lblMessaggio.Size = New System.Drawing.Size(313, 20)
        Me.lblMessaggio.TabIndex = 0
        Me.lblMessaggio.Text = "Messaggio"
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.ForeColor = System.Drawing.Color.Black
        Me.btnAnnulla.Location = New System.Drawing.Point(245, 89)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 25)
        Me.btnAnnulla.TabIndex = 103
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoAnnulla
        '
        Me.lblBordoAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBordoAnnulla.BackColor = System.Drawing.Color.Silver
        Me.lblBordoAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoAnnulla.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoAnnulla.Location = New System.Drawing.Point(244, 88)
        Me.lblBordoAnnulla.Name = "lblBordoAnnulla"
        Me.lblBordoAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoAnnulla.Size = New System.Drawing.Size(102, 27)
        Me.lblBordoAnnulla.TabIndex = 104
        Me.lblBordoAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNo
        '
        Me.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.Location = New System.Drawing.Point(137, 89)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNo.Size = New System.Drawing.Size(101, 25)
        Me.btnNo.TabIndex = 106
        Me.btnNo.Text = "No"
        Me.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoNo
        '
        Me.lblBordoNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBordoNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBordoNo.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoNo.Location = New System.Drawing.Point(136, 88)
        Me.lblBordoNo.Name = "lblBordoNo"
        Me.lblBordoNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoNo.Size = New System.Drawing.Size(103, 27)
        Me.lblBordoNo.TabIndex = 107
        Me.lblBordoNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSi
        '
        Me.btnSi.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSi.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSi.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.ForeColor = System.Drawing.Color.White
        Me.btnSi.Location = New System.Drawing.Point(30, 89)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSi.Size = New System.Drawing.Size(100, 25)
        Me.btnSi.TabIndex = 2
        Me.btnSi.Text = "Si"
        Me.btnSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoSi
        '
        Me.lblBordoSi.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblBordoSi.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblBordoSi.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoSi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoSi.Location = New System.Drawing.Point(29, 88)
        Me.lblBordoSi.Name = "lblBordoSi"
        Me.lblBordoSi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoSi.Size = New System.Drawing.Size(102, 27)
        Me.lblBordoSi.TabIndex = 108
        Me.lblBordoSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHidden
        '
        Me.txtHidden.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHidden.Location = New System.Drawing.Point(36, 35)
        Me.txtHidden.Margin = New System.Windows.Forms.Padding(0)
        Me.txtHidden.Name = "txtHidden"
        Me.txtHidden.Size = New System.Drawing.Size(100, 20)
        Me.txtHidden.TabIndex = 1
        '
        'frmMessaggio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 150)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblBordoNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.lblBordoSi)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.lblBordoAnnulla)
        Me.Controls.Add(Me.lblMessaggio)
        Me.Controls.Add(Me.txtHidden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(375, 150)
        Me.Name = "frmMessaggio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Messaggio"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessaggio As Label
    Friend WithEvents btnAnnulla As Label
    Friend WithEvents lblBordoAnnulla As Label
    Friend WithEvents btnNo As Label
    Friend WithEvents lblBordoNo As Label
    Friend WithEvents btnSi As Label
    Friend WithEvents lblBordoSi As Label
    Friend WithEvents txtHidden As TextBox
End Class
