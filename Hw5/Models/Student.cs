using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hw5.Models
{
    public class Student
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Email { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        public string ImageUrl { get; set; }
        public Department Department { get; set; }
        [NotMapped]
        public virtual IEnumerable<SelectListItem> departments { get; set; }

        public string CV { get; set; }

        public string StUserId { get; set; }
        public virtual StUser StUser { get; set; }


    }
}
