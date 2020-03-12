using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityAAU.Models
{
    public class Student
    {
     
        public int ID { get; set; }


        [Display(Name = "Last name")]
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage ="Error message here!")]
        public string LastName { get; set; }

 
        [Display(Name = "First name")]
        [StringLength(20)]
        public string? FirstName { get; set; }

        [Display(Name = "First middle name")]
        [StringLength(20)]
        public string? FirstMidName { get; set; }
        //public string emailaddress { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]

        //FullName property returns 3 other properties, there is no column in db so there is no set accessor.
        public string FullName
        {
            get
            {
                return FirstName + ", " + FirstMidName + ", " + LastName;
            }
        }

        public DateTime EnrollmentDate { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
