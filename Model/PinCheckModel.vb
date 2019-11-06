Public Class PinCheckModel
    Public Property PinStates As New List(Of PinModel)

    ' TODO:  Pin configuration should be loaded from external configuration
    Public Sub New()
        Me.PinStates.Add(New PinModel("Pin 1", True))
        Me.PinStates.Add(New PinModel("2: Side A", False))
        Me.PinStates.Add(New PinModel("Pin 3", True))
        Me.PinStates.Add(New PinModel("4: Side B", False))
        Me.PinStates.Add(New PinModel("Pin 5", True))
    End Sub
End Class
