namespace _2015137308.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Two : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TipoLugars", newName: "TipoLugares");
            AlterColumn("dbo.TipoTripulaciones", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Servicios", "Tipo", c => c.String(maxLength: 255));
            AlterColumn("dbo.LugarViajes", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.TipoLugares", "Descripcion", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoLugares", "Descripcion", c => c.String());
            AlterColumn("dbo.LugarViajes", "Descripcion", c => c.String());
            AlterColumn("dbo.Servicios", "Tipo", c => c.String(maxLength: 4000));
            AlterColumn("dbo.TipoTripulaciones", "Descripcion", c => c.String());
            RenameTable(name: "dbo.TipoLugares", newName: "TipoLugars");
        }
    }
}
