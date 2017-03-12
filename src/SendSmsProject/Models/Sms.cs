using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace SendSmsProject.Models
{
    public class Sms
    {
        private string areaCode { get; set; }
        private string phoneNumber { get; set; }
        private string textContent { get; set; }
        private List<string> codes = new List<string>(new string[] {"082", "083", "085", "086", "087", "088", "089"});

        public string Areacode
        {
            get { return areaCode; }

            set
            {
                foreach (var code in codes)
                {
                    if (code == areaCode)
                    {
                        areaCode = value;
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Please re-check area code");
                    }
                }
            }
        }

        public string PhoneNubmber
        {
            get { return phoneNumber; }

            set
            {
                if (phoneNumber.Length == 7)
                {
                    foreach (char c in phoneNumber)
                    {

                        if (c < '0' || c > '9')
                        {
                            throw new ArgumentException("Please re-check the number");
                        }
                        else
                        {
                            phoneNumber = value;

                        }
                    }

                }
                else
                {
                    throw new ArgumentException("Please re-check the length  of the number");
                }


            }
        }

        public string TextContent
        {
            get { return textContent; }

            set
            {
                if (textContent.Length < 1 || textContent.Length > 140)
                {
                    throw new ArgumentException("Message has to be between 1 and 140 characters!");
                }

                else
                {
                    textContent = value;
                }
            }
        }

        public Sms(string areaCode, string phoneNumber, string textContent)
        {
            Areacode = areaCode;
            PhoneNubmber = phoneNumber;
            TextContent = textContent;
        }
    }
}
