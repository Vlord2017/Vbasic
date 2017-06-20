Public Class RibbonForm1 

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim forma As New save
        forma.MdiParent = Me
        forma.Show()
    End Sub

    Private Sub RibbonForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class