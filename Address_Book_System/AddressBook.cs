using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class AddressBook
    {
        List<ContactDetails> contactDetails;
        public AddressBook()
        {
            contactDetails = new List<ContactDetails>();
        }
        public void AddContactDetails(string firstname, string lastname, string address, string city, string state, int zip, long phone, string email)
        {
            ContactDetails contact = new ContactDetails(firstname,lastname,address,city,state,zip,phone,email);
            contactDetails.Add(contact);
        }
        public void DisplayContacts()
        {
            foreach (var contact in contactDetails)
            {
                Console.WriteLine("First Name: " + contact.firstname);
                Console.WriteLine("Last Name: " + contact.lastname);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zip);
                Console.WriteLine("Phone Number: " + contact.phone);
                Console.WriteLine("Email ID: " + contact.email);
            }
                
        }
    }
}
