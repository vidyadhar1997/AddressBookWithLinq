using System;

namespace AddressBookWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address book using linq");
            AddressBookRepo addressBook = new AddressBookRepo();
            Contact contact = new Contact();
            addressBook.createTable();
            while (true)
            {
                Console.WriteLine("\n 1 for Display \n 2 for Add Contact \n 3 for Edit the Contact  \n 4 for Exit  \n 5 for");
                int choise = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choise)
                    {
                        case 1:
                            addressBook.displayAddressBook();
                            break;
                        case 2:
                            Console.WriteLine("Enter the first name = ");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter the last name = ");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter the address = ");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine("Enter the city = ");
                            contact.City = Console.ReadLine();
                            Console.WriteLine("Enter the state = ");
                            contact.State = Console.ReadLine();
                            Console.WriteLine("Enter the zip code = ");
                            contact.ZipCode = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the phone number = ");
                            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter the email = ");
                            contact.Email = Console.ReadLine();
                            addressBook.addContact(contact);
                            break;
                        case 3:
                            Console.WriteLine("Enter the first name = ");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter the last name = ");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter the address = ");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine("Enter the city = ");
                            contact.City = Console.ReadLine();
                            Console.WriteLine("Enter the state = ");
                            contact.State = Console.ReadLine();
                            Console.WriteLine("Enter the zip code = ");
                            contact.ZipCode = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the phone number = ");
                            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter the email = ");
                            contact.Email = Console.ReadLine();
                            addressBook.editContact(contact);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
    }
}

