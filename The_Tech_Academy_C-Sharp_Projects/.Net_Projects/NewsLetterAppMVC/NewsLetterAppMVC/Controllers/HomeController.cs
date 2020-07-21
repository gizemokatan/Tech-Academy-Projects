using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // These parameters have to match the name attribute of the input form but MVC can figure out mapping it.
        // Good practice to mark Post when posting something.
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            // Server validation check.
            /* If there are problems with the parameters being empty or null, we are return a View with an error message, 
            otherwise we are returning a View of Success.  */
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                // Using the premade error page.
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // Use ADO.Net to save this to a Db. We create the Db and then the Table before we insert anything.
                // Need a connection string before we can access data in Db. This has info like the server name to access data. 
                // Connect to Db inside of Db.
                string connectionString = @"Data Source=DESKTOP-8GQ12A2\SQLEXPRESS;Initial Catalog=Newsletter;
                                            Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";
                // Having parameters helps to prevent SQL injection.
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                            (@FirstName, @LastName, @EmailAddress)";
                /* When opening an outside connection like a Db, wrap it in a using statement,
                to makes ure when your done with it, it gets cut off. */
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    // This will insert what a user inputs into the form into the Db.
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}