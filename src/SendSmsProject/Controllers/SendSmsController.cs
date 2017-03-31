using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using SendSmsProject.Models;

namespace SendSmsProject.Controllers
{
    public class SendSmsController : Controller
    {
        public ActionResult Success()
        {


            return View();

        }

        public ActionResult Create()
        {

           
        return View();
    
        }

        [HttpPost]
        public ActionResult Create(Sms new1)
        {

            if ()
            {


                return RedirectToAction("Success");
            }
            return View(new1);

        }
    }
}