using mvc12122024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc12122024.Controllers
{
    public class LoginHomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: LoginHome
        public ActionResult LoginHome()
        {
            var ID=Convert.ToInt32(Session["IDD"]);
            var data = (from U in db.tblRegistrations
                        join C in db.tblCountries on U.rcountry equals C.cid
                        join S in db.tblStates on U.rstate equals S.sid
                        join G in db.tblGenders on U.rgender equals G.gid
                        where U.rid == ID
                        select new RegistrationJoin { rid = U.rid, rname = U.rname, remail = U.remail, rpassword = U.rpassword, rcountry = C.cname, rstate = S.sname, rgender = G.gender, rhobbies = U.rhobbies }).ToList();
            return View(data);
        }
    }
}