Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class frmModifica
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
    Private Sub txtTicket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTicket.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46))) AndAlso e.KeyChar <> "/" AndAlso e.KeyChar <> "C" AndAlso e.KeyChar <> "c") Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempo.KeyPress, txtExtra.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If

        If txtTempo.Focused And e.KeyChar <> vbBack Then
            If txtTempo.Text.Length >= 5 Then
                e.Handled = True
                Exit Sub
            End If
        ElseIf e.KeyChar <> vbBack Then
            If txtExtra.Text.Length >= 5 Then
                e.Handled = True
                Exit Sub
            End If
        End If

        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46))) AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            If txtTempo.Focused Then
                If txtTempo.Text.Contains(",") Or txtTempo.SelectionStart = 0 Then
                    e.Handled = True
                End If
            Else
                If txtExtra.Text.Contains(",") Or txtExtra.SelectionStart = 0 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    Private Sub cmbNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNota.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub disabilitaFreccie(sender As Object, e As KeyEventArgs) Handles txtTicket.KeyDown, cmbCliente.KeyDown, txtTempo.KeyDown, txtExtra.KeyDown, cmbNota.KeyDown
        If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down Then
            e.Handled = True
        End If
    End Sub

    Dim tabellaDB As String
    Dim colonna As String
    Dim c As Integer
    Dim riga As Integer
    Dim nota As String
    Dim id As String
    ReadOnly strConn As String = frmConsuntivazione.strConn
    ReadOnly logModifica As String = frmConsuntivazione.logModifica
    Dim dataOraLog As String = frmConsuntivazione.dataOraLog
    Dim consuntivato As Boolean
    Private Sub Modifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabellaDB = frmConsuntivazione.tabellaCondivisa
        riga = frmConsuntivazione.rigaCondivisa
        If tabellaDB <> "LinkGR" Then
            nota = frmConsuntivazione.dgvCalendario.Rows(riga).Cells(6).Value
        End If

        impostaConfig()
        PulisciCampi()

        impostaTab()
        arrotondaBordi()
        caricaValori()
    End Sub
    Sub controllaFormAttivo()
        Dim formAttivo As Boolean = False
        For Each control As Control In Me.Controls
            If control.ContainsFocus Then
                formAttivo = True
                Exit For
            End If
        Next

        If Not formAttivo Then
            Me.Close()
        End If
    End Sub
    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
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
                    lblTempo.ForeColor = ColorTranslator.FromHtml(value)
                    lblData.ForeColor = ColorTranslator.FromHtml(value)

                    ckbHome.ForeColor = ColorTranslator.FromHtml(value)
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Private Sub frmModifica_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If corretto = False Then
            frmConsuntivazione.annulla = True
        End If
        PulisciCampi()
        frmSfondoNero.Close()
    End Sub

    Sub PulisciCampi()
        txtTicket.Text = ""
        cmbCliente.Text = ""
        dtpData.Value = Now
        txtTempo.Text = ""
        txtExtra.Text = ""
        cmbNota.Text = ""
        ckbHome.Checked = False

        txtTempo.Mask = ""
        txtTempo.ValidatingType = GetType(System.Double)
        txtExtra.Mask = ""
        txtExtra.ValidatingType = GetType(System.Double)
    End Sub

    Sub impostaTabModifica()
        Me.Width = 280

        If colonna = "TEMPO" Then
            colonna += "_RISOLUZIONE"
        End If

        Select Case colonna
            Case "CLIENTE"
                TabIndex = 1
                cmbCliente.Text = ""
                cmbCliente.Focus()
                c = 2

            Case "TEMPO_RISOLUZIONE"
                TabIndex = 2
                txtTempo.Text = ""
                txtTempo.Focus()
                c = 3

            Case "DATA"
                TabIndex = 3
                dtpData.Focus()
                c = 4

            Case "NOTA"
                If tabellaDB = "LinkGR" Then
                    ckbHome.Enabled = False
                Else
                    ckbHome.Enabled = True
                End If
                c = 6
        End Select

    End Sub

    Sub impostaTab()
        frmSfondoNero.Show()
        impostaLocation()
    End Sub
    Sub impostaLocation()
        frmSfondoNero.Location = New Point(frmConsuntivazione.Location.X + 8, frmConsuntivazione.Location.Y + 31)
        frmSfondoNero.Size = New Size(frmConsuntivazione.Width - 16, frmConsuntivazione.Height - 39)

        Dim locationY As Integer = frmConsuntivazione.Location.Y + 31
        Dim locationX As Integer = frmConsuntivazione.Location.X + 8
        locationY += frmConsuntivazione.pnlMensile.Location.Y + frmConsuntivazione.pnlDataGrid.Location.Y + frmConsuntivazione.dgvCalendario.Location.Y
        locationX += frmConsuntivazione.pnlMensile.Location.X + frmConsuntivazione.pnlDataGrid.Location.X + frmConsuntivazione.dgvCalendario.Location.X

        Me.Location = New Point(((frmConsuntivazione.dgvCalendario.Width - Me.Width) / 2) + locationX, ((frmConsuntivazione.dgvCalendario.Height - Me.Height) / 2) + locationY)
    End Sub
    Sub arrotondaBordi()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 15, 15))

        lblBordoTicket.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoTicket.Width, lblBordoTicket.Height, 5, 5))
        lblInsTicket.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsTicket.Width, lblInsTicket.Height, 5, 5))

        lblBordoCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoCliente.Width, lblBordoCliente.Height, 5, 5))
        lblInsCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsCliente.Width, lblInsCliente.Height, 5, 5))

        lblBordoData.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoData.Width, lblBordoData.Height, 5, 5))
        lblInsData.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsData.Width, lblInsData.Height, 5, 5))

        lblBordoTempo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoTempo.Width, lblBordoTempo.Height, 5, 5))
        lblInsTempo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsTempo.Width, lblInsTempo.Height, 5, 5))

        lblBordoExtra.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoExtra.Width, lblBordoExtra.Height, 5, 5))
        lblInsExtra.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsExtra.Width, lblInsExtra.Height, 5, 5))

        lblBordoConsuntivato.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoConsuntivato.Width, lblBordoConsuntivato.Height, 5, 5))
        lblInsConsuntivatoSI.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsConsuntivatoSI.Width, lblInsConsuntivatoSI.Height, 5, 5))
        lblInsConsuntivatoNO.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsConsuntivatoNO.Width, lblInsConsuntivatoNO.Height, 5, 5))

        lblBordoNota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoNota.Width, lblBordoNota.Height, 5, 5))
        lblInsNota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsNota.Width, lblInsNota.Height, 5, 5))

        lblBordoModifica.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoModifica.Width, lblBordoModifica.Height, 5, 5))
        btnModifica.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModifica.Width, btnModifica.Height, 5, 5))

        lblBordoAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoAnnulla.Width, lblBordoAnnulla.Height, 5, 5))
        btnAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAnnulla.Width, btnAnnulla.Height, 5, 5))

        lblBordoElimina.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoElimina.Width, lblBordoElimina.Height, 5, 5))
        btnElimina.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnElimina.Width, btnElimina.Height, 5, 5))

    End Sub
    Sub caricaValori()
        id = frmConsuntivazione.idCondiviso
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM " & tabellaDB & " WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabellaDB = "Consuntivazione" Then
            txtTicket.Text = tabella.Rows(0).Item("TICKET").ToString
            cmbCliente.Text = tabella.Rows(0).Item("CLIENTE").ToString
            dtpData.Value = CDate(tabella.Rows(0).Item("DATA").ToString).ToShortDateString
            txtTempo.Text = tabella.Rows(0).Item("TEMPO_RISOLUZIONE").ToString
            caricaNota(tabella)
            If tabella.Rows(0).Item("CONSUNTIVATO").ToString = "NO" Then
                lblInsConsuntivatoNO.BackColor = Me.BackColor
                lblInsConsuntivatoSI.BackColor = lblBordoConsuntivato.BackColor
                consuntivato = False
            Else
                lblInsConsuntivatoNO.BackColor = lblBordoConsuntivato.BackColor
                lblInsConsuntivatoSI.BackColor = Me.BackColor
                consuntivato = True
            End If
        End If
    End Sub
    Sub caricaNota(tabella As DataTable)
        Dim vetDividiNota() As String
        Dim subExtra As String
        Dim tempoExtra As String
        Dim subNota As String

        If tabella.Rows(0).Item("NOTA").ToString.Contains("Extra") Then
            subExtra = tabella.Rows(0).Item("NOTA").ToString.Substring(tabella.Rows(0).Item("NOTA").ToString.LastIndexOf("Extra"), tabella.Rows(0).Item("NOTA").ToString.Length - tabella.Rows(0).Item("NOTA").ToString.LastIndexOf("Extra"))
            vetDividiNota = subExtra.Split("(")
            tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
            txtExtra.Text = tempoExtra
            subNota = tabella.Rows(0).Item("NOTA").ToString.Substring(0, tabella.Rows(0).Item("NOTA").ToString.LastIndexOf("Extra"))
        Else
            txtExtra.Text = 0
            subNota = tabella.Rows(0).Item("NOTA").ToString
        End If

        If subNota.Trim.EndsWith(",") Then
            subNota = subNota.Trim.Substring(0, subNota.Trim.Length - 1)
        Else
            subNota = subNota.Trim
        End If

        vetDividiNota = subNota.Split(",")

        For i = 0 To vetDividiNota.Length - 1
            If Not vetDividiNota(i).Contains("Extra") And Not vetDividiNota(i).Contains("Home") Then
                cmbNota.Text += vetDividiNota(i) & ", "
            ElseIf vetDividiNota(i).Contains("Home") Then
                ckbHome.Checked = True
            End If
        Next

        cmbNota.Text = cmbNota.Text.Trim
        If cmbNota.Text = "," Then
            cmbNota.Text = ""
        Else
            If cmbNota.Text <> "" Then
                cmbNota.Text = cmbNota.Text.Substring(0, cmbNota.Text.Length - 1)
            End If
        End If
    End Sub
    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        frmConsuntivazione.annulla = True
        PulisciCampi()
        Me.Close()
    End Sub
    Private Sub cmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub cmbTempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46))) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        End If
    End Sub

    Dim dato As String = ""
    Dim corretto As Boolean = True
    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        lblTicket.Focus()
        If Not verificaDati() Then
            Exit Sub
        End If

        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logModifica, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log Modifica:")
            logFile.WriteLine(dataOraLog + "ID: " & id)
        End Using

        datoTicket()
        datoCliente()
        datoData()
        datoTempo()
        datoConsuntivato()
        datoNota()

        'If tabellaDB = "LinkGR" Then
        'datoNotaCommesse()
        'End If

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM Consuntivazione WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim vecchiDati As String
        vecchiDati = tabella.Rows(0).Item("TICKET").ToString & "|"
        vecchiDati += tabella.Rows(0).Item("CLIENTE").ToString & "|"
        vecchiDati += tabella.Rows(0).Item("DATA").ToString & "|"
        vecchiDati += tabella.Rows(0).Item("TEMPO_RISOLUZIONE").ToString & "|"
        vecchiDati += tabella.Rows(0).Item("CONSUNTIVATO").ToString & "|"
        vecchiDati += tabella.Rows(0).Item("NOTA").ToString

        Dim nuoviDati As String
        nuoviDati = insTicket & "|"
        nuoviDati += insCliente & "|"
        nuoviDati += insData & "|"
        nuoviDati += insTempo & "|"
        nuoviDati += insConsuntivo & "|"
        nuoviDati += insNota

        str = "UPDATE " & tabellaDB & " SET TICKET = '" & insTicket & "', CLIENTE = '" & insCliente & "', DATA = #" & Format(CDate(insData), "MM/dd/yyyy") & "#, TEMPO_RISOLUZIONE = '" & insTempo & "', CONSUNTIVATO = '" & insConsuntivo & "', NOTA = '" & insNota & "' WHERE ID = " & id

        cn.Open()
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        Using logFile As New System.IO.StreamWriter(logModifica, True)
            logFile.WriteLine(dataOraLog + "Modificata riga [" & vecchiDati & "] impostando [" & nuoviDati & "] - ID: '" & id & "'")
            logFile.WriteLine(dataOraLog + "Fine Modifica - OK")
        End Using

        'MODIFICA DI TUTTE LE NOTE IN HOME O NON RIMOSSO PER I MEZZI GIORNI
        'If tabellaDB = "Consuntivazione" Then
        'Call modificaTutteNote()
        'If colonna = "TEMPO_RISOLUZIONE" Then
        'Call controllaExtra()
        'End If
        'End If

        If frmConsuntivazione.AggAutDettaglio = False And tabellaDB <> "LinkGR" Then
            frmConsuntivazione.dgvCalendario.Rows(riga).Cells(1).Value = insTicket
            frmConsuntivazione.dgvCalendario.Rows(riga).Cells(2).Value = insCliente
            frmConsuntivazione.dgvCalendario.Rows(riga).Cells(3).Value = insTempo
            frmConsuntivazione.lblOreLavorate.Text = CDbl(frmConsuntivazione.lblOreLavorate.Text) - CDbl(tabella.Rows(0).Item("TEMPO_RISOLUZIONE").ToString) + insTempo
            frmConsuntivazione.dgvCalendario.Rows(riga).Cells(4).Value = insData
            frmConsuntivazione.dgvCalendario.Rows(riga).Cells(5).Value = insConsuntivo
            frmConsuntivazione.dgvCalendario.Rows(riga).Cells(6).Value = insNota
        End If
        Me.Close()
    End Sub
    Function verificaDati()
        If lblBordoTicket.BackColor = Color.Red Or lblBordoCliente.BackColor = Color.Red Or lblBordoNota.BackColor = Color.Red Then
            corretto = False
        End If
        Return corretto
    End Function
    Sub modificaTutteNote()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT DATA FROM Consuntivazione WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()
        Dim giorno As Date = tabella.Rows(0).Item("DATA").ToString


        cn.Open()
        str = "SELECT DATA, NOTA, ID FROM Consuntivazione WHERE DATA = #" & Format(giorno, "MM/dd/yyyy") & "#"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim numGiorni As Integer = tabella.Rows.Count - 1
        Dim vetNota(numGiorni) As String
        Dim notaID As String = ""
        Dim contiene As Boolean = False

        For i = 0 To numGiorni
            vetNota(i) = tabella.Rows(i).Item("NOTA").ToString
            If tabella.Rows(i).Item("ID") = id Then
                notaID = vetNota(i)
            End If
        Next

        If notaID.Contains("Home") Then
            contiene = True
        End If

        For i = 0 To numGiorni
            If tabella.Rows(i).Item("ID") <> id Then
                If contiene = True Then
                    If vetNota(i).ToString = "" Then
                        dato = "Home"
                    ElseIf vetNota(i).ToString.Contains("Home") Then
                        dato = vetNota(i)
                    Else
                        dato = "Home, " & vetNota(i)
                    End If
                Else
                    If vetNota(i).ToString = "Home" Then
                        dato = ""
                    Else
                        dato = vetNota(i).ToString.Replace("Home, ", "")
                    End If
                End If
                cn.Open()
                If dato = "" Then
                    str = "UPDATE Consuntivazione SET NOTA = NULL WHERE ID = " & tabella.Rows(i).Item("ID")
                Else
                    str = "UPDATE Consuntivazione SET NOTA ='" & dato & "' WHERE ID = " & tabella.Rows(i).Item("ID")
                End If
                cmd = New OleDbCommand(str, cn)
                Try
                    str = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                    cn.Close()
                    Exit Sub
                End Try
                cn.Close()
            End If
        Next
        Me.Close()
    End Sub
    Dim insTicket As String
    Sub datoTicket()
        insTicket = StrConv(txtTicket.Text.Replace("'", "").Trim, VbStrConv.Uppercase)
    End Sub
    Dim insCliente As String
    Sub datoCliente()
        insCliente = StrConv(cmbCliente.Text.Replace("'", "").Trim, VbStrConv.ProperCase)
    End Sub
    Sub controllaCliente(cliente As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM Clienti WHERE Cliente = '" & cliente & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows.Count = 0 Then
            lblBordoCliente.BackColor = Color.Red
        End If
    End Sub

    Dim insTempo As Double
    Dim notaExtra As String = ""
    Sub datoTempo()
        insTempo = txtTempo.Text
        If txtExtra.Text > 0 Then
            notaExtra = "Extra(" & txtExtra.Text & ")"
        Else
            notaExtra = ""
        End If
    End Sub
    Sub calcolaExtra(dato As Double)
        Dim vecchioTempo As String = frmConsuntivazione.dgvCalendario.Rows(riga).Cells(3).Value
        Dim nuovoTempo As Double
        notaExtra = ""
        If CDbl(frmConsuntivazione.lblOreLavorate.Text) > 8 Then
            If CDbl(frmConsuntivazione.lblOreLavorate.Text) - CDbl(vecchioTempo) + dato > 8 Then
                nuovoTempo = (CDbl(frmConsuntivazione.lblOreLavorate.Text) - CDbl(vecchioTempo) + dato) - 8
                For i = 1 To frmConsuntivazione.dgvCalendario.Rows.Count - 1
                    Dim notaRiga As String = frmConsuntivazione.dgvCalendario.Rows(i).Cells(6).Value
                    If notaRiga.ToLower.Contains("extra") And i <> riga Then
                        Dim indice As Integer = notaRiga.IndexOf("(") + 1
                        notaRiga = notaRiga.Replace(")", "")
                        nuovoTempo -= CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                    End If
                Next
                If nuovoTempo > 0 Then
                    txtExtra.Text = nuovoTempo
                Else
                    txtExtra.Text = 0
                End If
                Exit Sub
            Else
                txtExtra.Text = 0
                Exit Sub
            End If
        ElseIf dato + CDbl(frmConsuntivazione.lblOreLavorate.Text) - CDbl(vecchioTempo) > 8 Then
            nuovoTempo = (CDbl(frmConsuntivazione.lblOreLavorate.Text) - CDbl(vecchioTempo) + dato) - 8
            For i = 1 To frmConsuntivazione.dgvCalendario.Rows.Count - 1
                Dim notaRiga As String = frmConsuntivazione.dgvCalendario.Rows(i).Cells(6).Value
                If notaRiga.ToLower.Contains("extra") Then
                    Dim indice As Integer = notaRiga.IndexOf("(") + 1
                    notaRiga = notaRiga.Replace(")", "")
                    nuovoTempo -= CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                End If
            Next
            If nuovoTempo > 0 Then
                txtExtra.Text = nuovoTempo
            Else
                txtExtra.Text = 0
            End If
        Else
            txtExtra.Text = 0
        End If
    End Sub
    Sub controllaExtra()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String


        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT DATA FROM Consuntivazione WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()
        Dim giorno As Date = tabella.Rows(0).Item("DATA").ToString


        cn.Open()
        str = "SELECT TEMPO_RISOLUZIONE, DATA, NOTA, ID FROM Consuntivazione WHERE DATA = #" & Format(giorno, "MM/dd/yyyy") & "#"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()
        Dim numRighe As Integer = tabella.Rows.Count - 1

        Dim somma As Double
        Dim tempoRiga As Double
        Dim notaRiga As String
        For i = 0 To numRighe
            notaRiga = tabella.Rows(i).Item("NOTA").ToString
            If notaRiga.ToLower.Contains("extra") Then
                Dim indice As Integer = notaRiga.IndexOf("(") + 1
                notaRiga = notaRiga.Replace(")", "")
                tempoRiga = CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                somma += tempoRiga
            End If
        Next

        Dim vecchioTempo As Double = CDbl(frmConsuntivazione.dgvCalendario.Rows(riga).Cells(3).Value)
        'Dim nuovoTempo As Double = CDbl(tabella.Rows(riga - 1).Item("TEMPO_RISOLUZIONE").ToString)
        If CDbl(frmConsuntivazione.lblOreLavorate.Text) - vecchioTempo + dato <= 8 Then
            For i = 0 To numRighe
                notaRiga = tabella.Rows(i).Item("NOTA").ToString
                If notaRiga.ToLower.Contains("extra(") Then
                    cn.Open()
                    str = "UPDATE Consuntivazione SET NOTA = NULL WHERE ID = " & tabella.Rows(i).Item("ID")
                    cmd = New OleDbCommand(str, cn)
                    Try
                        str = cmd.ExecuteNonQuery
                    Catch ex As Exception
                        Using logFile As New System.IO.StreamWriter(logModifica, True)
                            logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                            logFile.WriteLine(dataOraLog + "Fine Modifica - KO")
                        End Using
                        MsgBox("Operazione non conclusa con successo. Codice errore: " & ex.Message)
                        cn.Close()
                        corretto = False
                        Exit Sub
                    End Try
                    cn.Close()
                End If
            Next
        End If
    End Sub

    Dim insData As String
    Sub datoData()
        insData = dtpData.Text
    End Sub

    Dim insConsuntivo As String
    Sub datoConsuntivato()
        If consuntivato Then
            insConsuntivo = "SI"
        Else
            insConsuntivo = "NO"
        End If
    End Sub

    Dim insNota As String
    Sub datoNota()
        'da verificare perchè la nota viene inserita con la virgola finale
        If ckbHome.Checked Then
            insNota = "Home"
        Else
            insNota = ""
        End If
        If insNota = "" Then
            insNota = cmbNota.Text
        Else
            If cmbNota.Text <> "" Then
                insNota += ", " & cmbNota.Text
            End If
        End If
        If notaExtra <> "" Then
            If insNota = "" Then
                insNota = notaExtra
            Else
                insNota += ", " & notaExtra
            End If
        End If
    End Sub
    Sub controllaNota()
        cmbNota.Text = cmbNota.Text.Trim.ToLower
        cmbNota.Text = cmbNota.Text.Replace("'", "")
        cmbNota.Text = cmbNota.Text.Replace(",", "")
        cmbNota.Text = StrConv(cmbNota.Text, VbStrConv.ProperCase)
        Dim notaInput As String
        notaInput = cmbNota.Text

        If notaInput.Length > 150 Then
            lblBordoNota.BackColor = Color.Red
            Exit Sub
        ElseIf notaInput.ToLower.Contains("extra") Then
            lblBordoNota.BackColor = Color.Red
            Exit Sub
        End If
    End Sub
    'Sub datoNotaCommesse()
    '    Dim cn As OleDbConnection
    '    Dim cmd As OleDbCommand
    '    Dim da As OleDbDataAdapter
    '    Dim tabella As New DataTable
    '    Dim str As String
    '    cliente = frmCommesse.dgvCommesse.Rows(riga).Cells(1).Value
    '    nota = frmCommesse.dgvCommesse.Rows(riga).Cells(2).Value

    '    cn = New OleDbConnection(strConn)
    '    cn.Open()
    '    str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cliente & "'"
    '    cmd = New OleDbCommand(str, cn)
    '    da = New OleDbDataAdapter(cmd)
    '    tabella.Clear()
    '    da.Fill(tabella)
    '    cn.Close()

    '    Dim vetCommNota(tabella.Rows.Count - 1) As String
    '    For i = 0 To tabella.Rows.Count - 1
    '        vetCommNota(i) = tabella.Rows(i).Item("Nota").ToString
    '    Next

    '    Dim conta As Integer = 0
    '    Using logFile As New System.IO.StreamWriter(logModifica, True)
    '        If 0 = 0 Then ' rdbVuota.Checked = True Then
    '            For i = 0 To tabella.Rows.Count - 1
    '                If vetCommNota(i) = "" And vetCommNota(i).ToLower <> nota.ToLower Then
    '                    conta += 1
    '                End If
    '            Next
    '            dato = ""
    '        ElseIf 0 = 0 Then ' rdbFixed.Checked = True Then
    '            For i = 0 To tabella.Rows.Count - 1
    '                If vetCommNota(i) = "Fixed" And vetCommNota(i).ToLower <> nota.ToLower Then
    '                    conta += 1
    '                End If
    '            Next
    '            dato = "Fixed"
    '        ElseIf 0 = 0 Then ' rdbFormazione.Checked = True Then
    '            For i = 0 To tabella.Rows.Count - 1
    '                If vetCommNota(i) = "Formazione" And vetCommNota(i).ToLower <> nota.ToLower Then
    '                    conta += 1
    '                End If
    '            Next
    '            dato = "Formazione"
    '        ElseIf 0 = 0 Then ' ckbAltro.Checked = True Then
    '            Dim notaInput As String
    '            notaInput = InputBox("Inserisci una nota").Trim.ToLower
    '            notaInput = notaInput.Replace("'", "")
    '            notaInput = notaInput.Replace(",", "")
    '            notaInput = StrConv(notaInput, VbStrConv.ProperCase)

    '            If notaInput.Length > 150 Then
    '                logFile.WriteLine(dataOraLog + "Nota non valida (Max 150 car.)")
    '                logFile.WriteLine(dataOraLog + "Fine Modifica - KO")
    '                logFile.Close()
    '                MsgBox("Nota non valida (Max 150 car.)")
    '                corretto = False
    '                Exit Sub
    '            ElseIf notaInput.ToLower.Contains("criticità") Or notaInput.ToLower.Contains("home") Or notaInput.ToLower.Contains("fixed") Or notaInput.ToLower.Contains("formazione") Then
    '                logFile.WriteLine(dataOraLog + "Nota non valida (non puo essere uno dei valori gia predefiniti)")
    '                logFile.WriteLine(dataOraLog + "Fine Modifica - KO")
    '                logFile.Close()
    '                MsgBox("Nota non valida (non puo essere uno dei valori gia predefiniti)")
    '                corretto = False
    '                Exit Sub
    '            ElseIf notaInput.ToLower.Contains("extra") Then
    '                logFile.WriteLine(dataOraLog + "Non puoi inserire '" & notaInput & "' come commessa")
    '                logFile.WriteLine(dataOraLog + "Fine Modifica - KO")
    '                logFile.Close()
    '                MsgBox("Non puoi inserire questa commessa")
    '                Exit Sub
    '                corretto = False
    '            End If
    '            For i = 0 To tabella.Rows.Count - 1
    '                If vetCommNota(i).ToLower = notaInput.ToLower And vetCommNota(i).ToLower <> nota.ToLower Then
    '                    conta += 1
    '                End If
    '            Next
    '            dato = notaInput
    '        End If
    '        If conta > 0 Then
    '            logFile.WriteLine(dataOraLog + "Questa commessa è gia presente")
    '            logFile.WriteLine(dataOraLog + "Fine Modifica - KO")
    '            logFile.Close()
    '            MsgBox("Questa commessa è gia presente")
    '            corretto = False
    '            Exit Sub
    '        End If
    '    End Using
    '    corretto = True
    'End Sub

    Private Sub inviaModifiche_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTicket.KeyDown, cmbCliente.KeyDown, dtpData.KeyDown, txtTempo.KeyDown, txtExtra.KeyDown, cmbCliente.KeyDown, cmbNota.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnModifica_Click(sender, e)
        End If
    End Sub

    Dim allLabels As New List(Of Label)
    Private Sub caricaLabels()
        allLabels.AddRange({lblInsTicket, lblInsCliente, lblInsTempo, lblInsExtra, lblInsNota})
    End Sub
    Private Sub lblInsTicket_Click(sender As Object, e As EventArgs) Handles lblInsTicket.Click
        txtTicket.Select()
        SendKeys.Send("%{DOWN}")
        lblInsTicket.Text = txtTicket.Text & "|"

        allLabels.Remove(lblInsTicket)
        RemovePipes(allLabels)
        allLabels.Add(lblInsTicket)
    End Sub
    Private Sub lblInsCliente_Click(sender As Object, e As EventArgs) Handles lblInsCliente.Click
        cmbCliente.Focus()
        lblInsCliente.Text = cmbCliente.Text & "|"

        allLabels.Remove(lblInsCliente)
        RemovePipes(allLabels)
        allLabels.Add(lblInsCliente)
    End Sub
    Private Sub lblInsCliente_DoubleClick(sender As Object, e As EventArgs) Handles lblInsCliente.DoubleClick
        cmbCliente.Focus()
        SendKeys.Send("%{DOWN}")
    End Sub
    Private Sub lblInsData_Click(sender As Object, e As EventArgs) Handles lblInsData.Click
        dtpData.Select()
        SendKeys.Send("%{DOWN}")
    End Sub
    Private Sub lblInsTempo_Click(sender As Object, e As EventArgs) Handles lblInsTempo.Click
        txtTempo.Focus()
        lblInsTempo.Text = txtTempo.Text & "|"

        allLabels.Remove(lblInsTempo)
        RemovePipes(allLabels)
        allLabels.Add(lblInsTempo)
    End Sub
    Private Sub lblInsTempo_DoubleClick(sender As Object, e As EventArgs) Handles lblInsTempo.DoubleClick
        txtTempo.Focus()
        SendKeys.Send("%{DOWN}")
    End Sub
    Private Sub lblInsExtra_Click(sender As Object, e As EventArgs) Handles lblInsExtra.Click
        txtExtra.Select()
        SendKeys.Send("%{DOWN}")
        lblInsExtra.Text = txtExtra.Text & "|"

        allLabels.Remove(lblInsExtra)
        RemovePipes(allLabels)
        allLabels.Add(lblInsExtra)
    End Sub
    Private Sub lblInsConsuntivatoSI_Click(sender As Object, e As EventArgs) Handles lblInsConsuntivatoSI.Click
        lblInsConsuntivatoNO.BackColor = lblBordoConsuntivato.BackColor
        lblInsConsuntivatoSI.BackColor = Me.BackColor
        consuntivato = True
    End Sub
    Private Sub lblInsConsuntivatoNO_Click(sender As Object, e As EventArgs) Handles lblInsConsuntivatoNO.Click
        lblInsConsuntivatoNO.BackColor = Me.BackColor
        lblInsConsuntivatoSI.BackColor = lblBordoConsuntivato.BackColor
        consuntivato = False
    End Sub
    Private Sub lblInsNota_Click(sender As Object, e As EventArgs) Handles lblInsNota.Click
        cmbNota.Focus()
        lblInsNota.Text = cmbNota.Text & "|"

        allLabels.Remove(lblInsNota)
        RemovePipes(allLabels)
        allLabels.Add(lblInsNota)
    End Sub
    Private Sub lblInsNota_DoubleClick(sender As Object, e As EventArgs) Handles lblInsNota.DoubleClick
        cmbNota.Focus()
        SendKeys.Send("%{DOWN}")
    End Sub
    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        lblInsData.Text = dtpData.Value
    End Sub

    Private Sub txtInserimento_TextChanged(sender As Object, e As EventArgs) Handles txtTicket.TextChanged, cmbCliente.TextChanged, txtTempo.TextChanged, txtExtra.TextChanged, cmbNota.TextChanged
        UpdateLabels()

        If txtTicket.Focused And Not txtTicket.Text.Contains("|") Then
            AddPipe(lblInsTicket)
            lblBordoTicket.BackColor = Color.Silver
        ElseIf cmbCliente.Focused And Not cmbCliente.Text.Contains("|") Then
            AddPipe(lblInsCliente)
            lblBordoCliente.BackColor = Color.Silver
        ElseIf txtTempo.Focused And Not txtTempo.Text.Contains("|") Then
            AddPipe(lblInsTempo)
            lblBordoTempo.BackColor = Color.Silver
        ElseIf txtExtra.Focused And Not txtExtra.Text.Contains("|") Then
            AddPipe(lblInsExtra)
            lblBordoExtra.BackColor = Color.Silver
        ElseIf cmbNota.Focused And Not cmbNota.Text.Contains("|") Then
            AddPipe(lblInsNota)
        End If
    End Sub
    Private Sub txtInserimento_GotFocused(sender As Object, e As EventArgs) Handles txtTicket.GotFocus, cmbCliente.GotFocus, txtTempo.GotFocus, txtExtra.GotFocus, cmbNota.GotFocus
        UpdateLabels()

        If txtTicket.Focused Then
            txtTicket.SelectionStart = txtTicket.Text.Length
            AddPipe(lblInsTicket)
            lblBordoTicket.BackColor = Color.Silver
        ElseIf cmbCliente.Focused Then
            cmbCliente.SelectionStart = cmbCliente.Text.Length
            AddPipe(lblInsCliente)
            lblBordoCliente.BackColor = Color.Silver
        ElseIf txtTempo.Focused Then
            txtTempo.SelectionStart = txtTempo.Text.Length
            AddPipe(lblInsTempo)
            lblBordoTempo.BackColor = Color.Silver
        ElseIf txtExtra.Focused Then
            txtExtra.SelectionStart = txtExtra.Text.Length
            AddPipe(lblInsExtra)
            lblBordoExtra.BackColor = Color.Silver
        ElseIf cmbNota.Focused Then
            txtExtra.SelectionStart = txtExtra.Text.Length
            AddPipe(lblInsNota)
        End If
    End Sub
    Private Sub txtInserimento_LostFocus(sender As Object, e As EventArgs) Handles txtTicket.LostFocus, cmbCliente.LostFocus, txtTempo.LostFocus, txtExtra.LostFocus, cmbNota.LostFocus
        If Not txtTicket.Focused And Not cmbCliente.Focused And Not txtTempo.Focused And Not txtExtra.Focused And Not cmbNota.Focused Then
            RemovePipes(allLabels)
        End If
        controllaFormAttivo()
    End Sub
    Private Sub txtTicket_LostFocus(sender As Object, e As EventArgs) Handles txtTicket.LostFocus
        txtTicket.Text.Replace("'", "")
        If txtTicket.Text.Trim = "" Then
            lblBordoTicket.BackColor = Color.Red
        End If
    End Sub
    Private Sub cmbCliente_LostFocus(sender As Object, e As EventArgs) Handles cmbCliente.LostFocus
        cmbCliente.Text.Replace("'", "")
        controllaCliente(cmbCliente.Text)
    End Sub
    Private Sub txtTempo_LostFocus(sender As Object, e As EventArgs) Handles txtTempo.LostFocus
        calcolaExtra(If(txtTempo.Text = "", 0, txtTempo.Text))
    End Sub
    Private Sub cmbNota_LostFocus(sender As Object, e As EventArgs) Handles cmbNota.LostFocus
        controllaNota()
    End Sub
    Private Sub UpdateLabels()
        lblInsTicket.Text = txtTicket.Text
        lblInsCliente.Text = cmbCliente.Text
        lblInsTempo.Text = txtTempo.Text
        lblInsExtra.Text = txtExtra.Text
        lblInsNota.Text = cmbNota.Text
    End Sub
    Private Sub AddPipe(label As Label)
        ' Aggiunge un carattere "|" alla fine del testo dell'etichetta specificata.
        If Not label.Text.Contains("|") Then
            label.Text &= "|"
        End If
    End Sub
    Private Sub RemovePipes(ByVal labels As List(Of Label))
        ' Rimuove tutti i caratteri "|" dal testo delle etichette specificate.
        For Each label In labels
            label.Text = label.Text.Replace("|", "")
        Next label
    End Sub
    Private Sub txtTempo_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles txtTempo.TypeValidationCompleted
        Dim dato As String = If(e.ReturnValue, 0)

        If dato.Contains(",") Then
            If dato.Substring(dato.IndexOf(","), dato.Length - dato.IndexOf(",")).Length > 2 Then
                txtTempo.Text = Math.Round(CDbl(dato), 2)
            Else
                txtTempo.Text = CDbl(dato)
            End If
        Else
            txtTempo.Text = dato
        End If
    End Sub
    Private Sub txtExtra_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles txtExtra.TypeValidationCompleted
        Dim dato As String = If(e.ReturnValue, 0)

        If dato.Contains(",") Then
            If dato.Substring(dato.IndexOf(","), dato.Length - dato.IndexOf(",")).Length > 2 Then
                dato = Math.Round(CDbl(dato), 2)
            Else
                dato = CDbl(dato)
            End If
        End If
        If dato > CDbl(txtTempo.Text) Then
            txtExtra.Text = txtTempo.Text
        Else
            txtExtra.Text = dato
        End If
    End Sub

End Class