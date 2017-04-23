using RedditClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Services
{
    public class PostServices
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Post> GetAllPosts()
        {
            var list = db.Posts.ToList();
            return list;
        }
    }
}