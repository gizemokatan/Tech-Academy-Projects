using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        /* This specifies data validation rules and validation error messages using attributes. 
         * The StringLength attribute sets the maximum length in the database and provides 
         * client side and server side validation. */
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        /* The DisplayFormat attribute is used to explicitly specify the date format. 
         * The ApplyFormatInEditMode setting specifies that the specified formatting should 
         * also be applied when the value is displayed in a text box for editing. */
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}