using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AgatePrintingStation.Quotation
{
    class FormQuotationClass
    {
        private string RequestPath = @"\\192.168.2.125\program\Agate Monitoring Folder\Pending List\Request Folder\Forms\";
        string RequestFolder;
        private DataTable Table;
        private Form frmAddRequest;
        private string[] ColumnNames = { "Quantity", "Unit", "Description", "Size", "Material", "Sheets per Bind", "Copies", "Paper Arrangement", "Ink Color", "Price" };
        private int EditFlag = -1;

        public FormQuotationClass()
        {
            Table = new DataTable();
            CreateColumns();
            frmAddRequest = new Form();
            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            SetFormProperties();
            CreateButton();
            CreateLabelsAndTextBox();
        }

        private void CreateLabelsAndTextBox()
        {
            for (int index = ColumnNames.Count() - 1; index > -1; --index)
            {
                TextBox txtTemp = new TextBox();
                txtTemp.Name = string.Format("txt{0}", ColumnNames[index]);
                txtTemp.Dock = DockStyle.Top;
                txtTemp.TextAlign = HorizontalAlignment.Center;
                txtTemp.TabIndex = index;
                frmAddRequest.Controls.Add(txtTemp);
                Label lblTemp = new Label();
                lblTemp.Name = string.Format("{0}", ColumnNames[index]);
                lblTemp.Text = string.Format("{0}:", ColumnNames[index]);
                lblTemp.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                lblTemp.Dock = DockStyle.Top;
                frmAddRequest.Controls.Add(lblTemp);
            }
        }

        private void CreateButton()
        {
            Button btnTemp = new Button();
            btnTemp.Dock = DockStyle.Top;
            btnTemp.Name = "btnAdd";
            btnTemp.Text = "Add Request";
            btnTemp.Click += BtnTemp_Click;
            btnTemp.TabIndex = 10;
            frmAddRequest.Controls.Add(btnTemp);
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            DataRow Row;
            if (EditFlag == -1)
            {
                Row = Table.NewRow();
            }
            else
            {
                Row = Table.Rows[EditFlag];
            }
            foreach (Control item in frmAddRequest.Controls)
            {
                string Column = item.Name.Remove(0, 3);
                if(ColumnNames.Contains(Column))
                    Row[Column] = item.Text;
            }
            if(EditFlag == -1)
                Table.Rows.Add(Row);
            MessageBox.Show("Data Saved");
            EditFlag = -1;
            frmAddRequest.Close();
        }

        private void SetFormProperties()
        {
            frmAddRequest.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmAddRequest.StartPosition = FormStartPosition.CenterScreen;
            frmAddRequest.Size = new System.Drawing.Size(300, 500);
        }

        private void CreateColumns()
        {
            for (int index = 0; index < ColumnNames.Count(); ++index)
                Table.Columns.Add(ColumnNames[index]);

            Table.TableName = "Request Table";
        }

        public DataTable RequestTable
        {
            get
            {
                return Table;
            }
        }

        public void SaveRequest(string Folder, string CompanyName, string TIN)
        {
            RequestFolder = RequestPath + Folder;
            CheckDirectory();
            CreateFolder(RequestFolder);
            CreateFileDetails(CompanyName, TIN);
            CreateRequestTable();
        }

        private void CreateRequestTable()
        {
            string FileName = RequestFolder + "Request Table";
            Table.WriteXml(FileName);
        }

        private void CreateFileDetails(string CompanyName, string TIN)
        {
            StreamWriter WriteDetails = new StreamWriter(RequestFolder + "Request Details");
            WriteDetails.WriteLine(CompanyName);
            WriteDetails.WriteLine(TIN);
            WriteDetails.Close();
        }

        public void ListOfDirectories(ref ComboBox ListOfFolders)
        {
            CheckDirectory();
            ListOfFolders.Items.Clear();
            List<string> DirectoryList = Directory.EnumerateDirectories(RequestPath).ToList();
            for (int index = 0; index < DirectoryList.Count(); index++)
            {
                var ItemToAdd = DirectoryList[index].Split('\\');
                ListOfFolders.Items.Add(ItemToAdd[8]);
            }
        }

        public void EditRequest(int RowIndex)
        {
            EditFlag = RowIndex;
            foreach (Control item in frmAddRequest.Controls)
            {
                string Column = item.Name.Remove(0, 3);
                if (ColumnNames.Contains(Column))
                    item.Text = Table.Rows[RowIndex][Column].ToString();
            }
            frmAddRequest.ShowDialog();
        }

        public void LoadInfoFromFile(string FolderName, ref TextBox Reference, ref TextBox CompanyName, ref TextBox TIN)
        {
            string DetailsPath = RequestPath + FolderName + "\\";
            Reference.Text = FolderName;
            StreamReader ReadDetails = new StreamReader(DetailsPath + "Request Details");
            CompanyName.Text = ReadDetails.ReadLine();
            TIN.Text = ReadDetails.ReadLine();
            ReadDetails.Close();
            ReadTable(DetailsPath);
        }

        private void ReadTable(string Path)
        {
            string FileName = Path + "Request Table";
            Table.ReadXml(FileName);
        }

        public string FolderName
        {
            get
            {
                string FindTicket = string.Format("{0}{1}{2}*", DateTime.Today.Year, DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));

                int FileCount = 0;
                FileCount = Directory.EnumerateDirectories(RequestPath, FindTicket).Count();

                return string.Format(@"{0}{1:D2}", FindTicket.Remove(FindTicket.Count() - 1), FileCount);
            }
        }
        private void CheckDirectory()
        {
            CreateFolder(RequestPath);
        }

        private void CreateFolder(string Folder)
        {
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
        }

        public void AddRequestForm()
        {
            ClearTextBox();
            frmAddRequest.ShowDialog();
        }

        private void ClearTextBox()
        {
            foreach (Control item in frmAddRequest.Controls)
            {
                string Column = item.Name.Remove(0, 3);
                if (ColumnNames.Contains(Column))
                    item.Text = "";
            }
        }
    }
}
