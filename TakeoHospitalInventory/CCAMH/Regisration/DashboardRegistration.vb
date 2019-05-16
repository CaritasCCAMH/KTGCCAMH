Public Class DashboardRegistration

    Private Sub BtnNewClientRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewClientRegistration.Click
        'Dim FClientRegistration As New FormClientRegistration
        'FClientRegistration.ShowDialog()
        Dim frmClientReg As New FormClientRegistration
        frmClientReg.ShowDialog()
    End Sub
End Class
