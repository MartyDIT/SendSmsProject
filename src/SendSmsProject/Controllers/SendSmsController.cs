using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SendSmsProject.Controllers
{
    public class SendSmsController : Controller
    {
        public string NewMessage()
        {
            return "Hello from the Send sms controller";
        }
    }
}