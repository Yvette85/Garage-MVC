namespace GarageReturn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Valid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "Time", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParkedVehicles", "Time");
        }
    }
}
