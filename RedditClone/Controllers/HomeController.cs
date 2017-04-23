using RedditClone.Services;
using RedditClone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedditClone.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var vm = new HomePage();
            vm.Posts = new HomeServices().GetAllPosts();
            return View(vm);
        }

        [Authorize]
        public ActionResult Member()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}