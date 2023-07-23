using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class Directory
    {
        Dictionary<string, AddressBook> addressBooksDict;

        public  Directory() 
        {
            addressBooksDict = new Dictionary<string, AddressBook>();
        }
       public void Addaddressbook(string name)
        {
            AddressBook book = new AddressBook();
            addressBooksDict.Add(name, book);
        }
        public void DeleteAddressBook(string name)
        {
            addressBooksDict.Remove(name);
        }
        public void AddContact(string name)
        {
            AddressBook book = addressBooksDict[name];
            book.AddNewContact();
        }
        public void EditContact(string name) 
        {
            AddressBook book = addressBooksDict[name];
            Console.WriteLine("Enter name of the contact you wish to edit: ");
            string value = Console.ReadLine();
            book.EditContact(value);
        }
        public void DeleteContact(string name) 
        {
            AddressBook book = addressBooksDict[name];
            Console.WriteLine("Enter name of the contact you wish to Delete: ");
            string contactname = Console.ReadLine();
            book.DeleteContact(contactname);
        }public void MultipleContact(string name) 
        {
            AddressBook book = addressBooksDict[name];            
            book.MultipleContact();
        }

        internal void DisplayAllAddressBooks()
        {
          Dictionary<string,AddressBook>.KeyCollection keys = addressBooksDict.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
