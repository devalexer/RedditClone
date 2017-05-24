using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedditClone.Models;

namespace RedditClone.ViewModel
{
    public class VoteButtonContainer
    {
        public Post Post { get; set; }
        public int VoteValue { get; set; }
    }
}