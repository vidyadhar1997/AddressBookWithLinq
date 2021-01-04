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
        /// Creates the Address Book table.
        /// </summary>
        public void createTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(int));
            dataTable.Columns.Add("Email", typeof(string));
        }
    }
}
