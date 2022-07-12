namespace WindowsFormsApp5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class height : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "hieght", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "hieght");
        }
    }
}
