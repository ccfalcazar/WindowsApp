using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgatePrintingStation.ClientSolution
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ClientListClass Client = new ClientListClass();
            if (Client.AddClient(txtCompanyName.Text, txtAddress.Text, txtTin.Text, txtContactPerson.Text, txtContactNumber.Text) == 1)
            {
                MessageBox.Show("Company Added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Company Exists");
                foreach (var text in this.Controls)
                {
                    if(text is TextBox)
                    {
                        (text as TextBox).Text = "";
                    }
                }
            }

        }
    }
}
