Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmModificaCommessa
    ReadOnly strConn As String = frmConsuntivazione.strConn
    ReadOnly logCommesseClienti As String = frmConsuntivazione.logCommesseClienti
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
    Private Sub cmbNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNota.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub inviaModifiche_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown, txtCodCliente.KeyDown, cmbNota.KeyDown, txtCommessa.KeyDown, txtSottoCommessa.KeyDown, txtFase.KeyDown, txtSottoFase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnModifica_Click(sender, e)
        End If
    End Sub

    Private Sub disabilitaFreccie(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown, txtCodCliente.KeyDown, cmbNota.KeyDown, txtCommessa.KeyDown, txtSottoCommessa.KeyDown, txtFase.KeyDown, txtSottoFase.KeyDown
        If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmModificaCommessa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        impostaTab()
        impostaConfig()
        pulisciCampi()
        arrotondaBordi()
        caricaValori()
        frmCommesse.sfondoNeroClick = False
    End Sub
    Dim scelta As String = ""
    Private Sub frmModificaCommessa_GotFocus(sender As Object, e As EventArgs) Handles txtCliente.GotFocus
        If scelta = "" Then
            Exit Sub
        End If

        Select Case scelta
            Case "modificaCommesse&Cliente&Pregresso"
                If frmMessaggio.risultato = "commessa" Then
                    modificaCommessa()

                ElseIf frmMessaggio.risultato = "commesse&cliente&noPregresso" Then
                    modificaClienteCommesse()

                ElseIf frmMessaggio.risultato = "commesse&cliente&pregresso" Then
                    modificaClienteCommesse()

                    modificaPregresso()
                    frmConsuntivazione.AggiornaDG(Now.ToShortDateString, False)
                ElseIf frmMessaggio.risultato = "annulla" Then
                    Exit Sub
                End If
                frmClienti.modificaCmbClienti()
                frmClienti.aggiornaDG()
                frmCommesse.aggiornaDG()
                btnAnnulla_Click(sender, e) 'Chiudere il form

            Case "eliminaCommessa"
                If frmMessaggio.risultato = "commessa&noCliente" Then
                    eliminaCommessa(cli, comm)

                ElseIf frmMessaggio.risultato = "commessa&cliente&pregresso" Then
                    eliminaCommessa(cli, comm)
                    frmModificaCliente.eliminaCliente(cli)
                    eliminaPregresso(cli)
                    frmConsuntivazione.AggiornaDG(Now.ToShortDateString, False)

                ElseIf frmMessaggio.risultato = "commessa&cliente&noPregresso" Then
                    eliminaCommessa(cli, comm)
                    frmModificaCliente.eliminaCliente(cli)

                End If
                frmClienti.modificaCmbClienti()
                frmClienti.aggiornaDG()
                frmCommesse.aggiornaDG()
                btnAnnulla_Click(sender, e) 'Chiudere il form
        End Select
    End Sub

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

        lblBordoModifica.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoModifica.Width, lblBordoModifica.Height, 5, 5))
        btnModifica.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModifica.Width, btnModifica.Height, 5, 5))

        lblBordoAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoAnnulla.Width, lblBordoAnnulla.Height, 5, 5))
        btnAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAnnulla.Width, btnAnnulla.Height, 5, 5))

        lblBordoElimina.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoElimina.Width, lblBordoElimina.Height, 5, 5))
        btnElimina.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnElimina.Width, btnElimina.Height, 5, 5))

    End Sub
    Sub impostaTab()
        frmSfondoNero.BringToFront()
        impostaLocation()
    End Sub
    Sub impostaLocation()
        impostaSfondoNero()
        Dim locationY As Integer = frmConsuntivazione.Location.Y + 31
        Dim locationX As Integer = frmConsuntivazione.Location.X + 8
        locationY += (frmConsuntivazione.Height / 2) - (Me.Height / 2)
        locationX += (frmConsuntivazione.Width / 2) - (Me.Width / 2)

        Me.Location = New Point(locationX, locationY)
    End Sub
    Sub impostaSfondoNero()
        frmSfondoNero.Location = New Point(frmConsuntivazione.Location.X + 8, frmConsuntivazione.Location.Y + 31)
        frmSfondoNero.Size = New Size(frmConsuntivazione.Width - 16, frmConsuntivazione.Height - 39)
    End Sub
    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
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

        lblBordoCliente.BackColor = Color.Silver
        lblBordoCodCliente.BackColor = Color.Silver
        lblBordoNota.BackColor = Color.Silver
        lblBordoCommessa.BackColor = Color.Silver
        lblBordoSottoCommessa.BackColor = Color.Silver
    End Sub
    Public id As Integer = frmCommesse.idCommessa
    ReadOnly tabellaCondivisa As String = frmCommesse.tabellaCondivisa
    Sub caricaValori()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT * FROM " & tabellaCondivisa & " WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim vetLink() As String = tabella.Rows(0).Item("Link").ToString.Split("&")

        txtCliente.Text = tabella.Rows(0).Item("Cliente").ToString
        txtCodCliente.Text = vetLink(0).Replace("Cliente=", "")
        cmbNota.Text = tabella.Rows(0).Item("Nota").ToString
        txtCommessa.Text = vetLink(1).Replace("Commessa=", "")
        txtSottoCommessa.Text = vetLink(2).Replace("SottComm=", "")
        txtFase.Text = vetLink(3).Replace("Fase=", "")
        txtSottoFase.Text = vetLink(4).Replace("SottoFase=", "")

        lblInsCliente.Text = txtCliente.Text
        lblInsCodCliente.Text = txtCodCliente.Text
        lblInsNota.Text = cmbNota.Text
        lblInsCommessa.Text = txtCommessa.Text
        lblInsSottoCommessa.Text = txtSottoCommessa.Text
        lblInsFase.Text = txtFase.Text
        lblInsSottoFase.Text = txtSottoFase.Text
    End Sub
    Function verificaDati(cliente As String, codCliente As String, nota As String, commessa As String, sottoCommessa As String)
        Dim corretto As Boolean = True
        If cliente = "" Or cliente.Length > frmConsuntivazione.cmbCliente.MaxLength Then
            lblBordoCliente.BackColor = Color.Red
            corretto = False
        ElseIf codCliente = "" Then
            lblBordoCodCliente.BackColor = Color.Red
            corretto = False
        ElseIf nota.Length > frmConsuntivazione.cmbCliente.MaxLength Then
            lblBordoNota.BackColor = Color.Red
            corretto = False
        ElseIf commessa = "" Then
            lblBordoCommessa.BackColor = Color.Red
            corretto = False
        ElseIf sottoCommessa = "" Then
            lblBordoSottoCommessa.BackColor = Color.Red
            corretto = False
        End If
        Return corretto
    End Function
    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        txtCliente.Text = StrConv(txtCliente.Text.Replace("'", "").Trim, VbStrConv.ProperCase)

        If Not verificaDati(txtCliente.Text, txtCodCliente.Text, cmbNota.Text, txtCommessa.Text, txtSottoCommessa.Text) Then
            Exit Sub
        End If

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log Commesse:")
        End Using

        If verificaCommessa() Then
            cliPartenza()
            If txtCliente.Text <> clientePartenza Then
                scelta = "modificaCommesse&Cliente&Pregresso"
                frmCommesse.sfondoNeroClick = False
                frmMessaggio.lblMessaggio.Text = "Vuoi modificare anche il cliente e le altre commesse associate?"
                frmMessaggio.formPartenza = "frmModificaCommessa"
                frmMessaggio.richiesta = scelta
                frmMessaggio.Show()
                Exit Sub
            Else
                modificaCommessa()
                frmCommesse.aggiornaDG()
                btnAnnulla_Click(sender, e) 'Chiudere il form
            End If
        End If
    End Sub
    Function verificaCommessa()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT COUNT(0) AS NUM_RECORD FROM LinkGR WHERE Cliente = '" & txtCliente.Text & "' AND " & If(cmbNota.Text = "", "Nota IS NULL", "Nota = '" & cmbNota.Text & "'") & " AND ID <> " & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            If tabella.Rows(0).Item("NUM_RECORD") = 0 Then
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
                logFile.Close()
                Return True
            Else
                lblBordoCliente.BackColor = Color.Red
                lblBordoNota.BackColor = Color.Red
                logFile.WriteLine(dataOraLog + "Errore. Modifica non effettuata per il seguente motivo: Commessa già esistente")
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                Return False
            End If
        End Using
    End Function
    Dim cli, comm As String
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        'DA GESTIRE L'ELIMINAZIONE CHIEDENDO LA CONFERMA CON IL FORM MESSAGGIO
        cli = StrConv(txtCliente.Text.Replace("'", "").Trim, VbStrConv.ProperCase)
        comm = StrConv(cmbNota.Text.Replace("'", "").Trim, VbStrConv.ProperCase)

        If Not verificaCommessaElim(cli, comm) Then
            lblBordoCliente.BackColor = Color.Red
            lblBordoNota.BackColor = Color.Red
            Exit Sub
        End If

        scelta = "eliminaCommessa"
        frmCommesse.sfondoNeroClick = False
        frmMessaggio.lblMessaggio.Text = "Sei sicuro di voler cancellare la commessa? Non può essere recuperata"
        frmMessaggio.formPartenza = "frmModificaCommessa"
        frmMessaggio.richiesta = scelta
        frmMessaggio.Show()
        Exit Sub

        'SE E' L'UNICA COMMESSA CHE SI CANCELLA CHIEDERE SE SI VUOLE CANCELLARE IL CLIENTE 

        'A SEGUITO DI QUESTO CHIEDERE SE SI VUOLE PROCEDERE CON LA CANCELLAZIONE DEL PREGRESSO
        '(PER CHIAVE [CLIENTE-NOTA])


    End Sub
    Function verificaCommessaElim(cli As String, comm As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT COUNT(0) AS NUM_RECORD FROM LinkGR WHERE Cliente = '" & cli & "' AND " & If(comm = "", "Nota IS NULL", "Nota = '" & comm & "'")
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows(0).Item("NUM_RECORD").ToString = 0 Then
            Return False
        End If

        Return True
    End Function
    Function verificaUnicaCommessa()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        Dim cli As String = StrConv(txtCliente.Text.Replace("'", "").Trim, VbStrConv.ProperCase)

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT COUNT(0) AS NUM_RECORD FROM LinkGR WHERE Cliente = '" & cli & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows(0).Item("NUM_RECORD").ToString = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Dim m As MouseEventArgs
        frmSfondoNero.frmSfondoNero_MouseClick(sender, m)
    End Sub
    Sub modificaCommessa()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String
        Dim link As String

        link = "Cliente=" & txtCodCliente.Text & "&Commessa=" & txtCommessa.Text & "&SottComm=" & txtSottoCommessa.Text & "&Fase=" & txtFase.Text & "&SottoFase=" & txtSottoFase.Text

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE LinkGR SET Cliente = '" & txtCliente.Text & "', " & If(cmbNota.Text = "", "Nota = NULL", "Nota = '" & cmbNota.Text & "'") & ", Link = '" & link & "' WHERE ID = " & id
        cmd = New OleDbCommand(str, cn)
        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            Try
                str = cmd.ExecuteNonQuery
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore. Modifica non effettuata per il seguente motivo: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                cn.Close()
                Exit Sub
            End Try
        End Using
        cn.Close()
    End Sub
    Sub modificaClienteCommesse()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE LinkGR SET Cliente = '" & txtCliente.Text & "' WHERE Cliente = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            Try
                str = cmd.ExecuteNonQuery
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore. Modifica non effettuata per il seguente motivo: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                cn.Close()
                Exit Sub
            End Try
        End Using
        cn.Close()

        cn.Open()
        str = "UPDATE Clienti SET Cliente = '" & txtCliente.Text & "' WHERE Cliente = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Sub eliminaCommessa(cli As String, comm As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE * FROM LinkGR WHERE Cliente = '" & cli & "' AND " & If(comm = "", "Nota IS NULL", "Nota = '" & comm & "'")
        cmd = New OleDbCommand(str, cn)

        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            Try
                str = cmd.ExecuteNonQuery
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                cn.Close()
                Exit Sub
            End Try
            cn.Close()
            logFile.WriteLine(dataOraLog + "Camcellata correttamente commessa con id " & id)
            logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
        End Using
    End Sub
    Dim clientePartenza As String = ""
    Sub cliPartenza()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM LinkGR WHERE ID = " & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        clientePartenza = tabella.Rows(0).Item("Cliente").ToString
    End Sub
    Function verificaCommesseCliente()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cliPartenza()

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim noteClientePartenza(tabella.Rows.Count - 1) As String

        For i = 0 To tabella.Rows.Count - 1
            noteClientePartenza(i) = tabella.Rows(0).Item("Nota").ToString
        Next

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & txtCliente.Text & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        For i = 0 To noteClientePartenza.Count
            For j = 0 To tabella.Rows.Count - 1
                If noteClientePartenza(i) = tabella.Rows(j).Item("Nota").ToString Then
                    Return False
                End If
            Next
        Next

        If clientePartenza = txtCliente.Text Then
            Return True
        End If

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT COUNT(0) AS NUM_RECORD FROM Clienti WHERE Cliente = '" & txtCliente.Text & "'"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows(0).Item("NUM_RECORD") > 0 Then
            Return False
        End If

        Return True
    End Function
    Sub modificaPregresso()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE Consuntivazione SET CLIENTE = '" & txtCliente.Text & "' WHERE CLIENTE = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            Try
                str = cmd.ExecuteNonQuery
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore. Modifica non effettuata per il seguente motivo: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                cn.Close()
                Exit Sub
            End Try
        End Using
        cn.Close()
    End Sub
    Sub eliminaPregresso(cli As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE FROM Consuntivazione WHERE CLIENTE = '" & cli & "'"
        cmd = New OleDbCommand(str, cn)
        Using logFile As New System.IO.StreamWriter(logCommesseClienti, True)
            Try
                str = cmd.ExecuteNonQuery
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - OK")
            Catch ex As Exception
                logFile.WriteLine(dataOraLog + "Errore. Modifica non effettuata per il seguente motivo: " & ex.Message)
                logFile.WriteLine(dataOraLog + "Fine scrittura log Commesse - KO")
                logFile.Close()
                cn.Close()
                Exit Sub
            End Try
        End Using
        cn.Close()
    End Sub

    Dim allLabels As New List(Of Label)
    Private Sub caricaLabels()
        allLabels.AddRange({lblInsCliente})
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

    Private Sub Modifica_LostFocus(sender As Object, e As EventArgs) Handles txtCliente.LostFocus, txtCodCliente.LostFocus, cmbNota.LostFocus, txtCommessa.LostFocus, txtSottoCommessa.LostFocus, txtFase.LostFocus, txtSottoFase.LostFocus
        If frmMessaggio.risultato <> "" Then
            Exit Sub
        End If

        If Not txtCliente.Focused And Not txtCodCliente.Focused And Not cmbNota.Focused And Not txtCommessa.Focused And Not txtSottoCommessa.Focused And Not txtFase.Focused And Not txtSottoFase.Focused Then
            RemovePipes(allLabels)
        End If

        If Not controllaFormAttivo() And frmCommesse.sfondoNeroClick = False Then
            frmCommesse.chiudiTutto = True
            frmCommesse.dgvModificaCommessaClick = False
            frmCommesse.BringToFront()
            frmClienti.BringToFront()
            Me.Close()
        End If
    End Sub

    Function controllaFormAttivo()
        Dim formAttivo As Boolean = False
        For Each control As Control In Me.Controls
            If control.ContainsFocus Then
                formAttivo = True
                Exit For
            End If
        Next
        If frmMessaggio.Focused Then
            Return True
        End If
        If frmSfondoNero.Focused Then
            frmCommesse.sfondoNeroClick = True
        End If
        Return formAttivo
    End Function

End Class