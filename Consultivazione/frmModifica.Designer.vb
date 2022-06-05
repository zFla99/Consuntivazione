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
        Me.gboxNota = New System.Windows.Forms.GroupBox()
        Me.rdbFormazione = New System.Windows.Forms.RadioButton()
        Me.ckbHome = New System.Windows.Forms.CheckBox()
        Me.rdbFixed = New System.Windows.Forms.RadioButton()
        Me.rdbVuota = New System.Windows.Forms.RadioButton()
        Me.rdbCriticita = New System.Windows.Forms.RadioButton()
        Me.gboxTempo = New System.Windows.Forms.GroupBox()
        Me.cmbTempo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboxData = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.gboxCliente = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.gboxNota.Controls.Add(Me.ckbHome)
        Me.gboxNota.Controls.Add(Me.rdbFixed)
        Me.gboxNota.Controls.Add(Me.rdbVuota)
        Me.gboxNota.Controls.Add(Me.rdbCriticita)
        Me.gboxNota.Location = New System.Drawing.Point(765, 18)
        Me.gboxNota.Name = "gboxNota"
        Me.gboxNota.Size = New System.Drawing.Size(220, 120)
        Me.gboxNota.TabIndex = 16
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
        'ckbHome
        '
        Me.ckbHome.AutoSize = True
        Me.ckbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbHome.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.ckbHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckbHome.Location = New System.Drawing.Point(138, 64)
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
        Me.gboxTempo.Controls.Add(Me.Label2)
        Me.gboxTempo.Location = New System.Drawing.Point(264, 18)
        Me.gboxTempo.Name = "gboxTempo"
        Me.gboxTempo.Size = New System.Drawing.Size(220, 75)
        Me.gboxTempo.TabIndex = 16
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
        Me.cmbTempo.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tempo"
        '
        'gboxData
        '
        Me.gboxData.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxData.Controls.Add(Me.Label1)
        Me.gboxData.Controls.Add(Me.dtpData)
        Me.gboxData.Location = New System.Drawing.Point(513, 18)
        Me.gboxData.Name = "gboxData"
        Me.gboxData.Size = New System.Drawing.Size(220, 75)
        Me.gboxData.TabIndex = 16
        Me.gboxData.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data"
        '
        'dtpData
        '
        Me.dtpData.CustomFormat = "dd/MM/yyyy"
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpData.Location = New System.Drawing.Point(103, 29)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(89, 20)
        Me.dtpData.TabIndex = 17
        '
        'gboxCliente
        '
        Me.gboxCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboxCliente.Controls.Add(Me.Label3)
        Me.gboxCliente.Controls.Add(Me.cmbCliente)
        Me.gboxCliente.Location = New System.Drawing.Point(20, 18)
        Me.gboxCliente.Name = "gboxCliente"
        Me.gboxCliente.Size = New System.Drawing.Size(220, 75)
        Me.gboxCliente.TabIndex = 16
        Me.gboxCliente.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cliente"
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
        Me.cmbCliente.TabIndex = 16
        '
        'btnModifica
        '
        Me.btnModifica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModifica.Location = New System.Drawing.Point(37, 143)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(88, 25)
        Me.btnModifica.TabIndex = 1
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnnulla.Location = New System.Drawing.Point(141, 143)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(88, 25)
        Me.btnAnnulla.TabIndex = 2
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
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbTempo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents btnModifica As Button
    Friend WithEvents btnAnnulla As Button
End Class
