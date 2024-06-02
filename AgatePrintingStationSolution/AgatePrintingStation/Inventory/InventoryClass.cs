using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AgatePrintingStation.Inventory
{
    class InventoryClass
    {
        private Form PaperInventoryForm;
        private DataTable Data;
        public InventoryClass()
        {
            PaperInventoryForm = new Form();
            InitializeDataTable();
            InitializeInventoryForm();
        }

        private void InitializeDataTable()
        {
            Data = new DataTable();
        }

        private void InitializeInventoryForm()
        {
            PaperInventoryForm.StartPosition = FormStartPosition.CenterScreen;
            PaperInventoryForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            AddButtons();
            AddGridView();
        }

        private void AddGridView()
        {
            DataGridView TableViewer  = new DataGridView();
            TableViewer.Name = "dgvTable";
            TableViewer.ReadOnly = true;
            TableViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableViewer.DataSource = Data;
            TableViewer.Dock = DockStyle.Fill;
            PaperInventoryForm.Controls.Add(TableViewer);
        }

        private void AddButtons()
        {
            Button Temp = new Button();
            Temp.Text = "Add";
            Temp.Name = "btnAdd";
            Temp.Dock = DockStyle.Bottom;
            Temp.Click += AddButton_Click;
            PaperInventoryForm.Controls.Add(Temp);
            Temp = new Button();
            Temp.Text = "Edit";
            Temp.Name = "btnEdit";
            Temp.Dock = DockStyle.Bottom;
            Temp.Click += EditButton_Click;
            PaperInventoryForm.Controls.Add(Temp);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string[] TextBoxNames = { "Description", "Size", "Quantity", "Unit" };
            ManageInventoryForm PaperInventory = new ManageInventoryForm(TextBoxNames);
            PaperInventory.ShowInventory();            
        }

        public void ShowForm()
        {
            PaperInventoryForm.ShowDialog();
        }
    }

    public class ManageInventoryForm
    {
        private string[] CollectionOfTextbox;

        private Form ItemManageForm;

        public ManageInventoryForm(string[] TextBoxNames)
        {
            CollectionOfTextbox = TextBoxNames;
            ItemManageForm = new Form();
            ItemManageForm.StartPosition = FormStartPosition.CenterScreen;
            ItemManageForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ItemManageForm.Size = new System.Drawing.Size(350, 280);
            InitializeFormComponents();
        }

        public List<string> TextboxValues
        {
            get
            {
                List<string> Values = new List<string>();
                foreach(var val in ItemManageForm.Controls)
                {
                    if(val is TextBox)
                        Values.Add((val as TextBox).Text);
                }
                return Values;
            }
        }

        private void InitializeFormComponents()
        {
            for (int index = 0; index < CollectionOfTextbox.Count(); index++)
            {
                Label LabelControl = new Label();
                LabelControl.Text = CollectionOfTextbox[index];
                LabelControl.Dock = DockStyle.Bottom;

                ItemManageForm.Controls.Add(LabelControl);

                TextBox TextBoxControl = new TextBox();
                TextBoxControl.Name = CollectionOfTextbox[index];
                TextBoxControl.Dock = DockStyle.Bottom;
                TextBoxControl.TextAlign = HorizontalAlignment.Center;

                ItemManageForm.Controls.Add(TextBoxControl);
            }

            Label Space = new Label();
            Space.Text = "";
            Space.Dock = DockStyle.Bottom;
            ItemManageForm.Controls.Add(Space);
            CreateButton();

        }

        private void CreateButton()
        {
            Button AcceptButton = new Button();
            AcceptButton.Text = "Confirm";
            AcceptButton.Name = "btnAccept";
            AcceptButton.Click += AcceptButton_Click;
            AcceptButton.Dock = DockStyle.Bottom;
            ItemManageForm.Controls.Add(AcceptButton);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
           Form.ActiveForm.Close();
        }

        public void ShowInventory()
        {
            ItemManageForm.ShowDialog();
        }


    }
}
