<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificaCommessa
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
        Me.gboxClienti = New System.Windows.Forms.GroupBox()
        Me.lblInsNota = New System.Windows.Forms.Label()
        Me.lblBordoNota = New System.Windows.Forms.Label()
        Me.cmbNota = New System.Windows.Forms.ComboBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblInsCodCliente = New System.Windows.Forms.Label()
        Me.lblBordoCodCliente = New System.Windows.Forms.Label()
        Me.lblCodCliente = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.lblInsCliente = New System.Windows.Forms.Label()
        Me.lblBordoCliente = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.gboxCommessa = New System.Windows.Forms.GroupBox()
        Me.lblInsSottoFase = New System.Windows.Forms.Label()
        Me.lblInsFase = New System.Windows.Forms.Label()
        Me.lblInsSottoCommessa = New System.Windows.Forms.Label()
        Me.lblInsCommessa = New System.Windows.Forms.Label()
        Me.lblSottFase = New System.Windows.Forms.Label()
        Me.lblBordoSottoFase = New System.Windows.Forms.Label()
        Me.lblFase = New System.Windows.Forms.Label()
        Me.lblBordoFase = New System.Windows.Forms.Label()
        Me.lblSottCommessa = New System.Windows.Forms.Label()
        Me.txtSottoFase = New System.Windows.Forms.TextBox()
        Me.lblBordoSottoCommessa = New System.Windows.Forms.Label()
        Me.txtFase = New System.Windows.Forms.TextBox()
        Me.txtSottoCommessa = New System.Windows.Forms.TextBox()
        Me.lblCommessa = New System.Windows.Forms.Label()
        Me.lblBordoCommessa = New System.Windows.Forms.Label()
        Me.txtCommessa = New System.Windows.Forms.TextBox()
        Me.btnElimina = New System.Windows.Forms.Label()
        Me.lblBordoElimina = New System.Windows.Forms.Label()
        Me.btnAnnulla = New System.Windows.Forms.Label()
        Me.lblBordoAnnulla = New System.Windows.Forms.Label()
        Me.btnModifica = New System.Windows.Forms.Label()
        Me.lblBordoModifica = New System.Windows.Forms.Label()
        Me.gboxClienti.SuspendLayout()
        Me.gboxCommessa.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxClienti
        '
        Me.gboxClienti.Controls.Add(Me.lblInsNota)
        Me.gboxClienti.Controls.Add(Me.lblBordoNota)
        Me.gboxClienti.Controls.Add(Me.cmbNota)
        Me.gboxClienti.Controls.Add(Me.lblNota)
        Me.gboxClienti.Controls.Add(Me.lblInsCodCliente)
        Me.gboxClienti.Controls.Add(Me.lblBordoCodCliente)
        Me.gboxClienti.Controls.Add(Me.lblCodCliente)
        Me.gboxClienti.Controls.Add(Me.txtCodCliente)
        Me.gboxClienti.Controls.Add(Me.lblInsCliente)
        Me.gboxClienti.Controls.Add(Me.lblBordoCliente)
        Me.gboxClienti.Controls.Add(Me.lblCliente)
        Me.gboxClienti.Controls.Add(Me.txtCliente)
        Me.gboxClienti.Location = New System.Drawing.Point(32, 22)
        Me.gboxClienti.Name = "gboxClienti"
        Me.gboxClienti.Size = New System.Drawing.Size(583, 109)
        Me.gboxClienti.TabIndex = 23
        Me.gboxClienti.TabStop = False
        '
        'lblInsNota
        '
        Me.lblInsNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsNota.ForeColor = System.Drawing.Color.Black
        Me.lblInsNota.Location = New System.Drawing.Point(418, 49)
        Me.lblInsNota.Name = "lblInsNota"
        Me.lblInsNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsNota.Size = New System.Drawing.Size(113, 25)
        Me.lblInsNota.TabIndex = 93
        Me.lblInsNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoNota
        '
        Me.lblBordoNota.BackColor = System.Drawing.Color.Silver
        Me.lblBordoNota.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoNota.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoNota.Location = New System.Drawing.Point(417, 48)
        Me.lblBordoNota.Name = "lblBordoNota"
        Me.lblBordoNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoNota.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoNota.TabIndex = 92
        Me.lblBordoNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbNota
        '
        Me.cmbNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNota.Items.AddRange(New Object() {"Fixed", "Formazione"})
        Me.cmbNota.Location = New System.Drawing.Point(432, 51)
        Me.cmbNota.MaxLength = 20
        Me.cmbNota.Name = "cmbNota"
        Me.cmbNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNota.Size = New System.Drawing.Size(83, 21)
        Me.cmbNota.Sorted = True
        Me.cmbNota.TabIndex = 3
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNota.Location = New System.Drawing.Point(413, 25)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(43, 20)
        Me.lblNota.TabIndex = 91
        Me.lblNota.Text = "Nota"
        Me.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsCodCliente
        '
        Me.lblInsCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCodCliente.ForeColor = System.Drawing.Color.Black
        Me.lblInsCodCliente.Location = New System.Drawing.Point(230, 48)
        Me.lblInsCodCliente.Name = "lblInsCodCliente"
        Me.lblInsCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCodCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCodCliente.TabIndex = 75
        Me.lblInsCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCodCliente
        '
        Me.lblBordoCodCliente.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCodCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCodCliente.Location = New System.Drawing.Point(229, 47)
        Me.lblBordoCodCliente.Name = "lblBordoCodCliente"
        Me.lblBordoCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCodCliente.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCodCliente.TabIndex = 76
        Me.lblBordoCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodCliente
        '
        Me.lblCodCliente.AutoSize = True
        Me.lblCodCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCodCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodCliente.Location = New System.Drawing.Point(225, 25)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.Size = New System.Drawing.Size(112, 20)
        Me.lblCodCliente.TabIndex = 73
        Me.lblCodCliente.Text = "Codice Cliente"
        Me.lblCodCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Location = New System.Drawing.Point(240, 50)
        Me.txtCodCliente.MaxLength = 10
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodCliente.Size = New System.Drawing.Size(93, 20)
        Me.txtCodCliente.TabIndex = 2
        '
        'lblInsCliente
        '
        Me.lblInsCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCliente.ForeColor = System.Drawing.Color.Black
        Me.lblInsCliente.Location = New System.Drawing.Point(40, 48)
        Me.lblInsCliente.Name = "lblInsCliente"
        Me.lblInsCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCliente.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCliente.TabIndex = 71
        Me.lblInsCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCliente
        '
        Me.lblBordoCliente.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCliente.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCliente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCliente.Location = New System.Drawing.Point(39, 47)
        Me.lblBordoCliente.Name = "lblBordoCliente"
        Me.lblBordoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCliente.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCliente.TabIndex = 72
        Me.lblBordoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(35, 25)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Location = New System.Drawing.Point(50, 50)
        Me.txtCliente.MaxLength = 10
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(93, 20)
        Me.txtCliente.TabIndex = 1
        '
        'gboxCommessa
        '
        Me.gboxCommessa.Controls.Add(Me.lblInsSottoFase)
        Me.gboxCommessa.Controls.Add(Me.lblInsFase)
        Me.gboxCommessa.Controls.Add(Me.lblInsSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblInsCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblSottFase)
        Me.gboxCommessa.Controls.Add(Me.lblBordoSottoFase)
        Me.gboxCommessa.Controls.Add(Me.lblFase)
        Me.gboxCommessa.Controls.Add(Me.lblBordoFase)
        Me.gboxCommessa.Controls.Add(Me.lblSottCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtSottoFase)
        Me.gboxCommessa.Controls.Add(Me.lblBordoSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtFase)
        Me.gboxCommessa.Controls.Add(Me.txtSottoCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblCommessa)
        Me.gboxCommessa.Controls.Add(Me.lblBordoCommessa)
        Me.gboxCommessa.Controls.Add(Me.txtCommessa)
        Me.gboxCommessa.Location = New System.Drawing.Point(32, 137)
        Me.gboxCommessa.Name = "gboxCommessa"
        Me.gboxCommessa.Size = New System.Drawing.Size(583, 128)
        Me.gboxCommessa.TabIndex = 24
        Me.gboxCommessa.TabStop = False
        '
        'lblInsSottoFase
        '
        Me.lblInsSottoFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsSottoFase.ForeColor = System.Drawing.Color.Black
        Me.lblInsSottoFase.Location = New System.Drawing.Point(406, 83)
        Me.lblInsSottoFase.Name = "lblInsSottoFase"
        Me.lblInsSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsSottoFase.Size = New System.Drawing.Size(113, 25)
        Me.lblInsSottoFase.TabIndex = 96
        Me.lblInsSottoFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsFase
        '
        Me.lblInsFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsFase.ForeColor = System.Drawing.Color.Black
        Me.lblInsFase.Location = New System.Drawing.Point(127, 83)
        Me.lblInsFase.Name = "lblInsFase"
        Me.lblInsFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsFase.Size = New System.Drawing.Size(113, 25)
        Me.lblInsFase.TabIndex = 96
        Me.lblInsFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsSottoCommessa
        '
        Me.lblInsSottoCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsSottoCommessa.ForeColor = System.Drawing.Color.Black
        Me.lblInsSottoCommessa.Location = New System.Drawing.Point(406, 25)
        Me.lblInsSottoCommessa.Name = "lblInsSottoCommessa"
        Me.lblInsSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsSottoCommessa.Size = New System.Drawing.Size(113, 25)
        Me.lblInsSottoCommessa.TabIndex = 96
        Me.lblInsSottoCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsCommessa
        '
        Me.lblInsCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsCommessa.ForeColor = System.Drawing.Color.Black
        Me.lblInsCommessa.Location = New System.Drawing.Point(127, 25)
        Me.lblInsCommessa.Name = "lblInsCommessa"
        Me.lblInsCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsCommessa.Size = New System.Drawing.Size(113, 25)
        Me.lblInsCommessa.TabIndex = 96
        Me.lblInsCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSottFase
        '
        Me.lblSottFase.AutoSize = True
        Me.lblSottFase.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblSottFase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSottFase.Location = New System.Drawing.Point(318, 85)
        Me.lblSottFase.Name = "lblSottFase"
        Me.lblSottFase.Size = New System.Drawing.Size(81, 20)
        Me.lblSottFase.TabIndex = 94
        Me.lblSottFase.Text = "Sotto Fase"
        Me.lblSottFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoSottoFase
        '
        Me.lblBordoSottoFase.BackColor = System.Drawing.Color.Silver
        Me.lblBordoSottoFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoSottoFase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoSottoFase.Location = New System.Drawing.Point(405, 82)
        Me.lblBordoSottoFase.Name = "lblBordoSottoFase"
        Me.lblBordoSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoSottoFase.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoSottoFase.TabIndex = 97
        Me.lblBordoSottoFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblFase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFase.Location = New System.Drawing.Point(83, 85)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(38, 20)
        Me.lblFase.TabIndex = 94
        Me.lblFase.Text = "Fase"
        Me.lblFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoFase
        '
        Me.lblBordoFase.BackColor = System.Drawing.Color.Silver
        Me.lblBordoFase.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoFase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoFase.Location = New System.Drawing.Point(126, 82)
        Me.lblBordoFase.Name = "lblBordoFase"
        Me.lblBordoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoFase.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoFase.TabIndex = 97
        Me.lblBordoFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSottCommessa
        '
        Me.lblSottCommessa.AutoSize = True
        Me.lblSottCommessa.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblSottCommessa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSottCommessa.Location = New System.Drawing.Point(271, 27)
        Me.lblSottCommessa.Name = "lblSottCommessa"
        Me.lblSottCommessa.Size = New System.Drawing.Size(128, 20)
        Me.lblSottCommessa.TabIndex = 94
        Me.lblSottCommessa.Text = "Sotto Commessa"
        Me.lblSottCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSottoFase
        '
        Me.txtSottoFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoFase.Location = New System.Drawing.Point(416, 85)
        Me.txtSottoFase.MaxLength = 10
        Me.txtSottoFase.Name = "txtSottoFase"
        Me.txtSottoFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoFase.Size = New System.Drawing.Size(93, 20)
        Me.txtSottoFase.TabIndex = 7
        '
        'lblBordoSottoCommessa
        '
        Me.lblBordoSottoCommessa.BackColor = System.Drawing.Color.Silver
        Me.lblBordoSottoCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoSottoCommessa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoSottoCommessa.Location = New System.Drawing.Point(405, 24)
        Me.lblBordoSottoCommessa.Name = "lblBordoSottoCommessa"
        Me.lblBordoSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoSottoCommessa.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoSottoCommessa.TabIndex = 97
        Me.lblBordoSottoCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFase
        '
        Me.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFase.Location = New System.Drawing.Point(137, 85)
        Me.txtFase.MaxLength = 10
        Me.txtFase.Name = "txtFase"
        Me.txtFase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFase.Size = New System.Drawing.Size(93, 20)
        Me.txtFase.TabIndex = 6
        '
        'txtSottoCommessa
        '
        Me.txtSottoCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSottoCommessa.Location = New System.Drawing.Point(416, 27)
        Me.txtSottoCommessa.MaxLength = 10
        Me.txtSottoCommessa.Name = "txtSottoCommessa"
        Me.txtSottoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSottoCommessa.Size = New System.Drawing.Size(93, 20)
        Me.txtSottoCommessa.TabIndex = 5
        '
        'lblCommessa
        '
        Me.lblCommessa.AutoSize = True
        Me.lblCommessa.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 11.0!)
        Me.lblCommessa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCommessa.Location = New System.Drawing.Point(35, 27)
        Me.lblCommessa.Name = "lblCommessa"
        Me.lblCommessa.Size = New System.Drawing.Size(85, 20)
        Me.lblCommessa.TabIndex = 94
        Me.lblCommessa.Text = "Commessa"
        Me.lblCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoCommessa
        '
        Me.lblBordoCommessa.BackColor = System.Drawing.Color.Silver
        Me.lblBordoCommessa.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoCommessa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoCommessa.Location = New System.Drawing.Point(126, 24)
        Me.lblBordoCommessa.Name = "lblBordoCommessa"
        Me.lblBordoCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoCommessa.Size = New System.Drawing.Size(115, 27)
        Me.lblBordoCommessa.TabIndex = 97
        Me.lblBordoCommessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCommessa
        '
        Me.txtCommessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommessa.Location = New System.Drawing.Point(137, 27)
        Me.txtCommessa.MaxLength = 10
        Me.txtCommessa.Name = "txtCommessa"
        Me.txtCommessa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommessa.Size = New System.Drawing.Size(93, 20)
        Me.txtCommessa.TabIndex = 4
        '
        'btnElimina
        '
        Me.btnElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnElimina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElimina.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElimina.ForeColor = System.Drawing.Color.White
        Me.btnElimina.Location = New System.Drawing.Point(493, 278)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnElimina.Size = New System.Drawing.Size(121, 30)
        Me.btnElimina.TabIndex = 104
        Me.btnElimina.Text = "Elimina"
        Me.btnElimina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoElimina
        '
        Me.lblBordoElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBordoElimina.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoElimina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoElimina.Location = New System.Drawing.Point(492, 277)
        Me.lblBordoElimina.Name = "lblBordoElimina"
        Me.lblBordoElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoElimina.Size = New System.Drawing.Size(123, 32)
        Me.lblBordoElimina.TabIndex = 105
        Me.lblBordoElimina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnnulla
        '
        Me.btnAnnulla.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.ForeColor = System.Drawing.Color.Black
        Me.btnAnnulla.Location = New System.Drawing.Point(165, 278)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnnulla.Size = New System.Drawing.Size(125, 30)
        Me.btnAnnulla.TabIndex = 103
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoAnnulla
        '
        Me.lblBordoAnnulla.BackColor = System.Drawing.Color.Silver
        Me.lblBordoAnnulla.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoAnnulla.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoAnnulla.Location = New System.Drawing.Point(164, 277)
        Me.lblBordoAnnulla.Name = "lblBordoAnnulla"
        Me.lblBordoAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoAnnulla.Size = New System.Drawing.Size(127, 32)
        Me.lblBordoAnnulla.TabIndex = 106
        Me.lblBordoAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModifica
        '
        Me.btnModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifica.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifica.ForeColor = System.Drawing.Color.White
        Me.btnModifica.Location = New System.Drawing.Point(33, 278)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModifica.Size = New System.Drawing.Size(124, 30)
        Me.btnModifica.TabIndex = 102
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBordoModifica
        '
        Me.lblBordoModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblBordoModifica.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBordoModifica.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBordoModifica.Location = New System.Drawing.Point(32, 277)
        Me.lblBordoModifica.Name = "lblBordoModifica"
        Me.lblBordoModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBordoModifica.Size = New System.Drawing.Size(126, 32)
        Me.lblBordoModifica.TabIndex = 107
        Me.lblBordoModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmModificaCommessa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 338)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.lblBordoElimina)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.lblBordoAnnulla)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.lblBordoModifica)
        Me.Controls.Add(Me.gboxClienti)
        Me.Controls.Add(Me.gboxCommessa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModificaCommessa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica"
        Me.TopMost = True
        Me.gboxClienti.ResumeLayout(False)
        Me.gboxClienti.PerformLayout()
        Me.gboxCommessa.ResumeLayout(False)
        Me.gboxCommessa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboxClienti As GroupBox
    Friend WithEvents lblInsNota As Label
    Friend WithEvents lblBordoNota As Label
    Friend WithEvents cmbNota As ComboBox
    Friend WithEvents lblNota As Label
    Friend WithEvents lblInsCodCliente As Label
    Friend WithEvents lblBordoCodCliente As Label
    Friend WithEvents lblCodCliente As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents lblInsCliente As Label
    Friend WithEvents lblBordoCliente As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents gboxCommessa As GroupBox
    Friend WithEvents lblInsSottoFase As Label
    Friend WithEvents lblInsFase As Label
    Friend WithEvents lblInsSottoCommessa As Label
    Friend WithEvents lblInsCommessa As Label
    Friend WithEvents lblSottFase As Label
    Friend WithEvents lblBordoSottoFase As Label
    Friend WithEvents lblFase As Label
    Friend WithEvents lblBordoFase As Label
    Friend WithEvents lblSottCommessa As Label
    Friend WithEvents txtSottoFase As TextBox
    Friend WithEvents lblBordoSottoCommessa As Label
    Friend WithEvents txtFase As TextBox
    Friend WithEvents txtSottoCommessa As TextBox
    Friend WithEvents lblCommessa As Label
    Friend WithEvents lblBordoCommessa As Label
    Friend WithEvents txtCommessa As TextBox
    Friend WithEvents btnElimina As Label
    Friend WithEvents lblBordoElimina As Label
    Friend WithEvents btnAnnulla As Label
    Friend WithEvents lblBordoAnnulla As Label
    Friend WithEvents btnModifica As Label
    Friend WithEvents lblBordoModifica As Label
End Class
