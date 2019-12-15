namespace UpFile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Fileus");
            AlterColumn("dbo.Fileus", "imageid", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Fileus", "imageid");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Fileus");
            AlterColumn("dbo.Fileus", "imageid", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Fileus", "imageid");
        }
    }
}
