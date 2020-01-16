using HrSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HrSystem.Controllers
{
    public class VacantJobsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: VacantJobs
        public ActionResult Index()
        {
           var model = db.DriverJob.ToList();
            return View();
        }
    }
}