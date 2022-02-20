using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkFinder.Models;


namespace WorkFinder.Controllers
{
    public class AuthorizationController : Controller
    {

        private WorkFinderContext db;

        public AuthorizationController(WorkFinderContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public IActionResult AuthorizationPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AuthorizationPage(string login, string password)
        {

            AuthorizationManager checker = new AuthorizationManager();
            IEnumerable<IAccount> clientaccounts = db.Clients.ToList();
            IEnumerable<IAccount> adminaccounts = db.Admins.ToList();
            if (checker.CheckAuthorization(clientaccounts, login, password))
            {
                return Redirect("~/Authorization/ClientPage?login=" + login);
            }
            else if (checker.CheckAuthorization(adminaccounts, login, password))
            {
                return Redirect("~/Authorization/AdminPage?login=" + login);
            }
            return Redirect("~/Authorization/Registration");
        }

        [HttpGet]
        public IActionResult RegistrationPage(string massage)
        {
            ViewBag.Massage = massage;
            return View();
        }
        [HttpPost]
        public IActionResult RegistrationPage(string login, string password, string name, string surename)
        {
            AuthorizationManager checker = new AuthorizationManager();

            if (!checker.FindLogin(db.Clients.ToList(), login) && !checker.FindLogin(db.Admins.ToList(), login))
            {
                if (login != null && password != null && name != null && surename != null)
                {
                    return Redirect("~/Authorization/RegistrationPage?massage=" + "акаунт створено");
                }

                return Redirect("~/Authorization/RegistrationPage?massage=" + "не усі поля заповнені");

            }

            return Redirect("~/Authorization/RegistrationPage?massage=" + "Логін " + login + " зайнятий");
        }

        public IActionResult AdminPage(string login)
        {
            if (login == null)
            {
                return RedirectToAction("Index");
            }
            AuthorizationManager manager = new AuthorizationManager();
            ViewBag.Admin = manager.GetAccount(db.Admins.ToList(), login);
            return View();
        }

        public IActionResult ClientPage(string login)
        {
            if (login == null)
            {
                return RedirectToAction("Index");
            }
            AuthorizationManager manager = new AuthorizationManager();
            ViewBag.postid = 1;
            ViewBag.Client = manager.GetAccount(db.Clients.ToList(), login);
            List<AdPost> ClientPosts = new List<AdPost>();
            List<Request> ClientPostRequest = new List<Request>();
            foreach (AdPost p in db.AdPosts.ToList())
            {
                if (p.ClientId == manager.GetAccount(db.Clients.ToList(), login).Id)
                {
                    foreach (Request r in db.Requests.ToList())
                    {
                        if (r.AdPostId == p.AdPostId)
                        {
                            ClientPostRequest.Add(r);
                        }
                    }
                    ClientPosts.Add(p);
                }
            }
            ViewBag.ClientPosts = ClientPosts;
            ViewBag.ClientPostRequests = ClientPostRequest;
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
