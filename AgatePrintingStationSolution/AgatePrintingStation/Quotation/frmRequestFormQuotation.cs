using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgatePrintingStation.Quotation
{
    public partial class QuotationRequestForm : Form
    {
        private FormQuotationClass FormQuotation;

        public QuotationRequestForm()
        {
            InitializeComponent();
        }

        private void QuotationRequestForm_Load(object sender, EventArgs e)
        {
            FormQuotation = new FormQuotationClass();
            dgvSpecifications.DataSource = FormQuotation.RequestTable;
            txtRequestNumber.Text = FormQuotation.FolderName;
            FormQuotation.ListOfDirectories(ref cmbLoadInfo);
        }

        private void btnSelectCompany_Click(object sender, EventArgs e)
        {
            ClientSolution.ClientTableForm ClientForm = new ClientSolution.ClientTableForm();
            ClientForm.ShowDialog();
            try
            {
                txtCompanyName.Text = (ClientForm.SelectedRow.Cells[0].Value.ToString());
                txtTIN.Text = (ClientForm.SelectedRow.Cells[2].Value.ToString());
            }
            catch
            {
                MessageBox.Show("No Company Selected");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text != "" && txtRequestNumber.Text != "" && txtTIN.Text != "")
            {
                FormQuotation.SaveRequest(txtRequestNumber.Text + "\\", txtCompanyName.Text, txtTIN.Text);
                MessageBox.Show("Save Successful");
                this.Close();
            }
            else
                MessageBox.Show("Fill Up Missing Information");
        }

        private void cmbLoadInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormQuotation.LoadInfoFromFile(cmbLoadInfo.Text, ref txtRequestNumber,ref txtCompanyName, ref txtTIN);
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            FormQuotation.AddRequestForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormQuotation.EditRequest(dgvSpecifications.SelectedRows[0].Index);
        }
    }
}
