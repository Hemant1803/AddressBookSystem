using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void AddNewContact()
        {
            Console.WriteLine("Enter your First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number: ");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your EmailID: ");
            string email = Console.ReadLine();

            AddContactDetails(firstname, lastname, address, city, state, zip, phone, email);
            Console.WriteLine("**********************************************");
        }
        public void DisplayContacts()
        {
            foreach (var contact in contactDetails)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("First Name: " + contact.firstname);
                Console.WriteLine("Last Name: " + contact.lastname);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zip);
                Console.WriteLine("Phone Number: " + contact.phone);
                Console.WriteLine("Email ID: " + contact.email);
                Console.WriteLine("**********************************************");
            }
            

        }

        public void EditContact(string name)
        {
           for (int i = 0; i < contactDetails.Count; i++) 
            {
                
                ContactDetails contact = contactDetails[i];
                if (contact.firstname == name || contact.lastname == name)
                {
                    Console.WriteLine("\n Choose What you want to edit " +
                        "\n 1. First Name \n 2.Last Name \n 3. Address \n 4. City \n 5. State \n 6. ZipCode \n 7. Phone Number \n 8. Email ID");
                    int edit = Convert.ToInt32(Console.ReadLine());
                    switch (edit)
                    {
                        case 1:
                            Console.WriteLine("Enter New First Name: ");
                            contact.firstname = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter New Last Name: ");
                            contact.lastname = Console.ReadLine();
                            break;                           
                        case 3:
                            Console.WriteLine("Enter New Address: ");
                            contact.address = Console.ReadLine();
                            break;                          
                        case 4:
                            Console.WriteLine("Enter New City: ");
                            contact.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter New State: ");
                            contact.state = Console.ReadLine();
                            break;  
                        case 6:
                            Console.WriteLine("Enter New ZipCode: ");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;                            
                        case 7:
                            Console.WriteLine("Enter New Phone Number: ");
                            contact.phone = Convert.ToInt32(Console.ReadLine());
                            break;                            
                        case 8:
                            Console.WriteLine("Enter New Email Id: ");
                            contact.email = Console.ReadLine();
                            break;
                    }

                }

            }
        }

        public void DeleteContact(string contactname)
        {
           for(int i = 0; i < contactDetails.Count; i++)
            {
                ContactDetails contact = contactDetails[i];
                if (contact.firstname == contactname || contact.lastname == contactname)
                {
                    contactDetails.RemoveAt(i);

                    Console.WriteLine("Your Contact Has Been Deleted");

                }
            }
        }

        public void MultipleContact()
        {
            Console.WriteLine("How Many Contact You Want to add");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++) {

                AddNewContact();
            }
        }
    }
}
