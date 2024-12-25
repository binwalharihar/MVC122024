﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc12122024.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult AddLogout()
        {
            Session.Abandon();
            return RedirectToAction("LoginView","Login");
        }
    }
}