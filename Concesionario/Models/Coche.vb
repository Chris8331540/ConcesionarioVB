Imports System.ComponentModel.DataAnnotations

Public Class Coche

    Public Property Id As Integer
    <Display(Name:="Marca")>
    Public Property Brand As String

    <Display(Name:="Modelo")>
    Public Property Model As String

    <Display(Name:="Precio")>
    Public Property Price As Double

    <Display(Name:="Motor")>
    Public Property Engine As String

    <Display(Name:="Año")>
    Public Property Year As String

    <Display(Name:="Kilometraje")>
    Public Property Mileage As Double

    <Display(Name:="Combustible")>
    Public Property Fuel As FuelType

    <Display(Name:="Caja de cambios")>
    Public Property GearBox As GearBoxType

    <Display(Name:="Localización")>
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
