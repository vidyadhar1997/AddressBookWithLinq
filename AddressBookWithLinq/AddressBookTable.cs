using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookWithLinq
{
    public class AddressBookTable
    {
        private readonly DataTable dataTable = new DataTable();
        
        /// <summary>
        /// Creates the Address Book table and added the new contact into the table.
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
    }
}
