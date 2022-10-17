using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        //GET: ADMIN page
        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                table.Quote = GetQuote(table);
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                table.Quote = GetQuote(table);
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal GetQuote(Table table)
        {//definition may need to be decimal or eliminate 'double baseRate' or change var name
            decimal baseRate = 50;
            DateTime currentDateTime = DateTime.Now; //get current DateTime
            int currentDateTimeYear = currentDateTime.Year; //extract year and set to int from current datetime

            DateTime userDOB = table.DateOfBirth; //set table's DOB = to a var for use
            int tableYear = userDOB.Year; //extract year from table DOB 

            int age = currentDateTimeYear - tableYear; //current user age is now defined and formatted


            //age checks
            if (age <= 18)
            {
                baseRate += 100;
            }
            else if (age >= 19 || age <= 25)
            {
                baseRate += 50;
            }
            else if (age >= 26)
            {
                baseRate += 25;
            }

            //car year checks
            if (table.CarYear < 2000)
            {
                baseRate += 25;
            }
            else if (table.CarYear >= 2015)
            {
                baseRate += 25;
            }

            //car make checks
            if (table.CarMake == "Porsche")
            {
                baseRate += 25;
            }
            else if (table.CarMake == "Porsche 911 Carrera")
            {
                baseRate += 50; //50 because its porsche AND 911 carrera so 25 from each criteria
            }


            //ticket checks
            if (table.SpeedingTickets > 0)
            {
                int ticketAdjustment = table.SpeedingTickets * 10; //10$ for each ticket
                double ticketAdjustmentPrice = Convert.ToDouble(ticketAdjustment); //convert result to price format
                //baseRate += ticketAdjustmentPrice;

                baseRate *= 10; //add ticket rate to baseRate
            }

            //DUI checks
            if (table.DUI == true)
            {
                baseRate += baseRate * .25m;
            }

            //Coverage Check
            if (table.CoverageType == true)  //assuming true is the 1 value in type bit
            {
                baseRate += baseRate * .50m;
            }
            return baseRate;





            //See Create.cshtml check with instructor make sure this is right way before proceeding and check where to put the "hidden"
            //**dont forget to return a decimal eventually

        }
    }
}
