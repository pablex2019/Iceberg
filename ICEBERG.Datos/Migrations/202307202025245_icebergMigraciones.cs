namespace ICEBERG.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class icebergMigraciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false),
                        Apellidos = c.String(nullable: false),
                        Domicilio = c.String(nullable: false),
                        DNI = c.Int(),
                        TelefonoFijo = c.Int(),
                        Celular = c.Int(nullable: false),
                        CorreoElectronico = c.String(nullable: false),
                        SaldoDeudor = c.Single(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        ProveedorId = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false),
                        Cuit = c.String(nullable: false),
                        Cuil = c.String(),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Domicilio = c.String(nullable: false),
                        CorreoElectronico = c.String(nullable: false),
                        TelefonoFijo = c.Int(),
                        Celular = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProveedorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proveedores");
            DropTable("dbo.Clientes");
        }
    }
}
