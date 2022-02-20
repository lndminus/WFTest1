using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkFinder.Models;

namespace WorkFinder.Controllers
{
    public class AdPostController : Controller
    {
        private WorkFinderContext db;

        public AdPostController(WorkFinderContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public IActionResult CreatePost(int clientid)
        {
            ViewBag.ClientId = clientid;

            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(AdPost post)
        {

            db.AdPosts.Add(post);
            db.SaveChanges();
            return Content("створено");
        }
        public IActionResult ShowAdPost(int id)
        {
            AdPostManager manager = new AdPostManager();
            AdPost post = manager.GetPostById(db.AdPosts.ToList(), id);
            ViewBag.AdPost = post;
            return View();
        }

        [HttpGet]
        public IActionResult ShowPostForClient(int postid, int clientid)
        {
            AdPostManager manager = new AdPostManager();
            AdPost post = manager.GetPostById(db.AdPosts.ToList(), postid);
            ViewBag.AdPost = post;
            ViewBag.PostId = postid;
            ViewBag.ClientId = clientid;

            return View();
        }
        [HttpPost]
        public IActionResult ShowPostForClient(int postid, int clientid, string textr)
        {
            AuthorizationManager m = new AuthorizationManager();
            db.Requests.Add(new Models.Request() { RequestText = textr, AdPostId = postid, ClientId = clientid, RequestStatus = false }) ;
            db.SaveChanges();


            return Redirect("~/Authorization/ClientPage?login="+ m.GetAccountById(db.Clients.ToList(), clientid).Login);
        }

        [HttpGet]
        public IActionResult ShowPostForAdmin(int postid, string login, string password)
        {
            AuthorizationManager accmanager = new AuthorizationManager();
            if (accmanager.CheckAuthorization(db.Admins.ToList(), login, password))
            {
                AdPostManager manager = new AdPostManager();
                AdPost post = manager.GetPostById(db.AdPosts.ToList(), postid);
                ViewBag.AdPost = post;
                ViewBag.AdminLogin = login;
                ViewBag.PostId = postid;

                return View();
            }

            return Redirect("~/Home/Index");
        }
        [HttpPost]
        public IActionResult ShowPostForAdmin(int postid, string login)
        {
            AdPost post = new AdPost();
            post.AdPostId = postid;
            db.AdPosts.Remove(post);
            db.SaveChanges();
            return Redirect("~/Authorization/AdminPage?login=" + login);
        }


        public IActionResult ShowAllPosts(int clientid)
        {
            ViewBag.clientid = clientid;
            ViewBag.Posts = db.AdPosts.ToList();

            return View();

        }

        public IActionResult ShowAllPostsForAdmin(string login, string password)
        {
            ViewBag.AdminLogin = login;
            ViewBag.AdminPassword = password;
            ViewBag.Posts = db.AdPosts.ToList();

            return View();

        }

        [HttpGet]
        public IActionResult ShowRequest(int requestid, int clientid)
        {
            AdPostManager manager = new AdPostManager();
            AuthorizationManager accmanager = new AuthorizationManager();
            Request request = manager.GetRequestById(db.Requests.ToList(), requestid);
            AdPost post = manager.GetPostById(db.AdPosts.ToList(), request.AdPostId);
            IAccount client = accmanager.GetAccountById(db.Clients.ToList(), request.ClientId);
            ViewBag.Request = request;
            ViewBag.AdPost = post;
            ViewBag.Client = client;
            ViewBag.ClientId = clientid;

            return View();
        }
        [HttpPost]
        public IActionResult ShowRequest(int requestid, string login)
        {
            db.Requests.Find(requestid).RequestStatus = true;
            db.SaveChanges();
            ViewBag.Login = login;
            return View();
        }











        public IActionResult Index()
        {
            return View();
        }
    }
}
