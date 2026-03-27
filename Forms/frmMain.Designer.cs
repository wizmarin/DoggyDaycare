namespace DoggyDaycare.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlQuickAccess = new Panel();
            btnTabLabel = new Button();
            btnRegisterCustomer = new Button();
            btnRegisterPet = new Button();
            btnAddNewBooking = new Button();
            pnlContent = new Panel();
            pnlMenu = new Panel();
            btnLogOut = new Button();
            btnExit = new Button();
            pnlAdminButton = new Panel();
            btnReportCustomerBookings = new Button();
            btnReportDailyBookings = new Button();
            btnAdmin = new Button();
            btnServices = new Button();
            btnPets = new Button();
            btnCustomers = new Button();
            btnBookings = new Button();
            btnDashboard = new Button();
            btnMenu = new Button();
            pnlQuickAccess.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlAdminButton.SuspendLayout();
            SuspendLayout();
            // 
            // pnlQuickAccess
            // 
            pnlQuickAccess.BackColor = Color.FromArgb(246, 244, 246);
            pnlQuickAccess.Controls.Add(btnTabLabel);
            pnlQuickAccess.Controls.Add(btnRegisterCustomer);
            pnlQuickAccess.Controls.Add(btnRegisterPet);
            pnlQuickAccess.Controls.Add(btnAddNewBooking);
            pnlQuickAccess.Dock = DockStyle.Top;
            pnlQuickAccess.Location = new Point(0, 0);
            pnlQuickAccess.Margin = new Padding(0);
            pnlQuickAccess.Name = "pnlQuickAccess";
            pnlQuickAccess.Size = new Size(1190, 40);
            pnlQuickAccess.TabIndex = 1;
            // 
            // btnTabLabel
            // 
            btnTabLabel.BackColor = Color.FromArgb(225, 183, 186);
            btnTabLabel.Dock = DockStyle.Fill;
            btnTabLabel.Enabled = false;
            btnTabLabel.FlatStyle = FlatStyle.Flat;
            btnTabLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabLabel.ForeColor = Color.FromArgb(65, 64, 80);
            btnTabLabel.Location = new Point(0, 0);
            btnTabLabel.Margin = new Padding(0);
            btnTabLabel.Name = "btnTabLabel";
            btnTabLabel.Size = new Size(695, 40);
            btnTabLabel.TabIndex = 3;
            btnTabLabel.Text = "Dashboard 🐾";
            btnTabLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnTabLabel.UseVisualStyleBackColor = false;
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.BackColor = Color.FromArgb(225, 183, 186);
            btnRegisterCustomer.Cursor = Cursors.Hand;
            btnRegisterCustomer.Dock = DockStyle.Right;
            btnRegisterCustomer.FlatStyle = FlatStyle.Flat;
            btnRegisterCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterCustomer.ForeColor = Color.FromArgb(65, 64, 80);
            btnRegisterCustomer.Location = new Point(695, 0);
            btnRegisterCustomer.Margin = new Padding(0);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(165, 40);
            btnRegisterCustomer.TabIndex = 2;
            btnRegisterCustomer.Text = "Register Customer";
            btnRegisterCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRegisterPet
            // 
            btnRegisterPet.BackColor = Color.FromArgb(225, 183, 186);
            btnRegisterPet.Cursor = Cursors.Hand;
            btnRegisterPet.Dock = DockStyle.Right;
            btnRegisterPet.FlatStyle = FlatStyle.Flat;
            btnRegisterPet.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterPet.ForeColor = Color.FromArgb(65, 64, 80);
            btnRegisterPet.Location = new Point(860, 0);
            btnRegisterPet.Margin = new Padding(0);
            btnRegisterPet.Name = "btnRegisterPet";
            btnRegisterPet.Size = new Size(165, 40);
            btnRegisterPet.TabIndex = 1;
            btnRegisterPet.Text = "Register Pet";
            btnRegisterPet.UseVisualStyleBackColor = false;
            // 
            // btnAddNewBooking
            // 
            btnAddNewBooking.BackColor = Color.FromArgb(225, 183, 186);
            btnAddNewBooking.Cursor = Cursors.Hand;
            btnAddNewBooking.Dock = DockStyle.Right;
            btnAddNewBooking.FlatStyle = FlatStyle.Flat;
            btnAddNewBooking.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewBooking.ForeColor = Color.FromArgb(65, 64, 80);
            btnAddNewBooking.Location = new Point(1025, 0);
            btnAddNewBooking.Margin = new Padding(0);
            btnAddNewBooking.Name = "btnAddNewBooking";
            btnAddNewBooking.Size = new Size(165, 40);
            btnAddNewBooking.TabIndex = 0;
            btnAddNewBooking.Text = "Add New Booking";
            btnAddNewBooking.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.AutoSize = true;
            pnlContent.BackColor = Color.FromArgb(246, 244, 246);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(175, 40);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1015, 621);
            pnlContent.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(65, 64, 80);
            pnlMenu.Controls.Add(btnLogOut);
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Controls.Add(pnlAdminButton);
            pnlMenu.Controls.Add(btnServices);
            pnlMenu.Controls.Add(btnPets);
            pnlMenu.Controls.Add(btnCustomers);
            pnlMenu.Controls.Add(btnBookings);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMenu.Location = new Point(0, 40);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(175, 621);
            pnlMenu.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.FromArgb(225, 183, 186);
            btnLogOut.Image = Properties.Resources.log_out;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 551);
            btnLogOut.Margin = new Padding(0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(6, 0, 0, 0);
            btnLogOut.Size = new Size(175, 35);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = " Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(225, 183, 186);
            btnExit.Image = Properties.Resources.door_open;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 586);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 0, 0);
            btnExit.Size = new Size(175, 35);
            btnExit.TabIndex = 6;
            btnExit.Text = " Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlAdminButton
            // 
            pnlAdminButton.Controls.Add(btnReportCustomerBookings);
            pnlAdminButton.Controls.Add(btnReportDailyBookings);
            pnlAdminButton.Controls.Add(btnAdmin);
            pnlAdminButton.Dock = DockStyle.Top;
            pnlAdminButton.Location = new Point(0, 210);
            pnlAdminButton.Name = "pnlAdminButton";
            pnlAdminButton.Size = new Size(175, 135);
            pnlAdminButton.TabIndex = 8;
            // 
            // btnReportCustomerBookings
            // 
            btnReportCustomerBookings.BackColor = Color.FromArgb(45, 44, 56);
            btnReportCustomerBookings.Cursor = Cursors.Hand;
            btnReportCustomerBookings.Dock = DockStyle.Top;
            btnReportCustomerBookings.FlatAppearance.BorderSize = 0;
            btnReportCustomerBookings.FlatStyle = FlatStyle.Flat;
            btnReportCustomerBookings.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportCustomerBookings.ForeColor = Color.FromArgb(225, 183, 186);
            btnReportCustomerBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportCustomerBookings.Location = new Point(0, 85);
            btnReportCustomerBookings.Margin = new Padding(0);
            btnReportCustomerBookings.Name = "btnReportCustomerBookings";
            btnReportCustomerBookings.Padding = new Padding(25, 0, 0, 0);
            btnReportCustomerBookings.Size = new Size(175, 50);
            btnReportCustomerBookings.TabIndex = 8;
            btnReportCustomerBookings.Text = "Report Customer Bookings";
            btnReportCustomerBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnReportCustomerBookings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportCustomerBookings.UseVisualStyleBackColor = false;
            btnReportCustomerBookings.Visible = false;
            // 
            // btnReportDailyBookings
            // 
            btnReportDailyBookings.BackColor = Color.FromArgb(45, 44, 56);
            btnReportDailyBookings.Cursor = Cursors.Hand;
            btnReportDailyBookings.Dock = DockStyle.Top;
            btnReportDailyBookings.FlatAppearance.BorderSize = 0;
            btnReportDailyBookings.FlatStyle = FlatStyle.Flat;
            btnReportDailyBookings.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportDailyBookings.ForeColor = Color.FromArgb(225, 183, 186);
            btnReportDailyBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportDailyBookings.Location = new Point(0, 35);
            btnReportDailyBookings.Margin = new Padding(0);
            btnReportDailyBookings.Name = "btnReportDailyBookings";
            btnReportDailyBookings.Padding = new Padding(25, 0, 0, 0);
            btnReportDailyBookings.Size = new Size(175, 50);
            btnReportDailyBookings.TabIndex = 7;
            btnReportDailyBookings.Text = "Report Daily Bookings";
            btnReportDailyBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnReportDailyBookings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportDailyBookings.UseVisualStyleBackColor = false;
            btnReportDailyBookings.Visible = false;
            // 
            // btnAdmin
            // 
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(225, 183, 186);
            btnAdmin.Image = Properties.Resources.clipboard_list;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(6, 0, 0, 0);
            btnAdmin.Size = new Size(175, 35);
            btnAdmin.TabIndex = 6;
            btnAdmin.Text = " Admin";
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnServices
            // 
            btnServices.Cursor = Cursors.Hand;
            btnServices.Dock = DockStyle.Top;
            btnServices.FlatAppearance.BorderSize = 0;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServices.ForeColor = Color.FromArgb(225, 183, 186);
            btnServices.Image = Properties.Resources.bone;
            btnServices.ImageAlign = ContentAlignment.MiddleLeft;
            btnServices.Location = new Point(0, 175);
            btnServices.Margin = new Padding(0);
            btnServices.Name = "btnServices";
            btnServices.Padding = new Padding(6, 0, 0, 0);
            btnServices.Size = new Size(175, 35);
            btnServices.TabIndex = 5;
            btnServices.Text = " Services";
            btnServices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServices.UseVisualStyleBackColor = true;
            // 
            // btnPets
            // 
            btnPets.Cursor = Cursors.Hand;
            btnPets.Dock = DockStyle.Top;
            btnPets.FlatAppearance.BorderSize = 0;
            btnPets.FlatStyle = FlatStyle.Flat;
            btnPets.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPets.ForeColor = Color.FromArgb(225, 183, 186);
            btnPets.Image = Properties.Resources.paw_print;
            btnPets.ImageAlign = ContentAlignment.MiddleLeft;
            btnPets.Location = new Point(0, 140);
            btnPets.Margin = new Padding(0);
            btnPets.Name = "btnPets";
            btnPets.Padding = new Padding(6, 0, 0, 0);
            btnPets.Size = new Size(175, 35);
            btnPets.TabIndex = 3;
            btnPets.Text = " Pets";
            btnPets.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPets.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.FromArgb(225, 183, 186);
            btnCustomers.Image = Properties.Resources.user_search;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 105);
            btnCustomers.Margin = new Padding(0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(6, 0, 0, 0);
            btnCustomers.Size = new Size(175, 35);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = " Customers";
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            btnBookings.Cursor = Cursors.Hand;
            btnBookings.Dock = DockStyle.Top;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookings.ForeColor = Color.FromArgb(225, 183, 186);
            btnBookings.Image = Properties.Resources.calendar_search;
            btnBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookings.Location = new Point(0, 70);
            btnBookings.Margin = new Padding(0);
            btnBookings.Name = "btnBookings";
            btnBookings.Padding = new Padding(6, 0, 0, 0);
            btnBookings.Size = new Size(175, 35);
            btnBookings.TabIndex = 4;
            btnBookings.Text = " Bookings";
            btnBookings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(225, 183, 186);
            btnDashboard.Image = Properties.Resources.layout_dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 35);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(6, 0, 0, 0);
            btnDashboard.Size = new Size(175, 35);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = " Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.FromArgb(225, 183, 186);
            btnMenu.Image = Properties.Resources.burger_menu;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(6, 0, 0, 0);
            btnMenu.Size = new Size(175, 35);
            btnMenu.TabIndex = 0;
            btnMenu.Text = " Menu";
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1190, 661);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlQuickAccess);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doggy Daycare";
            Load += frmMain_Load;
            pnlQuickAccess.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlAdminButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlQuickAccess;
        private Panel pnlContent;
        private Button btnAddNewBooking;
        private Button btnRegisterPet;
        private Button btnRegisterCustomer;
        private Button btnTabLabel;
        private Panel pnlMenu;
        private Button btnMenu;
        private Button btnPets;
        private Button btnCustomers;
        private Button btnDashboard;
        private Button btnServices;
        private Button btnBookings;
        private Button btnExit;
        private Button btnLogOut;
        private Panel pnlAdminButton;
        private Button btnAdmin;
        private Button btnReportCustomerBookings;
        private Button btnReportDailyBookings;
    }
}