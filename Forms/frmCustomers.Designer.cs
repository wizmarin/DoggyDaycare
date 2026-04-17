namespace DoggyDaycare.Forms
{
    partial class frmCustomers
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
            pnlCustomerInfo = new Panel();
            tlpCustomerInfo = new TableLayoutPanel();
            lblPhone = new Label();
            lblCustomerName = new Label();
            lblCustomerID = new Label();
            lblEmail = new Label();
            lblEmergencyContact = new Label();
            lblEmergenceContactPhone = new Label();
            btnAssignedPetsLabel = new Button();
            lblPetsIDs = new Label();
            btnUpdateInformation = new Button();
            btnDeactivate = new Button();
            btnCustomerInfoLabel = new Button();
            pnlCustomersSearch = new Panel();
            pnlResults = new Panel();
            dgvResult = new DataGridView();
            tlpSearchControls = new TableLayoutPanel();
            cmbSearchType = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSearchLabel = new Button();
            pnlCustomerInfo.SuspendLayout();
            tlpCustomerInfo.SuspendLayout();
            pnlCustomersSearch.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            tlpSearchControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCustomerInfo
            // 
            pnlCustomerInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomerInfo.Controls.Add(tlpCustomerInfo);
            pnlCustomerInfo.Controls.Add(btnCustomerInfoLabel);
            pnlCustomerInfo.Dock = DockStyle.Right;
            pnlCustomerInfo.Location = new Point(728, 0);
            pnlCustomerInfo.Name = "pnlCustomerInfo";
            pnlCustomerInfo.Size = new Size(300, 600);
            pnlCustomerInfo.TabIndex = 0;
            // 
            // tlpCustomerInfo
            // 
            tlpCustomerInfo.ColumnCount = 1;
            tlpCustomerInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerInfo.Controls.Add(lblPhone, 0, 2);
            tlpCustomerInfo.Controls.Add(lblCustomerName, 0, 1);
            tlpCustomerInfo.Controls.Add(lblCustomerID, 0, 0);
            tlpCustomerInfo.Controls.Add(lblEmail, 0, 3);
            tlpCustomerInfo.Controls.Add(lblEmergencyContact, 0, 4);
            tlpCustomerInfo.Controls.Add(lblEmergenceContactPhone, 0, 5);
            tlpCustomerInfo.Controls.Add(btnAssignedPetsLabel, 0, 6);
            tlpCustomerInfo.Controls.Add(lblPetsIDs, 0, 7);
            tlpCustomerInfo.Controls.Add(btnUpdateInformation, 0, 9);
            tlpCustomerInfo.Controls.Add(btnDeactivate, 0, 10);
            tlpCustomerInfo.Dock = DockStyle.Fill;
            tlpCustomerInfo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpCustomerInfo.ForeColor = Color.FromArgb(34, 24, 28);
            tlpCustomerInfo.Location = new Point(0, 40);
            tlpCustomerInfo.Name = "tlpCustomerInfo";
            tlpCustomerInfo.Padding = new Padding(5);
            tlpCustomerInfo.RowCount = 11;
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCustomerInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomerInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerInfo.Size = new Size(298, 558);
            tlpCustomerInfo.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(8, 43);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(282, 19);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone: ";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Dock = DockStyle.Fill;
            lblCustomerName.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(8, 24);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(282, 19);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Full Name: ";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Dock = DockStyle.Fill;
            lblCustomerID.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(8, 5);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(282, 19);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "Customer ID: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(8, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(282, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email: ";
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.AutoSize = true;
            lblEmergencyContact.Dock = DockStyle.Fill;
            lblEmergencyContact.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmergencyContact.Location = new Point(8, 81);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(282, 19);
            lblEmergencyContact.TabIndex = 4;
            lblEmergencyContact.Text = "Emenrgency Contact: ";
            // 
            // lblEmergenceContactPhone
            // 
            lblEmergenceContactPhone.AutoSize = true;
            lblEmergenceContactPhone.Dock = DockStyle.Fill;
            lblEmergenceContactPhone.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmergenceContactPhone.Location = new Point(8, 100);
            lblEmergenceContactPhone.Name = "lblEmergenceContactPhone";
            lblEmergenceContactPhone.Size = new Size(282, 19);
            lblEmergenceContactPhone.TabIndex = 7;
            lblEmergenceContactPhone.Text = "Emergency Contact Phone: ";
            // 
            // btnAssignedPetsLabel
            // 
            btnAssignedPetsLabel.Dock = DockStyle.Fill;
            btnAssignedPetsLabel.Enabled = false;
            btnAssignedPetsLabel.FlatAppearance.BorderSize = 0;
            btnAssignedPetsLabel.FlatStyle = FlatStyle.Flat;
            btnAssignedPetsLabel.Location = new Point(8, 122);
            btnAssignedPetsLabel.Name = "btnAssignedPetsLabel";
            btnAssignedPetsLabel.Size = new Size(282, 29);
            btnAssignedPetsLabel.TabIndex = 8;
            btnAssignedPetsLabel.Text = "Assigned Pets";
            btnAssignedPetsLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnAssignedPetsLabel.UseVisualStyleBackColor = true;
            // 
            // lblPetsIDs
            // 
            lblPetsIDs.AutoSize = true;
            lblPetsIDs.Dock = DockStyle.Fill;
            lblPetsIDs.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPetsIDs.Location = new Point(8, 154);
            lblPetsIDs.Name = "lblPetsIDs";
            lblPetsIDs.Size = new Size(282, 20);
            lblPetsIDs.TabIndex = 9;
            lblPetsIDs.Text = "IDs: ";
            // 
            // btnUpdateInformation
            // 
            btnUpdateInformation.Dock = DockStyle.Fill;
            btnUpdateInformation.Location = new Point(8, 486);
            btnUpdateInformation.Name = "btnUpdateInformation";
            btnUpdateInformation.Size = new Size(282, 29);
            btnUpdateInformation.TabIndex = 5;
            btnUpdateInformation.Text = "Update Information";
            btnUpdateInformation.UseVisualStyleBackColor = true;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Dock = DockStyle.Fill;
            btnDeactivate.Location = new Point(8, 521);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(282, 29);
            btnDeactivate.TabIndex = 6;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerInfoLabel
            // 
            btnCustomerInfoLabel.Dock = DockStyle.Top;
            btnCustomerInfoLabel.Enabled = false;
            btnCustomerInfoLabel.FlatAppearance.BorderSize = 0;
            btnCustomerInfoLabel.FlatStyle = FlatStyle.Flat;
            btnCustomerInfoLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerInfoLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnCustomerInfoLabel.Location = new Point(0, 0);
            btnCustomerInfoLabel.Name = "btnCustomerInfoLabel";
            btnCustomerInfoLabel.Size = new Size(298, 40);
            btnCustomerInfoLabel.TabIndex = 0;
            btnCustomerInfoLabel.Text = "Customer Information";
            btnCustomerInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerInfoLabel.UseVisualStyleBackColor = true;
            // 
            // pnlCustomersSearch
            // 
            pnlCustomersSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomersSearch.Controls.Add(pnlResults);
            pnlCustomersSearch.Controls.Add(tlpSearchControls);
            pnlCustomersSearch.Controls.Add(btnSearchLabel);
            pnlCustomersSearch.Dock = DockStyle.Fill;
            pnlCustomersSearch.Location = new Point(0, 0);
            pnlCustomersSearch.Name = "pnlCustomersSearch";
            pnlCustomersSearch.Size = new Size(728, 600);
            pnlCustomersSearch.TabIndex = 1;
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dgvResult);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 75);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(5);
            pnlResults.Size = new Size(726, 523);
            pnlResults.TabIndex = 4;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToAddRows = false;
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.AllowUserToResizeColumns = false;
            dgvResult.AllowUserToResizeRows = false;
            dgvResult.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.Location = new Point(5, 5);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.Size = new Size(716, 513);
            dgvResult.TabIndex = 2;
            // 
            // tlpSearchControls
            // 
            tlpSearchControls.ColumnCount = 3;
            tlpSearchControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tlpSearchControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSearchControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpSearchControls.Controls.Add(cmbSearchType, 0, 0);
            tlpSearchControls.Controls.Add(btnSearch, 2, 0);
            tlpSearchControls.Controls.Add(txtSearch, 1, 0);
            tlpSearchControls.Dock = DockStyle.Top;
            tlpSearchControls.Location = new Point(0, 40);
            tlpSearchControls.Name = "tlpSearchControls";
            tlpSearchControls.RowCount = 1;
            tlpSearchControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSearchControls.Size = new Size(726, 35);
            tlpSearchControls.TabIndex = 2;
            // 
            // cmbSearchType
            // 
            cmbSearchType.Dock = DockStyle.Fill;
            cmbSearchType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSearchType.ForeColor = Color.FromArgb(34, 24, 28);
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "By ID", "By Name", "By Phone", "By Email" });
            cmbSearchType.Location = new Point(3, 3);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(129, 29);
            cmbSearchType.TabIndex = 0;
            cmbSearchType.Text = "By ID";
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(34, 24, 28);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(629, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(5, 0, 0, 0);
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(34, 24, 28);
            txtSearch.Location = new Point(138, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(485, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearchLabel
            // 
            btnSearchLabel.Dock = DockStyle.Top;
            btnSearchLabel.Enabled = false;
            btnSearchLabel.FlatAppearance.BorderSize = 0;
            btnSearchLabel.FlatStyle = FlatStyle.Flat;
            btnSearchLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnSearchLabel.Location = new Point(0, 0);
            btnSearchLabel.Name = "btnSearchLabel";
            btnSearchLabel.Size = new Size(726, 40);
            btnSearchLabel.TabIndex = 0;
            btnSearchLabel.Text = "Search";
            btnSearchLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchLabel.UseVisualStyleBackColor = true;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlCustomersSearch);
            Controls.Add(pnlCustomerInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomers";
            Text = "frmCustomers";
            pnlCustomerInfo.ResumeLayout(false);
            tlpCustomerInfo.ResumeLayout(false);
            tlpCustomerInfo.PerformLayout();
            pnlCustomersSearch.ResumeLayout(false);
            pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            tlpSearchControls.ResumeLayout(false);
            tlpSearchControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCustomerInfo;
        private Panel pnlCustomersSearch;
        private Button btnCustomerInfoLabel;
        private Button btnSearchLabel;
        private TableLayoutPanel tlpSearchControls;
        private ComboBox cmbSearchType;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel pnlResults;
        private DataGridView dgvResult;
        private TableLayoutPanel tlpCustomerInfo;
        private Label lblPhone;
        private Label lblCustomerName;
        private Label lblCustomerID;
        private Label lblEmail;
        private Label lblEmergencyContact;
        private Button btnUpdateInformation;
        private Button btnDeactivate;
        private Label lblEmergenceContactPhone;
        private Button btnAssignedPetsLabel;
        private Label lblPetsIDs;
    }
}