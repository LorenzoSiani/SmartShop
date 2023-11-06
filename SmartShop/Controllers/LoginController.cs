using SmartShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SmartShop.Controllers
{
    public class LoginController : Controller
    {
        private ModelDbContext db = new ModelDbContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Utente u)
        {
            if (ModelState.IsValid)
            {
                var user = db.Utente.Where(ut => ut.Email == u.Email && ut.Password == u.Password).FirstOrDefault();
                if (u != null)
                {
                    FormsAuthentication.SetAuthCookie(u.Email, false);
                    RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Utente non riconosciuto, controlla i dati e riprova.");
                    return View();
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}