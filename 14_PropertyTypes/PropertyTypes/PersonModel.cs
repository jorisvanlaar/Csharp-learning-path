using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes
{
    public class PersonModel
    {
        public string FirstName { private get; set; }   
        public string LastName { get; private set; }    

        private int _age;

        public int Age
        {
            get 
            { 
                return _age; 
            }
            set 
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age needs to be in a valid range", "value");
                }
            }
        }

        private string _isbn;

        public string ISBN
        {
            get 
            {
                string output = "******" + _isbn.Substring(_isbn.Length - 3);   
                return output;                                                                                                                     
            }
            set { _isbn = value; }
        }

        private string _password;

        public string Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName, int age, string isbn, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ISBN = isbn;
            Password = password;
        }
    }
}
