using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendSmsProject.Models;

namespace SendSmsProject.Controllers
{
    public class ContactsController : Controller
    {
        static private iDb db;

        public ContactsController()
        {
            db = new MockDB();
        }

        // GET: Contacts
        public ActionResult Index()
        {
           
            var people = db.GetPeople();
            return View(people);
        }

        public ActionResult SendText()
        {
            return View();
        }
    }
}