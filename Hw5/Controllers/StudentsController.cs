using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hw5.Data;
using Hw5.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Hw5.Controllers
{
    public class StudentsController : Controller
    {
        StudentContext StudentContext;

        private readonly IHostingEnvironment _hostingEnvironment;

        public StudentsController(StudentContext context, IHostingEnvironment hostingEnvironment)
        {
            StudentContext = context;
            _hostingEnvironment = hostingEnvironment;

        }





        public IActionResult Index()
        {
            var students = StudentContext.Students.Include(s => s.Department).ToList();

            return View(students);
        }


        public IActionResult Detail(int id)
        {
            Student student = StudentContext.Students.Include(s => s.Department).
                Where(s => s.Id == id).FirstOrDefault();
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }
        public ActionResult Add()
        {
            ViewData["DepartmentId"] = new SelectList(StudentContext.Department, "Id", "Dname", -1);
            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(Student student, IFormFile FileUrl)
        {
            if (ModelState.IsValid)
            {
                student.Department = StudentContext.Department.Where(x => x.Id == student.DepartmentId).FirstOrDefault();
                //StudentContext.Students.Add(student);

                string dirPath = Path.Combine(_hostingEnvironment.WebRootPath, @"uploads\");
                var fileName = Guid.NewGuid().ToString().Replace("-", "") + "_" + FileUrl.FileName;
                using (var fileStream = new FileStream(dirPath + fileName, FileMode.Create))
                {
                    await FileUrl.CopyToAsync(fileStream);
                }

                student.ImageUrl = fileName;
                StudentContext.Add(student);
                await StudentContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["DepartmentId"] = new SelectList(StudentContext.Department, "Id", "Dname", student.DepartmentId);

            return View(student);
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewData["DepartmentId"] = new SelectList(StudentContext.Department, "Id", "Dname", -1);
            var stu = StudentContext.Students.Find(id);

            return View("Edit", stu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Email,DepartmentId")] Student student)
        {

            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    StudentContext.Update(student);
                    await StudentContext.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


                StudentContext.Entry(student).State = EntityState.Modified;
                StudentContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["DepartmentId"] = new SelectList(StudentContext.Department, "Id", "Dname", student.DepartmentId);
            return View(student);
        }

        private bool StudentExists(int ıd)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id = 0)
        {
            Student student = StudentContext.Students.Include(s => s.Department).
              Where(s => s.Id == id).FirstOrDefault();
            Student stu = StudentContext.Students.Find(id);
            if (stu == null)
            {
                return HttpNotFound();
            }
            return View(stu);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }



        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student stu = StudentContext.Students.Find(id);
            StudentContext.Students.Remove(stu);
            StudentContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            StudentContext.Dispose();
            base.Dispose(disposing);
        }

    }
}


