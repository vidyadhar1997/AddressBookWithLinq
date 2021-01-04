using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookWithLinq
{
    public class AddressBookRepo
    {
        private readonly DataTable dataTable = new DataTable();
        
        /// <summary>
        /// Creates the Address Book table and insert the new contact into the table.
        /// </summary>
        public void createTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));

            dataTable.Rows.Add("dhiraj", "hudge", "tawarja", "latur", "maharashtra", 413512, 8149713160, "dhiraj@gmail.com");
            dataTable.Rows.Add("suraj", "hudge", "mataji", "pune", "karnataka", 413512, 8149713160, "suraj@gmail.com");
            dataTable.Rows.Add("nitikesh", "shinde", "tawarja", "delhi", "maharashtra", 413512, 8149713160, "nitij@gmail.com");
            dataTable.Rows.Add("shashi", "kumar", "mataji", "latur", "maharashtra", 413512, 8149713160, "shashi@gmail.com");
            dataTable.Rows.Add("rahul", "munde", "gandhi chowk", "beed", "up", 413562, 8148713160, "rahul@gmail.com");
            dataTable.Rows.Add("kunal", "huge", "adarsh colony", "latur", "maharashtra", 463512, 8149713160, "kunal@gmail.com");
            dataTable.Rows.Add("prince", "yede", "tawarja", "usmanabad", "maharashtra", 413512, 8149913160, "prince@gmail.com");
            dataTable.Rows.Add("akash", "pawar", "tawarja", "mumbai", "kerala", 413512, 8146713160, "akash@gmail.com");
            dataTable.Rows.Add("rohit", "kumar", "tawarja", "latur", "maharashtra", 413512, 8149713160, "rohit@gmail.com");
            dataTable.Rows.Add("dharmesh", "pande", "tawarja", "chakur", "chenni", 413512, 8149713160, "dharma@gmail.com");
        }
        
        /// <summary>
        /// Add the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void addContact(Contact contact)
        {
            dataTable.Rows.Add(contact.FirstName, contact.LastName, contact.Address, contact.City, 
            contact.State, contact.ZipCode, contact.PhoneNumber, contact.Email);
            Console.WriteLine("Added contact successfully");
        }
        
        /// <summary>
        /// Displays the address book.
        /// </summary>
        public void displayAddressBook()
        {
            foreach(var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-"+table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-"+table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-"+table.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-"+ table.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + table.Field<string>("Email"));
            }
        }
        
        /// <summary>
        /// Edit the contact using first name.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void editContact(Contact contact)
        {
            var recordData= dataTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == contact.FirstName).First();
            if (recordData != null)
            {
                recordData.SetField("LastName", contact.LastName);
                recordData.SetField("Address", contact.Address);
                recordData.SetField("City", contact.City);
                recordData.SetField("State", contact.State);
                recordData.SetField("ZipCode", contact.ZipCode);
                recordData.SetField("PhoneNumber", contact.PhoneNumber);
                recordData.SetField("Email", contact.Email);
            }
        }
        
        /// <summary>
        /// Deletes the contact using first name.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void deleteContact(Contact contact)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == contact.FirstName).First();
            if (recordData != null)
            {
                recordData.Delete();
                Console.WriteLine("Delete contact successfully");
            }
        }
        
        /// <summary>
        /// Retrieves the person by using state.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void retrievePersonByUsingState(Contact contact)
        {
            var selectdData = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("State") == contact.State) select dataTable;
            foreach(var table in selectdData.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + table.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + table.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + table.Field<string>("Email"));
            }
        }
        
        /// <summary>
        /// Retrieves the person by using city.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void retrievePersonByUsingCity(Contact contact)
        {
            var selectdData = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("City") == contact.City) select dataTable;
            foreach (var table in selectdData.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + table.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + table.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + table.Field<string>("Email"));
            }
        }
        
        /// <summary>
        /// Count the city and state
        /// </summary>
        public void countByCityAndState()
        {
            var countByCityAndState = from row in dataTable.AsEnumerable() group row by new { City = row.Field<string>("City"), State = row.Field<string>("State") } into groups
                                     select new
                                     {
                                         City = groups.Key.City,
                                         State = groups.Key.State,
                                         Count = groups.Count()
                                        };
            foreach(var row in countByCityAndState)
            {
                Console.WriteLine(row.City + "\n" + row.State + "\n" + row.Count);
            }
        }
    }
}
