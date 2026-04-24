namespace DoggyDaycare.Forms
{
    partial class frmAddBooking
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
            btnAddBookingLabel = new Button();
            tlpFormContent = new TableLayoutPanel();
            lblCheckOutTime = new Label();
            lblCheckInTime = new Label();
            lblCustomer = new Label();
            lblPet = new Label();
            lblService = new Label();
            lblCheckInDate = new Label();
            lblCheckOutDate = new Label();
            cmbCustomer = new ComboBox();
            cmbPet = new ComboBox();
            cmbService = new ComboBox();
            dtpCheckInDate = new DateTimePicker();
            dtpCheckOutDate = new DateTimePicker();
            dtpCheckOutTime = new DateTimePicker();
            dtpCheckInTime = new DateTimePicker();
            btnAddBooking = new Button();
            tlpFormContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddBookingLabel
            // 
            btnAddBookingLabel.Dock = DockStyle.Top;
            btnAddBookingLabel.Enabled = false;
            btnAddBookingLabel.FlatAppearance.BorderSize = 0;
            btnAddBookingLabel.FlatStyle = FlatStyle.Flat;
            btnAddBookingLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBookingLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnAddBookingLabel.Location = new Point(0, 0);
            btnAddBookingLabel.Name = "btnAddBookingLabel";
            btnAddBookingLabel.Size = new Size(1026, 40);
            btnAddBookingLabel.TabIndex = 1;
            btnAddBookingLabel.Text = "New Booking Form";
            btnAddBookingLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBookingLabel.UseVisualStyleBackColor = true;
            // 
            // tlpFormContent
            // 
            tlpFormContent.ColumnCount = 4;
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormContent.Controls.Add(lblCheckOutTime, 2, 8);
            tlpFormContent.Controls.Add(lblCheckInTime, 2, 6);
            tlpFormContent.Controls.Add(lblCustomer, 0, 0);
            tlpFormContent.Controls.Add(lblPet, 0, 2);
            tlpFormContent.Controls.Add(lblService, 0, 4);
            tlpFormContent.Controls.Add(lblCheckInDate, 0, 6);
            tlpFormContent.Controls.Add(lblCheckOutDate, 0, 8);
            tlpFormContent.Controls.Add(cmbCustomer, 0, 1);
            tlpFormContent.Controls.Add(cmbPet, 0, 3);
            tlpFormContent.Controls.Add(cmbService, 0, 5);
            tlpFormContent.Controls.Add(dtpCheckInDate, 0, 7);
            tlpFormContent.Controls.Add(dtpCheckOutDate, 0, 9);
            tlpFormContent.Controls.Add(dtpCheckOutTime, 2, 9);
            tlpFormContent.Controls.Add(dtpCheckInTime, 2, 7);
            tlpFormContent.Dock = DockStyle.Top;
            tlpFormContent.ForeColor = Color.FromArgb(34, 24, 28);
            tlpFormContent.Location = new Point(0, 40);
            tlpFormContent.Name = "tlpFormContent";
            tlpFormContent.Padding = new Padding(5);
            tlpFormContent.RowCount = 10;
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.Size = new Size(1026, 287);
            tlpFormContent.TabIndex = 2;
            // 
            // lblCheckOutTime
            // 
            lblCheckOutTime.AutoSize = true;
            lblCheckOutTime.Font = new Font("Gadugi", 9.75F);
            lblCheckOutTime.Location = new Point(328, 228);
            lblCheckOutTime.Margin = new Padding(3, 5, 3, 0);
            lblCheckOutTime.Name = "lblCheckOutTime";
            lblCheckOutTime.Size = new Size(102, 16);
            lblCheckOutTime.TabIndex = 13;
            lblCheckOutTime.Text = "Check-Out Time:";
            // 
            // lblCheckInTime
            // 
            lblCheckInTime.AutoSize = true;
            lblCheckInTime.Font = new Font("Gadugi", 9.75F);
            lblCheckInTime.Location = new Point(328, 172);
            lblCheckInTime.Margin = new Padding(3, 5, 3, 0);
            lblCheckInTime.Name = "lblCheckInTime";
            lblCheckInTime.Size = new Size(91, 16);
            lblCheckInTime.TabIndex = 12;
            lblCheckInTime.Text = "Check-In Time:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Dock = DockStyle.Fill;
            lblCustomer.Font = new Font("Gadugi", 9.75F);
            lblCustomer.Location = new Point(8, 10);
            lblCustomer.Margin = new Padding(3, 5, 3, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(294, 16);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer:";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Dock = DockStyle.Fill;
            lblPet.Font = new Font("Gadugi", 9.75F);
            lblPet.Location = new Point(8, 64);
            lblPet.Margin = new Padding(3, 5, 3, 0);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(294, 16);
            lblPet.TabIndex = 1;
            lblPet.Text = "Pet:";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Dock = DockStyle.Fill;
            lblService.Font = new Font("Gadugi", 9.75F);
            lblService.Location = new Point(8, 118);
            lblService.Margin = new Padding(3, 5, 3, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(294, 16);
            lblService.TabIndex = 2;
            lblService.Text = "Service:";
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Dock = DockStyle.Fill;
            lblCheckInDate.Font = new Font("Gadugi", 9.75F);
            lblCheckInDate.Location = new Point(8, 172);
            lblCheckInDate.Margin = new Padding(3, 5, 3, 0);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(294, 16);
            lblCheckInDate.TabIndex = 3;
            lblCheckInDate.Text = "Check-In Date:";
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Dock = DockStyle.Fill;
            lblCheckOutDate.Font = new Font("Gadugi", 9.75F);
            lblCheckOutDate.Location = new Point(8, 228);
            lblCheckOutDate.Margin = new Padding(3, 5, 3, 0);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(294, 16);
            lblCheckOutDate.TabIndex = 4;
            lblCheckOutDate.Text = "Check-Out Date:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.Dock = DockStyle.Fill;
            cmbCustomer.Font = new Font("Gadugi", 12F);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(8, 29);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(294, 27);
            cmbCustomer.TabIndex = 5;
            cmbCustomer.SelectionChangeCommitted += cmbCustomer_SelectionChangeCommitted;
            cmbCustomer.TextChanged += cmbCustomer_TextChanged;
            // 
            // cmbPet
            // 
            cmbPet.Dock = DockStyle.Fill;
            cmbPet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPet.Font = new Font("Gadugi", 12F);
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(8, 83);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(294, 27);
            cmbPet.TabIndex = 6;
            cmbPet.SelectedIndexChanged += cmbPet_SelectedIndexChanged;
            // 
            // cmbService
            // 
            cmbService.Dock = DockStyle.Fill;
            cmbService.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbService.Font = new Font("Gadugi", 12F);
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(8, 137);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(294, 27);
            cmbService.TabIndex = 7;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Dock = DockStyle.Fill;
            dtpCheckInDate.Font = new Font("Gadugi", 12F);
            dtpCheckInDate.Location = new Point(8, 191);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(294, 29);
            dtpCheckInDate.TabIndex = 8;
            dtpCheckInDate.ValueChanged += dtpCheckInDate_ValueChanged;
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Dock = DockStyle.Fill;
            dtpCheckOutDate.Font = new Font("Gadugi", 12F);
            dtpCheckOutDate.Location = new Point(8, 247);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(294, 29);
            dtpCheckOutDate.TabIndex = 9;
            dtpCheckOutDate.ValueChanged += dtpCheckOutDate_ValueChanged;
            // 
            // dtpCheckOutTime
            // 
            dtpCheckOutTime.Dock = DockStyle.Fill;
            dtpCheckOutTime.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOutTime.Format = DateTimePickerFormat.Time;
            dtpCheckOutTime.Location = new Point(328, 247);
            dtpCheckOutTime.Name = "dtpCheckOutTime";
            dtpCheckOutTime.ShowUpDown = true;
            dtpCheckOutTime.Size = new Size(244, 29);
            dtpCheckOutTime.TabIndex = 14;
            // 
            // dtpCheckInTime
            // 
            dtpCheckInTime.Dock = DockStyle.Fill;
            dtpCheckInTime.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckInTime.Format = DateTimePickerFormat.Time;
            dtpCheckInTime.Location = new Point(328, 191);
            dtpCheckInTime.Name = "dtpCheckInTime";
            dtpCheckInTime.ShowUpDown = true;
            dtpCheckInTime.Size = new Size(244, 29);
            dtpCheckInTime.TabIndex = 15;
            dtpCheckInTime.ValueChanged += dtpCheckInTime_ValueChanged;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBooking.ForeColor = Color.FromArgb(34, 24, 28);
            btnAddBooking.Location = new Point(172, 330);
            btnAddBooking.Margin = new Padding(50, 5, 50, 5);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(294, 30);
            btnAddBooking.TabIndex = 10;
            btnAddBooking.Text = "Add Booking";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // frmAddBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1026, 621);
            Controls.Add(btnAddBooking);
            Controls.Add(tlpFormContent);
            Controls.Add(btnAddBookingLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddBooking";
            Text = "frmAddBooking";
            Load += frmAddBooking_Load;
            tlpFormContent.ResumeLayout(false);
            tlpFormContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddBookingLabel;
        private TableLayoutPanel tlpFormContent;
        private Label lblCustomer;
        private Label lblPet;
        private Label lblService;
        private Label lblCheckInDate;
        private Label lblCheckOutDate;
        private ComboBox cmbCustomer;
        private ComboBox cmbPet;
        private ComboBox cmbService;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private Button btnAddBooking;
        private Label lblCheckOutTime;
        private Label lblCheckInTime;
        private DateTimePicker dtpCheckOutTime;
        private DateTimePicker dtpCheckInTime;
    }
}