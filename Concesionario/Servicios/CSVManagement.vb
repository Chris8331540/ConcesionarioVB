Imports System.IO
Imports Concesionario
Imports Concesionario.Controllers
Imports Microsoft.VisualBasic.FileIO

Public Class CSVManagement
    Implements ICSVManagement

    Public Sub SubirRegistroBD(registro As String()) Implements ICSVManagement.SubirRegistroBD
        Dim db = New MyDbContext()
        Dim coche = New Coche()

        coche.Brand = registro(0).ToString()
        coche.Model = registro(1).ToString()
        coche.Price = Double.Parse(registro(2).ToString())
        coche.Engine = registro(3).ToString()
        coche.Year = registro(4).ToString()
        coche.Mileage = Double.Parse(registro(5).ToString())
        coche.Fuel = System.Enum.Parse(GetType(Coche.FuelType), registro(6).ToString())
        coche.GearBox = System.Enum.Parse(GetType(Coche.GearBoxType), registro(7).ToString())
        coche.Location = registro(8).ToString()
        db.Coches.Add(coche)
        db.SaveChanges()

    End Sub

    Public Function SubirFicheroBD(archivoCSV As HttpPostedFileBase) As Boolean Implements ICSVManagement.SubirFicheroBD
        Dim resultado As Boolean = False
        If archivoCSV IsNot Nothing AndAlso archivoCSV.ContentLength > 0 Then
            Using reader As New StreamReader(archivoCSV.InputStream, Encoding.Default)
                Dim linea As String = reader.ReadLine() 'Se salta el encabezado

                Try
                    While Not reader.EndOfStream
                        linea = reader.ReadLine()
                        Dim registro As String() = linea.Split(";"c) 'Separa el registro por campos
                        SubirRegistroBD(registro)
                    End While
                Catch ex As Exception
                    Return False
                End Try

            End Using
            resultado = True
        End If

        Return resultado
    End Function

End Class
