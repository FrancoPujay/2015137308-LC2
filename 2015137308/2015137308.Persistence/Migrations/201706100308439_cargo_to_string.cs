namespace _2015137308.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cargo_to_string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleados", "Cargo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleados", "Cargo", c => c.Int());
        }
    }
}
