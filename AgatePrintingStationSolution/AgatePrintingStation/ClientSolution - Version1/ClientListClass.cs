using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace AgatePrintingStation.ClientSolution
{
    class ClientListClass
    {
        private string NetworkPath = @"\\192.168.2.125\program\Agate Monitoring Folder\Company List\";
        private DataTable ClientTable;
        private string[] ColumnNames = {"Company Name", "Address", "TIN", "Contact Person", "Contact Number"};
        private string FileName;

        public ClientListClass()
        {
            ClientTable = new DataTable();

            CreateColumns();

            FileName = NetworkPath + "Client List";
            CreateDatabase();
        }

        public DataTable Table
        {
            get
            {
                ClientTable.ReadXml(FileName);
                return ClientTable;
            }
        }

        private void CreateColumns()
        {
            for(int index = 0; index < ColumnNames.Count(); ++index)
                ClientTable.Columns.Add(ColumnNames[index]);
            ClientTable.TableName = "Client Table";
            ClientTable.AcceptChanges();
        }

        public int AddClient(string CompanyName, string Address, string TIN, string ContactPerson, string ContactNumber)
        {
            CreateCompanyDetailsFile(CompanyName, Address, TIN, ContactPerson, ContactNumber);
            return 1;
        }

        private void CreateCompanyDetailsFile(string CompanyName, string Address, string TIN, string ContactPerson, string ContactNumber)
        {
            DataRow Row = ClientTable.NewRow();
            Row[0] = CompanyName;
            Row[1] = Address;
            Row[2] = TIN;
            Row[3] = ContactPerson;
            Row[4] = ContactNumber;
            ClientTable.Rows.Add(Row);
            ClientTable.AcceptChanges();
            ClientTable.WriteXml(FileName);
        }

        private void CreateDatabase()
        {
            if (!File.Exists(FileName))
                File.Create(FileName);
        }
    }
}
