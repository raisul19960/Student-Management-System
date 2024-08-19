using Banglafire_Solution_Ltd_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banglafire_Solution_Ltd_Task.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentDbContext db;
        public StudentsController()
        {
            db = new StudentDbContext();
        }
        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(st);
                db.SaveChanges();

                return RedirectToAction("Create", new { message = "Data saved successfully" });
            }
            return View(st);
        }
        public ActionResult Edit(int id)
        {
            return View(db.Students.FirstOrDefault(x => x.StudentID == id));
        }
        [HttpPost]
        public ActionResult Edit(Student st)
        {
            if (ModelState.IsValid)
            {
                db.Entry(st).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ViewBag.Message = "Data Update successfully";
                return View("Edit", st);
            }
            return View(st);
        }
        public ActionResult Delete(int id)
        {
            var data = db.Students.FirstOrDefault(x => x.StudentID == id);
            if (data != null)
            {
                db.Students.Remove(data);
                db.SaveChanges();
                ViewBag.Message = "Record deleted successfully";
            }
            else
            {
                ViewBag.Message = "Record not found";
            }
            return RedirectToAction("Index");

        }
    }
}