namespace _2015137308.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class One : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Servicios", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Servicios", "LugarViaje_LugarViajeId", "dbo.LugarViajes");
            DropForeignKey("dbo.Servicios", "Bus_BusId1", "dbo.Buses");
            DropForeignKey("dbo.Servicios", "LugarViaje_LugarViajeId1", "dbo.LugarViajes");
            DropIndex("dbo.Servicios", new[] { "Bus_BusId" });
            DropIndex("dbo.Servicios", new[] { "LugarViaje_LugarViajeId" });
            DropIndex("dbo.Servicios", new[] { "Bus_BusId1" });
            DropIndex("dbo.Servicios", new[] { "LugarViaje_LugarViajeId1" });
            DropColumn("dbo.Servicios", "Bus_BusId");
            DropColumn("dbo.Servicios", "LugarViaje_LugarViajeId");
            RenameColumn(table: "dbo.Servicios", name: "Bus_BusId1", newName: "Bus_BusId");
            RenameColumn(table: "dbo.Servicios", name: "LugarViaje_LugarViajeId1", newName: "LugarViaje_LugarViajeId");
            AddColumn("dbo.Servicios", "BusId", c => c.Int());
            AddColumn("dbo.Servicios", "LugarViajeId", c => c.Int());
            AddColumn("dbo.Servicios", "BusId1", c => c.Int());
            AddColumn("dbo.Servicios", "LugarViajeId1", c => c.Int());
            AddColumn("dbo.Servicios", "ClienteId", c => c.Int());
            AddColumn("dbo.Servicios", "TipoViajeId", c => c.Int());
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Servicios", "Tipo", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Servicios", "Bus_BusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Servicios", "LugarViaje_LugarViajeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Servicios", "Bus_BusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Servicios", "LugarViaje_LugarViajeId", c => c.Int(nullable: false));
            AlterColumn("dbo.TipoViajes", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Servicios", "Bus_BusId");
            CreateIndex("dbo.Servicios", "LugarViaje_LugarViajeId");
            AddForeignKey("dbo.Servicios", "Bus_BusId", "dbo.Buses", "BusId", cascadeDelete: true);
            AddForeignKey("dbo.Servicios", "LugarViaje_LugarViajeId", "dbo.LugarViajes", "LugarViajeId", cascadeDelete: true);
            DropColumn("dbo.Servicios", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servicios", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Servicios", "LugarViaje_LugarViajeId", "dbo.LugarViajes");
            DropForeignKey("dbo.Servicios", "Bus_BusId", "dbo.Buses");
            DropIndex("dbo.Servicios", new[] { "LugarViaje_LugarViajeId" });
            DropIndex("dbo.Servicios", new[] { "Bus_BusId" });
            AlterColumn("dbo.TipoViajes", "Descripcion", c => c.String());
            AlterColumn("dbo.Servicios", "LugarViaje_LugarViajeId", c => c.Int());
            AlterColumn("dbo.Servicios", "Bus_BusId", c => c.Int());
            AlterColumn("dbo.Servicios", "LugarViaje_LugarViajeId", c => c.Int());
            AlterColumn("dbo.Servicios", "Bus_BusId", c => c.Int());
            AlterColumn("dbo.Servicios", "Tipo", c => c.String());
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String());
            DropColumn("dbo.Servicios", "TipoViajeId");
            DropColumn("dbo.Servicios", "ClienteId");
            DropColumn("dbo.Servicios", "LugarViajeId1");
            DropColumn("dbo.Servicios", "BusId1");
            DropColumn("dbo.Servicios", "LugarViajeId");
            DropColumn("dbo.Servicios", "BusId");
            RenameColumn(table: "dbo.Servicios", name: "LugarViaje_LugarViajeId", newName: "LugarViaje_LugarViajeId1");
            RenameColumn(table: "dbo.Servicios", name: "Bus_BusId", newName: "Bus_BusId1");
            AddColumn("dbo.Servicios", "LugarViaje_LugarViajeId", c => c.Int());
            AddColumn("dbo.Servicios", "Bus_BusId", c => c.Int());
            CreateIndex("dbo.Servicios", "LugarViaje_LugarViajeId1");
            CreateIndex("dbo.Servicios", "Bus_BusId1");
            CreateIndex("dbo.Servicios", "LugarViaje_LugarViajeId");
            CreateIndex("dbo.Servicios", "Bus_BusId");
            AddForeignKey("dbo.Servicios", "LugarViaje_LugarViajeId1", "dbo.LugarViajes", "LugarViajeId");
            AddForeignKey("dbo.Servicios", "Bus_BusId1", "dbo.Buses", "BusId");
            AddForeignKey("dbo.Servicios", "LugarViaje_LugarViajeId", "dbo.LugarViajes", "LugarViajeId");
            AddForeignKey("dbo.Servicios", "Bus_BusId", "dbo.Buses", "BusId");
        }
    }
}
