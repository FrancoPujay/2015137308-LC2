namespace _2015137308.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hola : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteDTOes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Dni = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteDTOes");
        }
    }
}
