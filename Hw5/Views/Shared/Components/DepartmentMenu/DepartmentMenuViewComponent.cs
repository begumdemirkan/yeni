using Hw5.Data;
using Hw5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw5.Views.Shared.Components.DepartmentMenu
{
    public class DepartmentMenuViewComponent : ViewComponent
    {
        private readonly StudentContext dbContext;


        public DepartmentMenuViewComponent(StudentContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var departments = await dbContext.Department.ToListAsync();
            return View(departments);
        }
    }
}