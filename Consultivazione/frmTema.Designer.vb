<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTema))
        Me.ColorDialogTema = New System.Windows.Forms.ColorDialog()
        Me.lblSfondoPannello = New System.Windows.Forms.Label()
        Me.lblTestoPannello = New System.Windows.Forms.Label()
        Me.lblSfondoForm = New System.Windows.Forms.Label()
        Me.lblTestoForm = New System.Windows.Forms.Label()
        Me.lblSfondoPannelloTesto = New System.Windows.Forms.Label()
        Me.lblTestoPannelloTesto = New System.Windows.Forms.Label()
        Me.lblSfondoFormTesto = New System.Windows.Forms.Label()
        Me.btnApplica = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.lblTestoFormTesto = New System.Windows.Forms.Label()
        Me.gboxColori = New System.Windows.Forms.GroupBox()
        Me.gboxIcone = New System.Windows.Forms.GroupBox()
        Me.rdbIconeNere = New System.Windows.Forms.RadioButton()
        Me.rdbIconeBianche = New System.Windows.Forms.RadioButton()
        Me.lblIconeNere = New System.Windows.Forms.Label()
        Me.lblIconeBianche = New System.Windows.Forms.Label()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.gboxColori.SuspendLayout()
        Me.gboxIcone.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorDialogTema
        '
        Me.ColorDialogTema.AnyColor = True
        Me.ColorDialogTema.FullOpen = True
        '
        'lblSfondoPannello
        '
        Me.lblSfondoPannello.BackColor = System.Drawing.Color.Black
        Me.lblSfondoPannello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSfondoPannello.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSfondoPannello.Location = New System.Drawing.Point(44, 23)
        Me.lblSfondoPannello.Name = "lblSfondoPannello"
        Me.lblSfondoPannello.Size = New System.Drawing.Size(72, 40)
        Me.lblSfondoPannello.TabIndex = 0
        '
        'lblTestoPannello
        '
        Me.lblTestoPannello.BackColor = System.Drawing.Color.Black
        Me.lblTestoPannello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTestoPannello.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTestoPannello.Location = New System.Drawing.Point(44, 152)
        Me.lblTestoPannello.Name = "lblTestoPannello"
        Me.lblTestoPannello.Size = New System.Drawing.Size(72, 40)
        Me.lblTestoPannello.TabIndex = 0
        '
        'lblSfondoForm
        '
        Me.lblSfondoForm.BackColor = System.Drawing.Color.Black
        Me.lblSfondoForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSfondoForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSfondoForm.Location = New System.Drawing.Point(248, 23)
        Me.lblSfondoForm.Name = "lblSfondoForm"
        Me.lblSfondoForm.Size = New System.Drawing.Size(72, 40)
        Me.lblSfondoForm.TabIndex = 0
        '
        'lblTestoForm
        '
        Me.lblTestoForm.BackColor = System.Drawing.Color.Black
        Me.lblTestoForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTestoForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTestoForm.Location = New System.Drawing.Point(248, 152)
        Me.lblTestoForm.Name = "lblTestoForm"
        Me.lblTestoForm.Size = New System.Drawing.Size(72, 40)
        Me.lblTestoForm.TabIndex = 0
        '
        'lblSfondoPannelloTesto
        '
        Me.lblSfondoPannelloTesto.AutoSize = True
        Me.lblSfondoPannelloTesto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfondoPannelloTesto.ForeColor = System.Drawing.Color.Black
        Me.lblSfondoPannelloTesto.Location = New System.Drawing.Point(19, 65)
        Me.lblSfondoPannelloTesto.Name = "lblSfondoPannelloTesto"
        Me.lblSfondoPannelloTesto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSfondoPannelloTesto.Size = New System.Drawing.Size(122, 40)
        Me.lblSfondoPannelloTesto.TabIndex = 11
        Me.lblSfondoPannelloTesto.Text = "Sfondo Pannello" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inserimento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSfondoPannelloTesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTestoPannelloTesto
        '
        Me.lblTestoPannelloTesto.AutoSize = True
        Me.lblTestoPannelloTesto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestoPannelloTesto.ForeColor = System.Drawing.Color.Black
        Me.lblTestoPannelloTesto.Location = New System.Drawing.Point(25, 194)
        Me.lblTestoPannelloTesto.Name = "lblTestoPannelloTesto"
        Me.lblTestoPannelloTesto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTestoPannelloTesto.Size = New System.Drawing.Size(113, 40)
        Me.lblTestoPannelloTesto.TabIndex = 11
        Me.lblTestoPannelloTesto.Text = "Testo Pannello " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inserimento"
        Me.lblTestoPannelloTesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSfondoFormTesto
        '
        Me.lblSfondoFormTesto.AutoSize = True
        Me.lblSfondoFormTesto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfondoFormTesto.ForeColor = System.Drawing.Color.Black
        Me.lblSfondoFormTesto.Location = New System.Drawing.Point(234, 65)
        Me.lblSfondoFormTesto.Name = "lblSfondoFormTesto"
        Me.lblSfondoFormTesto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSfondoFormTesto.Size = New System.Drawing.Size(98, 20)
        Me.lblSfondoFormTesto.TabIndex = 11
        Me.lblSfondoFormTesto.Text = "Sfondo Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSfondoFormTesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnApplica
        '
        Me.btnApplica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnApplica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnApplica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnApplica.Location = New System.Drawing.Point(453, 269)
        Me.btnApplica.Name = "btnApplica"
        Me.btnApplica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnApplica.Size = New System.Drawing.Size(138, 33)
        Me.btnApplica.TabIndex = 12
        Me.btnApplica.Text = "Applica"
        Me.btnApplica.UseVisualStyleBackColor = False
        '
        'btnAnnulla
        '
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnAnnulla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnnulla.Location = New System.Drawing.Point(43, 269)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(138, 33)
        Me.btnAnnulla.TabIndex = 12
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = False
        '
        'lblTestoFormTesto
        '
        Me.lblTestoFormTesto.AutoSize = True
        Me.lblTestoFormTesto.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestoFormTesto.ForeColor = System.Drawing.Color.Black
        Me.lblTestoFormTesto.Location = New System.Drawing.Point(240, 194)
        Me.lblTestoFormTesto.Name = "lblTestoFormTesto"
        Me.lblTestoFormTesto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTestoFormTesto.Size = New System.Drawing.Size(85, 20)
        Me.lblTestoFormTesto.TabIndex = 13
        Me.lblTestoFormTesto.Text = "Testo Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTestoFormTesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboxColori
        '
        Me.gboxColori.Controls.Add(Me.lblTestoFormTesto)
        Me.gboxColori.Controls.Add(Me.lblSfondoFormTesto)
        Me.gboxColori.Controls.Add(Me.lblSfondoPannelloTesto)
        Me.gboxColori.Controls.Add(Me.lblTestoPannelloTesto)
        Me.gboxColori.Controls.Add(Me.lblTestoForm)
        Me.gboxColori.Controls.Add(Me.lblTestoPannello)
        Me.gboxColori.Controls.Add(Me.lblSfondoForm)
        Me.gboxColori.Controls.Add(Me.lblSfondoPannello)
        Me.gboxColori.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.gboxColori.Location = New System.Drawing.Point(20, 7)
        Me.gboxColori.Name = "gboxColori"
        Me.gboxColori.Size = New System.Drawing.Size(364, 248)
        Me.gboxColori.TabIndex = 0
        Me.gboxColori.TabStop = False
        Me.gboxColori.Text = "Colori"
        '
        'gboxIcone
        '
        Me.gboxIcone.Controls.Add(Me.rdbIconeNere)
        Me.gboxIcone.Controls.Add(Me.rdbIconeBianche)
        Me.gboxIcone.Controls.Add(Me.lblIconeNere)
        Me.gboxIcone.Controls.Add(Me.lblIconeBianche)
        Me.gboxIcone.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.gboxIcone.Location = New System.Drawing.Point(399, 7)
        Me.gboxIcone.Name = "gboxIcone"
        Me.gboxIcone.Size = New System.Drawing.Size(214, 248)
        Me.gboxIcone.TabIndex = 13
        Me.gboxIcone.TabStop = False
        Me.gboxIcone.Text = "Icone"
        '
        'rdbIconeNere
        '
        Me.rdbIconeNere.AutoSize = True
        Me.rdbIconeNere.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbIconeNere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbIconeNere.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.rdbIconeNere.Location = New System.Drawing.Point(133, 137)
        Me.rdbIconeNere.Name = "rdbIconeNere"
        Me.rdbIconeNere.Size = New System.Drawing.Size(46, 37)
        Me.rdbIconeNere.TabIndex = 13
        Me.rdbIconeNere.Text = "Nere"
        Me.rdbIconeNere.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbIconeNere.UseVisualStyleBackColor = True
        '
        'rdbIconeBianche
        '
        Me.rdbIconeBianche.AutoSize = True
        Me.rdbIconeBianche.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbIconeBianche.Checked = True
        Me.rdbIconeBianche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbIconeBianche.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.rdbIconeBianche.Location = New System.Drawing.Point(19, 137)
        Me.rdbIconeBianche.Name = "rdbIconeBianche"
        Me.rdbIconeBianche.Size = New System.Drawing.Size(68, 37)
        Me.rdbIconeBianche.TabIndex = 12
        Me.rdbIconeBianche.TabStop = True
        Me.rdbIconeBianche.Text = "Bianche"
        Me.rdbIconeBianche.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbIconeBianche.UseVisualStyleBackColor = True
        '
        'lblIconeNere
        '
        Me.lblIconeNere.BackColor = System.Drawing.Color.Transparent
        Me.lblIconeNere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconeNere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIconeNere.Image = Global.Consuntivazione.My.Resources.Resources.pennello_32x32_nero
        Me.lblIconeNere.Location = New System.Drawing.Point(120, 80)
        Me.lblIconeNere.Name = "lblIconeNere"
        Me.lblIconeNere.Size = New System.Drawing.Size(72, 55)
        Me.lblIconeNere.TabIndex = 0
        '
        'lblIconeBianche
        '
        Me.lblIconeBianche.BackColor = System.Drawing.Color.Black
        Me.lblIconeBianche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIconeBianche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIconeBianche.Image = Global.Consuntivazione.My.Resources.Resources.pennello_32x32_bianco
        Me.lblIconeBianche.Location = New System.Drawing.Point(18, 80)
        Me.lblIconeBianche.Name = "lblIconeBianche"
        Me.lblIconeBianche.Size = New System.Drawing.Size(72, 55)
        Me.lblIconeBianche.TabIndex = 0
        '
        'btnDefault
        '
        Me.btnDefault.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefault.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDefault.Location = New System.Drawing.Point(364, 269)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDefault.Size = New System.Drawing.Size(83, 33)
        Me.btnDefault.TabIndex = 12
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = False
        '
        'frmTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(629, 321)
        Me.Controls.Add(Me.gboxIcone)
        Me.Controls.Add(Me.gboxColori)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnApplica)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(645, 360)
        Me.MinimumSize = New System.Drawing.Size(645, 360)
        Me.Name = "frmTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tema"
        Me.gboxColori.ResumeLayout(False)
        Me.gboxColori.PerformLayout()
        Me.gboxIcone.ResumeLayout(False)
        Me.gboxIcone.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialogTema As ColorDialog
    Friend WithEvents lblSfondoPannello As Label
    Friend WithEvents lblTestoPannello As Label
    Friend WithEvents lblSfondoForm As Label
    Friend WithEvents lblTestoForm As Label
    Friend WithEvents lblSfondoPannelloTesto As Label
    Friend WithEvents lblTestoPannelloTesto As Label
    Friend WithEvents lblSfondoFormTesto As Label
    Friend WithEvents btnApplica As Button
    Friend WithEvents btnAnnulla As Button
    Friend WithEvents lblTestoFormTesto As Label
    Friend WithEvents gboxColori As GroupBox
    Friend WithEvents gboxIcone As GroupBox
    Friend WithEvents lblIconeNere As Label
    Friend WithEvents lblIconeBianche As Label
    Friend WithEvents rdbIconeNere As RadioButton
    Friend WithEvents rdbIconeBianche As RadioButton
    Friend WithEvents btnDefault As Button
End Class
