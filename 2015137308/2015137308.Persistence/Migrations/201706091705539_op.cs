namespace _2015137308.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class op : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        Placa = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.BusId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.Int(nullable: false, identity: true),
                        LugarViajeId = c.Int(nullable: false),
                        BusId = c.Int(nullable: false),
                        ClienteId = c.Int(),
                        TipoViaje = c.Int(),
                        Beneficiario = c.String(),
                        Peso = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Buses", t => t.BusId, cascadeDelete: true)
                .ForeignKey("dbo.LugarViajes", t => t.LugarViajeId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.LugarViajeId)
                .Index(t => t.BusId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.LugarViajes",
                c => new
                    {
                        LugarViajeId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 255),
                        TipoLugar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LugarViajeId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        TipoComprobante = c.Int(nullable: false),
                        TipoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.Empleados", t => t.EmpleadoId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Servicios", t => t.VentaId)
                .Index(t => t.VentaId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Dni = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Area = c.String(),
                        Cargo = c.Int(),
                        BusId = c.Int(),
                        TipoTripulacion = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.Buses", t => t.BusId, cascadeDelete: true)
                .Index(t => t.BusId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Dni = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "BusId", "dbo.Buses");
            DropForeignKey("dbo.Ventas", "VentaId", "dbo.Servicios");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Servicios", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Ventas", "EmpleadoId", "dbo.Empleados");
            DropForeignKey("dbo.Servicios", "LugarViajeId", "dbo.LugarViajes");
            DropForeignKey("dbo.Servicios", "BusId", "dbo.Buses");
            DropIndex("dbo.Empleados", new[] { "BusId" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropIndex("dbo.Ventas", new[] { "EmpleadoId" });
            DropIndex("dbo.Ventas", new[] { "VentaId" });
            DropIndex("dbo.Servicios", new[] { "ClienteId" });
            DropIndex("dbo.Servicios", new[] { "BusId" });
            DropIndex("dbo.Servicios", new[] { "LugarViajeId" });
            DropTable("dbo.Clientes");
            DropTable("dbo.Empleados");
            DropTable("dbo.Ventas");
            DropTable("dbo.LugarViajes");
            DropTable("dbo.Servicios");
            DropTable("dbo.Buses");
        }
    }
}
