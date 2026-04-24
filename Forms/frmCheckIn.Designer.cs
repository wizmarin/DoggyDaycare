namespace DoggyDaycare.Forms
{
    partial class frmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIn));
            tlpContent = new TableLayoutPanel();
            pnlButtons = new Panel();
            lblMessage = new Label();
            lblBookingId = new Label();
            lblService = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblPricePerHour = new Label();
            lblCustomer = new Label();
            lblPet = new Label();
            lblActualPrice = new Label();
            lblStatus = new Label();
            btnCancel = new Button();
            btnCheckIn = new Button();
            dtpCheckInTime = new DateTimePicker();
            tlpContent.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 3;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpContent.Controls.Add(lblMessage, 1, 1);
            tlpContent.Controls.Add(lblBookingId, 1, 3);
            tlpContent.Controls.Add(lblService, 1, 4);
            tlpContent.Controls.Add(lblCheckIn, 1, 5);
            tlpContent.Controls.Add(lblCheckOut, 1, 6);
            tlpContent.Controls.Add(lblPricePerHour, 1, 7);
            tlpContent.Controls.Add(lblCustomer, 1, 8);
            tlpContent.Controls.Add(lblPet, 1, 9);
            tlpContent.Controls.Add(lblActualPrice, 1, 10);
            tlpContent.Controls.Add(lblStatus, 1, 11);
            tlpContent.Controls.Add(pnlButtons, 1, 15);
            tlpContent.Controls.Add(dtpCheckInTime, 1, 13);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(0, 0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 16;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContent.Size = new Size(484, 311);
            tlpContent.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnCheckIn);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(38, 283);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(408, 25);
            pnlButtons.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(38, 15);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(330, 15);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "You are about to perform check-in for the following booking:";
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Dock = DockStyle.Fill;
            lblBookingId.Location = new Point(38, 50);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(408, 20);
            lblBookingId.TabIndex = 2;
            lblBookingId.Text = "Booking ID: ";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Dock = DockStyle.Fill;
            lblService.Location = new Point(38, 70);
            lblService.Name = "lblService";
            lblService.Size = new Size(408, 20);
            lblService.TabIndex = 3;
            lblService.Text = "Service: ";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Dock = DockStyle.Fill;
            lblCheckIn.Location = new Point(38, 90);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(408, 20);
            lblCheckIn.TabIndex = 4;
            lblCheckIn.Text = "Check-In: ";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Dock = DockStyle.Fill;
            lblCheckOut.Location = new Point(38, 110);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(408, 20);
            lblCheckOut.TabIndex = 5;
            lblCheckOut.Text = "Check-Out: ";
            // 
            // lblPricePerHour
            // 
            lblPricePerHour.AutoSize = true;
            lblPricePerHour.Dock = DockStyle.Fill;
            lblPricePerHour.Location = new Point(38, 130);
            lblPricePerHour.Name = "lblPricePerHour";
            lblPricePerHour.Size = new Size(408, 20);
            lblPricePerHour.TabIndex = 6;
            lblPricePerHour.Text = "Price Per Hour: ";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Dock = DockStyle.Fill;
            lblCustomer.Location = new Point(38, 150);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(408, 20);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Customer: ";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Dock = DockStyle.Fill;
            lblPet.Location = new Point(38, 170);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(408, 20);
            lblPet.TabIndex = 8;
            lblPet.Text = "Pet: ";
            // 
            // lblActualPrice
            // 
            lblActualPrice.AutoSize = true;
            lblActualPrice.Dock = DockStyle.Fill;
            lblActualPrice.Location = new Point(38, 190);
            lblActualPrice.Name = "lblActualPrice";
            lblActualPrice.Size = new Size(408, 20);
            lblActualPrice.TabIndex = 9;
            lblActualPrice.Text = "Actual Price: ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(38, 210);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(408, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status: ";
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Left;
            btnCancel.Location = new Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 25);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Dock = DockStyle.Right;
            btnCheckIn.Location = new Point(223, 0);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(185, 25);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // dtpCheckInTime
            // 
            dtpCheckInTime.Dock = DockStyle.Right;
            dtpCheckInTime.Format = DateTimePickerFormat.Time;
            dtpCheckInTime.Location = new Point(261, 243);
            dtpCheckInTime.Name = "dtpCheckInTime";
            dtpCheckInTime.Size = new Size(185, 23);
            dtpCheckInTime.TabIndex = 11;
            // 
            // frmCheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(484, 311);
            Controls.Add(tlpContent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCheckIn";
            Text = "Confirm Check-In";
            Load += frmCheckIn_Load;
            tlpContent.ResumeLayout(false);
            tlpContent.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpContent;
        private Panel pnlButtons;
        private Label lblMessage;
        private Label lblBookingId;
        private Label lblService;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Label lblPricePerHour;
        private Label lblCustomer;
        private Label lblPet;
        private Label lblActualPrice;
        private Label lblStatus;
        private Button btnCheckIn;
        private Button btnCancel;
        private DateTimePicker dtpCheckInTime;
    }
}