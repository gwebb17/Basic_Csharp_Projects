using NewsletterAppMVC465.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC465.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //first way to write line 22 is below on 18
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList(); //SignUps comes from Model1.context.cs file (model1.edmx expand)
                //since Removeed accepts null values above statement is saying if x(iterator) is currently on a Removed column == null,
                //We only want those displayed since those wont be removed (without date value) then make it a list
                //altnerate way to write line 18 in LINQ:
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms); //i think this means it will return the View (admin since its same indentation)
                                        //with signups (list of all signup lists) as parameter
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id); //Find looks for the column in () here Id
                signup.Removed = DateTime.Now; //set Removed to the time right now so it populates column with it
                db.SaveChanges(); //save changes to db
            }
            return RedirectToAction("Index");  //return statement to break method and take us back to index page
        }
    }
}