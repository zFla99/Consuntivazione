<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifica))
        Me.gboxNota = New System.Windows.Forms.GroupBox()
        Me.rdbFormazione = New System.Windows.Forms.RadioButton()
        Me.ckbAltro = New System.Windows.Forms.CheckBox()
        Me.ckbHome = New System.Windows.Forms.CheckBox()
        Me.rdbFixed = New System.Windows.Forms.RadioButton()
        Me.rdbVuota = New System.Windows.Forms.RadioButton()
        Me.rdbCriticita = New System.Windows.Forms.RadioButton()
        Me.gboxTempo = New System.Windows.Forms.GroupBox()
        Me.cmbTempo = New System.Windows.Forms.ComboBox()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.gboxData = New System.Windows.Forms.GroupBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.gboxCliente = New System.Windows.Forms.GroupBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.gboxNota.SuspendLayout()
        Me.gboxTempo.SuspendLayout()
        Me.gboxData.SuspendLayout()
        Me.gboxCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxNota
        '
        Me.gboxNota.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxNota.Controls.Add(Me.rdbFormazione)
        Me.gboxNota.Controls.Add(Me.ckbAltro)
        Me.gboxNota.Controls.Add(Me.ckbHome)
        Me.gboxNota.Controls.Add(Me.rdbFixed)
        Me.gboxNota.Controls.Add(Me.rdbVuota)
        Me.gboxNota.Controls.Add(Me.rdbCriticita)
        Me.gboxNota.Location = New System.Drawing.Point(765, 18)
        Me.gboxNota.Name = "gboxNota"
        Me.gboxNota.Size = New System.Drawing.Size(220, 120)
        Me.gboxNota.TabIndex = 1
        Me.gboxNota.TabStop = False
        '
        'rdbFormazione
        '
        Me.rdbFormazione.AutoSize = True
        Me.rdbFormazione.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFormazione.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbFormazione.Location = New System.Drawing.Point(16, 89)
        Me.rdbFormazione.Name = "rdbFormazione"
        Me.rdbFormazione.Size = New System.Drawing.Size(88, 20)
        Me.rdbFormazione.TabIndex = 14
        Me.rdbFormazione.Text = "Formazione"
        Me.rdbFormazione.UseVisualStyleBackColor = True
        '
        'ckbAltro
        '
        Me.ckbAltro.AutoSize = True
        Me.ckbAltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbAltro.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbAltro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckbAltro.Location = New System.Drawing.Point(144, 89)
        Me.ckbAltro.Name = "ckbAltro"
        Me.ckbAltro.Size = New System.Drawing.Size(54, 20)
        Me.ckbAltro.TabIndex = 13
        Me.ckbAltro.Text = "Altro"
        Me.ckbAltro.UseVisualStyleBackColor = True
        '
        'ckbHome
        '
        Me.ckbHome.AutoSize = True
        Me.ckbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbHome.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckbHome.Location = New System.Drawing.Point(144, 38)
        Me.ckbHome.Name = "ckbHome"
        Me.ckbHome.Size = New System.Drawing.Size(59, 20)
        Me.ckbHome.TabIndex = 13
        Me.ckbHome.Text = "Home"
        Me.ckbHome.UseVisualStyleBackColor = True
        '
        'rdbFixed
        '
        Me.rdbFixed.AutoSize = True
        Me.rdbFixed.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbFixed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbFixed.Location = New System.Drawing.Point(16, 63)
        Me.rdbFixed.Name = "rdbFixed"
        Me.rdbFixed.Size = New System.Drawing.Size(53, 20)
        Me.rdbFixed.TabIndex = 14
        Me.rdbFixed.Text = "Fixed"
        Me.rdbFixed.UseVisualStyleBackColor = True
        '
        'rdbVuota
        '
        Me.rdbVuota.AutoSize = True
        Me.rdbVuota.Checked = True
        Me.rdbVuota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbVuota.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbVuota.Location = New System.Drawing.Point(16, 11)
        Me.rdbVuota.Name = "rdbVuota"
        Me.rdbVuota.Size = New System.Drawing.Size(58, 20)
        Me.rdbVuota.TabIndex = 14
        Me.rdbVuota.TabStop = True
        Me.rdbVuota.Text = "Vuota"
        Me.rdbVuota.UseVisualStyleBackColor = True
        '
        'rdbCriticita
        '
        Me.rdbCriticita.AutoSize = True
        Me.rdbCriticita.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.rdbCriticita.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbCriticita.Location = New System.Drawing.Point(16, 37)
        Me.rdbCriticita.Name = "rdbCriticita"
        Me.rdbCriticita.Size = New System.Drawing.Size(70, 20)
        Me.rdbCriticita.TabIndex = 14
        Me.rdbCriticita.Text = "Criticità"
        Me.rdbCriticita.UseVisualStyleBackColor = True
        '
        'gboxTempo
        '
        Me.gboxTempo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxTempo.Controls.Add(Me.cmbTempo)
        Me.gboxTempo.Controls.Add(Me.lblTempo)
        Me.gboxTempo.Location = New System.Drawing.Point(264, 18)
        Me.gboxTempo.Name = "gboxTempo"
        Me.gboxTempo.Size = New System.Drawing.Size(220, 75)
        Me.gboxTempo.TabIndex = 2
        Me.gboxTempo.TabStop = False
        '
        'cmbTempo
        '
        Me.cmbTempo.AutoCompleteCustomSource.AddRange(New String() {"0,25", "0,5", "0,75", "1", "1,25", "1,5", "1,75", "2", "2,25", "2,5", "2,75", "3", "3,25", "3,5", "3,75", "4", "4,25", "4,5", "4,75", "5", "5,25", "5,5", "5,75", "6", "6,25", "6,5", "6,75", "7", "7,25", "7,5", "7,75", "8"})
        Me.cmbTempo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTempo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTempo.FormattingEnabled = True
        Me.cmbTempo.Location = New System.Drawing.Point(95, 29)
        Me.cmbTempo.MaxLength = 4
        Me.cmbTempo.Name = "cmbTempo"
        Me.cmbTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTempo.Size = New System.Drawing.Size(110, 21)
        Me.cmbTempo.TabIndex = 2
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempo.ForeColor = System.Drawing.Color.Black
        Me.lblTempo.Location = New System.Drawing.Point(20, 29)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempo.Size = New System.Drawing.Size(55, 20)
        Me.lblTempo.TabIndex = 17
        Me.lblTempo.Text = "Tempo"
        '
        'gboxData
        '
        Me.gboxData.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxData.Controls.Add(Me.lblData)
        Me.gboxData.Controls.Add(Me.dtpData)
        Me.gboxData.Location = New System.Drawing.Point(513, 18)
        Me.gboxData.Name = "gboxData"
        Me.gboxData.Size = New System.Drawing.Size(220, 75)
        Me.gboxData.TabIndex = 3
        Me.gboxData.TabStop = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Black
        Me.lblData.Location = New System.Drawing.Point(38, 29)
        Me.lblData.Name = "lblData"
        Me.lblData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblData.Size = New System.Drawing.Size(42, 20)
        Me.lblData.TabIndex = 16
        Me.lblData.Text = "Data"
        '
        'dtpData
        '
        Me.dtpData.CustomFormat = "dd/MM/yyyy"
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpData.Location = New System.Drawing.Point(103, 29)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(89, 20)
        Me.dtpData.TabIndex = 3
        '
        'gboxCliente
        '
        Me.gboxCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxCliente.Controls.Add(Me.lblCliente)
        Me.gboxCliente.Controls.Add(Me.cmbCliente)
        Me.gboxCliente.Location = New System.Drawing.Point(20, 18)
        Me.gboxCliente.Name = "gboxCliente"
        Me.gboxCliente.Size = New System.Drawing.Size(220, 75)
        Me.gboxCliente.TabIndex = 1
        Me.gboxCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCliente.Location = New System.Drawing.Point(19, 29)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 17
        Me.lblCliente.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.Location = New System.Drawing.Point(94, 29)
        Me.cmbCliente.MaxLength = 30
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCliente.Size = New System.Drawing.Size(110, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'btnModifica
        '
        Me.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModifica.Location = New System.Drawing.Point(37, 143)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(88, 25)
        Me.btnModifica.TabIndex = 4
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnnulla.Location = New System.Drawing.Point(141, 143)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(88, 25)
        Me.btnAnnulla.TabIndex = 5
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'frmModifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 191)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.gboxData)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.gboxTempo)
        Me.Controls.Add(Me.gboxCliente)
        Me.Controls.Add(Me.gboxNota)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(280, 230)
        Me.MinimumSize = New System.Drawing.Size(280, 230)
        Me.Name = "frmModifica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica"
        Me.gboxNota.ResumeLayout(False)
        Me.gboxNota.PerformLayout()
        Me.gboxTempo.ResumeLayout(False)
        Me.gboxTempo.PerformLayout()
        Me.gboxData.ResumeLayout(False)
        Me.gboxData.PerformLayout()
        Me.gboxCliente.ResumeLayout(False)
        Me.gboxCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboxNota As GroupBox
    Friend WithEvents rdbFormazione As RadioButton
    Friend WithEvents ckbHome As CheckBox
    Friend WithEvents rdbFixed As RadioButton
    Friend WithEvents rdbCriticita As RadioButton
    Friend WithEvents rdbVuota As RadioButton
    Friend WithEvents gboxTempo As GroupBox
    Friend WithEvents gboxData As GroupBox
    Friend WithEvents gboxCliente As GroupBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbTempo As ComboBox
    Friend WithEvents lblTempo As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents btnModifica As Button
    Friend WithEvents btnAnnulla As Button
    Friend WithEvents ckbAltro As CheckBox
End Class
