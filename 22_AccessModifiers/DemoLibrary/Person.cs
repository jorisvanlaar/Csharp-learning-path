using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Person
    {
        protected string formerLastName = "";           

        public string FirstName { get; private set; }   
        public string LastName { get; private set; }

        private string _ssn;                    

        public string SSN
        {
            get
            {
                return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
            }
            set { _ssn = value; }
        }


        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;          
            LastName = newLastName;
        }
        
        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string connectionString = data.GetConnectionString();
            // saves the person to the db
        }
    }
}
