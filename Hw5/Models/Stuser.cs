using Hw5.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Hw5.Models
{
    public class StUser : IdentityUser
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string City  { get; set; }




    }
}
//namespace Hw5.Models
//{
//    public class StudentContext : DbContext
//    {
//        public StudentContext()
//        {
//        }

//        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
//        {
//        }
//        public DbSet<Student> Students { get; set; }

//        internal object GetStudent()
//        {
//            throw new NotImplementedException();
//        }

//        public DbSet<Hw5.Models.Department> Department { get; set; }
//        internal object GetDepartment()
//        {
//            throw new NotImplementedException();
//        }

//    }
//}