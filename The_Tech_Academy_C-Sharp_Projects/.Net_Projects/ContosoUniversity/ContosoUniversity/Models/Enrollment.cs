using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Enrollment
    {
        // We use enum for our list of Grades, since the letter grades are non-changing.
        public enum Grade
        {
            A, B, C, D, F
        }
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        // The Grade type indicates the Grade property is nullable.
        public Grade? Grade { get; set; }

        // These are navigation properties that hold other entities related to this entity.
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}