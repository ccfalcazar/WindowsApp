namespace AgatePrintingStation.ClientSolution
{
    partial class ClientTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectCompany = new System.Windows.Forms.Button();
            this.dgvClientTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectCompany
            // 
            this.btnSelectCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectCompany.Location = new System.Drawing.Point(0, 418);
            this.btnSelectCompany.Name = "btnSelectCompany";
            this.btnSelectCompany.Size = new System.Drawing.Size(584, 23);
            this.btnSelectCompany.TabIndex = 1;
            this.btnSelectCompany.Text = "Select";
            this.btnSelectCompany.UseVisualStyleBackColor = true;
            this.btnSelectCompany.Click += new System.EventHandler(this.btnSelectCompany_Click);
            // 
            // dgvClientTable
            // 
            this.dgvClientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientTable.Location = new System.Drawing.Point(0, 0);
            this.dgvClientTable.MultiSelect = false;
            this.dgvClientTable.Name = "dgvClientTable";
            this.dgvClientTable.ReadOnly = true;
            this.dgvClientTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientTable.Size = new System.Drawing.Size(584, 418);
            this.dgvClientTable.TabIndex = 2;
            // 
            // ClientTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.dgvClientTable);
            this.Controls.Add(this.btnSelectCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientTableForm";
            this.Load += new System.EventHandler(this.ClientTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectCompany;
        private System.Windows.Forms.DataGridView dgvClientTable;
    }
}