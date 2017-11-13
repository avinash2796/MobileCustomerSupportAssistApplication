Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileDataSet.Offers' table. You can move, or remove it, as needed.
        'Me.OffersTableAdapter.Fill(Me.MobileDataSet.Offers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim search As String = TextBox1.Text
        Me.OffersTableAdapter.FillBySearchAmt(Me.MobileDataSet.Offers, search)
    End Sub
End Class