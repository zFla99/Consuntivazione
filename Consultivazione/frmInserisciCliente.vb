Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Public Class frmInserisciCliente
    ReadOnly strConn As String = frmConsuntivazione.strConn
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
    Private Sub cmbNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNota.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub disabilitaFreccie(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown, txtCodCliente.KeyDown, cmbNota.KeyDown, txtCommessa.KeyDown, txtSottoCommessa.KeyDown, txtFase.KeyDown, txtSottoFase.KeyDown
        If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmInserisciCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pulisciCampi()
        impostaConfig()

        arrotondaBordi()
        frmSfondoNero.Show()
        impostaLocation()
        txtCliente.Focus()
    End Sub
    Private Sub frmInserisciCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        pulisciCampi()
        frmSfondoNero.Close()
    End Sub
    Function controllaFormAttivo()
        If Me.Visible = False Then
            Return True
        End If

        Dim formAttivo As Boolean = False
        For Each control As Control In Me.Controls
            If control.ContainsFocus Then
                formAttivo = True
                Exit For
            End If
        Next
        Return formAttivo
    End Function
    Sub arrotondaBordi()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 15, 15))

        lblBordoCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoCliente.Width, lblBordoCliente.Height, 5, 5))
        lblInsCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsCliente.Width, lblInsCliente.Height, 5, 5))

        lblBordoCodCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoCodCliente.Width, lblBordoCodCliente.Height, 5, 5))
        lblInsCodCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsCodCliente.Width, lblInsCodCliente.Height, 5, 5))

        lblBordoNota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoNota.Width, lblBordoNota.Height, 5, 5))
        lblInsNota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsNota.Width, lblInsNota.Height, 5, 5))

        lblBordoCommessa.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoCommessa.Width, lblBordoCommessa.Height, 5, 5))
        lblInsCommessa.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsCommessa.Width, lblInsCommessa.Height, 5, 5))

        lblBordoSottoCommessa.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoSottoCommessa.Width, lblBordoSottoCommessa.Height, 5, 5))
        lblInsSottoCommessa.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsSottoCommessa.Width, lblInsSottoCommessa.Height, 5, 5))

        lblBordoFase.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoFase.Width, lblBordoFase.Height, 5, 5))
        lblInsFase.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsFase.Width, lblInsFase.Height, 5, 5))

        lblBordoSottoFase.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoSottoCommessa.Width, lblBordoSottoCommessa.Height, 5, 5))
        lblInsSottoFase.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsSottoCommessa.Width, lblInsSottoCommessa.Height, 5, 5))

        lblBordoInserisci.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoInserisci.Width, lblBordoInserisci.Height, 5, 5))
        btnInserisci.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnInserisci.Width, btnInserisci.Height, 5, 5))

        lblBordoAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoAnnulla.Width, lblBordoAnnulla.Height, 5, 5))
        btnAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAnnulla.Width, btnAnnulla.Height, 5, 5))

        lblBordoClientiCommesse.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoClientiCommesse.Width, lblBordoClientiCommesse.Height, 5, 5))
        btnClientiCommesse.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClientiCommesse.Width, btnClientiCommesse.Height, 5, 5))

    End Sub
    Sub impostaLocation()
        impostaSfondoNero()
        Dim locationY As Integer = frmConsuntivazione.Location.Y + 31
        Dim locationX As Integer = frmConsuntivazione.Location.X + 8
        locationY += frmConsuntivazione.pnlMensile.Location.Y + frmConsuntivazione.pnlDataGrid.Location.Y + frmConsuntivazione.dgvCalendario.Location.Y
        locationX += frmConsuntivazione.pnlMensile.Location.X + frmConsuntivazione.pnlDataGrid.Location.X + frmConsuntivazione.dgvCalendario.Location.X

        Me.Location = New Point(((frmConsuntivazione.dgvCalendario.Width - Me.Width) / 2) + locationX, ((frmConsuntivazione.dgvCalendario.Height - Me.Height) / 2) + locationY)
    End Sub
    Sub impostaSfondoNero()
        frmSfondoNero.Location = New Point(frmConsuntivazione.Location.X + 8, frmConsuntivazione.Location.Y + 31)
        frmSfondoNero.Size = New Size(frmConsuntivazione.Width - 16, frmConsuntivazione.Height - 39)
    End Sub
    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
    ReadOnly logConfig As String = frmConsuntivazione.logConfig
    Public logInsMassivTicket As String = frmConsuntivazione.logInsMassivTicket
    Public logInsMassivComm As String = frmConsuntivazione.logInsMassivComm
    Dim dataOraLog As String = ""
    Sub impostaConfig()
        Dim sr As New StreamReader(fileConfig)
        Dim appoggio As String = sr.ReadLine
        Dim selezionaModifica As String = ""

        Do
            If appoggio.StartsWith("[") Then
                selezionaModifica = appoggio.Replace("[", "")
                selezionaModifica = selezionaModifica.Replace("]", "")
                appoggio = sr.ReadLine()
            End If
            Dim index As Integer = appoggio.IndexOf("=") + 1
            Dim value As String = appoggio.Substring(index, appoggio.Length - index)
            If selezionaModifica = "ItemColor" Then
                If appoggio.Contains("Form_BackColor") Then
                    Me.BackColor = ColorTranslator.FromHtml(value)

                ElseIf appoggio.Contains("From_ForeColor") Then
                    lblCliente.ForeColor = ColorTranslator.FromHtml(value)
                    lblCodCliente.ForeColor = ColorTranslator.FromHtml(value)
                    lblNota.ForeColor = ColorTranslator.FromHtml(value)
                    lblCommessa.ForeColor = ColorTranslator.FromHtml(value)
                    lblSottCommessa.ForeColor = ColorTranslator.FromHtml(value)
                    lblFase.ForeColor = ColorTranslator.FromHtml(value)
                    lblSottFase.ForeColor = ColorTranslator.FromHtml(value)

                    rdbClienteConfig.ForeColor = ColorTranslator.FromHtml(value)
                    rdbCliente.ForeColor = ColorTranslator.FromHtml(value)
                    rdbConfig.ForeColor = ColorTranslator.FromHtml(value)
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Sub pulisciCampi()
        txtCliente.Text = ""
        txtCodCliente.Text = ""
        cmbNota.Text = ""
        txtCommessa.Text = ""
        txtSottoCommessa.Text = ""
        txtFase.Text = ""
        txtSottoFase.Text = ""
        rdbClienteConfig.Checked = True

        lblBordoCliente.BackColor = Color.Silver
        lblBordoCodCliente.BackColor = Color.Silver
        lblBordoNota.BackColor = Color.Silver
        lblBordoCommessa.BackColor = Color.Silver
        lblBordoSottoCommessa.BackColor = Color.Silver
    End Sub
    Private Sub txtCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtCodCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtCommessa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtSottoCommessa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtFase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub txtSottoFase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Dim corretto As Boolean
    Private Sub btnInserisci_Click(sender As Object, e As EventArgs) Handles btnInserisci.Click
        lblCliente.Focus()
        corretto = True
        If Not verificaDati() Then
            Exit Sub
        End If

        Dim cliente As String = txtCliente.Text.Replace("'", "").Trim
        Dim CodCliente As String = txtCodCliente.Text.Replace("'", "").Trim
        Dim nota As String = cmbNota.Text.Replace("'", "").Replace(",", "").Trim
        Dim commessa As String = txtCommessa.Text.Replace("'", "").Trim
        Dim SottoCommessa As String = txtSottoCommessa.Text.Replace("'", "").Trim
        Dim fase As String = txtFase.Text.Replace("'", "").Trim
        Dim SottoFase As String = txtSottoFase.Text.Replace("'", "").Trim

        Dim link As String
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti WHERE Cliente = '" & cliente & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logConfig, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log ConfigClienti:")
        End Using

        If btnInserisci.Text = "Inserisci Commessa" Then
            If tabella.Rows.Count = 0 Then
                Using logFile As New System.IO.StreamWriter(logConfig, True)
                    logFile.WriteLine(dataOraLog + "Il cliente '" & cliente & "' non esiste")
                    logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                End Using
                ToolTip1.Show("Questo cliente non esiste", lblInsCliente, -18, 30, 3000)
                lblBordoCliente.BackColor = Color.Red
                Exit Sub
            End If
        End If
        If btnInserisci.Text <> "Inserisci Commessa" Then
            If tabella.Rows.Count = 1 Then
                Using logFile As New System.IO.StreamWriter(logConfig, True)
                    logFile.WriteLine(dataOraLog + "Il cliente '" & cliente & "' esiste già")
                    logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                End Using
                ToolTip1.Show("Questo cliente esiste già.", lblInsCliente, -18, 30, 3000)
                lblBordoCliente.BackColor = Color.Red
                Exit Sub
            End If
        End If

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cliente & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim vetCommNota(tabella.Rows.Count) As String
        For i = 0 To tabella.Rows.Count - 1
            vetCommNota(i) = tabella.Rows(i).Item("Nota").ToString
        Next

        Using logFile As New System.IO.StreamWriter(logConfig, True)
            Dim conta As Integer = 0

            nota = cmbNota.Text.Trim.ToLower
            nota = cmbNota.Text.Replace("'", "")
            nota = cmbNota.Text.Replace(",", "")
            nota = StrConv(cmbNota.Text, VbStrConv.ProperCase)

            If nota.Length > 150 Then
                logFile.WriteLine(dataOraLog + "Nota '" & nota & "' non valida (Max 150 car.)")
                logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                logFile.Close()
                lblBordoNota.BackColor = Color.Red
                Exit Sub
            ElseIf nota.ToLower.Contains("criticità") Or nota.ToLower.Contains("extra") Then
                logFile.WriteLine(dataOraLog + "Nota '" & nota & "' non valida (non puoi inserire questa commessa)")
                logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                logFile.Close()
                lblBordoNota.BackColor = Color.Red
                Exit Sub
            End If

            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i).ToLower = nota.ToLower Then
                    conta += 1
                End If
            Next

            If conta > 0 Then
                logFile.WriteLine(dataOraLog + "La commessa '" & nota & "' è già presente per il cliente '" & cliente & "'")
                logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                logFile.Close()
                ToolTip1.Show("Questa commessa è gia presente per questo cliente", lblInsNota, -80, 30, 3000)
                lblBordoNota.BackColor = Color.Red
                Exit Sub
            End If
        End Using

        If btnInserisci.Text <> "Inserisci Commessa" Then
            inserisciCliente(cliente)
            If btnInserisci.Text = "Inserisci Cliente" Then
                MsgBox("Il cliente " & cliente & " è stato aggiunto!")
                pulisciCampi()
                Exit Sub
            End If
        End If

        link = "Cliente=" & CodCliente & "&Commessa=" & commessa & "&SottComm=" & SottoCommessa & "&Fase=" & fase & "&SottoFase=" & SottoFase
        inserisciConfig(cliente, nota, link)
        MsgBox("Il cliente " & cliente & " è la sua commessa è stato aggiunto!")

        pulisciCampi()
    End Sub
    Function verificaDati()
        If rdbCliente.Checked Then
            txtCliente.Text.Replace("'", "")
            If txtCliente.Text.Trim = "" Then
                lblBordoCliente.BackColor = Color.Red
            End If
            If lblBordoCliente.BackColor = Color.Red Then
                corretto = False
            End If
        Else
            txtCliente.Text.Replace("'", "")
            If txtCliente.Text.Trim = "" Then
                lblBordoCliente.BackColor = Color.Red
            End If
            txtCodCliente.Text.Replace("'", "")
            If txtCodCliente.Text.Trim = "" Then
                lblBordoCodCliente.BackColor = Color.Red
            End If
            txtCommessa.Text.Replace("'", "")
            If txtCommessa.Text.Trim = "" Then
                lblBordoCommessa.BackColor = Color.Red
            End If
            txtSottoCommessa.Text.Replace("'", "")
            If txtSottoCommessa.Text.Trim = "" Then
                lblBordoSottoCommessa.BackColor = Color.Red
            End If
            If lblBordoCliente.BackColor = Color.Red Or lblBordoCodCliente.BackColor = Color.Red Or lblBordoCommessa.BackColor = Color.Red Or lblBordoSottoCommessa.BackColor = Color.Red Then
                corretto = False
            End If
        End If
        Return corretto
    End Function

    Sub inserisciCliente(cliente As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        cn.Open()
            str = "INSERT into Clienti (Cliente) VALUES ('" & cliente & "')"
            cmd = New OleDbCommand(str, cn)
        Using logFile As New System.IO.StreamWriter(logConfig, True)
            Try
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore. Il cliente '" & cliente & "' non è stato inserito per questo motivo: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                inserito = False
                Exit Sub
            End Try
            cn.Close()
            logFile.WriteLine(dataOraLog + "Il cliente '" & cliente & "' è stato inserito.")
            logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
        End Using

        cn = New OleDbConnection(strConn)
            cn.Open()
            str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
            cmd = New OleDbCommand(str, cn)
            da = New OleDbDataAdapter(cmd)
            tabella.Clear()
            da.Fill(tabella)
            cn.Close()

            frmModifica.cmbCliente.Items.Clear()
        frmConsuntivazione.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
                frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next
    End Sub
    Sub inserisciConfig(cliente As String, nota As String, link As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        cn.Open()
        If nota = "" Then
            str = "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "',NULL,'" & link & "')"
        Else
            str = "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "','" & nota & "','" & link & "')"
        End If
        Using logFile As New System.IO.StreamWriter(logConfig, True)
            cmd = New OleDbCommand(str, cn)
            Try
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore. La commessa con [Cliente='" & cliente & "'] [Nota='" & If(nota <> "", nota, "NULL") & "'] [Link='" & link & "'] non è stata inserita: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - KO")
                logFile.Close()
                MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                cn.Close()
                Exit Sub
            End Try
            cn.Close()
            logFile.WriteLine(dataOraLog + "La commessa con [Cliente='" & cliente & "'] [Nota='" & If(nota <> "", nota, "NULL") & "'] [Link='" & link & "'] è stata inserita correttamente")
            logFile.WriteLine(dataOraLog + "Fine scrittura log ConfigClienti - OK")
        End Using
    End Sub
    Dim clientiDaInserire As String = ""
    Dim inserito As Boolean
    Dim rigaExcel As Integer = 0
    Dim errore As String = ""
    Sub InserisciMassivamente()
        Dim msgResult As MsgBoxResult = MsgBox("Vuoi scaricare il Template per l'inserimento massivo?", MsgBoxStyle.YesNoCancel)
        If msgResult = MsgBoxResult.Yes Then
            Call scaricaTemplate()
            Exit Sub
        ElseIf msgResult = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        ofdFile.ShowDialog()
        Dim filePath As String = ofdFile.FileName

        If filePath.EndsWith("Template_Commesse.xlsx") = False Then
            MsgBox("Seleziona il template scaricato", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim cnStr As String
        Dim cn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable

        cnStr = String.Format("Provider=Microsoft.Ace.Oledb.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filePath)
        cn = New OleDbConnection(cnStr)
        cn.Open()
        da = New OleDbDataAdapter("SELECT * FROM [Commesse$] WHERE CLIENTE IS NOT NULL AND 'COD.CLIENTE' IS NOT NULL AND COMMESSA IS NOT NULL AND 'SOTT.COMMESSA' IS NOT NULL", cn)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log InsMassivComm:")
            If tabella.Rows.Count = 0 Then
                logFile.WriteLine(dataOraLog + "Il template è vuoto")
                logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivComm - OK")
                logFile.Close()
                MsgBox("Il template è vuoto")
                Exit Sub
            End If
        End Using

        Dim cmd As OleDbCommand
        Dim str As String
        Dim tabellaClientiDB As New DataTable

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabellaClientiDB.Clear()
        da.Fill(tabellaClientiDB)
        cn.Close()

        Dim tabellaClientiExcel As New DataTable

        cn = New OleDbConnection(cnStr)
        cn.Open()
        da = New OleDbDataAdapter("SELECT DISTINCT CLIENTE FROM [Commesse$] WHERE CLIENTE IS NOT NULL", cn)
        tabellaClientiExcel.Clear()
        da.Fill(tabellaClientiExcel)
        cn.Close()

        Dim presente As Boolean = False
        For i = 0 To tabellaClientiExcel.Rows.Count - 1
            For j = 0 To tabellaClientiDB.Rows.Count - 1
                If tabellaClientiExcel.Rows(i).Item("CLIENTE") = tabellaClientiDB.Rows(j).Item("Cliente") Then
                    presente = True
                End If
            Next
            If presente = False Then
                clientiDaInserire += tabellaClientiExcel.Rows(i).Item("CLIENTE").ToString & ";"
                Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
                    logFile.WriteLine(dataOraLog + "Inizio inserimento clienti:")
                    logFile.WriteLine(dataOraLog + "Clienti da inserire: " & clientiDaInserire)
                End Using
            End If
        Next

        Call uploadTemplate(tabella)
        Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
            If inserito = False Then
                logFile.WriteLine(dataOraLog + "Importazione interrotta alla riga " & rigaExcel + 2 & " dell'Excel. " & errore)
                logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivComm - KO")
                logFile.Close()
                MsgBox("Importazione interrotta alla riga " & rigaExcel + 2 & " dell'Excel. " & errore, MsgBoxStyle.Critical)
                Exit Sub
            End If
            logFile.WriteLine(dataOraLog + "Le commesse sono state inserite correttamente")
            logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivComm - OK")
        End Using
        MsgBox("Le commesse sono state inserite correttamente", MsgBoxStyle.Information)
    End Sub
    Sub scaricaTemplate()
        Dim path As String = Application.StartupPath
        If path.EndsWith("Debug") Then
            path = path.Replace("bin\Debug", "Template\Template_Commesse.xlsx")
        Else
            path += "\Resources\Template\Template_Commesse.xlsx"
        End If
        Try
            My.Computer.FileSystem.CopyFile(path, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/Template_Commesse.xlsx")
        Catch ex As Exception
            MsgBox("Il template non è stato trasferito perche " + ex.Message, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        MsgBox("Il template è stato salvato sul Desktop con il nome di 'Template_Commesse'. Completalo e fai l'upload", MsgBoxStyle.Information)
    End Sub
    Sub uploadTemplate(tabellaExcel As DataTable)
        If clientiDaInserire <> "" Then
            clientiDaInserire = clientiDaInserire.Substring(0, clientiDaInserire.Length - 1)
            Dim vetClienti() As String = clientiDaInserire.Split(";")
            Call InserisciClienteMassivamente(vetClienti)
            If inserito = False And errore <> "" Then
                Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
                    logFile.WriteLine(dataOraLog + errore)
                    logFile.WriteLine(dataOraLog + "Fine scrittura log InsMassivComm - KO")
                End Using
                MsgBox(errore)
                rigaExcel = 0
                Exit Sub
            End If
        End If
        Call InserisciCommesseMassivamente(tabellaExcel)
    End Sub
    Sub InserisciClienteMassivamente(vetClienti() As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim nRighe As Integer
        Dim strSQL As String = ""


        For i = 0 To vetClienti.Length - 1
            strSQL += "INSERT into Clienti (Cliente) VALUES ('" & vetClienti(i) & "');"
        Next
        cn = New OleDbConnection(strConn)
        cn.Open()
        strSQL = strSQL.Substring(0, strSQL.Length - 1)
        Dim vetStrSQL() As String = strSQL.Split(";")
        For i = 0 To vetStrSQL.Length - 1
            cmd = New OleDbCommand(vetStrSQL(i), cn)
            Try
                nRighe = cmd.ExecuteNonQuery
            Catch ex As Exception
                cn.Close()
                errore = "Il cliente " & vetClienti(i) & " non è stato inserito correttamente. Codice errore: " & ex.Message
                inserito = False
                Exit Sub
            End Try
            Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
                logFile.WriteLine(dataOraLog & i + 1 & "/" & vetStrSQL.Length & "Inserito cliente: '" & vetClienti(i) & "'")
            End Using
        Next

        strSQL = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(strSQL, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        frmModifica.cmbCliente.Items.Clear()
        frmConsuntivazione.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
            frmModifica.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next
        inserito = True
    End Sub
    Sub InserisciCommesseMassivamente(tabellaExcel As DataTable)
        Dim cliente As String
        Dim CodCliente As String
        Dim commessa As String
        Dim SottoCommessa As String
        Dim fase As String
        Dim SottoFase As String
        Dim nota As String
        Dim link As String
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim nRighe As Integer
        Dim str As String
        Dim strSQL As String = ""
        Dim vetCommDaIns(tabellaExcel.Rows.Count) As String

        Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
            logFile.WriteLine(dataOraLog + "Inizio inserimento commesse")
        End Using

        For i = 0 To tabellaExcel.Rows.Count - 1
            inserito = False
            cliente = tabellaExcel.Rows(i).Item("CLIENTE").ToString
            nota = tabellaExcel.Rows(i).Item("NOTA").ToString
            CodCliente = tabellaExcel.Rows(i).Item("COD#CLIENTE").ToString
            commessa = tabellaExcel.Rows(i).Item("COMMESSA").ToString
            SottoCommessa = tabellaExcel.Rows(i).Item("SOTT#COMMESSA").ToString
            fase = tabellaExcel.Rows(i).Item("FASE").ToString
            SottoFase = tabellaExcel.Rows(i).Item("SOTT#FASE").ToString

            cn = New OleDbConnection(strConn)
            cn.Open()
            str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cliente & "'"
            cmd = New OleDbCommand(str, cn)
            da = New OleDbDataAdapter(cmd)
            tabella.Clear()
            da.Fill(tabella)
            cn.Close()

            Dim vetCommNota(tabella.Rows.Count) As String
            For j = 0 To tabella.Rows.Count - 1
                vetCommNota(j) = tabella.Rows(j).Item("Nota").ToString
            Next

            Dim conta As Integer = 0
            If nota.Contains("Criticità") Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa standard"
                    rigaExcel = i
                    Exit Sub
                End If
            ElseIf nota.Contains("Fixed") Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "Fixed" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa per il Bug Fix"
                    rigaExcel = i
                    Exit Sub
                End If
            ElseIf nota.Contains("Formazione") Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "Formazione" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa per la Formazione"
                    rigaExcel = i
                    Exit Sub
                End If
            ElseIf nota = "" Then
                For j = 0 To tabella.Rows.Count - 1
                    If vetCommNota(j) = "" Then
                        conta += 1
                    End If
                Next
                If conta <> 0 Then
                    errore = "Il cliente " & cliente & " ha già la commessa standard"
                    rigaExcel = i
                    Exit Sub
                End If
            End If
            link = "Cliente=" & CodCliente & "&Commessa=" & commessa & "&SottComm=" & SottoCommessa & "&Fase=" & fase & "&SottoFase=" & SottoFase
            If nota = "" Then
                strSQL += "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "',NULL,'" & link & "');"
            Else
                strSQL += "INSERT into LinkGR (Cliente, Nota, Link) VALUES ('" & cliente & "','" & nota & "','" & link & "');"
            End If
            vetCommDaIns(i) = "[Cliente: '" & cliente & "'] [Nota: '" & If(nota <> "", nota, "NULL") & "'] [Link: '" & link & "']"
        Next

        strSQL = strSQL.Substring(0, strSQL.Length - 1)
        Dim vetStrSQL() As String = strSQL.Split(";")

        cn = New OleDbConnection(strConn)
        cn.Open()
        For i = 0 To vetStrSQL.Length - 1
            cmd = New OleDbCommand(vetStrSQL(i), cn)
            Using logFile As New System.IO.StreamWriter(logInsMassivComm, True)
                Try
                    nRighe = cmd.ExecuteNonQuery
                Catch ex As Exception
                    logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                    logFile.Close()
                    MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                    cn.Close()
                    inserito = False
                    Exit Sub
                End Try
                logFile.WriteLine(dataOraLog & i + 1 & "/" & vetStrSQL.Length & "Inserita commessa: " & vetCommDaIns(i))
            End Using
        Next
        cn.Close()
        inserito = True
    End Sub
    Private Sub rdbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCliente.CheckedChanged
        If rdbCliente.Checked = True Then
            lblCodCliente.Enabled = False
            txtCodCliente.Enabled = False
            lblBordoCodCliente.BackColor = Color.Silver
            lblInsCodCliente.BackColor = lblBordoCodCliente.BackColor
            txtCodCliente.Text = ""
            lblInsCodCliente.Text = ""

            lblNota.Enabled = False
            cmbNota.Enabled = False
            lblBordoNota.BackColor = Color.Silver
            lblInsNota.BackColor = lblBordoNota.BackColor
            cmbNota.Text = ""
            lblInsNota.Text = ""

            gboxCommessa.Enabled = False
            lblBordoCommessa.BackColor = Color.Silver
            lblBordoSottoCommessa.BackColor = Color.Silver
            txtCommessa.Text = ""
            lblInsCommessa.BackColor = lblBordoCommessa.BackColor
            lblInsSottoCommessa.BackColor = lblBordoSottoCommessa.BackColor
            txtSottoCommessa.Text = ""
            lblInsFase.BackColor = lblBordoFase.BackColor
            txtFase.Text = ""
            lblInsSottoFase.BackColor = lblBordoSottoFase.BackColor
            txtSottoFase.Text = ""

            btnInserisci.Text = "Inserisci Cliente"
        End If
    End Sub

    Private Sub rdbClienteConfig_CheckedChanged(sender As Object, e As EventArgs) Handles rdbClienteConfig.CheckedChanged
        If rdbClienteConfig.Checked = True Then
            lblCodCliente.Enabled = True
            txtCodCliente.Enabled = True
            lblInsCodCliente.BackColor = Me.BackColor

            lblNota.Enabled = True
            cmbNota.Enabled = True
            lblInsNota.BackColor = Me.BackColor

            gboxCommessa.Enabled = True
            lblInsCommessa.BackColor = Me.BackColor
            lblInsSottoCommessa.BackColor = Me.BackColor
            lblInsFase.BackColor = Me.BackColor
            lblInsSottoFase.BackColor = Me.BackColor

            btnInserisci.Text = "Inserisci Cliente e Commessa"
        End If
    End Sub

    Private Sub rdbConfig_CheckedChanged(sender As Object, e As EventArgs) Handles rdbConfig.CheckedChanged
        If rdbConfig.Checked = True Then
            lblCodCliente.Enabled = True
            txtCodCliente.Enabled = True
            lblInsCodCliente.BackColor = Me.BackColor

            lblNota.Enabled = True
            cmbNota.Enabled = True
            lblInsNota.BackColor = Me.BackColor

            gboxCommessa.Enabled = True
            lblInsCommessa.BackColor = Me.BackColor
            lblInsSottoCommessa.BackColor = Me.BackColor
            lblInsFase.BackColor = Me.BackColor
            lblInsSottoFase.BackColor = Me.BackColor

            btnInserisci.Text = "Inserisci Commessa"
        End If
    End Sub
    Private Sub btnClienti_Click(sender As Object, e As EventArgs)
        frmClienti.ShowDialog()
    End Sub

    Private Sub btnCommesse_Click(sender As Object, e As EventArgs)
        frmCommesse.ShowDialog()
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub inviaModifiche_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown, txtCodCliente.KeyDown, cmbNota.KeyDown, txtCommessa.KeyDown, txtSottoCommessa.KeyDown, txtFase.KeyDown, txtSottoFase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnInserisci_Click(sender, e)
        End If
    End Sub

    Dim allLabels As New List(Of Label)
    Private Sub caricaLabels()
        allLabels.AddRange({lblInsCliente, lblInsCodCliente, lblInsNota, lblInsCommessa, lblInsSottoCommessa, lblInsFase, lblInsSottoFase})
    End Sub
    Private Sub lblInsCliente_Click(sender As Object, e As EventArgs) Handles lblInsCliente.Click
        txtCliente.Focus()
        lblInsCliente.Text = txtCliente.Text & "|"

        allLabels.Remove(lblInsCliente)
        RemovePipes(allLabels)
        allLabels.Add(lblInsCliente)
    End Sub
    Private Sub lblInsCodCliente_Click(sender As Object, e As EventArgs) Handles lblInsCodCliente.Click
        txtCodCliente.Focus()
        lblInsCodCliente.Text = txtCodCliente.Text & "|"

        allLabels.Remove(lblInsCodCliente)
        RemovePipes(allLabels)
        allLabels.Add(lblInsCodCliente)
    End Sub
    Private Sub lblInsNota_Click(sender As Object, e As EventArgs) Handles lblInsNota.Click
        cmbNota.Focus()
        lblInsNota.Text = cmbNota.Text & "|"

        allLabels.Remove(lblInsNota)
        RemovePipes(allLabels)
        allLabels.Add(lblInsNota)
    End Sub
    Private Sub lblInsCommessa_Click(sender As Object, e As EventArgs) Handles lblInsCommessa.Click
        txtCommessa.Focus()
        lblInsCommessa.Text = txtCommessa.Text & "|"

        allLabels.Remove(lblInsCommessa)
        RemovePipes(allLabels)
        allLabels.Add(lblInsCommessa)
    End Sub
    Private Sub lblInsSottoCommessa_Click(sender As Object, e As EventArgs) Handles lblInsSottoCommessa.Click
        txtSottoCommessa.Focus()
        lblInsSottoCommessa.Text = txtSottoCommessa.Text & "|"

        allLabels.Remove(lblInsSottoCommessa)
        RemovePipes(allLabels)
        allLabels.Add(lblInsSottoCommessa)
    End Sub
    Private Sub lblInsFase_Click(sender As Object, e As EventArgs) Handles lblInsFase.Click
        txtFase.Focus()
        lblInsFase.Text = txtFase.Text & "|"

        allLabels.Remove(lblInsFase)
        RemovePipes(allLabels)
        allLabels.Add(lblInsFase)
    End Sub
    Private Sub lblInsSottoFase_Click(sender As Object, e As EventArgs) Handles lblInsSottoFase.Click
        txtSottoFase.Focus()
        lblInsSottoFase.Text = txtSottoFase.Text & "|"

        allLabels.Remove(lblInsSottoFase)
        RemovePipes(allLabels)
        allLabels.Add(lblInsSottoFase)
    End Sub
    Private Sub txtInserimento_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged, txtCodCliente.TextChanged, cmbNota.TextChanged, txtCommessa.TextChanged, txtSottoCommessa.TextChanged, txtFase.TextChanged, txtSottoFase.TextChanged
        UpdateLabels()

        If txtCliente.Focused And Not txtCliente.Text.Contains("|") Then
            AddPipe(lblInsCliente)
            lblBordoCliente.BackColor = Color.Silver
        ElseIf txtCodCliente.Focused And Not txtCodCliente.Text.Contains("|") Then
            AddPipe(lblInsCodCliente)
            lblBordoCodCliente.BackColor = Color.Silver
        ElseIf cmbNota.Focused And Not cmbNota.Text.Contains("|") Then
            AddPipe(lblInsNota)
            lblBordoNota.BackColor = Color.Silver
        ElseIf txtCommessa.Focused And Not txtCommessa.Text.Contains("|") Then
            AddPipe(lblInsCommessa)
            lblBordoCommessa.BackColor = Color.Silver
        ElseIf txtSottoCommessa.Focused And Not txtSottoCommessa.Text.Contains("|") Then
            AddPipe(lblInsSottoCommessa)
            lblBordoSottoCommessa.BackColor = Color.Silver
        ElseIf txtSottoCommessa.Focused And Not txtSottoCommessa.Text.Contains("|") Then
            AddPipe(lblInsSottoCommessa)
            lblBordoSottoCommessa.BackColor = Color.Silver
        ElseIf txtFase.Focused And Not txtFase.Text.Contains("|") Then
            AddPipe(lblInsFase)
            lblBordoFase.BackColor = Color.Silver
        ElseIf txtSottoFase.Focused And Not txtSottoFase.Text.Contains("|") Then
            AddPipe(lblInsSottoFase)
            lblBordoSottoFase.BackColor = Color.Silver
        End If
    End Sub
    Private Sub txtInserimento_GotFocused(sender As Object, e As EventArgs) Handles txtCliente.GotFocus, txtCodCliente.GotFocus, cmbNota.GotFocus, txtCommessa.GotFocus, txtSottoCommessa.GotFocus, txtFase.GotFocus, txtSottoFase.GotFocus
        UpdateLabels()

        If txtCliente.Focused Then
            txtCliente.SelectionStart = txtCliente.Text.Length
            AddPipe(lblInsCliente)
            lblBordoCliente.BackColor = Color.Silver
        ElseIf txtCodCliente.Focused Then
            txtCodCliente.Text = ""
            txtCodCliente.SelectionStart = txtCodCliente.Text.Length
            AddPipe(lblInsCodCliente)
            lblBordoCodCliente.BackColor = Color.Silver
        ElseIf cmbNota.Focused Then
            cmbNota.SelectionStart = cmbNota.Text.Length
            AddPipe(lblInsNota)
            lblBordoNota.BackColor = Color.Silver
        ElseIf txtCommessa.Focused Then
            txtCommessa.SelectionStart = txtCommessa.Text.Length
            AddPipe(lblInsCommessa)
            lblBordoCommessa.BackColor = Color.Silver
        ElseIf txtSottoCommessa.Focused Then
            txtSottoCommessa.SelectionStart = txtSottoCommessa.Text.Length
            AddPipe(lblInsSottoCommessa)
            lblBordoSottoCommessa.BackColor = Color.Silver
        ElseIf txtSottoCommessa.Focused Then
            txtSottoCommessa.SelectionStart = txtSottoCommessa.Text.Length
            AddPipe(lblInsSottoCommessa)
            lblBordoSottoCommessa.BackColor = Color.Silver
        ElseIf txtFase.Focused Then
            txtFase.SelectionStart = txtFase.Text.Length
            AddPipe(lblInsFase)
            lblBordoFase.BackColor = Color.Silver
        ElseIf txtSottoFase.Focused Then
            txtSottoFase.SelectionStart = txtSottoFase.Text.Length
            AddPipe(lblInsSottoFase)
            lblBordoSottoFase.BackColor = Color.Silver
        End If
    End Sub
    Private Sub txtInserimento_LostFocus(sender As Object, e As EventArgs) Handles txtCliente.LostFocus, txtCodCliente.LostFocus, cmbNota.LostFocus, txtCommessa.LostFocus, txtSottoCommessa.LostFocus, txtFase.LostFocus, txtSottoFase.LostFocus
        If Not txtCliente.Focused And Not txtCodCliente.Focused And Not cmbNota.Focused And Not txtCommessa.Focused And Not txtSottoCommessa.Focused And Not txtFase.Focused And Not txtSottoFase.Focused Then
            RemovePipes(allLabels)
        End If

        If Not controllaFormAttivo() Then
            Me.Close()
        End If
    End Sub
    Private Sub txtCliente_LostFocus(sender As Object, e As EventArgs) Handles txtCliente.LostFocus
        txtCliente.Text.Replace("'", "")
        If txtCliente.Text.Trim = "" Then
            lblBordoCliente.BackColor = Color.Red
        End If
    End Sub
    Private Sub txtCodCliente_LostFocus(sender As Object, e As EventArgs) Handles txtCodCliente.LostFocus
        txtCodCliente.Text.Replace("'", "")
        If txtCodCliente.Text.Trim = "" Then
            lblBordoCodCliente.BackColor = Color.Red
        End If
    End Sub
    Private Sub txtCommessa_LostFocus(sender As Object, e As EventArgs) Handles txtCommessa.LostFocus
        txtCommessa.Text.Replace("'", "")
        If txtCommessa.Text.Trim = "" Then
            lblBordoCommessa.BackColor = Color.Red
        End If
    End Sub
    Private Sub txtSottoCommessa_LostFocus(sender As Object, e As EventArgs) Handles txtSottoCommessa.LostFocus
        txtSottoCommessa.Text.Replace("'", "")
        If txtSottoCommessa.Text.Trim = "" Then
            lblBordoSottoCommessa.BackColor = Color.Red
        End If
    End Sub
    Private Sub RemovePipes(ByVal labels As List(Of Label))
        ' Rimuove tutti i caratteri "|" dal testo delle etichette specificate.
        For Each label In labels
            label.Text = label.Text.Replace("|", "")
        Next label
    End Sub
    Private Sub UpdateLabels()
        lblInsCliente.Text = txtCliente.Text
        lblInsCodCliente.Text = txtCodCliente.Text
        lblInsNota.Text = cmbNota.Text
        lblInsCommessa.Text = txtCommessa.Text
        lblInsSottoCommessa.Text = txtSottoCommessa.Text
        lblInsFase.Text = txtFase.Text
        lblInsSottoFase.Text = txtSottoFase.Text
    End Sub
    Private Sub AddPipe(label As Label)
        ' Aggiunge un carattere "|" alla fine del testo dell'etichetta specificata.
        If Not label.Text.Contains("|") Then
            label.Text &= "|"
        End If
    End Sub

    Private Sub btnClientiCommesse_Click(sender As Object, e As EventArgs) Handles btnClientiCommesse.Click
        Me.Visible = False

        frmClienti.Show()
        frmClienti.Visible = False
        frmCommesse.Show()
        frmCommesse.Visible = False

        frmCommesse.Visible = True
        frmClienti.Visible = True
    End Sub
End Class