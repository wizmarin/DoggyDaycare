namespace DoggyDaycare.Forms
{
    partial class frmBookings
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
            pnlBookingInfo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeactivate = new Button();
            btnUpdateInformation = new Button();
            lblBookingID = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblPricePerHour = new Label();
            lblActualPrice = new Label();
            lblStatus = new Label();
            lblServiceID = new Label();
            lblCustomerID = new Label();
            lblPetID = new Label();
            btnBookingInfoLabel = new Button();
            pnlBookingsSearch = new Panel();
            pnlResults = new Panel();
            dgvResult = new DataGridView();
            tlpSearchControls = new TableLayoutPanel();
            cmbSearchType = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSearchLabel = new Button();
            pnlBookingInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlBookingsSearch.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            tlpSearchControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBookingInfo
            // 
            pnlBookingInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingInfo.Controls.Add(tableLayoutPanel1);
            pnlBookingInfo.Controls.Add(btnBookingInfoLabel);
            pnlBookingInfo.Dock = DockStyle.Right;
            pnlBookingInfo.Location = new Point(728, 0);
            pnlBookingInfo.Name = "pnlBookingInfo";
            pnlBookingInfo.Size = new Size(300, 600);
            pnlBookingInfo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnDeactivate, 0, 11);
            tableLayoutPanel1.Controls.Add(btnUpdateInformation, 0, 10);
            tableLayoutPanel1.Controls.Add(lblBookingID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCheckIn, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCheckOut, 0, 2);
            tableLayoutPanel1.Controls.Add(lblPricePerHour, 0, 3);
            tableLayoutPanel1.Controls.Add(lblActualPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 5);
            tableLayoutPanel1.Controls.Add(lblServiceID, 0, 6);
            tableLayoutPanel1.Controls.Add(lblCustomerID, 0, 7);
            tableLayoutPanel1.Controls.Add(lblPetID, 0, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(298, 558);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Dock = DockStyle.Fill;
            btnDeactivate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.Location = new Point(8, 521);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(282, 29);
            btnDeactivate.TabIndex = 11;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInformation
            // 
            btnUpdateInformation.Dock = DockStyle.Fill;
            btnUpdateInformation.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateInformation.Location = new Point(8, 486);
            btnUpdateInformation.Name = "btnUpdateInformation";
            btnUpdateInformation.Size = new Size(282, 29);
            btnUpdateInformation.TabIndex = 10;
            btnUpdateInformation.Text = "Update Information";
            btnUpdateInformation.UseVisualStyleBackColor = true;
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Location = new Point(8, 5);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(92, 19);
            lblBookingID.TabIndex = 0;
            lblBookingID.Text = "Booking ID: ";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(8, 25);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(77, 19);
            lblCheckIn.TabIndex = 1;
            lblCheckIn.Text = "Check-In: ";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(8, 45);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(90, 19);
            lblCheckOut.TabIndex = 2;
            lblCheckOut.Text = "Check-Out: ";
            // 
            // lblPricePerHour
            // 
            lblPricePerHour.AutoSize = true;
            lblPricePerHour.Location = new Point(8, 65);
            lblPricePerHour.Name = "lblPricePerHour";
            lblPricePerHour.Size = new Size(116, 19);
            lblPricePerHour.TabIndex = 3;
            lblPricePerHour.Text = "Price Per Hour: ";
            // 
            // lblActualPrice
            // 
            lblActualPrice.AutoSize = true;
            lblActualPrice.Location = new Point(8, 85);
            lblActualPrice.Name = "lblActualPrice";
            lblActualPrice.Size = new Size(97, 19);
            lblActualPrice.TabIndex = 4;
            lblActualPrice.Text = "Actual Price: ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(8, 105);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 19);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status: ";
            // 
            // lblServiceID
            // 
            lblServiceID.AutoSize = true;
            lblServiceID.Location = new Point(8, 125);
            lblServiceID.Name = "lblServiceID";
            lblServiceID.Size = new Size(85, 19);
            lblServiceID.TabIndex = 6;
            lblServiceID.Text = "Service ID: ";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(8, 145);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(103, 19);
            lblCustomerID.TabIndex = 7;
            lblCustomerID.Text = "Customer ID: ";
            // 
            // lblPetID
            // 
            lblPetID.AutoSize = true;
            lblPetID.Location = new Point(8, 165);
            lblPetID.Name = "lblPetID";
            lblPetID.Size = new Size(57, 19);
            lblPetID.TabIndex = 8;
            lblPetID.Text = "Pet ID: ";
            // 
            // btnBookingInfoLabel
            // 
            btnBookingInfoLabel.Dock = DockStyle.Top;
            btnBookingInfoLabel.Enabled = false;
            btnBookingInfoLabel.FlatAppearance.BorderSize = 0;
            btnBookingInfoLabel.FlatStyle = FlatStyle.Flat;
            btnBookingInfoLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookingInfoLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnBookingInfoLabel.Location = new Point(0, 0);
            btnBookingInfoLabel.Name = "btnBookingInfoLabel";
            btnBookingInfoLabel.Size = new Size(298, 40);
            btnBookingInfoLabel.TabIndex = 1;
            btnBookingInfoLabel.Text = "Booking Information";
            btnBookingInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnBookingInfoLabel.UseVisualStyleBackColor = true;
            // 
            // pnlBookingsSearch
            // 
            pnlBookingsSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingsSearch.Controls.Add(pnlResults);
            pnlBookingsSearch.Controls.Add(tlpSearchControls);
            pnlBookingsSearch.Controls.Add(btnSearchLabel);
            pnlBookingsSearch.Dock = DockStyle.Fill;
            pnlBookingsSearch.Location = new Point(0, 0);
            pnlBookingsSearch.Name = "pnlBookingsSearch";
            pnlBookingsSearch.Size = new Size(728, 600);
            pnlBookingsSearch.TabIndex = 1;
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
            cmbSearchType.Items.AddRange(new object[] { "By ID", "By Status", "By Customer ID", "By Pet ID", "By Service ID" });
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
            btnSearchLabel.TabIndex = 1;
            btnSearchLabel.Text = "Search";
            btnSearchLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchLabel.UseVisualStyleBackColor = true;
            // 
            // frmBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlBookingsSearch);
            Controls.Add(pnlBookingInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBookings";
            Text = "frmBookings";
            pnlBookingInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlBookingsSearch.ResumeLayout(false);
            pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            tlpSearchControls.ResumeLayout(false);
            tlpSearchControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBookingInfo;
        private Panel pnlBookingsSearch;
        private Button btnSearchLabel;
        private Button btnBookingInfoLabel;
        private TableLayoutPanel tlpSearchControls;
        private ComboBox cmbSearchType;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel pnlResults;
        private DataGridView dgvResult;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBookingID;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Label lblPricePerHour;
        private Label lblActualPrice;
        private Label lblStatus;
        private Label lblServiceID;
        private Label lblCustomerID;
        private Label lblPetID;
        private Button btnUpdateInformation;
        private Button btnDeactivate;
    }
}