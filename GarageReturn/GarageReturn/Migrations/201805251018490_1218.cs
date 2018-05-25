namespace GarageReturn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1218 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "VehicleTypes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "VehicleTypes", c => c.String());
        }
    }
}
