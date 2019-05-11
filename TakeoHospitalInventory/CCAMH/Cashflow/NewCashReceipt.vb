Public Class NewCashReceipt

    Private Sub PanelMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMain.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class