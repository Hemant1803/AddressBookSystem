using System.Xml.Linq;

namespace Address_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ******Address Book****** ");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContactDetails("Hemant", "Sharma", "Shahdara", "Delhi", "Delhi", 110093, 7532026247, "hshemantsharma445@gmail.com");

            Console.WriteLine("\n1.Add New Contact\n2.Edit Contact\n3.Delete Contact\n4.Add Multiple Contact");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    addressBook.AddNewContact();
                    break;
                case 2:
                    Console.WriteLine("Enter name of the contact you wish to edit: ");
                    string name = Console.ReadLine();
                    addressBook.EditContact(name);
                    break;                    
                case 3:                   
                    Console.WriteLine("Enter name of the contact you wish to Delete: ");
                    string contactname = Console.ReadLine();
                    addressBook.DeleteContact(contactname);
                    break;
                case 4:                                      
                    addressBook.MultipleContact();
                    break;
            }
            addressBook.DisplayContacts();
        }

    }
}