Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Concesionario_uno
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Coches",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Brand = c.String(),
                        .Model = c.String(),
                        .Price = c.Double(nullable := False),
                        .Engine = c.String(),
                        .Year = c.DateTime(nullable := False),
                        .Mileage = c.Double(nullable := False),
                        .Fuel = c.Int(nullable := False),
                        .GearBox = c.Int(nullable := False),
                        .Location = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Coches")
        End Sub
    End Class
End Namespace
