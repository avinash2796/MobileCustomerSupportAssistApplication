Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileDataSet.Tarrif' table. You can move, or remove it, as needed.
        Me.TarrifTableAdapter.FillByTarrif(Me.MobileDataSet.Tarrif, "BSNL")

    End Sub
End Class