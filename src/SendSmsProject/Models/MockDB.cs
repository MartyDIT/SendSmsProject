using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendSmsProject.Models
{
    interface iDb
    {
        List<Person> GetPeople();
        Person GetPerson(int findid);
        void CreatePerson(Person p);
    }

    public class MockDB : iDb // we have an inteface here
    {
        List<Person> people;
        
        public MockDB() // we are faking a database here
        {
            people = new List<Person>();
            people.Add(new Person() { Id = 1,Forename = "Ginette", Surename = "Shaeffer", AreaCode = "089", PhoneNumber = "2084057"});
            people.Add(new Person() { Id = 2, Forename = "Marceline", Surename = "Sprow", AreaCode = "088", PhoneNumber = "2084058" });
            people.Add(new Person() { Id = 3, Forename = "Emmitt", Surename = "Holtkamp", AreaCode = "089", PhoneNumber = "2084059" });
            people.Add(new Person() { Id = 4, Forename = "Drew ", Surename = "Craghead", AreaCode = "083", PhoneNumber = "2084060" });
            people.Add(new Person() { Id = 5, Forename = "Mary ", Surename = "Schumacher", AreaCode = "082", PhoneNumber = "2084061" });
            people.Add(new Person() { Id = 6, Forename = "Eladia ", Surename = "Shute", AreaCode = "084", PhoneNumber = "2084062" });
            people.Add(new Person() { Id = 7, Forename = "Nicol ", Surename = "Skidmore", AreaCode = "085", PhoneNumber = "2084063" });
            people.Add(new Person() { Id = 8, Forename = "Aleta ", Surename = "Roberge", AreaCode = "087", PhoneNumber = "2084064" });
            people.Add(new Person() { Id = 9, Forename = "Almeta", Surename = "Bonomo", AreaCode = "089", PhoneNumber = "2084065" });
            people.Add(new Person() { Id = 10, Forename = "Ginette", Surename = "Lish", AreaCode = "088", PhoneNumber = "2084066" });
        }
        public List<Person> GetPeople()
        {
            return people;
        }

        public Person GetPerson(int findid)
        {
            return people.Where(p => p.Id == findid).FirstOrDefault(); //returns the first person with findID 

        }

        public void CreatePerson(Person p)
        {
            people.Add(p);
        }


        public String findContact(String AreaCode, String PhoneNumber)
        {
            var contact = people.FirstOrDefault(x => x.AreaCode == AreaCode && x.PhoneNumber == PhoneNumber);
            
            if (contact == null)
            {
                return "Not found";
            }
            else
            {
                return "";
            }

            {
                
            }
        }

        public List<String> GetName(String AreaCode, String PhoneNumber)
        {
            var name = people
                     .Where(x => x.AreaCode == AreaCode && x.PhoneNumber == PhoneNumber)
                      .Select(x => x.Forename)
                       .ToList();

            return name;
        }
        
         
           
        }

    }
