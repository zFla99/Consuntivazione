Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmModificaCliente
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
    Private Sub disabilitaFreccie(sender As Object, e As KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down Then
            e.Handled = True
        End If
    End Sub
    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
    ReadOnly strConn As String = frmConsuntivazione.strConn
    Private Sub frmModificaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        impostaTab()
        impostaConfig()
        PulisciCampi()
        arrotondaBordi()
        caricaValori()
        caricaLabels()
        frmClienti.sfondoNeroClick = False
    End Sub
    Dim scelta As String = ""
    Private Sub cmbCliente_GotFocus(sender As Object, e As EventArgs) Handles cmbCliente.GotFocus
        If scelta = "" Then
            Exit Sub
        End If

        Select Case scelta
            Case "modificaCliente&Commesse&Pregresso"
                If frmMessaggio.risultato = "cliente" Then
                    modificaCliente(cliente)
                    frmClienti.modificaCmbClienti()
                    frmClienti.aggiornaDG()

                ElseIf frmMessaggio.risultato = "cliente&commesse&noPregresso" Then
                    modificaClienteCommesse()
                    frmClienti.modificaCmbClienti()
                    frmClienti.aggiornaDG()
                    frmCommesse.aggiornaDG()

                ElseIf frmMessaggio.risultato = "cliente&commesse&pregresso" Then
                    modificaClienteCommesse()
                    frmClienti.modificaCmbClienti()
                    frmClienti.aggiornaDG()
                    frmCommesse.aggiornaDG()

                    modificaPregresso()
                    frmConsuntivazione.AggiornaDG(Now.ToShortDateString, False)
                ElseIf frmMessaggio.risultato = "annulla" Then
                    Exit Sub
                End If
                btnAnnulla_Click(sender, e) 'Chiudere il form
            Case "elimina"
                If frmMessaggio.risultato = "cliente" Then
                    eliminaCliente(cliente)

                ElseIf frmMessaggio.risultato = "cliente&commesse&noPregresso" Then
                    eliminaCliente(cliente)
                    eliminaCommesseCliente(cliente)
                    frmCommesse.aggiornaDG()

                ElseIf frmMessaggio.risultato = "cliente&commesse&pregresso" Then
                    eliminaCliente(cliente)
                    eliminaCommesseCliente(cliente)
                    frmCommesse.aggiornaDG()

                    eliminaPregresso()
                    frmConsuntivazione.AggiornaDG(Now.ToShortDateString, False)

                ElseIf frmMessaggio.risultato = "annulla" Then
                    Exit Sub
                End If

                frmClienti.modificaCmbClienti()
                frmClienti.aggiornaDG()
                btnAnnulla_Click(sender, e) 'Chiudere il form
        End Select
    End Sub
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
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Sub PulisciCampi()
        cmbCliente.Text = ""
    End Sub
    Sub impostaTab()
        frmSfondoNero.BringToFront()
        impostaLocation()
    End Sub
    Sub impostaLocation()
        Dim locationY As Integer = frmConsuntivazione.Location.Y + 31
        Dim locationX As Integer = frmConsuntivazione.Location.X + 8
        locationY += (frmConsuntivazione.Height / 2) - Me.Height / 2 - 10
        locationX += (frmConsuntivazione.Width / 2) - (Me.Width / 2)

        Me.Location = New Point(locationX, locationY)
    End Sub
    Sub arrotondaBordi()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 15, 15))

        lblBordoCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoCliente.Width, lblBordoCliente.Height, 5, 5))
        lblInsCliente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblInsCliente.Width, lblInsCliente.Height, 5, 5))

        lblBordoModifica.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoModifica.Width, lblBordoModifica.Height, 5, 5))
        btnModifica.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModifica.Width, btnModifica.Height, 5, 5))

        lblBordoAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoAnnulla.Width, lblBordoAnnulla.Height, 5, 5))
        btnAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAnnulla.Width, btnAnnulla.Height, 5, 5))

        lblBordoElimina.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoElimina.Width, lblBordoElimina.Height, 5, 5))
        btnElimina.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnElimina.Width, btnElimina.Height, 5, 5))
    End Sub
    Public id As Integer = frmClienti.idCliente
    Sub caricaValori()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows.Count() > 0 Then
            cmbCliente.Text = tabella.Rows(0).Item("Cliente").ToString
        End If

        lblInsCliente.Text = cmbCliente.Text
    End Sub
    Function verificaDati(cliente As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti WHERE Cliente = '" & cliente & "' AND ID <> " & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        Dim corretto As Boolean = True
        If cliente = "" Or cliente.Length > frmConsuntivazione.cmbCliente.MaxLength Or tabella.Rows.Count > 0 Then
            lblBordoCliente.BackColor = Color.Red
            corretto = False
        End If
        Return corretto
    End Function
    Dim cliente As String
    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        cmbCliente.Text = StrConv(cmbCliente.Text.Replace("'", "").Trim, VbStrConv.ProperCase)
        cliente = cmbCliente.Text

        If Not verificaDati(cliente) Then
            Exit Sub
        End If

        cliPartenza()
        If cliente <> clientePartenza Then
            scelta = "modificaCliente&Commesse&Pregresso"
            frmCommesse.sfondoNeroClick = False
            frmMessaggio.lblMessaggio.Text = "Vuoi modificare anche le commesse associate?"
            frmMessaggio.formPartenza = "frmModificaCliente"
            frmMessaggio.richiesta = scelta
            frmMessaggio.Show()
            Exit Sub
        Else
            btnAnnulla_Click(sender, e) 'Chiudere il form
        End If
    End Sub
    Sub modificaCliente(cliente As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE Clienti SET Cliente = '" & cliente & "' WHERE ID = " & id
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Dim m As MouseEventArgs
        frmSfondoNero.frmSfondoNero_MouseClick(sender, m)
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        cliente = cmbCliente.Text
        cliente = cliente.Replace("'", "")

        If verificaCliente(cliente) Then
            scelta = "elimina"
            frmClienti.sfondoNeroClick = False
            frmMessaggio.lblMessaggio.Text = "Vuoi eliminare anche le commesse?"
            frmMessaggio.formPartenza = "frmModificaCliente"
            frmMessaggio.richiesta = scelta
            frmMessaggio.Show()
            Exit Sub
        End If
    End Sub
    Function verificaCliente(cliente)
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

        Try
            If tabella.Rows(0).Item("Cliente") IsNot Nothing Then
                Return True
            End If
        Catch ex As Exception
            lblBordoCliente.BackColor = Color.Red
            Return False
        End Try

        Return False
    End Function
    Dim clientePartenza As String = ""
    Sub cliPartenza()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT Cliente FROM Clienti WHERE ID = " & id
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
        str = "SELECT Cliente, Nota FROM LinkGR WHERE Cliente = '" & cmbCliente.Text & "'"
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

        If clientePartenza = cmbCliente.Text Then
            Return True
        End If

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT COUNT(0) AS NUM_RECORD FROM Clienti WHERE Cliente = '" & cmbCliente.Text & "'"
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
    Sub modificaClienteCommesse()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE LinkGR SET Cliente = '" & cmbCliente.Text & "' WHERE Cliente = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()

        cn.Open()
        str = "UPDATE Clienti SET Cliente = '" & cmbCliente.Text & "' WHERE Cliente = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Sub modificaPregresso()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "UPDATE Consuntivazione SET CLIENTE = '" & cmbCliente.Text & "' WHERE CLIENTE = '" & clientePartenza & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Sub eliminaPregresso()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE Consuntivazione WHERE CLIENTE = '" & cmbCliente.Text & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Sub eliminaCliente(c As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE FROM Clienti WHERE Cliente = '" & c & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Sub eliminaCommesseCliente(c As String)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "DELETE FROM LinkGR WHERE Cliente = '" & c & "'"
        cmd = New OleDbCommand(str, cn)
        Try
            str = cmd.ExecuteNonQuery
        Catch ex As Exception
            cn.Close()
            Exit Sub
        End Try
        cn.Close()
    End Sub
    Private Sub inviaModifiche_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnModifica_Click(sender, e)
        End If
    End Sub
    Dim allLabels As New List(Of Label)
    Private Sub caricaLabels()
        allLabels.AddRange({lblInsCliente})
    End Sub
    Private Sub RemovePipes(ByVal labels As List(Of Label))
        ' Rimuove tutti i caratteri "|" dal testo delle etichette specificate.
        For Each label In labels
            label.Text = label.Text.Replace("|", "")
        Next label
    End Sub
    Private Sub UpdateLabels()
        lblInsCliente.Text = cmbCliente.Text
    End Sub
    Private Sub AddPipe(label As Label)
        ' Aggiunge un carattere "|" alla fine del testo dell'etichetta specificata.
        If Not label.Text.Contains("|") Then
            label.Text &= "|"
        End If
    End Sub

    Private Sub lblInsCliente_Click(sender As Object, e As EventArgs) Handles lblInsCliente.Click
        cmbCliente.Focus()
        lblInsCliente.Text = cmbCliente.Text & "|"

        allLabels.Remove(lblInsCliente)
        RemovePipes(allLabels)
        allLabels.Add(lblInsCliente)
    End Sub
    Private Sub txtInserimento_TextChanged(sender As Object, e As EventArgs) Handles cmbCliente.TextChanged
        UpdateLabels()

        If cmbCliente.Focused And Not cmbCliente.Text.Contains("|") Then
            AddPipe(lblInsCliente)
            lblBordoCliente.BackColor = Color.Silver
        End If
    End Sub
    Private Sub txtInserimento_GotFocused(sender As Object, e As EventArgs) Handles cmbCliente.GotFocus
        UpdateLabels()

        If cmbCliente.Focused Then
            cmbCliente.SelectionStart = cmbCliente.Text.Length
            AddPipe(lblInsCliente)
            lblBordoCliente.BackColor = Color.Silver
        End If
    End Sub
    Private Sub cmbCliente_LostFocus(sender As Object, e As EventArgs) Handles cmbCliente.LostFocus
        If frmMessaggio.risultato <> "" Then
            Exit Sub
        End If

        If Not cmbCliente.Focused Then
            cmbCliente.Text.Replace("'", "")
            If cmbCliente.Text.Trim = "" Then
                lblBordoCliente.BackColor = Color.Red
            End If
            RemovePipes(allLabels)
        End If

        If Not controllaFormAttivo() And frmClienti.sfondoNeroClick = False Then
            frmClienti.chiudiTutto = True
            frmClienti.dgvModificaClienteClick = False
            frmClienti.BringToFront()
            frmCommesse.BringToFront()
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
            frmClienti.sfondoNeroClick = True
        End If
        Return formAttivo
    End Function
End Class