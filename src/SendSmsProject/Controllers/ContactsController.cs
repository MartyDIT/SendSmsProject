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

        public ActionResult SendMessage(String AreaCode, String PhoneNumber)
        {
            Sms sms = new Sms();
           
            return View("~/Views/SendSms/Create.cshtml");
        }
    }
}

