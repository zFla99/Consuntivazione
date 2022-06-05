Imports System.Data.OleDb
Public Class frmModifica
    Dim colonna As String
    Dim id As String
    Private Sub Modifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colonna = frmConsuntivazione.colonnaCondivisa
        id = frmConsuntivazione.idCondiviso
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
        cmbCliente.Items.Add("Acerbis")
        cmbCliente.Items.Add("Aspi")
        cmbCliente.Items.Add("Barilla")
        cmbCliente.Items.Add("Bottega Veneta")
        cmbCliente.Items.Add("Ducati")
        cmbCliente.Items.Add("Fiorentini")
        cmbCliente.Items.Add("Fomas")
        cmbCliente.Items.Add("Leroy Merlin")
        cmbCliente.Items.Add("MCZ")
        cmbCliente.Items.Add("OSN")
        cmbCliente.Items.Add("Prima Industrie")
        cmbCliente.Items.Add("Whirlpool")
        cmbCliente.Items.Add("Ynap")

        'Tempo
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
            str = "UPDATE Consuntivazione SET " & colonna & "= NULL WHERE ID = " & id
        Else
            str = "UPDATE Consuntivazione SET " & colonna & "='" & dato & "' WHERE ID = " & id
        End If
        cmd = New OleDbCommand(str, cn)
        str = cmd.ExecuteNonQuery
        cn.Close()
        Call modificaTutteNote()
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
    Dim cliente As String = frmConsuntivazione.clienteCondiviso
    Sub datoNota()
        If ckbHome.Checked = True Then
            dato = "Home"
        Else
            dato = ""
        End If

        If rdbCriticita.Checked = True Then
            If dato = "" Then
                dato = "Criticità"
            Else
                dato += ", Criticità"
            End If
        ElseIf rdbFixed.Checked = True Then
            If cliente = "Acerbis" Or cliente = "Barilla" Or cliente = "Fomas" Or cliente = "OSN" Or cliente = "Ynap" Then
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
            If cliente = "Aspi" Or cliente = "Bottega Veneta" Or cliente = "MCZ" Or cliente = "Prima Industrie" Or cliente = "Whirlpool" Or cliente = "Acerbis" Or cliente = "Fomas" Or cliente = "OSN" Or cliente = "Ynap" Then
                MsgBox("Questo cliente non ha la commessa per la Formazione")
                corretto = False
                Exit Sub
            End If
            If dato = "" Then
                dato = "Formazione"
            Else
                dato += ", Formazione"
            End If
        End If
        corretto = True
    End Sub
End Class