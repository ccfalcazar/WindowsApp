namespace AgatePrintingStation
{
    partial class frmMain
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
            this.tblPending = new System.Windows.Forms.DataGridView();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnClearNote = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.grpQuotation = new System.Windows.Forms.GroupBox();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnForms = new System.Windows.Forms.Button();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.btnInkInventory = new System.Windows.Forms.Button();
            this.btnPaperInventory = new System.Windows.Forms.Button();
            this.btnMiscInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPending)).BeginInit();
            this.grpClient.SuspendLayout();
            this.grpQuotation.SuspendLayout();
            this.grpInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPending
            // 
            this.tblPending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPending.Location = new System.Drawing.Point(0, 0);
            this.tblPending.Name = "tblPending";
            this.tblPending.ReadOnly = true;
            this.tblPending.Size = new System.Drawing.Size(784, 162);
            this.tblPending.TabIndex = 0;
            // 
            // btnAddNote
            // 
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Location = new System.Drawing.Point(557, 411);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(227, 23);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.Text = "Add New Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnClearNote
            // 
            this.btnClearNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearNote.FlatAppearance.BorderSize = 0;
            this.btnClearNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNote.Location = new System.Drawing.Point(0, 534);
            this.btnClearNote.Name = "btnClearNote";
            this.btnClearNote.Size = new System.Drawing.Size(784, 27);
            this.btnClearNote.TabIndex = 3;
            this.btnClearNote.Text = "Clear Note";
            this.btnClearNote.UseVisualStyleBackColor = true;
            this.btnClearNote.Click += new System.EventHandler(this.btnClearNote_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(557, 168);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 5;
            // 
            // lstNotes
            // 
            this.lstNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.Location = new System.Drawing.Point(0, 441);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(784, 93);
            this.lstNotes.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Location = new System.Drawing.Point(557, 334);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(227, 71);
            this.txtNote.TabIndex = 10;
            this.txtNote.Text = "";
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.btnNewClient);
            this.grpClient.Controls.Add(this.btnView);
            this.grpClient.Location = new System.Drawing.Point(0, 168);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(190, 81);
            this.grpClient.TabIndex = 11;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client Control";
            // 
            // btnNewClient
            // 
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.Location = new System.Drawing.Point(6, 48);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(178, 23);
            this.btnNewClient.TabIndex = 11;
            this.btnNewClient.Text = "New Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(6, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(178, 23);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View Client";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grpQuotation
            // 
            this.grpQuotation.Controls.Add(this.btnOthers);
            this.grpQuotation.Controls.Add(this.btnForms);
            this.grpQuotation.Location = new System.Drawing.Point(196, 168);
            this.grpQuotation.Name = "grpQuotation";
            this.grpQuotation.Size = new System.Drawing.Size(190, 81);
            this.grpQuotation.TabIndex = 12;
            this.grpQuotation.TabStop = false;
            this.grpQuotation.Text = "Request Quotation";
            // 
            // btnOthers
            // 
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Location = new System.Drawing.Point(6, 48);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(178, 23);
            this.btnOthers.TabIndex = 13;
            this.btnOthers.Text = "Others";
            this.btnOthers.UseVisualStyleBackColor = true;
            // 
            // btnForms
            // 
            this.btnForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForms.Location = new System.Drawing.Point(6, 19);
            this.btnForms.Name = "btnForms";
            this.btnForms.Size = new System.Drawing.Size(178, 23);
            this.btnForms.TabIndex = 12;
            this.btnForms.Text = "Forms";
            this.btnForms.UseVisualStyleBackColor = true;
            this.btnForms.Click += new System.EventHandler(this.btnForms_Click);
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.btnMiscInventory);
            this.grpInventory.Controls.Add(this.btnInkInventory);
            this.grpInventory.Controls.Add(this.btnPaperInventory);
            this.grpInventory.Location = new System.Drawing.Point(0, 255);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(190, 107);
            this.grpInventory.TabIndex = 14;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // btnInkInventory
            // 
            this.btnInkInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInkInventory.Location = new System.Drawing.Point(6, 48);
            this.btnInkInventory.Name = "btnInkInventory";
            this.btnInkInventory.Size = new System.Drawing.Size(178, 23);
            this.btnInkInventory.TabIndex = 13;
            this.btnInkInventory.Text = "Inks";
            this.btnInkInventory.UseVisualStyleBackColor = true;
            // 
            // btnPaperInventory
            // 
            this.btnPaperInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaperInventory.Location = new System.Drawing.Point(6, 19);
            this.btnPaperInventory.Name = "btnPaperInventory";
            this.btnPaperInventory.Size = new System.Drawing.Size(178, 23);
            this.btnPaperInventory.TabIndex = 12;
            this.btnPaperInventory.Text = "Paper";
            this.btnPaperInventory.UseMnemonic = false;
            this.btnPaperInventory.UseVisualStyleBackColor = true;
            this.btnPaperInventory.Click += new System.EventHandler(this.btnPaperInventory_Click);
            // 
            // btnMiscInventory
            // 
            this.btnMiscInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiscInventory.Location = new System.Drawing.Point(6, 77);
            this.btnMiscInventory.Name = "btnMiscInventory";
            this.btnMiscInventory.Size = new System.Drawing.Size(178, 23);
            this.btnMiscInventory.TabIndex = 14;
            this.btnMiscInventory.Text = "Miscellaneous";
            this.btnMiscInventory.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.grpQuotation);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lstNotes);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.btnClearNote);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.tblPending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPending)).EndInit();
            this.grpClient.ResumeLayout(false);
            this.grpQuotation.ResumeLayout(false);
            this.grpInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPending;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnClearNote;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox grpQuotation;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button btnForms;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnMiscInventory;
        private System.Windows.Forms.Button btnInkInventory;
        private System.Windows.Forms.Button btnPaperInventory;
    }
}