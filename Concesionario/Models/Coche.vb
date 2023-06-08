Public Class Coche
    Public Property Id As Integer
    Public Property Brand As String
    Public Property Model As String
    Public Property Price As Double
    Public Property Engine As String
    Public Property Year As String

    Public Property Mileage As Double
    Public Property Fuel As FuelType
    Public Property GearBox As GearBoxType
    Public Property Location As String

    Public Enum FuelType
        Gasolina
        Diésel
        Híbrido
        GLP
        Eléctrico
    End Enum

    Public Enum GearBoxType
        Manual
        Automatica
    End Enum
End Class
