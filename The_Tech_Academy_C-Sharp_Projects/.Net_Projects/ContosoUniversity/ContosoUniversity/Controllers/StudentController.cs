using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using PagedList;

namespace ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Student
        /* The first time the page is displayed, or if the user hasn't clicked a paging or sorting link, all the 
         * parameters are null. If a paging link is clicked, the page variable contains the page number to display. */
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            /* The two ViewBag variables are used so that the view can configure the column 
             * heading hyperlinks with the appropriate query string values: */
            /* A ViewBag property provides the view with the current sort order, because this must be included in 
             * the paging links in order to keep the sort order the same while paging. */
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "";
            /* Above are ternary statements. The first one specifies that if the sortOrder parameter is null or empty, 
             * ViewBag.NameSortParm should be set to "name_desc"; otherwise, it should be set to an empty string.*/
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var students = from s in db.Students
                          select s;
            /* The code adds a searchString parameter to the Index method. It also adds a where clause to the LINQ statement
             * that selects only students whose first name or last name contains the search string. The statement 
             * that adds the Where clause executes only if there's a value to search for. */
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.Contains(searchString)
                                        || s.FirstMidName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            /* The ToPagedList extension method on the students IQueryable object converts the student query to a single page 
             * of students in a collection type that supports paging. That single page of students is then passed to the view: */
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            /* The ToPagedList method takes a page number. The two question marks represent the null-coalescing operator. 
             * The null-coalescing operator defines a default value for a nullable type; the expression (page ?? 1) means return
             * the value of page if it has a value, or return 1 if page is null. */
            return View(students.ToPagedList(pageNumber, pageSize));
        }
        /* The method above uses LINQ to Entities to specify the column to sort by. The code creates an IQueryable<T> variable 
         * before the switch statement, modifies it in the switch statement, and calls the ToList method after the switch statement. 
         * When you create and modify IQueryable variables, no query is sent to the database. The query is not executed until 
         * you convert the IQueryable object into a collection by calling a method such as ToList. Therefore, this code results 
         * in a single query that is not executed until the return View statement. */

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        /* This code adds the Student entity created by the ASP.NET MVC model binder to the Students entity set 
         * and then saves the changes to the database. The model binder converts posted form values to CLR types 
         * and passes them to the action method in parameters. In this case, the model binder instantiates a Student entity
         * for you using property values from the Form collection.*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        /* The Bind attribute is one way to protect against over-posting in create scenarios. For example, 
         * suppose the Student entity includes a Secret property that you don't want this web page to set. */
        // It's best to use the Include parameter with the Bind attribute to whitelist fields. 
        public ActionResult Create([Bind(Include = "LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    /* When you pass a new entity to the Add method, that entity's state is set to Added. 
                     * Then when you call the SaveChanges method, the database context issues a SQL INSERT command. */
                    db.Students.Add(student);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */) 
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        /* The new code reads the existing entity and calls TryUpdateModel to update fields from user input in the posted form data. 
         *      The Entity Framework's automatic change tracking sets the EntityState.Modified flag on the entity. When the SaveChanges 
         *      method is called, the Modified flag causes the Entity Framework to create SQL statements to update the database row. */
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var studentToUpdate = db.Students.Find(id);
            if (TryUpdateModel(studentToUpdate, "",
                new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
            {
                try
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(studentToUpdate);
        }

        /* The method that is called in response to a GET request displays a view that gives the user a chance to 
         * approve or cancel the delete operation. If the user approves it, a POST request is created.
         * When that happens, the HttpPost Delete method is called and then that method actually performs the delete operation. */
        // GET: Student/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        /* We add a try-catch block to the HttpPostAttribute Delete method to handle any errors that might occur when the 
         * database is updated. If an error occurs, the HttpPostAttribute Delete method calls the HttpGetAttribute Delete method, 
         * passing it a parameter that indicates that an error has occurred. The HttpGetAttribute Delete method then 
         * redisplays the confirmation page along with the error message, giving the user an opportunity to cancel or try again. */
        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        /* This code retrieves the selected entity, then calls the Remove method to set the entity's status to Deleted. 
         * When SaveChanges is called, a SQL DELETE command is generated. */
        public ActionResult Delete(int id)
        {
            try
            {
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        /* To close database connections and free up the resources they hold as soon as possible, 
         * dispose the context instance when you are done with it. The base Controller class already 
         * implements the IDisposable interface, so this code simply adds an override to the Dispose(bool) 
         * method to explicitly dispose the context instance. */
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
