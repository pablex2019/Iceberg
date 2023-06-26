namespace ICEBERG.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
