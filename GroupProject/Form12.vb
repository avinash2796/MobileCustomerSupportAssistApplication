Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileDataSet.Offers' table. You can move, or remove it, as needed.
        Me.OffersTableAdapter.FillByOffer(Me.MobileDataSet.Offers, "Aircel")

    End Sub
End Class