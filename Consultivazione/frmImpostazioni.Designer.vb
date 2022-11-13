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
        Me.ckbGiornoAttuale = New System.Windows.Forms.CheckBox()
        Me.ckbAggDettaglio = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancellaDB = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAggiornaDB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fbdPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdPath
        '
        Me.ofdPath.InitialDirectory = "Documents"
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnAnnulla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnnulla.Location = New System.Drawing.Point(43, 352)
        Me.btnAnnulla.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(207, 51)
        Me.btnAnnulla.TabIndex = 1
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = False
        '
        'btnApplica
        '
        Me.btnApplica.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnApplica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnApplica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnApplica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnApplica.Location = New System.Drawing.Point(451, 352)
        Me.btnApplica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplica.Name = "btnApplica"
        Me.btnApplica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnApplica.Size = New System.Drawing.Size(207, 51)
        Me.btnApplica.TabIndex = 15
        Me.btnApplica.Text = "Applica"
        Me.btnApplica.UseVisualStyleBackColor = False
        '
        'lblPathDB
        '
        Me.lblPathDB.AutoSize = True
        Me.lblPathDB.Font = New System.Drawing.Font("Segoe UI Historic", 8.0!)
        Me.lblPathDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPathDB.Location = New System.Drawing.Point(40, 44)
        Me.lblPathDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPathDB.Name = "lblPathDB"
        Me.lblPathDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPathDB.Size = New System.Drawing.Size(68, 21)
        Me.lblPathDB.TabIndex = 11
        Me.lblPathDB.Text = "Path DB:"
        '
        'txtPathDB
        '
        Me.txtPathDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPathDB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPathDB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.txtPathDB.Location = New System.Drawing.Point(141, 37)
        Me.txtPathDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPathDB.MaxLength = 1000
        Me.txtPathDB.Name = "txtPathDB"
        Me.txtPathDB.ReadOnly = True
        Me.txtPathDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPathDB.Size = New System.Drawing.Size(470, 30)
        Me.txtPathDB.TabIndex = 12
        '
        'lblOpenFolderDB
        '
        Me.lblOpenFolderDB.AutoSize = True
        Me.lblOpenFolderDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOpenFolderDB.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenFolderDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpenFolderDB.Location = New System.Drawing.Point(619, 34)
        Me.lblOpenFolderDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpenFolderDB.Name = "lblOpenFolderDB"
        Me.lblOpenFolderDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOpenFolderDB.Size = New System.Drawing.Size(38, 30)
        Me.lblOpenFolderDB.TabIndex = 1
        Me.lblOpenFolderDB.Text = "[x]"
        '
        'ckbGiornoAttuale
        '
        Me.ckbGiornoAttuale.AutoSize = True
        Me.ckbGiornoAttuale.Font = New System.Drawing.Font("Segoe UI Historic", 8.0!)
        Me.ckbGiornoAttuale.Location = New System.Drawing.Point(44, 39)
        Me.ckbGiornoAttuale.Name = "ckbGiornoAttuale"
        Me.ckbGiornoAttuale.Size = New System.Drawing.Size(274, 25)
        Me.ckbGiornoAttuale.TabIndex = 16
        Me.ckbGiornoAttuale.Text = "Reindirizzamento al giorno attuale"
        Me.ckbGiornoAttuale.UseVisualStyleBackColor = True
        '
        'ckbAggDettaglio
        '
        Me.ckbAggDettaglio.AutoSize = True
        Me.ckbAggDettaglio.Font = New System.Drawing.Font("Segoe UI Historic", 8.0!)
        Me.ckbAggDettaglio.Location = New System.Drawing.Point(44, 69)
        Me.ckbAggDettaglio.Name = "ckbAggDettaglio"
        Me.ckbAggDettaglio.Size = New System.Drawing.Size(349, 25)
        Me.ckbAggDettaglio.TabIndex = 16
        Me.ckbAggDettaglio.Text = "Aggornamento automatico del tab 'Dettaglio'"
        Me.ckbAggDettaglio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.Controls.Add(Me.ckbAggDettaglio)
        Me.GroupBox1.Controls.Add(Me.ckbGiornoAttuale)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 140)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aggiornamento automatico delle Grid"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancellaDB)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnAggiornaDB)
        Me.GroupBox2.Controls.Add(Me.lblOpenFolderDB)
        Me.GroupBox2.Controls.Add(Me.txtPathDB)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblPathDB)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 159)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DataBase"
        '
        'btnCancellaDB
        '
        Me.btnCancellaDB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancellaDB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancellaDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancellaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancellaDB.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnCancellaDB.ForeColor = System.Drawing.Color.Red
        Me.btnCancellaDB.Location = New System.Drawing.Point(472, 96)
        Me.btnCancellaDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancellaDB.Name = "btnCancellaDB"
        Me.btnCancellaDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancellaDB.Size = New System.Drawing.Size(139, 40)
        Me.btnCancellaDB.TabIndex = 21
        Me.btnCancellaDB.Text = "Cancella"
        Me.btnCancellaDB.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(372, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(92, 40)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cancella " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database:"
        '
        'btnAggiornaDB
        '
        Me.btnAggiornaDB.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAggiornaDB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAggiornaDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAggiornaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAggiornaDB.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!)
        Me.btnAggiornaDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAggiornaDB.Location = New System.Drawing.Point(141, 96)
        Me.btnAggiornaDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAggiornaDB.Name = "btnAggiornaDB"
        Me.btnAggiornaDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAggiornaDB.Size = New System.Drawing.Size(145, 40)
        Me.btnAggiornaDB.TabIndex = 19
        Me.btnAggiornaDB.Text = "Aggiorna"
        Me.btnAggiornaDB.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 8.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(40, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(78, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Aggiorna " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database:"
        '
        'frmImpostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 437)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnApplica)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(716, 493)
        Me.MinimumSize = New System.Drawing.Size(716, 493)
        Me.Name = "frmImpostazioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Impostazioni"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents btnAnnulla As Button
    Friend WithEvents btnApplica As Button
    Friend WithEvents lblPathDB As Label
    Friend WithEvents txtPathDB As TextBox
    Friend WithEvents lblOpenFolderDB As Label
    Friend WithEvents ckbGiornoAttuale As CheckBox
    Friend WithEvents ckbAggDettaglio As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancellaDB As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAggiornaDB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents fbdPath As FolderBrowserDialog
End Class
