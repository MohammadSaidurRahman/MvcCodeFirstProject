namespace MvcCodeFirstProject_Sayed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0007 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomType = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        ImagePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
        }
    }
}
