Module Globals

    Public gActiveUserName As String = "John Super Doe"
    Public gActiveUserGroup As String = "admin1"

    Public gDecimalSeparator As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString()

    Public UiStyles As New clsUiStyle

    Public gDeviceConfig As New DeviceModel()
    Public gActiveUserOptions As UserOptions

End Module
