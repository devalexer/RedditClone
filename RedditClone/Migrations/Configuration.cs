namespace RedditClone.Migrations
{
    using RedditClone.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RedditClone.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RedditClone.Models.ApplicationDbContext";
        }

        protected override void Seed(RedditClone.Models.ApplicationDbContext context)
        {
            var post = new List<Post>
            {
                new Post{Title = "Bully gets the dropkick of justice! 1", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice! 2", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice! 3", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice! 4", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice! 5", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
            };
            post.ForEach(oc => context.Posts.AddOrUpdate(o => o.Title, oc));
            context.SaveChanges();
        }
    }
}
