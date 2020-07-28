using System.ComponentModel.DataAnnotations;

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
        /* An enrollment record is for a single course, so there's a CourseID foreign key property and a Course navigation property. */
        public int CourseID { get; set; }
        /* An enrollment record is for a single student, so there's a StudentID foreign key property and a Student navigation property. */
        public int StudentID { get; set; }
        /* The Grade type indicates the Grade property is nullable. */
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        /* These are navigation properties that hold other entities related to this entity. */
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}