namespace GarageReturn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegNum = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        Brand = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        NumberOfWheels = c.Int(nullable: false),
                        ParkedTime = c.DateTime(nullable: false),
                        MemberId = c.Int(nullable: false),
                        VehiclesTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleTypes", t => t.VehiclesTypeId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.VehiclesTypeId);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegNum = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        Brand = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        NumberOfWheels = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkedVehicles", "VehiclesTypeId", "dbo.VehicleTypes");
            DropForeignKey("dbo.ParkedVehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.ParkedVehicles", new[] { "VehiclesTypeId" });
            DropIndex("dbo.ParkedVehicles", new[] { "MemberId" });
            DropTable("dbo.Parks");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.ParkedVehicles");
            DropTable("dbo.Members");
        }
    }
}
