namespace _2015137308.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spar : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClienteDTOes", newName: "Clientes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Clientes", newName: "ClienteDTOes");
        }
    }
}
