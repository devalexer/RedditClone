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
        }

        protected override void Seed(RedditClone.Models.ApplicationDbContext context)
        {

            var post = new List<Post>
            {
                new Post{Title = "Bully gets the dropkick of justice!", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice!", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice!", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice!", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
                new Post{Title = "Bully gets the dropkick of justice!", Url = "http://i.imgur.com/D1jTcg5.gifv", Image = "/images/bully.jpg", UpVotes = 4, DownVotes = 0},
            };
            post.ForEach(oc => context.Posts.AddOrUpdate(o => o.Title, oc));
            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
