Public Class Coche
    Public Property Id As Integer
    Public Property Brand As String
    Public Property Model As String
    Public Property Price As Double
    Public Property Engine As String
    Public Property Year As DateTime

    Public Property Mileage As Double
    Public Property Fuel As FuelType
    Public Property GearBox As GearBoxType
    Public Property Location As String

    Public Enum FuelType
        Gasolina
        Diésel
    End Enum

    Public Enum GearBoxType
        Manual
        Automática
    End Enum
End Class
