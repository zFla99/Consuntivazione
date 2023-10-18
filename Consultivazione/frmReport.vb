Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft
Imports OpenQA.Selenium

Public Class frmReport
    ReadOnly strConn As String = frmConsuntivazione.strConn
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coloraBorders()
        cambioColoreBtn("Text: Ultimi 7 Giorni", e)
    End Sub
    Sub coloraBorders()
        btnCustom.FlatAppearance.BorderColor = frmConsuntivazione.lblSfondoColorato.BackColor
        btnOggi.FlatAppearance.BorderColor = frmConsuntivazione.lblSfondoColorato.BackColor
        btn7Giorni.FlatAppearance.BorderColor = frmConsuntivazione.lblSfondoColorato.BackColor
        btnMeseCorrente.FlatAppearance.BorderColor = frmConsuntivazione.lblSfondoColorato.BackColor
    End Sub
    Sub CaricaReport(giornoDa As Date, giornoA As Date)
        Dim selectData As String
        Dim whereData As String

        'CARICA NUM CLIENTI SEGUITI
        selectData = "COUNT(CLIENTE)"
        lblNumClienti.Text = getDati(giornoDa, giornoA, selectData)

        'CARICA NUM TICKET FATTI
        selectData = "COUNT(TICKET)"
        lblNumTicket.Text = getDati(giornoDa, giornoA, selectData)

        'CARICA ORE LAVORATE
        selectData = "SUM(TEMPO_RISOLUZIONE)"
        lblOreLavorate.Text = getDati(giornoDa, giornoA, selectData)

        'CARICA ORE EXTRA
        selectData = "NOTA"
        whereData = "AND NOTA LIKE '%Extra%'"
        lblOreExtra.Text = getDati(giornoDa, giornoA, selectData, whereData)

    End Sub
    Function getDati(giornoDa As Date, giornoA As Date, selectData As String, Optional whereData As String = "", Optional groupByData As String = "")
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String
        Dim dato As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        If selectData.Contains("COUNT(CLIENTE)") Then
            str = "SELECT " & selectData & " AS TOT FROM (SELECT DISTINCT CLIENTE FROM Consuntivazione WHERE DATA BETWEEN #" & Format(giornoDa, "MM/dd/yyyy") & "# AND #" & Format(giornoA, "MM/dd/yyyy") & "# " & If(groupByData <> "", groupByData, "") & ")"
        Else
            str = "SELECT " & selectData & " AS TOT FROM Consuntivazione WHERE DATA BETWEEN #" & Format(giornoDa, "MM/dd/yyyy") & "# AND #" & Format(giornoA, "MM/dd/yyyy") & "# " & If(whereData <> "", whereData, "") & " " & If(groupByData <> "", groupByData, "")
        End If
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        If tabella.Rows.Count = 1 Then
            dato = If(tabella.Rows(0).Item("TOT").ToString <> "", tabella.Rows(0).Item("TOT").ToString, "N/A")
        ElseIf selectData.Contains("NOTA") Then
            Dim tempo As Double = 0
            For i = 0 To tabella.Rows.Count - 1
                Dim notaRiga As String = tabella.Rows(i).Item("TOT").ToString
                If notaRiga.ToLower.Contains("extra") Then
                    Dim indice As Integer = notaRiga.IndexOf("(") + 1
                    notaRiga = notaRiga.Replace(")", "")
                    tempo += CDbl(notaRiga.Substring(indice, notaRiga.Length - indice))
                End If
            Next
            dato = If(tempo > 0, tempo, "N/A")
        Else
            dato = "N/A"
        End If

        Return dato
    End Function

    Private Sub cambioColoreBtn(sender As Object, e As EventArgs) Handles btnCustom.Click, btnOggi.Click, btn7Giorni.Click, btnMeseCorrente.Click
        btnCustom.BackColor = Color.WhiteSmoke
        btnOggi.BackColor = Color.WhiteSmoke
        btn7Giorni.BackColor = Color.WhiteSmoke
        btnMeseCorrente.BackColor = Color.WhiteSmoke

        btnCustom.ForeColor = Color.Black
        btnOggi.ForeColor = Color.Black
        btn7Giorni.ForeColor = Color.Black
        btnMeseCorrente.ForeColor = Color.Black

        dtpDataDa.Enabled = False
        dtpDataA.Enabled = False
        lblDataDa.ForeColor = Color.Gray
        lblDataA.ForeColor = Color.Gray

        If sender.ToString.Contains("Text: Custom") Then
            dtpDataDa.Value = Today.AddMonths(-1)
            dtpDataA.Value = Today

            btnCustom.BackColor = btnCustom.FlatAppearance.BorderColor
            btnCustom.ForeColor = frmConsuntivazione.lblGiorno.ForeColor

            dtpDataDa.Enabled = True
            dtpDataA.Enabled = True
            lblDataDa.ForeColor = Color.Black
            lblDataA.ForeColor = Color.Black
        ElseIf sender.ToString.Contains("Text: Oggi") Then
            dtpDataDa.Value = Today
            dtpDataA.Value = Today

            btnOggi.BackColor = btnOggi.FlatAppearance.BorderColor
            btnOggi.ForeColor = frmConsuntivazione.lblGiorno.ForeColor
        ElseIf sender.ToString.Contains("Text: Ultimi 7 Giorni") Then
            dtpDataDa.Value = Today.AddDays(-7)
            dtpDataA.Value = Today

            btn7Giorni.BackColor = btn7Giorni.FlatAppearance.BorderColor
            btn7Giorni.ForeColor = frmConsuntivazione.lblGiorno.ForeColor
        ElseIf sender.ToString.Contains("Text: Mese Corrente") Then
            dtpDataDa.Value = "01/" & (Today.Month) & "/" & (Today.Year)
            dtpDataA.Value = DateTime.DaysInMonth(Today.Year, Today.Month) & "/" & Today.Month & "/" & Today.Year

            btnMeseCorrente.BackColor = btnMeseCorrente.FlatAppearance.BorderColor
            btnMeseCorrente.ForeColor = frmConsuntivazione.lblGiorno.ForeColor
        End If
    End Sub
    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataDa.ValueChanged, dtpDataA.ValueChanged
        lblDataDa.Text = dtpDataDa.Text
        lblDataA.Text = dtpDataA.Text
        CambiaRagne()
    End Sub
    Sub CambiaRagne()
        CaricaReport(dtpDataDa.Value, dtpDataA.Value)
        caricaGrafici(dtpDataDa.Value, dtpDataA.Value)
    End Sub
    Sub caricaGrafici(giornoDa As Date, giornoA As Date)
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim tabella As New DataTable
        Dim str As String

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT COUNT(TICKET) AS TICKET, DATA FROM Consuntivazione WHERE DATA BETWEEN #" & Format(giornoDa, "MM/dd/yyyy") & "# AND #" & Format(giornoA, "MM/dd/yyyy") & "# GROUP BY DATA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        chtTicketTotali.DataSource = tabella
        chtTicketTotali.Series(0).XValueMember = "DATA"
        chtTicketTotali.Series(0).YValueMembers = "TICKET"
        chtTicketTotali.DataBind()

        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT TOP 6 COUNT(TICKET) AS TICKET, CLIENTE FROM Consuntivazione WHERE DATA BETWEEN #" & Format(giornoDa, "MM/dd/yyyy") & "# AND #" & Format(giornoA, "MM/dd/yyyy") & "# AND CLIENTE NOT IN ((SELECT Cliente FROM LinkGR WHERE Link LIKE '%Commessa=/%')) GROUP BY CLIENTE ORDER BY COUNT(TICKET) DESC"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabella.Clear()
        da.Fill(tabella)
        cn.Close()

        chtTicketPerCliente.DataSource = tabella
        chtTicketPerCliente.Series(0).XValueMember = "CLIENTE"
        chtTicketPerCliente.Series(0).YValueMembers = "TICKET"
        chtTicketPerCliente.DataBind()

        Dim tabellaDGV As New DataTable
        cn = New OleDbConnection(strConn)
        cn.Open()
        str = "SELECT TICKET, CLIENTE, TEMPO_RISOLUZIONE AS TEMPO, DATA, NOTA FROM Consuntivazione WHERE DATA BETWEEN #" & Format(giornoDa, "MM/dd/yyyy") & "# AND #" & Format(giornoA, "MM/dd/yyyy") & "# ORDER BY DATA, CLIENTE, NOTA"
        cmd = New OleDbCommand(str, cn)
        da = New OleDbDataAdapter(cmd)
        tabellaDGV.Clear()
        da.Fill(tabellaDGV)
        cn.Close()

        dgvReport.DataSource = tabellaDGV
    End Sub

    Private Sub lblDataDa_Click(sender As Object, e As EventArgs) Handles lblDataDa.Click
        dtpDataDa.Select()
        SendKeys.Send("%{DOWN}")
    End Sub

    Private Sub lblDataA_Click(sender As Object, e As EventArgs) Handles lblDataA.Click
        dtpDataA.Select()
        SendKeys.Send("%{DOWN}")
    End Sub

    Private Sub frmReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'RIDIMENSIONA PNL SUPERIORI

        Dim MeWidthDefault As Integer = 1030
        Dim pnlWidthDefault As Integer = 241
        Dim differenzaWidth As Integer

        differenzaWidth = Me.Width - MeWidthDefault
        pnlClientiSeguiti.Width = pnlWidthDefault + differenzaWidth / 4
        pnlTicketFatti.Width = pnlWidthDefault + differenzaWidth / 4
        pnlOreLavorate.Width = pnlWidthDefault + differenzaWidth / 4
        pnlOreExtra.Width = pnlWidthDefault + differenzaWidth / 4
        pnlClientiSeguiti.Left = 16
        pnlTicketFatti.Left = pnlClientiSeguiti.Location.X + pnlClientiSeguiti.Width + 6
        pnlOreLavorate.Left = pnlTicketFatti.Location.X + pnlTicketFatti.Width + 6
        pnlOreExtra.Left = pnlOreLavorate.Location.X + pnlOreLavorate.Width + 6

        'RIDIMENSIONARE GRAFICI E DATAGRID

        Dim MeHeightDefault As Integer = 596
        Dim chtTicketWidthDefault As Integer = 601

        Dim chtTicketHeightDefault As Integer = 256
        Dim pnlTicketHeightDefault As Integer = 155

        Dim chtClientiWithtDefault As Integer = 375

        Dim differenzaHeight As Integer


        differenzaWidth = Me.Width - MeWidthDefault
        chtTicketTotali.Width = chtTicketWidthDefault + differenzaWidth / 2
        pnlDGV.Width = chtTicketWidthDefault + differenzaWidth / 2

        chtTicketPerCliente.Width = chtClientiWithtDefault + differenzaWidth / 2
        chtTicketPerCliente.Left = chtTicketTotali.Left + chtTicketTotali.Width + 6

        differenzaHeight = Me.Height - MeHeightDefault
        chtTicketTotali.Height = chtTicketHeightDefault + differenzaHeight / 2

        pnlDGV.Height = pnlTicketHeightDefault + differenzaHeight / 2
        pnlDGV.Top = chtTicketTotali.Top + chtTicketTotali.Height + 6

        '122
        '539
        'ALTEZZA DEFAULT = 417
    End Sub
End Class