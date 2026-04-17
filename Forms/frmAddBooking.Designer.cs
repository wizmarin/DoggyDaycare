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
            lblCustomer = new Label();
            lblPet = new Label();
            lblService = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            cmbCustomer = new ComboBox();
            cmbPet = new ComboBox();
            cmbService = new ComboBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            btnRegisterCustomer = new Button();
            btnRegisterPet = new Button();
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
            tlpFormContent.Controls.Add(lblCustomer, 0, 0);
            tlpFormContent.Controls.Add(lblPet, 0, 2);
            tlpFormContent.Controls.Add(lblService, 0, 4);
            tlpFormContent.Controls.Add(lblCheckIn, 0, 6);
            tlpFormContent.Controls.Add(lblCheckOut, 0, 8);
            tlpFormContent.Controls.Add(cmbCustomer, 0, 1);
            tlpFormContent.Controls.Add(cmbPet, 0, 3);
            tlpFormContent.Controls.Add(cmbService, 0, 5);
            tlpFormContent.Controls.Add(dtpCheckIn, 0, 7);
            tlpFormContent.Controls.Add(dtpCheckOut, 0, 9);
            tlpFormContent.Controls.Add(btnRegisterCustomer, 2, 1);
            tlpFormContent.Controls.Add(btnRegisterPet, 2, 3);
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
            lblPet.Location = new Point(8, 67);
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
            lblService.Location = new Point(8, 124);
            lblService.Margin = new Padding(3, 5, 3, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(294, 16);
            lblService.TabIndex = 2;
            lblService.Text = "Service:";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Dock = DockStyle.Fill;
            lblCheckIn.Font = new Font("Gadugi", 9.75F);
            lblCheckIn.Location = new Point(8, 178);
            lblCheckIn.Margin = new Padding(3, 5, 3, 0);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(294, 16);
            lblCheckIn.TabIndex = 3;
            lblCheckIn.Text = "Check-In";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Dock = DockStyle.Fill;
            lblCheckOut.Font = new Font("Gadugi", 9.75F);
            lblCheckOut.Location = new Point(8, 234);
            lblCheckOut.Margin = new Padding(3, 5, 3, 0);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(294, 16);
            lblCheckOut.TabIndex = 4;
            lblCheckOut.Text = "Check-Out";
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
            // 
            // cmbPet
            // 
            cmbPet.Dock = DockStyle.Fill;
            cmbPet.Font = new Font("Gadugi", 12F);
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(8, 86);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(294, 27);
            cmbPet.TabIndex = 6;
            // 
            // cmbService
            // 
            cmbService.Dock = DockStyle.Fill;
            cmbService.Font = new Font("Gadugi", 12F);
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(8, 143);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(294, 27);
            cmbService.TabIndex = 7;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Dock = DockStyle.Fill;
            dtpCheckIn.Font = new Font("Gadugi", 12F);
            dtpCheckIn.Location = new Point(8, 197);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(294, 29);
            dtpCheckIn.TabIndex = 8;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Dock = DockStyle.Fill;
            dtpCheckOut.Font = new Font("Gadugi", 12F);
            dtpCheckOut.Location = new Point(8, 253);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(294, 29);
            dtpCheckOut.TabIndex = 9;
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.Dock = DockStyle.Fill;
            btnRegisterCustomer.Font = new Font("Century Gothic", 12F);
            btnRegisterCustomer.Location = new Point(328, 29);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(244, 30);
            btnRegisterCustomer.TabIndex = 10;
            btnRegisterCustomer.Text = "Register Customer";
            btnRegisterCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPet
            // 
            btnRegisterPet.Dock = DockStyle.Fill;
            btnRegisterPet.Font = new Font("Century Gothic", 12F);
            btnRegisterPet.Location = new Point(328, 86);
            btnRegisterPet.Name = "btnRegisterPet";
            btnRegisterPet.Size = new Size(244, 30);
            btnRegisterPet.TabIndex = 11;
            btnRegisterPet.Text = "Register Pet";
            btnRegisterPet.UseVisualStyleBackColor = true;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBooking.ForeColor = Color.FromArgb(34, 24, 28);
            btnAddBooking.Location = new Point(8, 335);
            btnAddBooking.Margin = new Padding(50, 5, 50, 5);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(294, 30);
            btnAddBooking.TabIndex = 10;
            btnAddBooking.Text = "Add Booking";
            btnAddBooking.UseVisualStyleBackColor = true;
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
        private Label lblCheckIn;
        private Label lblCheckOut;
        private ComboBox cmbCustomer;
        private ComboBox cmbPet;
        private ComboBox cmbService;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Button btnRegisterCustomer;
        private Button btnRegisterPet;
        private Button btnAddBooking;
    }
}