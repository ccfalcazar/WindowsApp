using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgatePrintingStation
{
    public partial class frmMain : Form
    {
        frmMainClass FormHandler;
        public frmMain()
        {
            InitializeComponent();
            FormHandler = new frmMainClass();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            FormHandler.AddNote(DateTime.Today.ToShortDateString() +" - " +txtNote.Text);
            FormHandler.RefreshNotes(ref lstNotes);
            txtNote.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FormHandler.RefreshNotes(ref lstNotes);
        }

        private void btnClearNote_Click(object sender, EventArgs e)
        {
            if(lstNotes.SelectedIndex != -1)
                FormHandler.ClearItem(ref lstNotes, lstNotes.SelectedIndex);
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            ClientSolution.AddClientForm ClientAddForm = new ClientSolution.AddClientForm();
            ClientAddForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClientSolution.ClientTableForm ClientTable = new ClientSolution.ClientTableForm();
            ClientTable.ShowDialog();
        }

        private void btnForms_Click(object sender, EventArgs e)
        {
            Quotation.QuotationRequestForm RequestForm = new Quotation.QuotationRequestForm();
            RequestForm.ShowDialog();
        }

        private void btnPaperInventory_Click(object sender, EventArgs e)
        {
            Inventory.InventoryClass InventoryForm = new Inventory.InventoryClass();
            InventoryForm.ShowForm();
        }
    }
}
