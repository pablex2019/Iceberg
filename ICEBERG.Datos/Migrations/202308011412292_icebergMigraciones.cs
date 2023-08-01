namespace ICEBERG.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class icebergMigraciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        ArticuloId = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descripción = c.String(nullable: false),
                        PrecioCosto = c.Single(),
                        PrecioPedidoPorMenor = c.Single(),
                        PrecioPedidoPorMayor = c.Single(),
                        FechaHora = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Categoría_CategoríaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticuloId)
                .ForeignKey("dbo.Categoría", t => t.Categoría_CategoríaId, cascadeDelete: true)
                .Index(t => t.Categoría_CategoríaId);
            
            CreateTable(
                "dbo.Categoría",
                c => new
                    {
                        CategoríaId = c.Int(nullable: false, identity: true),
                        Descripción = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Rubro_RubroId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoríaId)
                .ForeignKey("dbo.Rubroes", t => t.Rubro_RubroId)
                .Index(t => t.Rubro_RubroId);
            
            CreateTable(
                "dbo.Rubroes",
                c => new
                    {
                        RubroId = c.Int(nullable: false, identity: true),
                        Descripción = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RubroId);
            
            CreateTable(
                "dbo.ArticuloPedidoes",
                c => new
                    {
                        ArticuloPedidoId = c.Int(nullable: false, identity: true),
                        Articulo_ArticuloId = c.Int(),
                        Pedido_PedidoId = c.Int(),
                    })
                .PrimaryKey(t => t.ArticuloPedidoId)
                .ForeignKey("dbo.Articuloes", t => t.Articulo_ArticuloId)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_PedidoId)
                .Index(t => t.Articulo_ArticuloId)
                .Index(t => t.Pedido_PedidoId);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        FechaHora = c.DateTime(nullable: false),
                        ImportePedido = c.Single(nullable: false),
                        ImporteCostoDelPedido = c.Single(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Cliente_ClienteId = c.Int(),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Dni = c.Int(),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Domicilio = c.String(nullable: false),
                        TelefonoFijo = c.Int(),
                        Celular = c.Int(nullable: false),
                        CorreoElectronico = c.String(),
                        SaldoDeudor = c.Single(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Clave = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Empleado_EmpleadoId = c.Int(),
                        Perfil_PerfilId = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Empleadoes", t => t.Empleado_EmpleadoId)
                .ForeignKey("dbo.Perfils", t => t.Perfil_PerfilId)
                .Index(t => t.Empleado_EmpleadoId)
                .Index(t => t.Perfil_PerfilId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Legajo = c.Int(nullable: false),
                        Cuit = c.String(nullable: false),
                        Cuil = c.String(),
                        Dni = c.Int(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        CorreoElectronico = c.String(),
                        TelefonoFijo = c.Int(),
                        Celular = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Perfils",
                c => new
                    {
                        PerfilId = c.Int(nullable: false, identity: true),
                        Descripción = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PerfilId);
            
            CreateTable(
                "dbo.ArticuloProveedors",
                c => new
                    {
                        ArticuloProveedorId = c.Int(nullable: false, identity: true),
                        Articulo_ArticuloId = c.Int(),
                        Proveedor_ProveedorId = c.Int(),
                    })
                .PrimaryKey(t => t.ArticuloProveedorId)
                .ForeignKey("dbo.Articuloes", t => t.Articulo_ArticuloId)
                .ForeignKey("dbo.Proveedors", t => t.Proveedor_ProveedorId)
                .Index(t => t.Articulo_ArticuloId)
                .Index(t => t.Proveedor_ProveedorId);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        ProveedorId = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false),
                        Cuit = c.String(nullable: false),
                        Cuil = c.String(),
                        Dni = c.Int(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(nullable: false),
                        CorreoElectronico = c.String(),
                        TelefonoFijo = c.Int(),
                        Celular = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProveedorId);
            
            CreateTable(
                "dbo.LineaPedidoes",
                c => new
                    {
                        LineaPedidoId = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        ImportePedidosAcumulados = c.Single(nullable: false),
                        ImporteCostosPedidosAcumulados = c.Single(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LineaPedidoId);
            
            CreateTable(
                "dbo.Novedads",
                c => new
                    {
                        NovedadId = c.Int(nullable: false, identity: true),
                        FechaHora = c.DateTime(nullable: false),
                        Descripción = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.NovedadId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.OpciónMenu",
                c => new
                    {
                        OpciónMenuId = c.Int(nullable: false, identity: true),
                        Descripción = c.String(),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OpciónMenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Novedads", "Usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.ArticuloProveedors", "Proveedor_ProveedorId", "dbo.Proveedors");
            DropForeignKey("dbo.ArticuloProveedors", "Articulo_ArticuloId", "dbo.Articuloes");
            DropForeignKey("dbo.ArticuloPedidoes", "Pedido_PedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.Pedidoes", "Usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "Perfil_PerfilId", "dbo.Perfils");
            DropForeignKey("dbo.Usuarios", "Empleado_EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.Pedidoes", "Cliente_ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.ArticuloPedidoes", "Articulo_ArticuloId", "dbo.Articuloes");
            DropForeignKey("dbo.Articuloes", "Categoría_CategoríaId", "dbo.Categoría");
            DropForeignKey("dbo.Categoría", "Rubro_RubroId", "dbo.Rubroes");
            DropIndex("dbo.Novedads", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.ArticuloProveedors", new[] { "Proveedor_ProveedorId" });
            DropIndex("dbo.ArticuloProveedors", new[] { "Articulo_ArticuloId" });
            DropIndex("dbo.Usuarios", new[] { "Perfil_PerfilId" });
            DropIndex("dbo.Usuarios", new[] { "Empleado_EmpleadoId" });
            DropIndex("dbo.Pedidoes", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.Pedidoes", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.ArticuloPedidoes", new[] { "Pedido_PedidoId" });
            DropIndex("dbo.ArticuloPedidoes", new[] { "Articulo_ArticuloId" });
            DropIndex("dbo.Categoría", new[] { "Rubro_RubroId" });
            DropIndex("dbo.Articuloes", new[] { "Categoría_CategoríaId" });
            DropTable("dbo.OpciónMenu");
            DropTable("dbo.Novedads");
            DropTable("dbo.LineaPedidoes");
            DropTable("dbo.Proveedors");
            DropTable("dbo.ArticuloProveedors");
            DropTable("dbo.Perfils");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.ArticuloPedidoes");
            DropTable("dbo.Rubroes");
            DropTable("dbo.Categoría");
            DropTable("dbo.Articuloes");
        }
    }
}
