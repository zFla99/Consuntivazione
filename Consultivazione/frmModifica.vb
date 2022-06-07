Imports System.Data.OleDb
Public Class frmModifica
    Dim tabellaDB As String
    Dim colonna As String
    Dim id As String
    Dim cliente As String = frmConsuntivazione.clienteCondiviso
    Private Sub Modifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabellaDB = frmConsuntivazione.tabellaCondivisa
        colonna = frmConsuntivazione.colonnaCondivisa
        id = frmConsuntivazione.idCondiviso
        cliente = frmConsuntivazione.clienteCondiviso
        caricaClientiTempo()
        impostaTabModifica()
    End Sub
    Private Sub frmModifica_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If corretto = False Then
            frmConsuntivazione.annulla = True
        End If
        PulisciCampi()
    End Sub
    Sub caricaClientiTempo()
        'Clienti
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT Cliente FROM Clienti ORDER BY Cliente"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        cmbCliente.Items.Clear()
        frmConsuntivazione.cmbCliente.Items.Clear()
        frmCommesse.cmbCliente.Items.Clear()
        For i = 0 To tabella.Rows.Count - 1
            cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmConsuntivazione.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
            frmCommesse.cmbCliente.Items.Add(tabella.Rows(i).Item("Cliente").ToString)
        Next

        'Tempo
        cmbTempo.Items.Clear()
        cmbTempo.Items.Add("0,25")
        cmbTempo.Items.Add("0,5")
        cmbTempo.Items.Add("0,75")
        cmbTempo.Items.Add("1")
        cmbTempo.Items.Add("1,25")
        cmbTempo.Items.Add("1,5")
        cmbTempo.Items.Add("1,75")
        cmbTempo.Items.Add("2")
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

            Case "TEMPO_RISOLUZIONE"
                gboxTempo.Visible = True
                gboxTempo.Left = 20

            Case "DATA"
                gboxData.Visible = True
                gboxData.Left = 20

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

            Case "DATA"
                datoData()

            Case "NOTA"
                datoNota()
        End Select

        If corretto = False Then
            PulisciCampi()
            Exit Sub
        End If

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        If dato = "" Then
            str = "UPDATE " & tabellaDB & " SET " & colonna & "= NULL WHERE ID = " & id
        Else
            str = "UPDATE " & tabellaDB & " SET " & colonna & "='" & dato & "' WHERE ID = " & id
        End If
        cmd = New OleDbCommand(str, cn)
        str = cmd.ExecuteNonQuery
        cn.Close()
        If tabellaDB = "Consuntivazione" Then
            Call modificaTutteNote()
        End If
        Me.Close()
    End Sub
    Sub modificaTutteNote()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
        cn.Open()
        str = "SELECT DATA FROM Consuntivazione WHERE ID =" & id
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()
        Dim giorno As String = tabella.Rows(0).Item("DATA").ToString


        cn.Open()
        str = "SELECT DATA, NOTA, ID FROM Consuntivazione WHERE DATA ='" & giorno & "'"
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
    Sub datoTempo()
        dato = cmbTempo.Text
        If IsNumeric(dato) = False Then
            MsgBox("Inserisci un tempo di risoluzione valido")
            corretto = False
            Exit Sub
        End If
        dato = dato.Replace(".", ",")
        corretto = True
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

        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath & "/Consuntivazione.accdb"
        cn = New OleDbConnection(str)
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
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa standard")
                corretto = False
                Exit Sub
            End If
            If dato = "" Then
                dato = "Criticità"
            Else
                dato += ", Criticità"
            End If
        ElseIf rdbFixed.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Fixed" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa per il Bug Fix")
                corretto = False
                Exit Sub
            End If

            If dato = "" Then
                dato = "Fixed"
            Else
                dato += ", Fixed"
            End If
        ElseIf rdbFormazione.Checked = True Then
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "Formazione" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa per la Formazione")
                corretto = False
                Exit Sub
            End If
            If dato = "" Then
                dato = "Formazione"
            Else
                dato += ", Formazione"
            End If
        Else
            For i = 0 To tabella.Rows.Count - 1
                If vetCommNota(i) = "" Then
                    conta += 1
                End If
            Next
            If conta = 0 Then
                MsgBox("Questo cliente non ha la commessa standard")
                corretto = False
                Exit Sub
            End If
        End If
        corretto = True
    End Sub
End Class