namespace WindowsFormsApp5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Humen",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        family = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Humen");
        }
    }
}
