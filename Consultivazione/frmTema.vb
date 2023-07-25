Imports System.Runtime.InteropServices
Imports System.IO
Public Class frmTema
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function

    ReadOnly fileConfig As String = frmConsuntivazione.fileConfig
    ReadOnly logConfig As String = frmConsuntivazione.logConfig
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
                If appoggio.Contains("InserisciMenu_BackColor") Then
                    lblSfondoPannello.BackColor = ColorTranslator.FromHtml(value)

                ElseIf appoggio.Contains("InserisciMenu_ForeColor") Then
                    lblTestoPannello.BackColor = ColorTranslator.FromHtml(value)

                ElseIf appoggio.Contains("Form_BackColor") Then
                    Me.BackColor = ColorTranslator.FromHtml(value)
                    lblSfondoForm.BackColor = ColorTranslator.FromHtml(value)

                ElseIf appoggio.Contains("From_ForeColor") Then
                    gboxColori.ForeColor = ColorTranslator.FromHtml(value)
                    gboxIcone.ForeColor = ColorTranslator.FromHtml(value)

                    lblSfondoPannelloTesto.ForeColor = ColorTranslator.FromHtml(value)
                    lblTestoPannelloTesto.ForeColor = ColorTranslator.FromHtml(value)
                    lblSfondoFormTesto.ForeColor = ColorTranslator.FromHtml(value)
                    lblTestoFormTesto.ForeColor = ColorTranslator.FromHtml(value)

                    rdbIconeBianche.ForeColor = ColorTranslator.FromHtml(value)
                    rdbIconeNere.ForeColor = ColorTranslator.FromHtml(value)

                    lblTestoForm.BackColor = ColorTranslator.FromHtml(value)
                End If
            End If
            If selezionaModifica = "IconColor" Then
                If appoggio.Contains("white") Then
                    rdbIconeBianche.Checked = True
                    rdbIconeNere.Checked = False
                ElseIf appoggio.Contains("black") Then
                    rdbIconeBianche.Checked = False
                    rdbIconeNere.Checked = True
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Private Sub frmTema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call impostaConfig()
        If lblSfondoPannello.BackColor <> Me.BackColor Then
            lblSfondoPannello.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, lblSfondoPannello.Width - 2, lblSfondoPannello.Height - 2, 5, 1))
        End If
        If lblTestoPannello.BackColor <> Me.BackColor Then
            lblTestoPannello.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, lblSfondoPannello.Width - 2, lblSfondoPannello.Height - 2, 5, 1))
        End If
        If lblSfondoForm.BackColor <> Me.BackColor Then
            lblSfondoForm.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, lblSfondoPannello.Width - 2, lblSfondoPannello.Height - 2, 5, 1))
        End If
        If lblTestoForm.BackColor <> Me.BackColor Then
            lblTestoForm.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, lblSfondoPannello.Width - 2, lblSfondoPannello.Height - 2, 5, 1))
        End If
    End Sub


    Private Sub lblIconeBianche_Click(sender As Object, e As EventArgs) Handles lblIconeBianche.Click
        rdbIconeBianche.Checked = True
    End Sub

    Private Sub lblIconeNere_Click(sender As Object, e As EventArgs) Handles lblIconeNere.Click
        rdbIconeNere.Checked = True
    End Sub
    Sub valorizzaVetColori(voce As String, testo As String)
        Dim modificato As Boolean = False
        If vetColori Is Nothing = False Then
            For i = 0 To vetColori.Length - 1
                If vetColori(i).Contains(voce) Then
                    vetColori(i) = voce & "-" & testo
                    modificato = True
                End If
            Next
        End If
        If modificato = False Then
            contaColori += 1
            ReDim Preserve vetColori(contaColori)
            vetColori(contaColori) = voce & "-" & testo
        End If
    End Sub
    Sub modificaFile(vetColori() As String)
        For i = 0 To vetColori.Length - 1
            Dim vetVoceTesto() As String = vetColori(i).Split("-")
            Dim voce As String = vetVoceTesto(0)
            Dim testo As String = vetVoceTesto(1)
            Dim sr As New StreamReader(fileConfig)
            Dim sw As New StreamWriter(Path.ChangeExtension(fileConfig, "tmp"))
            Dim appoggio As String = sr.ReadLine()

            Using logFile As New System.IO.StreamWriter(logConfig, True)
                logFile.WriteLine(dataOraLog + "Nessuna modifica effettuata")
                Do
                    If appoggio.Contains(voce) Then
                        sw.WriteLine(testo)
                        logFile.WriteLine(dataOraLog + "Modificata config da " & appoggio & " a " & testo)
                    Else
                        sw.WriteLine(appoggio)
                    End If
                    appoggio = sr.ReadLine()
                Loop Until appoggio = Nothing
                sr.Close()
                sw.Close()
                File.Copy(Path.ChangeExtension(fileConfig, "tmp"), fileConfig, True)
                File.Delete(Path.ChangeExtension(fileConfig, "tmp"))
                logFile.WriteLine(dataOraLog + "Fine scrittura log Config - OK")
            End Using
        Next
    End Sub

    Dim vetColori() As String
    Dim contaColori As Integer = -1
    Private Sub lblSfondoPannello_Click(sender As Object, e As EventArgs) Handles lblSfondoPannello.Click
        Dim color As DialogResult
        color = ColorDialogTema.ShowDialog()

        If color = Windows.Forms.DialogResult.OK Then
            Dim hex_color As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialogTema.Color.R, ColorDialogTema.Color.G, ColorDialogTema.Color.B)
            Dim voce As String = "InserisciMenu_BackColor"
            Dim testo As String = "InserisciMenu_BackColor=" & hex_color

            lblSfondoPannello.BackColor = ColorDialogTema.Color
            Call valorizzaVetColori(voce, testo)
        End If
    End Sub

    Private Sub lblTestoPannello_Click(sender As Object, e As EventArgs) Handles lblTestoPannello.Click
        Dim color As DialogResult
        color = ColorDialogTema.ShowDialog()

        If color = Windows.Forms.DialogResult.OK Then
            Dim hex_color As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialogTema.Color.R, ColorDialogTema.Color.G, ColorDialogTema.Color.B)
            Dim voce As String = "InserisciMenu_ForeColor"
            Dim testo As String = "InserisciMenu_ForeColor=" & hex_color

            lblTestoPannello.BackColor = ColorDialogTema.Color
            Call valorizzaVetColori(voce, testo)
        End If
    End Sub

    Private Sub lblSfondoForm_Click(sender As Object, e As EventArgs) Handles lblSfondoForm.Click
        Dim color As DialogResult
        color = ColorDialogTema.ShowDialog()

        If color = Windows.Forms.DialogResult.OK Then
            Dim hex_color As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialogTema.Color.R, ColorDialogTema.Color.G, ColorDialogTema.Color.B)
            Dim voce As String = "Form_BackColor"
            Dim testo As String = "Form_BackColor=" & hex_color

            lblSfondoForm.BackColor = ColorDialogTema.Color
            Call valorizzaVetColori(voce, testo)
        End If
    End Sub

    Private Sub lblTestoForm_Click(sender As Object, e As EventArgs) Handles lblTestoForm.Click
        Dim color As DialogResult
        color = ColorDialogTema.ShowDialog()

        If color = Windows.Forms.DialogResult.OK Then
            Dim hex_color As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialogTema.Color.R, ColorDialogTema.Color.G, ColorDialogTema.Color.B)
            Dim voce As String = "From_ForeColor"
            Dim testo As String = "From_ForeColor=" & hex_color

            lblTestoForm.BackColor = ColorDialogTema.Color
            Call valorizzaVetColori(voce, testo)
        End If
    End Sub
    Public coloriModificati As Boolean = False
    Private Sub btnApplica_Click(sender As Object, e As EventArgs) Handles btnApplica.Click
        If frmConsuntivazione.coloreIcone = "white" And rdbIconeNere.Checked = True Then
            Dim voce As String = "IconsColor"
            Dim testo As String = "IconsColor=black"
            valorizzaVetColori(voce, testo)
        ElseIf frmConsuntivazione.coloreIcone = "black" And rdbIconeBianche.Checked = True Then
            Dim voce As String = "IconsColor"
            Dim testo As String = "IconsColor=white"
            valorizzaVetColori(voce, testo)
        End If

        dataOraLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - "
        Using logFile As New System.IO.StreamWriter(logConfig, True)
            logFile.WriteLine(dataOraLog + "------------------------------------------")
            logFile.WriteLine(dataOraLog + "Inizio scrittura log Config:")
        End Using
        If vetColori Is Nothing Then
            MsgBox("Non è stata fatta nessuna modifica", MsgBoxStyle.Exclamation)
            Using logFile As New System.IO.StreamWriter(logConfig, True)
                logFile.WriteLine(dataOraLog + "Nessuna modifica effettuata")
                logFile.WriteLine(dataOraLog + "Fine scrittura log Config - OK")
            End Using
            Exit Sub
        End If

        modificaFile(vetColori)
        MsgBox("I colori sono stati modificati correttamente. L'applicazione verrà chiusa per apportare le modifiche.", MsgBoxStyle.Information)
        coloriModificati = True
        Me.Close()
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        vetColori = Nothing
        contaColori = -1
        Me.Close()
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        If MsgBox("Sei sicuro di voler rimettere le impostazioni di default? Non potrai piu tornare indietro.
Attualmente questo tasto ripristina tutte le configurazioni e non solo il colore.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
            Dim fileConfigDefault As String = fileConfig
            fileConfigDefault = fileConfigDefault.Replace("\config.ini", "\configDefault.ini")
            File.Copy(fileConfigDefault, fileConfig, True)
            MsgBox("I colori sono stati modificati correttamente. L'applicazione verrà chiusa per apportare le modifiche.", MsgBoxStyle.Information)
            coloriModificati = True
            Using logFile As New System.IO.StreamWriter(logConfig, True)
                logFile.WriteLine(dataOraLog + "Impostati config di Default")
                logFile.WriteLine(dataOraLog + "Fine scrittura log Config - OK")
            End Using
            Me.Close()
        End If
    End Sub
End Class