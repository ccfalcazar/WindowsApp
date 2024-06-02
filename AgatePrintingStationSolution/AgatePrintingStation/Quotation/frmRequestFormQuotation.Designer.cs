namespace AgatePrintingStation.Quotation
{
    partial class QuotationRequestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.lblTin = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtRequestNumber = new System.Windows.Forms.TextBox();
            this.lblRequestNumber = new System.Windows.Forms.Label();
            this.lblLoadInfo = new System.Windows.Forms.Label();
            this.cmbLoadInfo = new System.Windows.Forms.ComboBox();
            this.btnSelectCompany = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSpecifications = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecifications)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddRequest);
            this.splitContainer1.Panel1.Controls.Add(this.txtTIN);
            this.splitContainer1.Panel1.Controls.Add(this.lblTin);
            this.splitContainer1.Panel1.Controls.Add(this.txtCompanyName);
            this.splitContainer1.Panel1.Controls.Add(this.lblCompanyName);
            this.splitContainer1.Panel1.Controls.Add(this.txtRequestNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lblRequestNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lblLoadInfo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbLoadInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectCompany);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSpecifications);
            this.splitContainer1.Size = new System.Drawing.Size(784, 281);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.Location = new System.Drawing.Point(0, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(261, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit Request";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRequest.Location = new System.Drawing.Point(0, 138);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(261, 23);
            this.btnAddRequest.TabIndex = 20;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // txtTIN
            // 
            this.txtTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTIN.Location = new System.Drawing.Point(0, 118);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.ReadOnly = true;
            this.txtTIN.Size = new System.Drawing.Size(261, 20);
            this.txtTIN.TabIndex = 19;
            this.txtTIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTin
            // 
            this.lblTin.AutoSize = true;
            this.lblTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTin.Location = new System.Drawing.Point(0, 92);
            this.lblTin.Name = "lblTin";
            this.lblTin.Size = new System.Drawing.Size(28, 26);
            this.lblTin.TabIndex = 18;
            this.lblTin.Text = "\r\nTIN:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyName.Location = new System.Drawing.Point(0, 72);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(261, 20);
            this.txtCompanyName.TabIndex = 17;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyName.Location = new System.Drawing.Point(0, 46);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(97, 26);
            this.lblCompanyName.TabIndex = 16;
            this.lblCompanyName.Text = "\r\nCOMPANY NAME:";
            // 
            // txtRequestNumber
            // 
            this.txtRequestNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequestNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRequestNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRequestNumber.Location = new System.Drawing.Point(0, 26);
            this.txtRequestNumber.Name = "txtRequestNumber";
            this.txtRequestNumber.ReadOnly = true;
            this.txtRequestNumber.Size = new System.Drawing.Size(261, 20);
            this.txtRequestNumber.TabIndex = 15;
            this.txtRequestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRequestNumber
            // 
            this.lblRequestNumber.AutoSize = true;
            this.lblRequestNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRequestNumber.Location = new System.Drawing.Point(0, 0);
            this.lblRequestNumber.Name = "lblRequestNumber";
            this.lblRequestNumber.Size = new System.Drawing.Size(112, 26);
            this.lblRequestNumber.TabIndex = 14;
            this.lblRequestNumber.Text = "\r\nREQUEST NUMBER:";
            // 
            // lblLoadInfo
            // 
            this.lblLoadInfo.AutoSize = true;
            this.lblLoadInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoadInfo.Location = new System.Drawing.Point(0, 201);
            this.lblLoadInfo.Name = "lblLoadInfo";
            this.lblLoadInfo.Size = new System.Drawing.Size(67, 13);
            this.lblLoadInfo.TabIndex = 13;
            this.lblLoadInfo.Text = "LOAD INFO:";
            // 
            // cmbLoadInfo
            // 
            this.cmbLoadInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbLoadInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadInfo.FormattingEnabled = true;
            this.cmbLoadInfo.Location = new System.Drawing.Point(0, 214);
            this.cmbLoadInfo.Name = "cmbLoadInfo";
            this.cmbLoadInfo.Size = new System.Drawing.Size(261, 21);
            this.cmbLoadInfo.TabIndex = 12;
            this.cmbLoadInfo.SelectedIndexChanged += new System.EventHandler(this.cmbLoadInfo_SelectedIndexChanged);
            // 
            // btnSelectCompany
            // 
            this.btnSelectCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectCompany.Location = new System.Drawing.Point(0, 235);
            this.btnSelectCompany.Name = "btnSelectCompany";
            this.btnSelectCompany.Size = new System.Drawing.Size(261, 23);
            this.btnSelectCompany.TabIndex = 9;
            this.btnSelectCompany.Text = "Select Company";
            this.btnSelectCompany.UseVisualStyleBackColor = true;
            this.btnSelectCompany.Click += new System.EventHandler(this.btnSelectCompany_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Request";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvSpecifications
            // 
            this.dgvSpecifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpecifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSpecifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSpecifications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSpecifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpecifications.Location = new System.Drawing.Point(0, 0);
            this.dgvSpecifications.Name = "dgvSpecifications";
            this.dgvSpecifications.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpecifications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSpecifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecifications.Size = new System.Drawing.Size(519, 281);
            this.dgvSpecifications.TabIndex = 3;
            // 
            // QuotationRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 281);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuotationRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Quotation";
            this.Load += new System.EventHandler(this.QuotationRequestForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSpecifications;
        private System.Windows.Forms.Button btnSelectCompany;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbLoadInfo;
        private System.Windows.Forms.Label lblLoadInfo;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.Label lblTin;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtRequestNumber;
        private System.Windows.Forms.Label lblRequestNumber;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnEdit;
    }
}