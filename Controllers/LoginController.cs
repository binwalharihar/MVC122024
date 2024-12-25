using mvc12122024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace mvc12122024.Controllers
{
    public class LoginController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Login
        public ActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginView(tblRegistration reg)
        {
            var data = (from R in db.tblRegistrations
                        where R.remail == reg.remail && R.rpassword == reg.rpassword
                        select R).ToList();

            if (data.Count > 0)
            {
                Session["IDD"] = data[0].rid;
                return RedirectToAction("LoginHome", "LoginHome");
            }
            else
            {
                ViewBag.Message = "Invalid email or password";
                return View();
            }
        }
    }
}