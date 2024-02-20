Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmMessaggio
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function

    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
    Public risultato As String = ""
    Public formPartenza As String = ""
    Dim sfondoNeroClickMsg As Boolean = False
    Public richiesta As String
    Private Sub frmMessaggio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        impostaTab()
        gestisciDimensioni()
        impostaConfig()
    End Sub
    Sub gestisciDimensioni()
        Dim dimensione As Integer = lblMessaggio.Height - 20

        Me.Height = Me.MinimumSize.Height + dimensione

        impostaLocation()
        arrotondaBordi()
    End Sub
    Sub impostaTab()
        frmSfondoNero.BringToFront()
    End Sub
    Sub impostaLocation()
        Dim locationY As Integer = frmConsuntivazione.Location.Y + 31
        Dim locationX As Integer = frmConsuntivazione.Location.X + 8
        locationY += (frmConsuntivazione.Height / 2) - (Me.Height / 2)
        locationX += (frmConsuntivazione.Width / 2) - (Me.Width / 2)

        Me.Location = New Point(locationX, locationY)
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
                    lblMessaggio.ForeColor = ColorTranslator.FromHtml(value)
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Sub arrotondaBordi()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 15, 15))

        lblBordoSi.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoSi.Width, lblBordoSi.Height, 5, 5))
        btnSi.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSi.Width, btnSi.Height, 5, 5))

        lblBordoAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoAnnulla.Width, lblBordoAnnulla.Height, 5, 5))
        btnAnnulla.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAnnulla.Width, btnAnnulla.Height, 5, 5))

        lblBordoNo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblBordoNo.Width, lblBordoNo.Height, 5, 5))
        btnNo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNo.Width, btnNo.Height, 5, 5))
    End Sub

    Private Sub frmMessaggio_LostFocus(sender As Object, e As EventArgs) Handles txtHidden.LostFocus
        If Not controllaFormAttivo() And sfondoNeroClickMsg = False Then
            If risultato <> "" Or richiesta = "errore" Then
                Exit Sub
            End If
            Select Case formPartenza
                Case "frmModificaCliente"
                    frmClienti.chiudiTutto = True
                    frmClienti.dgvModificaClienteClick = False
                    frmModificaCliente.BringToFront()
                    frmModificaCliente.Focus()
                    Me.Close()
                Case "frmModificaCommessa"
                    frmCommesse.chiudiTutto = True
                    frmCommesse.dgvModificaCommessaClick = False
                    frmModificaCommessa.BringToFront()
                    frmModificaCommessa.Focus()
                    Me.Close()
            End Select
        End If
    End Sub
    Private Sub frmMessaggio_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Select Case formPartenza
            Case "frmModificaCliente"
                frmModificaCliente.BringToFront()
                frmModificaCliente.Focus()
            Case "frmModificaCommessa"
                frmModificaCommessa.BringToFront()
                frmModificaCommessa.txtCliente.Focus()
        End Select
    End Sub
    Function controllaFormAttivo()
        Dim formAttivo As Boolean = False
        For Each control As Control In Me.Controls
            If control.ContainsFocus Then
                formAttivo = True
                Exit For
            End If
        Next
        If frmSfondoNero.Focused Then
            sfondoNeroClickMsg = True
        End If
        Return formAttivo
    End Function
    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Select Case formPartenza
            Case "frmModificaCliente"
                Select Case richiesta
                    'MODIFICA CLIENTE
                    Case "modificaCliente&Commesse&Pregresso"
                        If Not frmModificaCliente.verificaCommesseCliente() Then
                            lblMessaggio.Text = "Non è possibile sostituire le commesse. Sono stati trovati dei duplicati"
                            errore()
                            gestisciDimensioni()
                            Exit Sub
                        End If
                        risultato = "cliente&commesse"

                        lblMessaggio.Text = "Vuoi modificare anche pregresso associato al cliente di partenza?"
                        richiesta = "modificaPregresso"
                        gestisciDimensioni()
                        Exit Sub

                    Case "modificaPregresso"
                        risultato += "&pregresso"

                    'ELIMINA CLIENTE
                    Case "elimina"
                        risultato = "cliente&commesse"
                        lblMessaggio.Text = "Vuoi modificare anche pregresso associato al cliente?"
                        richiesta = "modificaPregresso"
                        gestisciDimensioni()
                        Exit Sub
                End Select

            Case "frmModificaCommessa"
                Select Case richiesta
                    'MODIFICA COMMESSA
                    Case "modificaCommesse&Cliente&Pregresso"
                        If Not frmModificaCommessa.verificaCommesseCliente() Then
                            lblMessaggio.Text = "Non è possibile sostituire le commesse. Sono stati trovati dei duplicati"
                            errore()
                            gestisciDimensioni()
                            Exit Sub
                        End If
                        risultato = "commesse&cliente"

                        lblMessaggio.Text = "Vuoi modificare anche pregresso consuntivato con il cliente di partenza?"
                        richiesta = "modificaPregresso"
                        gestisciDimensioni()
                        Exit Sub

                    Case "modificaPregresso"
                        risultato += "&pregresso"

                    'ELIMINA COMMESSA
                    Case "eliminaCommessa"
                        risultato = "commessa"

                        If frmModificaCommessa.verificaUnicaCommessa Then
                            lblMessaggio.Text = "Questa è l'unica commessa per questo cliente. Vuoi modificare anche il cliente associato?"
                            richiesta = "eliminaCliente"
                            gestisciDimensioni()
                            Exit Sub
                        End If

                    Case "eliminaCliente"
                        risultato += "&cliente"
                        lblMessaggio.Text = "Vuoi eliminare anche pregresso consuntivato con questo cliente?"
                        richiesta = "eliminaPregresso"
                        gestisciDimensioni()
                        Exit Sub

                    Case "eliminaPregresso"
                        risultato += "&pregresso"
                End Select
        End Select
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Select Case formPartenza
            Case "frmModificaCliente"
                Select Case richiesta
                    'MODIFICA CLIENTE
                    Case "modificaCliente&Commesse&Pregresso"
                        risultato = "cliente"

                    Case "modificaPregresso"
                        risultato += "&noPregresso"

                    'ELIMINA CLIENTE
                    Case "elimina"
                        risultato = "cliente"
                End Select

            Case "frmModificaCommessa"
                Select Case richiesta
                    'MODIFICA COMMESSA
                    Case "modificaCommesse&Cliente&Pregresso"
                        risultato = "commessa"

                    Case "modificaPregresso"
                        risultato += "&noPregresso"

                    'ELIMINA COMMESSA
                    Case "eliminaCommessa"
                        risultato = "annulla"

                    Case "eliminaCliente"
                        risultato += "&noCliente"

                    Case "eliminaPregresso"
                        risultato += "&noPregresso"
                End Select
        End Select
        Me.Close()
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Select Case formPartenza
            Case "frmModificaCliente"
                risultato = "annulla"

            Case "frmModificaCommessa"
                risultato = "annulla"
        End Select
        Me.Close()
    End Sub
    Sub errore()
        btnSi.Visible = False
        lblBordoSi.Visible = False
        btnNo.Visible = False
        lblBordoNo.Visible = False

        btnAnnulla.Text = "Ok"
    End Sub

End Class