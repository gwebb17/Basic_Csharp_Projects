using NewsletterAppMVC465.Models;
using NewsletterAppMVC465.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC465.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()//METHODS CALLED ACTION RESULT MUST RETURN DATA TYPE ACTIONRESULT
        {
            return View();
        }
        

        [HttpPost]//this is supposed to be here for any methods that POST , below method POSTS to form.
        public ActionResult SignUp(string firstName, string lastName, string emailAddress) //hover mouse over props to see if they saved
        {//prop var names above are camelcase and input html has them snakecase. VS is able to detect that and adapt
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) //IsNullOrEmpty= if () var has null or no value
            {
                return View("~/Views/Shared/Error.cshtml");  //~ = relative path, return the Error file if above vars are NullOrEmpty
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges(); //saves changes to database
                }
                return View("Success");  //now if no empty or null values are entered in form we print the success page
            }
          
        }
    }
}