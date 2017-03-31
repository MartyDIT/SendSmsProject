using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendSmsProject.Models
{
    public class Person
    {
        public int Id { get; set; } // we need id for the database
        
        public string Forename { get; set; }
        public string Surename { get; set; }
        public int AreaCode { get; set; }
        public int PhoneNumber { get; set; }
    }
}