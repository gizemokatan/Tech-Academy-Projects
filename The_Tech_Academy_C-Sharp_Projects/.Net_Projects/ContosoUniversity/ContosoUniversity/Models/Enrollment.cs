using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    // We use enum for our list of Grades, since the letter grades are non-changing.
    // The enum must be placed outside of the Enrollment class to avoid ambiguity.
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        // The Grade type indicates the Grade property is nullable.
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // These are navigation properties that hold other entities related to this entity.
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}