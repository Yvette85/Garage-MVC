namespace GarageReturn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20180522 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "VehicleTypes", c => c.Int(nullable: false));
            DropColumn("dbo.ParkedVehicles", "Type");
            DropColumn("dbo.ParkedVehicles", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "Time", c => c.String());
            AddColumn("dbo.ParkedVehicles", "Type", c => c.String());
            DropColumn("dbo.ParkedVehicles", "VehicleTypes");
        }
    }
}
