using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc12122024.Models;
using System.IO;

namespace mvc12122024.Controllers
{
    public class EmployeeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Employee
        public ActionResult AddEmployee(int A=0)
        {
            ViewBag.EB = "Submit";
           tblEmployee obj = new tblEmployee();
            if (A > 0)
            {
                var data = (from E in db.tblEmployees where E.empid == A select E).ToList();
                obj.empid = data[0].empid;
                obj.empname = data[0].empname;
                obj.empage = data[0].empage;
                obj.empimage = data[0].empimage;
                ViewBag.img= data[0].empimage;
                ViewBag.EB = "Update";
            }
            return View(obj);
        }

        public ActionResult InsertEmployee(tblEmployee emp ,HttpPostedFileBase file)
        {
            if (emp.empid > 0)
            {
                if (file != null)
                {
                    string FN = Path.GetFileName(file.FileName);
                    file.SaveAs(Path.Combine(Server.MapPath("~/EmployeePics/"), FN));
                    System.IO.File.Delete(Server.MapPath(emp.empimage));
                    emp.empimage = "~/EmployeePics/" + FN;
                }
                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                string FN = DateTime.Now.Ticks.ToString()+Path.GetFileName(file.FileName);
                file.SaveAs(Path.Combine(Server.MapPath("~/EmployeePics/"), FN));
                emp.empimage = "~/EmployeePics/" + FN;
                db.tblEmployees.Add(emp);
               
            }
            db.SaveChanges();
            return RedirectToAction("ViewEmployee");
        }

        public ActionResult DeleteEmployee(int A=0)
        {
            var data = db.tblEmployees.Find(A);
            System.IO.File.Delete(Server.MapPath(data.empimage));
            db.tblEmployees.Remove(data);
            db.SaveChanges();
            return RedirectToAction("ViewEmployee");
        }

        public ActionResult ViewEmployee()
        {
            var data = db.tblEmployees.ToList();
            return View(data);
        }
    }
}