Public Class infoGestionale

    Private Sub buttonChiudi_Click(sender As Object, e As EventArgs) Handles buttonChiudi.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles suggerimentiLink.LinkClicked
        Process.Start("mailto:info@tdesigner.it")
    End Sub

    Private Sub famLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles famLink.LinkClicked
        Process.Start("http://www.famfamfam.com/lab/icons/")
    End Sub

    Private Sub infoGestionale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.StartPosition = CType(FormStartPosition.CenterScreen = 1, FormStartPosition)
    End Sub
End Class