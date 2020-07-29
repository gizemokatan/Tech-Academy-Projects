using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    /* The main class that coordinates Entity Framework functionality for a given data model is the database context class. 
     * You create this class by deriving from the System.Data.Entity.DbContext class. In your code, you specify which entities 
     * are included in the data model. */
    public class SchoolContext : DbContext
    {
        /* This code creates a DbSet property for each entity set. In Entity Framework terminology, 
         * an entity set typically corresponds to a database table, and an entity corresponds to a row in the table. */
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        /* The modelBuilder.Conventions.Remove statement in the OnModelCreating method prevents table names from being pluralized. */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            /* Here we use the fluent API for database mapping that you can't do with attributes. */
            /* For the many-to-many relationship between the Instructor and Course entities, the code specifies the table and column 
             * names for the join table. Code First can configure the many-to-many relationship for you without this code, but if you 
             * don't call it, you will get default names such as InstructorInstructorID for the InstructorID column. */
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors).WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseID")
                    .MapRightKey("InstructorID")
                    .ToTable("CourseInstructor"));

        }
    }
}