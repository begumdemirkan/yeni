using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hw5.Models;
using Hw5.Data;

namespace Hw5.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly StudentContext _context;

        public object Repository { get; private set; }

        public DepartmentsController(StudentContext context)
        {
            _context = context;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            var departments = _context.Students.ToList();

            return View(await _context.Department.ToListAsync());
        }



        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Department.Include(c => c.Students)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dname")] Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dep = _context.Department.Find(id);

            return View("Edit", dep);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dname")]Department department)
        {

            if (id != department.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(department);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(department.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


                //StudentContext.Entry(student).State = EntityState.Modified;
                //StudentContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Dname");
            return View(department);
        }

        private bool DepartmentExists(int ıd)
        {
            throw new NotImplementedException();
        }

        private bool StudentExists(int ıd)
        {
            throw new NotImplementedException();
        }




        public ActionResult Delete(int id = 0)
        {
            Department department = _context.Department.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = _context.Department.Find(id);
            _context.Department.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}
