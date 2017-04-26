using RedditClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace RedditClone.Services
{
    public class HomeServices
    {
        public IEnumerable<Post> GetAllPosts()
        {
            var rv = new ApplicationDbContext().Posts.Include(i => i.User).ToList();
            return rv;
        }


    }
}