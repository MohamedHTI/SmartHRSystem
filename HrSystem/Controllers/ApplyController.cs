using HrSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HrSystem.Controllers
{
   
    public class ApplyController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Apply
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult CarJob()
        {
            DriverJob job = new DriverJob();
            return View(job);
           
        }

        [HttpPost]
        public ActionResult CarJob(DriverJob Job) {
            if (ModelState.IsValid)
            {
                
                return View("Success");
            }
            return View(Job);
        }
        public ActionResult ITJob()
        {
            ITProfessional job = new ITProfessional();
            return View(job);
           
        }

        [HttpPost]
        public ActionResult ITJob(ITProfessional Job) {
            if (ModelState.IsValid)
            {
                
                return View("Success");
            }
            return View(Job);
        }





    }
}