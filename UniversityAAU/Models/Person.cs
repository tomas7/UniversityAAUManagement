using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAAU.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Display(Name = "Last name")]
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Error message here!")]
        public string LastName { get; set; }

        [Display(Name = "First middle name")]
        [StringLength(20)]
        public string? FirstMidName { get; set; }
    }
}
