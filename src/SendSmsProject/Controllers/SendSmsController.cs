﻿using System;
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

            if (ModelState.IsValid)
            {
                MockDB newDb = new MockDB();
               
                string checkList = newDb.findContact(new1.areaCode, new1.phoneNumber);

                if (checkList == "Not found")
                {
                   ViewData["SuccessMsg"] = "Error. Contact does not exist. Go to contacts page above.";
                }
                else
                {
                   
                    return RedirectToAction("Success");
                }
                
            }
            return View(new1);

        }
    }
}