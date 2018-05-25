namespace GarageReturn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1212 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "ParkedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "VehicleTypes", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "VehicleTypes", c => c.Int(nullable: false));
            DropColumn("dbo.ParkedVehicles", "ParkedTime");
        }
    }
}
