using System.Xml.Linq;

namespace Address_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ******Address Book****** ");
            AddressBook addressBook = new AddressBook();

            
            Console.WriteLine("\n1.Create Contact\n2.Add New Contact\n3.Edit Contact");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    addressBook.AddContactDetails("Hemant", "Sharma", "Shahdara", "Delhi", "Delhi", 110093, 7532026247, "hshemantsharma445@gmail.com");                   
                    break;
                case 2:
                    addressBook.AddNewContact();
                    break;
                case 3:
                    addressBook.AddContactDetails("Hemant", "Sharma", "Shahdara", "Delhi", "Delhi", 110093, 7532026247, "hshemantsharma445@gmail.com");
                    Console.WriteLine("Enter name of the contact you wish to edit: ");
                    string name = Console.ReadLine();
                    addressBook.EditContact(name);
                    break; 
            }
            addressBook.DisplayContacts();
        }

    }
}