Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CambioFechaTipoString
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Coches", "Year", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Coches", "Year", Function(c) c.DateTime(nullable := False))
        End Sub
    End Class
End Namespace
