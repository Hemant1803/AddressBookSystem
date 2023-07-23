using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Address_Book_System
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Directory dir = new Directory();
            for (; ; )
            {
                Console.WriteLine("\n0.Display All Address Books\n1.Add New AddressBook\n2.Delete AddressBook\n3.Add New Contact\n4.Edit Contact\n5.Delete Contact\n6.Add Multiple Contact");
                int option = Convert.ToInt32(Console.ReadLine());

               

               

                switch (option)
                {
                    case 0:
                        dir.DisplayAllAddressBooks();
                        break;
                    case 1: {
                            Console.WriteLine("Enter name of the address book: ");
                            string name = Console.ReadLine();
                            dir.Addaddressbook(name);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter name of the address book: ");
                            string name = Console.ReadLine();
                            dir.DeleteAddressBook(name);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter name of the address book: ");
                            string name = Console.ReadLine();
                            dir.AddContact(name);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter name of the address book: ");
                            string name = Console.ReadLine();
                            dir.EditContact(name);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter name of the address book: ");
                            string name = Console.ReadLine();
                            dir.DeleteContact(name);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter name of the address book: ");
                            string name = Console.ReadLine();
                            dir.MultipleContact(name);
                            break;
                        }
                        case 7:
                        return;                
                }
            }
           
        }

    }
}