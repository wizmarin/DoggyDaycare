namespace DoggyDaycare.Forms
{
    partial class frmServices
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
            pnlServiceInfo = new Panel();
            tlpServiceInfo = new TableLayoutPanel();
            lblBreedType = new Label();
            lblServiceName = new Label();
            lblServiceID = new Label();
            lblPricePerHour = new Label();
            lblMaxCapacityPerTimeSlot = new Label();
            btnUpdateInformation = new Button();
            btnDeactivate = new Button();
            btnServicesInfoLabel = new Button();
            pnlServicesSearch = new Panel();
            pnlResults = new Panel();
            dgvResult = new DataGridView();
            tlpSearchControls = new TableLayoutPanel();
            cmbSearchType = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSearchLabel = new Button();
            pnlServiceInfo.SuspendLayout();
            tlpServiceInfo.SuspendLayout();
            pnlServicesSearch.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            tlpSearchControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlServiceInfo
            // 
            pnlServiceInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlServiceInfo.Controls.Add(tlpServiceInfo);
            pnlServiceInfo.Controls.Add(btnServicesInfoLabel);
            pnlServiceInfo.Dock = DockStyle.Right;
            pnlServiceInfo.Location = new Point(728, 0);
            pnlServiceInfo.Name = "pnlServiceInfo";
            pnlServiceInfo.Size = new Size(300, 600);
            pnlServiceInfo.TabIndex = 0;
            // 
            // tlpServiceInfo
            // 
            tlpServiceInfo.ColumnCount = 1;
            tlpServiceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpServiceInfo.Controls.Add(lblBreedType, 0, 2);
            tlpServiceInfo.Controls.Add(lblServiceName, 0, 1);
            tlpServiceInfo.Controls.Add(lblServiceID, 0, 0);
            tlpServiceInfo.Controls.Add(lblPricePerHour, 0, 3);
            tlpServiceInfo.Controls.Add(lblMaxCapacityPerTimeSlot, 0, 4);
            tlpServiceInfo.Controls.Add(btnUpdateInformation, 0, 6);
            tlpServiceInfo.Controls.Add(btnDeactivate, 0, 7);
            tlpServiceInfo.Dock = DockStyle.Fill;
            tlpServiceInfo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpServiceInfo.ForeColor = Color.FromArgb(34, 24, 28);
            tlpServiceInfo.Location = new Point(0, 40);
            tlpServiceInfo.Name = "tlpServiceInfo";
            tlpServiceInfo.Padding = new Padding(5);
            tlpServiceInfo.RowCount = 8;
            tlpServiceInfo.RowStyles.Add(new RowStyle());
            tlpServiceInfo.RowStyles.Add(new RowStyle());
            tlpServiceInfo.RowStyles.Add(new RowStyle());
            tlpServiceInfo.RowStyles.Add(new RowStyle());
            tlpServiceInfo.RowStyles.Add(new RowStyle());
            tlpServiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpServiceInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpServiceInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpServiceInfo.Size = new Size(298, 558);
            tlpServiceInfo.TabIndex = 1;
            // 
            // lblBreedType
            // 
            lblBreedType.AutoSize = true;
            lblBreedType.Dock = DockStyle.Fill;
            lblBreedType.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBreedType.Location = new Point(8, 43);
            lblBreedType.Name = "lblBreedType";
            lblBreedType.Size = new Size(282, 19);
            lblBreedType.TabIndex = 2;
            lblBreedType.Text = "Breed Type: ";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Dock = DockStyle.Fill;
            lblServiceName.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServiceName.Location = new Point(8, 24);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(282, 19);
            lblServiceName.TabIndex = 1;
            lblServiceName.Text = "Service Name: ";
            // 
            // lblServiceID
            // 
            lblServiceID.AutoSize = true;
            lblServiceID.Dock = DockStyle.Fill;
            lblServiceID.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServiceID.Location = new Point(8, 5);
            lblServiceID.Name = "lblServiceID";
            lblServiceID.Size = new Size(282, 19);
            lblServiceID.TabIndex = 0;
            lblServiceID.Text = "Service ID: ";
            // 
            // lblPricePerHour
            // 
            lblPricePerHour.AutoSize = true;
            lblPricePerHour.Dock = DockStyle.Fill;
            lblPricePerHour.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPricePerHour.Location = new Point(8, 62);
            lblPricePerHour.Name = "lblPricePerHour";
            lblPricePerHour.Size = new Size(282, 19);
            lblPricePerHour.TabIndex = 3;
            lblPricePerHour.Text = "Price Per Hour: ";
            // 
            // lblMaxCapacityPerTimeSlot
            // 
            lblMaxCapacityPerTimeSlot.AutoSize = true;
            lblMaxCapacityPerTimeSlot.Dock = DockStyle.Fill;
            lblMaxCapacityPerTimeSlot.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaxCapacityPerTimeSlot.Location = new Point(8, 81);
            lblMaxCapacityPerTimeSlot.Name = "lblMaxCapacityPerTimeSlot";
            lblMaxCapacityPerTimeSlot.Size = new Size(282, 19);
            lblMaxCapacityPerTimeSlot.TabIndex = 4;
            lblMaxCapacityPerTimeSlot.Text = "Max Capacity Per Time Slot: ";
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
            // btnServicesInfoLabel
            // 
            btnServicesInfoLabel.Dock = DockStyle.Top;
            btnServicesInfoLabel.Enabled = false;
            btnServicesInfoLabel.FlatAppearance.BorderSize = 0;
            btnServicesInfoLabel.FlatStyle = FlatStyle.Flat;
            btnServicesInfoLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServicesInfoLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnServicesInfoLabel.Location = new Point(0, 0);
            btnServicesInfoLabel.Name = "btnServicesInfoLabel";
            btnServicesInfoLabel.Size = new Size(298, 40);
            btnServicesInfoLabel.TabIndex = 0;
            btnServicesInfoLabel.Text = "Service Information";
            btnServicesInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnServicesInfoLabel.UseVisualStyleBackColor = true;
            // 
            // pnlServicesSearch
            // 
            pnlServicesSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlServicesSearch.Controls.Add(pnlResults);
            pnlServicesSearch.Controls.Add(tlpSearchControls);
            pnlServicesSearch.Controls.Add(btnSearchLabel);
            pnlServicesSearch.Dock = DockStyle.Fill;
            pnlServicesSearch.Location = new Point(0, 0);
            pnlServicesSearch.Name = "pnlServicesSearch";
            pnlServicesSearch.Size = new Size(728, 600);
            pnlServicesSearch.TabIndex = 1;
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dgvResult);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 75);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(5);
            pnlResults.Size = new Size(726, 523);
            pnlResults.TabIndex = 3;
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
            tlpSearchControls.TabIndex = 1;
            // 
            // cmbSearchType
            // 
            cmbSearchType.Dock = DockStyle.Fill;
            cmbSearchType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSearchType.ForeColor = Color.FromArgb(34, 24, 28);
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "By ID", "By Name", "By Breed Type" });
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
            // frmServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlServicesSearch);
            Controls.Add(pnlServiceInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmServices";
            Text = "frmServices";
            pnlServiceInfo.ResumeLayout(false);
            tlpServiceInfo.ResumeLayout(false);
            tlpServiceInfo.PerformLayout();
            pnlServicesSearch.ResumeLayout(false);
            pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            tlpSearchControls.ResumeLayout(false);
            tlpSearchControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlServiceInfo;
        private Panel pnlServicesSearch;
        private Button btnServicesInfoLabel;
        private TableLayoutPanel tlpSearchControls;
        private Button btnSearchLabel;
        private ComboBox cmbSearchType;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvResult;
        private Panel pnlResults;
        private TableLayoutPanel tlpServiceInfo;
        private Label lblServiceID;
        private Label lblServiceName;
        private Label lblBreedType;
        private Label lblPricePerHour;
        private Label lblMaxCapacityPerTimeSlot;
        private Button btnUpdateInformation;
        private Button btnDeactivate;
    }
}