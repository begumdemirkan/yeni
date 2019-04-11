using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hw5.Models
{
    public class Department
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string Dname { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }


    }
}
