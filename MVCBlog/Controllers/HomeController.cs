using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Models;
using System.Data.Entity;

namespace MVCBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var lastFivePosts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3).ToList();
            ViewBag.SideBarPosts = lastFivePosts;
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);
            return View(posts.ToList());
        }
    }
}