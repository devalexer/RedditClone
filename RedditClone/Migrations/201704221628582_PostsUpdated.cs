namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Url", c => c.String());
            AddColumn("dbo.Posts", "Image", c => c.String());
            DropColumn("dbo.Posts", "Body");
            DropColumn("dbo.Posts", "PostedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "Body", c => c.String());
            DropColumn("dbo.Posts", "Image");
            DropColumn("dbo.Posts", "Url");
        }
    }
}
