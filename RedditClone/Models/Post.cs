using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedditClone.Models;

namespace RedditClone.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public int UpVotes { get; set; } = 0;
        public int DownVotes { get; set; } = 0;
        public DateTime PostedAt { get; set; } = DateTime.Now;


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}