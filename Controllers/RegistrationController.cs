using mvc12122024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace mvc12122024.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        DatabaseContext db = new DatabaseContext();
        public ActionResult AddUser(int A = 0)
        {
            tblRegistration1 reg1 = new tblRegistration1();
            reg1.lstcountry = db.tblCountries.ToList();
            reg1.lstgender = db.tblGenders.ToList();
            var hdata = db.tblHobbies.ToList();
            reg1.lsthobby1 = hdata.Select(x => new tblHobbies1
            {
                hid = x.hid,
                hname = x.hname,
                isChecked = false
            }).ToList();
            ViewBag.bt = "submit";
            if (A > 0)
            {
                var data=(from R in db.tblRegistrations where  R.rid == A select R).ToList();
                reg1.rid = data[0].rid;
                reg1.rname = data[0].rname;
                reg1.rgender = data[0].rgender;
                reg1.remail= data[0].remail;
                reg1.rpassword = data[0].rpassword;
                reg1.rcountry = data[0].rcountry;
                reg1.rstate = data[0].rstate;
                string[] arr = data[0].rhobbies.Split(',');
                foreach(var a in reg1.lsthobby1)
                {
                    foreach(var b in arr)
                    {
                        if (a.hname == b)
                        {
                            a.isChecked = true;
                        }
                    }
                }
                ViewBag.bt = "update";
            }
            reg1.lststate = (from S in db.tblStates where S.cid == reg1.rcountry select S).ToList();
            return View(reg1);
        }

        [HttpPost]
        public ActionResult AddUser(tblRegistration1 reg1)
        {
            string pp = "";
            foreach (var a in reg1.lsthobby1)
            {
                if (a.isChecked == true)
                {
                    pp += a.hname + ",";
                }
            }
            pp = pp.TrimEnd(',');
            tblRegistration reg = new tblRegistration();
            reg.rname = reg1.rname;
            reg.rstate = reg1.rstate;
            reg.rpassword = reg1.rpassword;
            reg.remail = reg1.remail;
            reg.rcountry = reg1.rcountry;
            reg.rgender = reg1.rgender;
            reg.rhobbies = pp;
            if (reg1.rid > 0)
            {
                reg.rid = reg1.rid;
                db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                db.tblRegistrations.Add(reg);
            }
            db.SaveChanges();
            return RedirectToAction("ShowUser");
        }

        public ActionResult ShowUser()
        {
            var data = (from U in db.tblRegistrations
                        join C in db.tblCountries on U.rcountry equals C.cid
                        join S in db.tblStates on U.rstate equals S.sid
                        join G in db.tblGenders on U.rgender equals G.gid
                        select new RegistrationJoin { rid = U.rid, rname = U.rname, remail = U.remail, rpassword = U.rpassword, rcountry = C.cname, rstate = S.sname, rgender = G.gender, rhobbies = U.rhobbies }).ToList();
            return View(data);
        }

        public ActionResult DeleteUser(int A=0)
        {
            var data = db.tblRegistrations.Find(A);
            db.tblRegistrations.Remove(data);
            db.SaveChanges();
            return RedirectToAction("ShowUser");
        }
        public JsonResult BindState(int A)
        {
            var data = (from S in db.tblStates where S.cid == A select S).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}