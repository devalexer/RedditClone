namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinorUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UpVotes", c => c.Int());
            AlterColumn("dbo.Posts", "DownVotes", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "DownVotes", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "UpVotes", c => c.Int(nullable: false));
        }
    }
}
