Public Class DashboardCashRecieve

    Private Sub BtnCashReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCashReceipt.Click
        Dim CashReceipt As New NewCashReceipt
        CashReceipt.ShowDialog()
    End Sub
End Class
