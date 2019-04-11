using Hw5.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw5.Data
{
    
        public class StudentContext : IdentityDbContext<StUser>

        {
            public StudentContext(DbContextOptions<StudentContext> options)
                : base(options)
            {
            }

            public DbSet<Department> Department { get; set; }
            public DbSet<Student> Students { get; set; }
            


        
    }
}
