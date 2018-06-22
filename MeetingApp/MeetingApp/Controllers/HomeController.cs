using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeetingApp.DAL;
using PagedList.Mvc;
using PagedList;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        private WPG_ConferenceEntities _db;
        public HomeController()
        {
            _db = new WPG_ConferenceEntities();
        }
        public ActionResult Index(int? page)
        {
            var emp = _db.Employees.Include(x => x.Employee_Guest).Include(x => x.Meeting_Employee).Include(x => x.Role).ToList();
            return View(emp.OrderByDescending(x => x.Meeting_Employee.Count > 0).ToPagedList(page??1,15));
        }


    }
}