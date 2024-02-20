<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificaCliente
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
        Me.lblInsCliente = New System.Windows.Forms.Label()
        Me.lblBordoCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnModifica = New System.Windows.Forms.Label()
        Me.lblBordoModifica = New System.Windows.Forms.Label()
        Me.lblBordoAnnulla = New System.Windows.Forms.Label()
        Me.btnAnnulla = New System.Windows.Forms.Label()
        Me.lblBordoElimina = New System.Windows.Forms.Label()
        Me.btnElimina = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInsCliente
        '
        Me.lblInsCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCliente.ForeColor = System.Drawing.Color.Black
        Me.lblInsCliente.Location = New System.Drawing.Point(35, 62)
        Me.lblInsCliente.Name = "lblInsCliente"
        Me.lblInsCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCliente.TabIndex = 76
        Me.lblInsCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCliente
        '
        Me.lblBordoCliente.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCliente.Location = New System.Drawing.Point(34, 61)
        Me.lblBordoCliente.Name = "lblBordoCliente"
        Me.lblBordoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCliente.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCliente.TabIndex = 69
        Me.lblBordoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCliente.Location = New System.Drawing.Point(41, 63)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(99, 21)
        Me.cmbCliente.TabIndex = 62
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(30, 39)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 61
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModifica
        '
        Me.btnModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifica.ForeColor = System.Drawing.Color.White
        Me.btnModifica.Location = New System.Drawing.Point(190, 26)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModifica.Size = New System.Drawing.Size(100, 25)
        Me.btnModifica.TabIndex = 98
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoModifica
        '
        Me.lblBordoModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblBordoModifica.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoModifica.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoModifica.Location = New System.Drawing.Point(189, 25)
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
        Me.lblBordoAnnulla.Location = New System.Drawing.Point(189, 61)
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
        Me.btnAnnulla.Location = New System.Drawing.Point(190, 62)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 25)
        Me.btnAnnulla.TabIndex = 99
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoElimina
        '
        Me.lblBordoElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBordoElimina.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoElimina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoElimina.Location = New System.Drawing.Point(189, 97)
        Me.lblBordoElimina.Name = "lblBordoElimina"
        Me.lblBordoElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoElimina.Size = New System.Drawing.Size(103, 27)
        Me.lblBordoElimina.TabIndex = 101
        Me.lblBordoElimina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnElimina
        '
        Me.btnElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnElimina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElimina.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElimina.ForeColor = System.Drawing.Color.White
        Me.btnElimina.Location = New System.Drawing.Point(190, 98)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnElimina.Size = New System.Drawing.Size(101, 25)
        Me.btnElimina.TabIndex = 100
        Me.btnElimina.Text = "Elimina"
        Me.btnElimina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmModificaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 154)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.lblBordoElimina)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.lblBordoAnnulla)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.lblBordoModifica)
        Me.Controls.Add(Me.lblInsCliente)
        Me.Controls.Add(Me.lblBordoCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModificaCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInsCliente As Label
    Friend WithEvents lblBordoCliente As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents btnModifica As Label
    Friend WithEvents lblBordoModifica As Label
    Friend WithEvents lblBordoAnnulla As Label
    Friend WithEvents btnAnnulla As Label
    Friend WithEvents lblBordoElimina As Label
    Friend WithEvents btnElimina As Label
End Class
