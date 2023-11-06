using SmartShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Controllers
{
    public class RegisterController : Controller
    {
        private ModelDbContext db = new ModelDbContext();
        // GET: Register

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Register(Utente u)
        {
            if(ModelState.IsValid)
            {
                db.Utente.Add(u);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}