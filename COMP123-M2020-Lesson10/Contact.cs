using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Lesson10
{
    public class Contact
    {
        // PUBLIC PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }

        // CONSTRUCTOR
        public Contact(string first_name ="", string last_name="", string email_address="", string contact_number="")
        {
            this.FirstName = first_name;
            this.LastName = last_name;
            this.EmailAddress = email_address;
            this.ContactNumber = contact_number;
        }
    }
}
