using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using SendSmsProject.Models;

namespace SendSmsProject.Controllers
{
    public class SendSmsController : Controller //Sent Sms Page Controller - directs to once the message is sent
    {
        public ActionResult Success()
        {


            return View();

        }

        public ActionResult Create() // New Message initial Controller with a get method
        {

           
        return View();
    
        }

        [HttpPost]
        public ActionResult Create(Sms new1) // New Message Controller with a HttpPost
        {

            if (ModelState.IsValid) //Checks if the Sms model is Valid
            {
                MockDB newDb = new MockDB(); // Creates new Database Object
               
                string checkList = newDb.findContact(new1.areaCode, new1.phoneNumber); //Checks contacts

                if (checkList == "Not found")
                {
                   ViewData["SuccessMsg"] = "Error. Contact does not exist. Go to contacts page above."; //Throws an error if not found
                }
                else
                {   //if found passes to success page
                    ViewData["Content"] = new1.textContent;
                    var name2= newDb.GetName(new1.areaCode, new1.phoneNumber);
                    if (name2 != null)
                    {
                        foreach (var VARIABLE in name2)
                        {
                            ViewData["Receiver"] = VARIABLE;
                        }
                    }
                    
                    return View("Success"); // Returns success page
                    Logging lognew = new Logging(new1.textContent); // Logs messages
                }
                
            }
            return View(new1); // Returns same page with inputed value if error

        }
    }
}