Imports System.IO
Imports System.Data.OleDb

Public Class frmImpostazioni
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Dim fileConfig As String = frmConsuntivazione.fileConfig
    Dim vetModifiche(1) As String
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtPathDB.GotFocus
        HideCaret(txtPathDB.Handle)
    End Sub
    Private Sub frmImpostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        impostaPathDB()
        vetModifiche(0) = "PATH_DB=" & txtPathDB.Text
        btnAnnulla.Select()
    End Sub
    Sub impostaPathDB()
        Dim sr As New StreamReader(fileConfig)
        Dim appoggio As String = sr.ReadLine
        Dim selezionaModifica As String = ""
        Dim path As String

        Do
            If appoggio.StartsWith("[") Then
                selezionaModifica = appoggio.Replace("[", "")
                selezionaModifica = selezionaModifica.Replace("]", "")
                appoggio = sr.ReadLine()
            End If
            If selezionaModifica = "Path" Then
                Dim index As Integer = appoggio.IndexOf("=") + 1
                path = appoggio.Substring(index, appoggio.Length - index)
                If appoggio.Contains("DB_PATH") Then
                    txtPathDB.Text = path
                End If
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
    End Sub
    Private Sub lblOpenFolderDB_Click(sender As Object, e As EventArgs) Handles lblOpenFolderDB.Click
        ofdPath.ShowDialog()
        txtPathDB.Text = ofdPath.FileName.ToString
        vetModifiche(0) = "DB_PATH=" & txtPathDB.Text
    End Sub

    Public modifica As Boolean = False
    Private Sub btnApplica_Click(sender As Object, e As EventArgs) Handles btnApplica.Click
        If MsgBox("Vuoi applicare le modifiche? Il programma verrà chiuso per apportarle.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.No Then
            Exit Sub
        End If
        Call applicaModifiche(vetModifiche)
        modifica = True
        Me.Close()
    End Sub
    Sub applicaModifiche(vetModifiche() As String)
        Dim vetVoceTesto() As String = vetModifiche(0).Split("=")
        Dim voce As String = vetVoceTesto(0)
        Dim testo As String = vetVoceTesto(1)
        Dim sr As New StreamReader(fileConfig)
        Dim sw As New StreamWriter(Path.ChangeExtension(fileConfig, "tmp"))
        Dim appoggio As String = sr.ReadLine()

        Do
            If appoggio.Contains(voce) Then
                sw.WriteLine(voce & "=" & testo)
            Else
                sw.WriteLine(appoggio)
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
        sw.Close()
        File.Copy(Path.ChangeExtension(fileConfig, "tmp"), fileConfig, True)
        File.Delete(Path.ChangeExtension(fileConfig, "tmp"))
    End Sub
    Sub applicaModifiche(pathDefault As String)
        Dim voce As String = "DB_PATH"
        Dim testo As String = pathDefault
        Dim sr As New StreamReader(fileConfig)
        Dim sw As New StreamWriter(Path.ChangeExtension(fileConfig, "tmp"))
        Dim appoggio As String = sr.ReadLine()

        Do
            If appoggio.Contains(voce) Then
                sw.WriteLine(voce & "=" & testo)
            Else
                sw.WriteLine(appoggio)
            End If
            appoggio = sr.ReadLine()
        Loop Until appoggio = Nothing
        sr.Close()
        sw.Close()
        File.Copy(Path.ChangeExtension(fileConfig, "tmp"), fileConfig, True)
        File.Delete(Path.ChangeExtension(fileConfig, "tmp"))
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub
End Class