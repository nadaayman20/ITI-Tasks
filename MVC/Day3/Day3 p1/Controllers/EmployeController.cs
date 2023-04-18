using Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Controllers
{
    public class EmployeController : Controller
    {
        EMPLOYEESEntities context = new EMPLOYEESEntities();

        // GET: Employe
        public ActionResult show()
        {
            return View( context.Depts.ToList());
        }
        public ActionResult Index()
        {
            return View(context.Emps.ToList());
        }
        public ActionResult data(int deptID)
        {
            return View(context.Emps.Where(E => E.dID == deptID).ToList());
        }

        // GET: Employe/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Emps.FirstOrDefault(e=>e.EmpID == id));
        }

        // GET: Employe/Create
        public ActionResult Create()
        {
            SelectList department = new SelectList(context.Depts.ToList(), "DeptID", "DeptName");
            ViewBag.department = department;
            return View();
           
        }

        // POST: Employe/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Emp employee = new Emp()
                {
                    EmpFname = collection["EmpFname"],
                    EmpLname = collection["EmpLname"],
                    EmpHDate = Convert.ToDateTime(collection["EmpHDate"]),
                    EmpSalary = double.Parse(collection["EmpSalary"]),
                    dID = int.Parse(collection["dID"]),
                    CtyID = int.Parse(collection["CtyID"])
                };
               context.Emps.Add(employee);
                context.SaveChanges();
               
            }   
        
            catch
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        // GET: Employe/Edit/5
        public ActionResult Edit(int id)
        {
            SelectList department = new SelectList(context.Depts.ToList(),"DeptID", "DeptName");
            ViewBag.department = department;
            return View(context.Emps.FirstOrDefault(e => e.EmpID == id));
          
        }

        // POST: Employe/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Emp employee = context.Emps.FirstOrDefault(ct => ct.EmpID == id);
                employee.EmpFname = collection["EmpFname"];
                employee.EmpLname = collection["EmpLname"];
                employee.EmpHDate = Convert.ToDateTime(collection["EmpHDate"]);
                employee.EmpSalary = double.Parse(collection["EmpSalary"]);
                employee.dID = int.Parse(collection["dID"]);
                employee.CtyID = int.Parse(collection["CtyID"]);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Employe/Delete/5
        public ActionResult Delete(int id)
        {
            Emp employee = context.Emps.FirstOrDefault(e => e.EmpID == id);
            context.Emps.Remove(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


     
    }
}
