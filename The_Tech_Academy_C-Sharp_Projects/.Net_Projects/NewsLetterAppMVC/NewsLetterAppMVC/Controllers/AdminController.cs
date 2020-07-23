using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        /* This method is the same as what used to be the Admin() method in the HomeController 
         * - we moved it from HomeController to AdminController to avoid bloating the HomeController. */
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // Create a variable signups that equals db.Signups which represents all the signups in that Db.
                // Now signups will only be those who have the Removed property equal to null.

                // Rather than doing queries against SQL, with EF we can do the queries right here. Lambda syntax.
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();

                // Another way to query that is closer to SQL. LINQ syntax.
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();

                // Create a new list of ViewModels
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    // Map the ViewModels, from the Model to the Vms.
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                // Pass that list to the View.
                return View(signupVms);
            }
        }

        /* This method is called when the button is hit, it gets the Id, finds the record that matches the Id, 
        then changes the removed column to the DateTime.now and saves it. */ 
        public ActionResult Unsubscribe(int Id)
        {
            // Establish our Db context to create a connection to the Db.
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // Find the record we want using the Primary key
                var signup = db.SignUps.Find(Id);
                // Change the removed, assign it datetime.now to update it to the db.
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            // This method returns the the Index method, which will also return all signups.
            return RedirectToAction("Index");
        }
    }
}