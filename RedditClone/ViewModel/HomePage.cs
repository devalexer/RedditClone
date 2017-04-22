using RedditClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.ViewModel
{
    public class HomePage
    {
        public IEnumerable<Post> Posts { get; set; }

    }
}