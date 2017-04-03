using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SendSmsProject.Models;

namespace SendSmsProject.Models
{
    public class Logging //Loggs messages
    {
        
      public Logging(String new1)
      {
          System.Diagnostics.Debug.WriteLine(new1);
       }  
    }
}