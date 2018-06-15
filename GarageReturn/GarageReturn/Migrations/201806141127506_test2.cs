namespace GarageReturn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Parks");
        }
        
        public override void Down()
        {
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
    }
}
