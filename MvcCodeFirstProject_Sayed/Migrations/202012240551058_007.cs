namespace MvcCodeFirstProject_Sayed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _007 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emloyees", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emloyees", "ImagePath");
        }
    }
}
