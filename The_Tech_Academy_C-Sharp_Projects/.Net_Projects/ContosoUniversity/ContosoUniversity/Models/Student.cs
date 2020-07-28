using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        /* The Required attribute makes the name properties required fields. The Required attribute is not needed for value types 
         * such as DateTime, int, double, and float. Value types cannot be assigned a null value, so they are inherently treated 
         * as required fields. The Required attribute must be used with MinimumLength for the MinimumLength to be enforced.*/
        [Required]
        [StringLength(50)]
        /* The Display attribute specifies that the caption for the text boxes should be "First Name", "Last Name", "Full Name", 
         * and "Enrollment Date" instead of the property name in each instance. */
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        /* This specifies data validation rules and validation error messages using attributes. 
         * The StringLength attribute sets the maximum length in the database and provides 
         * client side and server side validation. */
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        /* The Column attribute specifies that when the database is created, the column of the Student table
         * that maps to the FirstMidName property will be named FirstName. If you don't specify column names, 
         * they are given the same name as the property name. */
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        /* If you use the DataType attribute with a date field, you have to specify the DisplayFormat 
         * attribute also in order to ensure that the field renders correctly in Chrome browsers. */
        [DataType(DataType.Date)]
        /* The DisplayFormat attribute is used to explicitly specify the date format. 
         * The ApplyFormatInEditMode setting specifies that the specified formatting should 
         * also be applied when the value is displayed in a text box for editing. */
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        /* FullName is a calculated property that returns a value that's created by concatenating two other properties. 
         * Therefore it has only a get accessor, and no FullName column will be generated in the database. */
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}