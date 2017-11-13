Public Class Form22
    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileDataSet.Mobnet' table. You can move, or remove it, as needed.
        Me.MobnetTableAdapter.FillByNetwork(Me.MobileDataSet.Mobnet, "Vodafone")

    End Sub
End Class