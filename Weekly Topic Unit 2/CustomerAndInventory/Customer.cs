using System;
using System.Dynamic;

namespace CustomerAndInventory
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }


        
        public string FullName()
        {
            return FirstName + " " + LastName ; //implement
        }

        public bool ValidateName()
        {
            bool FirstNameIsValid = FirstName.Length > 1;

            bool LastNameIsValid = LastName.Length > 1;

            return FirstNameIsValid && LastNameIsValid;
        }
    }

    

    

    
}
