using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;


namespace SendSmsProject.Models
{
    public class Sms
    {   
        [Required(ErrorMessage = " You must enter an Area Code ")]
        [Range(081, 089, ErrorMessage = "You must enter 3 characters valid code ")]
        
        public string areaCode { get; set; }

        [Required(ErrorMessage = " You must enter your Phone Number ")]
        [Range(0, 9999999, ErrorMessage = "Only Numbers are allowed ")]
        [StringLength(7, ErrorMessage = "You must enter 7 characters number ",MinimumLength = 7)]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = " Please Enter your message ")]
        [StringLength(140, ErrorMessage = "The message can not be longer than 140 characters ", MinimumLength = 1)]
        public string textContent { get; set; }

        //private string[] codes = { "082", "083", "085", "086", "087", "088", "089" };

        ////public string Areacode
        ////{
        ////    get { return areaCode; }

        ////    set
        ////    {


        ////        foreach (string code in codes)
        ////        {
        ////            if (code == value)
        ////            {
        ////                areaCode = value;
        ////            }


        ////            else
        ////            {
        ////                throw new ArgumentException("Please re-check the number");
        ////            }
        ////        }
        ////    }
        ////}

        ////public string PhoneNumber
        ////{
        ////    get { return phoneNumber; }

        ////    set
        ////    {
        ////        if (value.Length == 7)
        ////        {
        ////            foreach (char c in value)
        ////            {

        ////                if (c >= '0' && c <= '9')
        ////                {
        ////                    phoneNumber = value;
        ////                }
        ////                else
        ////                {
        ////                    throw new ArgumentException("Please re-check the number");
        ////                    }
        ////            }

        ////        }
        ////        else
        ////        {
        ////            throw new ArgumentException("Please re-check the length of the number");
        ////        }


        ////    }
        ////}

        ////public string TextContent
        ////{
        ////    get { return textContent; }

        ////    set
        ////    {
        ////        if (value.Length < 1 || value.Length > 140)
        ////        {
        ////            throw new ArgumentException("Message has to be between 1 and 140 characters!");
        ////        }

        ////        else
        ////        {
        ////            textContent = value;
        ////        }
        ////    }
        ////}

        //////public Sms(string areaCode, string phoneNumber, string textContent)
        //////{
        //////    Areacode = areaCode;
        //////    PhoneNumber = phoneNumber;
        //////    TextContent = textContent;
        //////}


        //public override string ToString()
        //{
        //    return"area code: " + areaCode +"phone Number" + phoneNumber+ "Text Comment" + textContent
        //    ;
        //}
    }
}

