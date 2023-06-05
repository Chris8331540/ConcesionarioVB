
Imports System.Data.Common
Imports System.Data.Entity

Public Class MyDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("SqlConnectionString")
    End Sub
    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        ' Configuraciones adicionales de Entity Framework, como convenciones y relaciones
        modelBuilder.Entity(Of Coche)().HasKey(Function(x) x.Id)
    End Sub
    Public Property Coches As DbSet(Of Coche)
End Class
