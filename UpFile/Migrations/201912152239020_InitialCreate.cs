namespace UpFile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fileus",
                c => new
                    {
                        imageid = c.Int(nullable: false),
                        image = c.Binary(),
                    })
                .PrimaryKey(t => t.imageid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fileus");
        }
    }
}
