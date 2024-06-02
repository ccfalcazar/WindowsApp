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
    public partial class ClientTableForm : Form
    {
        private DataGridViewRow _SelectedRow;
        public ClientTableForm()
        {
            InitializeComponent();
        }

        private void ClientTableForm_Load(object sender, EventArgs e)
        {
            ClientListClass Client = new ClientListClass();
            dgvClientTable.DataSource = Client.Table;
        }

        public DataGridViewRow SelectedRow
        {
            get
            {
                return _SelectedRow;
            }
        }

        private void btnSelectCompany_Click(object sender, EventArgs e)
        {
            _SelectedRow = dgvClientTable.SelectedRows[0];
            this.Close();
        }
    }
}
