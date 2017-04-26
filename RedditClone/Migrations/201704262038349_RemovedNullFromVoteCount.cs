namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNullFromVoteCount : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UpVotes", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "DownVotes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "DownVotes", c => c.Int());
            AlterColumn("dbo.Posts", "UpVotes", c => c.Int());
        }
    }
}
