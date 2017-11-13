Public Class Form19
    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileDataSet.Tarrif' table. You can move, or remove it, as needed.
        Me.TarrifTableAdapter.FillByTarrif(Me.MobileDataSet.Tarrif, "Vodafone")

    End Sub
End Class