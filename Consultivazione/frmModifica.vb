Imports System.Data.OleDb
Imports System.IO
Public Class frmModifica
    Dim tabellaDB As String
    Dim colonna As String
    Dim riga As Integer
    Dim nota As String
    Dim id As String
    Dim cliente As String = frmConsuntivazione.clienteCondiviso
    ReadOnly strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Altro\Consuntivazione\published\Database\Consuntivazione.accdb"
    Private Sub Modifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabellaDB = frmConsuntivazione.tabellaCondivisa
        colonna = frmConsuntivazione.colonnaCondivisa
        riga = frmConsuntivazione.rigaCondivisa
        If tabellaDB <> "LinkGR" Then
            nota = frmConsuntivazione.dgvCalendario.Rows(riga).Cells(6).Value
        End If
        id = frmConsuntivazione.idCondiviso
        cliente = frmConsuntivazione.clienteCondiviso
        impostaTabModifica()
        impostaConfig()
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

                    rdbVuota.ForeColor = ColorTranslator.FromHtml(value)
                    rdbCriticita.ForeColor = ColorTranslator.FromHtml(value)
                    rdbFixed.ForeColor = ColorTranslator.FromHtml(value)
                    rdbFormazione.ForeColor = ColorTranslator.FromHtml(value)

                    ckbHome.ForeColor = ColorTranslator.FromHtml(value)
                    ckbAltro.ForeColor = ColorTranslator.FromHtml(value)
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
    End Sub

    Sub PulisciCampi()
        dtpData.Value = Now
        cmbCliente.Text = ""
        cmbTempo.Text = ""

        rdbVuota.Checked = True
        rdbCriticita.Checked = False
        rdbFixed.Checked = False
        rdbFormazione.Checked = False
        ckbHome.Checked = False
    End Sub

    Sub impostaTabModifica()
        Me.Width = 280
        gboxCliente.Visible = False
        gboxTempo.Visible = False
        gboxData.Visible = False
        gboxNota.Visible = False

        If colonna = "TEMPO" Then
            colonna += "_RISOLUZIONE"
        End If

        Select Case colonna
            Case "CLIENTE"
                gboxCliente.Visible = True
                gboxCliente.Left = 20
                TabIndex = 1
                gboxCliente.Focus()
                cmbCliente.Focus()

            Case "TEMPO_RISOLUZIONE"
                gboxTempo.Visible = True
                gboxTempo.Left = 20
                TabIndex = 2
                gboxTempo.Focus()
                cmbTempo.Focus()

            Case "DATA"
                gboxData.Visible = True
                gboxData.Left = 20
                TabIndex = 3
                gboxData.Focus()
                dtpData.Focus()

            Case "NOTA"
                If tabellaDB = "LinkGR" Then
                    ckbHome.Enabled = False
                    rdbCriticita.Enabled = False
                Else
                    ckbHome.Enabled = True
                    rdbCriticita.Enabled = True
                End If
                gboxNota.Visible = True
                gboxNota.Left = 20
        End Select

    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        frmConsuntivazione.annulla = True
        PulisciCampi()
        Me.Close()
    End Sub
    Private Sub cmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCliente.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = ""
            Exit Sub
        End If
    End Sub
    Private Sub cmbTempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTempo.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46))) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        End If
    End Sub

    Dim dato As String = ""
    Dim corretto As Boolean = False
    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim tabella As New DataTable
        Dim str As String

        If colonna = "TEMPO" Then
            colonna += "_RISOLUZIONE"
        End If

        Select Case colonna
            Case "CLIENTE"
                datoCliente()

            Case "TEMPO_RISOLUZIONE"
                datoTempo()
                Dim tempoExtra As String
                Dim vetDividiNota() As String
                If nota.ToLower.Contains("extra(") Then
                    vetDividiNota = nota.Split("(")
                    tempoExtra = CDbl(vetDividiNota(1).Substring(0, vetDividiNota(1).Length - 1))
                    nota = nota.Replace("Extra(" & tempoExtra & ")", "")
                    If nota = "" Then
                        nota = notaExtra
                    ElseIf notaExtra <> "" Then
                        nota = nota.Replace(", ", ", " + notaExtra)
                    ElseIf notaExtra = "" Then
                        nota = nota.Replace(", ", "")
                    End If
                ElseIf notaExtra <> "" And nota = "" Then
                    nota = notaExtra
                ElseIf notaExtra <> "" And nota <> "" Then
                    nota += ", " + notaExtra
                End If
            Case "DATA"
                datoData()

            Case "NOTA"
                If tabellaDB = "LinkGR" Then
                    datoNotaCommesse()
                Else
                    datoNota()
                End If
        End Select

        If corretto = False Then
            PulisciCampi()
            Exit Sub
        End If


        cn = New OleDbConnection(strConn)
        cn.Open()
        If dato = "" Then
            str = "UPDATE " & tabellaDB & " SET " & colonna & "= NULL WHERE ID = " & id
        ElseIf colonna = "TEMPO_RISOLUZIONE" And nota <> "" Then
            str = "UPDATE " & tabellaDB & " SET " & colonna & "='" & dato & "', NOTA = '" & nota & "' WHERE ID = " & id
        ElseIf colonna = "TEMPO_RISOLUZIONE" And nota = "" Then
            str = "UPDATE " & tabellaDB & " SET " & colonna & "='" & dato & "', NOTA = NULL WHERE ID = " & id
        Else
            str = "UPDATE " & tabellaDB & " SET " & colonna & "='" & dato & "' WHERE ID = " & id
        End If
        cmd = New OleDbCommand(str, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        If tabellaDB = "Consuntivazione" Then
            Call modificaTutteNote()
            If colonna = "TEMPO_RISOLUZIONE" Then
                Call controllaExtra()
            End If
        End If
        Me.Close()
    End Sub
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
        Dim giorno As String = tabella.Rows(0).Item("DATA").ToString


        cn.Open()
        str = "SELECT DATA, NOTA, ID FROM Consuntivazione WHERE DATA =#" & giorno & "#"
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
    Sub datoCliente()
        If cmbCliente.Text = "" Then
            MsgBox("Inserisci un cliente valido")
            corretto = False
            Exit Sub
        End If
        dato = cmbCliente.Text
        corretto = True
    End Sub
    Dim notaExtra As String = ""
    Sub datoTempo()
        dato = cmbTempo.Text
        If IsNumeric(dato) = False Then
            MsgBox("Inserisci un tempo di risoluzione valido")
            corretto = False
            Exit Sub
        End If
        dato = dato.Replace(".", ",")
        Dim vecchioTempo As String = frmConsuntivazione.dgvCalendario.Rows(riga).Cells(3).Value
        Dim nuovoTempo As Double
        notaExtra = ""
        If CDbl(frmConsuntivazione.lblTempoTot.Text) > 8 Then
            If CDbl(frmConsuntivazione.lblTempoTot.Text) - CDbl(vecchioTempo) + dato > 8 Then
                nuovoTempo = (CDbl(frmConsuntivazione.lblTempoTot.Text) - CDbl(vecchioTempo) + dato) - 8
                For i = 1 To frmConsuntivazione.dgvCalendario.Rows.Count - 1
                    Dim notaRiga As String = frmConsuntivazione.dgvCalendario.Rows(i).Cells(6).Value
                    If notaRiga.ToLower.Contains("extra") And i <> riga Then
                        Dim indice As Integer = notaRiga.IndexOf("(") + 1
                        notaRiga = notaRiga.Replace(")", "")
                        nuovoTempo -= CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                    End If
                Next
                If nuovoTempo > 0 Then
                    notaExtra = "Extra(" & nuovoTempo & ")"
                Else
                    notaExtra = ""
                End If
                corretto = True
                Exit Sub
            Else
                notaExtra = ""
                corretto = True
                Exit Sub
            End If
        End If
        If dato + CDbl(frmConsuntivazione.lblTempoTot.Text) - CDbl(vecchioTempo) > 8 Then
            nuovoTempo = (CDbl(frmConsuntivazione.lblTempoTot.Text) - CDbl(vecchioTempo) + dato) - 8
            For i = 1 To frmConsuntivazione.dgvCalendario.Rows.Count - 1
                Dim notaRiga As String = frmConsuntivazione.dgvCalendario.Rows(i).Cells(6).Value
                If notaRiga.ToLower.Contains("extra") Then
                    Dim indice As Integer = notaRiga.IndexOf("(") + 1
                    notaRiga = notaRiga.Replace(")", "")
                    nuovoTempo -= CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                End If
            Next
            If nuovoTempo > 0 Then
                notaExtra = "Extra(" & nuovoTempo & ")"
            Else
                notaExtra = ""
            End If
        End If
        corretto = True
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
        Dim giorno As String = tabella.Rows(0).Item("DATA").ToString


        cn.Open()
        str = "SELECT TEMPO_RISOLUZIONE, DATA, NOTA, ID FROM Consuntivazione WHERE DATA =#" & giorno & "#"
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
        Dim nuovoTempo As Double = CDbl(tabella.Rows(riga - 1).Item("TEMPO_RISOLUZIONE").ToString)
        If CDbl(frmConsuntivazione.lblTempoTot.Text) - vecchioTempo + nuovoTempo <= 8 Then
            For i = 0 To numRighe
                notaRiga = tabella.Rows(i).Item("NOTA").ToString
                If notaRiga.ToLower.Contains("extra(") Then
                    cn.Open()
                    str = "UPDATE Consuntivazione SET NOTA = NULL WHERE ID = " & tabella.Rows(i).Item("ID")
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
        End If
    End Sub
    Sub datoData()
        dato = dtpData.Text
        corretto = True
    End Sub
    Sub datoNota()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String


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

        Dim conta As Integer = 0
        If ckbHome.Checked = True Then
            dato = "Home"
        Else
            dato = ""
        End If

        If rdbCriticita.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "" Then
                    conta += 1
                End If
            Next
            If nota = "" Then
                nota = "Criticità"
            Else
                nota += ", Criticità"
            End If
        ElseIf rdbFixed.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Fixed" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa per il Bug Fix", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If nota = "" Then
                nota = "Fixed"
            Else
                nota += ", Fixed"
            End If
        ElseIf rdbFormazione.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Formazione" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa per la Formazione", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If nota = "" Then
                nota = "Formazione"
            Else
                nota += ", Formazione"
            End If
        Else
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "" Then
                    conta += 1
                End If
            Next
        End If

        If ckbAltro.Checked = True Then
            Dim notaInput As String
            notaInput = InputBox("Inserisci una nota").Trim.ToLower
            notaInput = StrConv(notaInput, VbStrConv.ProperCase)

            If notaInput.Length > 150 Then
                MsgBox("Nota non valida (Max 150 car.)", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf notaInput.ToLower.Contains("criticità") Or notaInput.ToLower.Contains("home") Or notaInput.ToLower.Contains("fixed") Or notaInput.ToLower.Contains("formazione") Then
                MsgBox("Nota non valida (non puo essere uno dei valori gia predefiniti)", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf notaInput.ToLower.Contains("extra") Then
                If CDbl(frmConsuntivazione.lblTempoTot.Text) <= 8 Then
                    MsgBox("Tempo extra non valido (non puoi inserire un tempo extra se hai fatto meno di 8 ore)", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                Dim tempoExtra As String = InputBox("Inserisci un tempo extra")
                tempoExtra = tempoExtra.Replace(".", ",")
                If IsNumeric(tempoExtra) = False Then
                    MsgBox("Tempo extra non valido (non è un numero)")
                    Exit Sub
                ElseIf tempoExtra > CDbl(frmConsuntivazione.dgvCalendario.Rows(riga).Cells(3).Value) Then
                    MsgBox("Tempo extra non valido (non può essere maggiore del tempo di risoluzione)", MsgBoxStyle.Exclamation)
                    Exit Sub
                ElseIf tempoExtra <= 0 Then
                    MsgBox("Tempo extra non valido (non può essere minore o uguale a 0)", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                notaInput = "Extra(" & tempoExtra & ")"
                notaInput = notaInput.Replace("'", "")
            End If
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = notaInput Then
                    conta += 1
                End If
            Next
            If conta > 1 And nota <> "" Then
                MsgBox("Non è consentito inserire 2 commesse nelle note!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If dato = "" Then
                dato = notaInput
            Else
                dato += ", " & notaInput
            End If
        End If
        If conta = 0 Then
            MsgBox("Questo cliente non ha la commessa standard", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        corretto = True
    End Sub
    Sub datoNotaCommesse()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        cliente = frmCommesse.dgvCommesse.Rows(riga).Cells(1).Value


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

        Dim conta As Integer = 0
        If rdbVuota.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "" Then
                    conta += 1
                End If
            Next
            dato = ""
        ElseIf rdbFixed.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Fixed" Then
                    conta += 1
                End If
            Next
            dato = "Fixed"
        ElseIf rdbFormazione.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Formazione" Then
                    conta += 1
                End If
            Next
            dato = "Formazione"
        ElseIf ckbAltro.Checked = True Then
            Dim notaInput As String
            notaInput = InputBox("Inserisci una nota").Trim.ToLower
            notaInput = StrConv(notaInput, VbStrConv.ProperCase)

            If notaInput.Length > 150 Then
                MsgBox("Nota non valida (Max 150 car.)")
                corretto = False
                Exit Sub
            ElseIf notaInput.ToLower.Contains("criticità") Or notaInput.ToLower.Contains("home") Or notaInput.ToLower.Contains("fixed") Or notaInput.ToLower.Contains("formazione") Then
                MsgBox("Nota non valida (non puo essere uno dei valori gia predefiniti)")
                corretto = False
                Exit Sub
            ElseIf notaInput.ToLower.Contains("extra") Then
                MsgBox("Non puoi inserire questa commessa")
                Exit Sub
                corretto = False
            End If
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i).ToLower = notaInput Then
                    conta += 1
                End If
            Next
            dato = notaInput
        End If
        If conta > 0 Then
            MsgBox("Questa commessa è gia presente")
            corretto = False
            Exit Sub
        End If
        corretto = True
    End Sub

    Private Sub dtpData_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpData.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnModifica_Click(sender, e)
        End If
    End Sub
    Private Sub cmbTempo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTempo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnModifica_Click(sender, e)
        End If
    End Sub
    Private Sub cmbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnModifica_Click(sender, e)
        End If
    End Sub

    Private Sub ckbAltro_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAltro.CheckedChanged
        If tabellaDB = "LinkGR" Then
            If ckbAltro.Checked = True Then
                rdbVuota.Checked = False
                rdbFixed.Checked = False
                rdbFormazione.Checked = False
                rdbVuota.Enabled = False
                rdbFixed.Enabled = False
                rdbFormazione.Enabled = False
            Else
                rdbVuota.Checked = True
                rdbFixed.Checked = False
                rdbFormazione.Checked = False
                rdbVuota.Enabled = True
                rdbFixed.Enabled = True
                rdbFormazione.Enabled = True
            End If
        Else
            rdbVuota.Enabled = True
            rdbFixed.Enabled = True
            rdbFormazione.Enabled = True
        End If
    End Sub
End Class