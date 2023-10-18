Public Class frmSfondoNero
    Private Sub frmSfondoNero_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        frmClienti.sfondoNeroClick = True
        If Not frmConsuntivazione.menuChiuso Then
            frmConsuntivazione.lblSlide_Click(sender, e)
        End If
        If Application.OpenForms().OfType(Of Form)().Any(Function(frm) String.Compare(frm.Name, "frmModifica", True) = 0) Then
            frmModifica.Close()
        End If
        If Application.OpenForms().OfType(Of Form)().Any(Function(frm) String.Compare(frm.Name, "frmClienti", True) = 0) And Application.OpenForms().OfType(Of Form)().Any(Function(frm) String.Compare(frm.Name, "frmCommesse", True) = 0) Then
            frmClienti.Close()
            frmCommesse.Close()
            frmInserisciCliente.Visible = True
            frmInserisciCliente.BringToFront()
            Exit Sub
        End If
        If Application.OpenForms().OfType(Of Form)().Any(Function(frm) String.Compare(frm.Name, "frmInserisciCliente", True) = 0) Then
            frmInserisciCliente.Close()
        End If
        Me.Close()
    End Sub
End Class