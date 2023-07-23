namespace Address_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ******Address Book****** ");
            AddressBook addressBook = new AddressBook();

            addressBook.AddContactDetails("Hemant", "Sharma", "Shahdara", "Delhi", "Delhi", 110093, 7532026247, "hshemantsharma445@gmail.com");
            addressBook.DisplayContacts();
        }
    }
}