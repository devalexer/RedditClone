using RedditClone.Models;
using RedditClone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedditClone.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        [HttpPost]
        public ActionResult Up(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.FirstOrDefault(f => f.Id == id);
            post.UpVotes += 1;
            db.SaveChanges();
            var vm = new VoteButtonContainer { Post = post, VoteValue = 1 };
            return PartialView("_voteDisplay", post);
        }

        // GET: Vote
        [HttpPost]
        public ActionResult Down(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.FirstOrDefault(f => f.Id == id);
            post.DownVotes += 1;
            db.SaveChanges();
            var vm = new VoteButtonContainer { Post = post, VoteValue = -1 };
            return PartialView("_voteDisplay", post);
        }
    }
}