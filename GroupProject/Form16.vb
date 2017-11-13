Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileDataSet.Offers' table. You can move, or remove it, as needed.
        Me.OffersTableAdapter.FillByOffer(Me.MobileDataSet.Offers, "Idea")

    End Sub
End Class