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
            flpMenu = new FlowLayoutPanel();
            pnlQuickAccess = new Panel();
            btnTabLabel = new Button();
            btnRegisterCustomer = new Button();
            btnRegisterPet = new Button();
            btnAddNewBooking = new Button();
            pnlContent = new Panel();
            pnlQuickAccess.SuspendLayout();
            SuspendLayout();
            // 
            // flpMenu
            // 
            flpMenu.BackColor = Color.FromArgb(65, 64, 80);
            flpMenu.Dock = DockStyle.Left;
            flpMenu.Location = new Point(0, 0);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(200, 661);
            flpMenu.TabIndex = 0;
            // 
            // pnlQuickAccess
            // 
            pnlQuickAccess.BackColor = Color.FromArgb(246, 244, 246);
            pnlQuickAccess.Controls.Add(btnTabLabel);
            pnlQuickAccess.Controls.Add(btnRegisterCustomer);
            pnlQuickAccess.Controls.Add(btnRegisterPet);
            pnlQuickAccess.Controls.Add(btnAddNewBooking);
            pnlQuickAccess.Dock = DockStyle.Top;
            pnlQuickAccess.Location = new Point(200, 0);
            pnlQuickAccess.Name = "pnlQuickAccess";
            pnlQuickAccess.Size = new Size(990, 48);
            pnlQuickAccess.TabIndex = 1;
            // 
            // btnTabLabel
            // 
            btnTabLabel.BackColor = Color.FromArgb(225, 183, 186);
            btnTabLabel.Dock = DockStyle.Fill;
            btnTabLabel.Enabled = false;
            btnTabLabel.FlatStyle = FlatStyle.Flat;
            btnTabLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnTabLabel.Location = new Point(0, 0);
            btnTabLabel.Margin = new Padding(0);
            btnTabLabel.Name = "btnTabLabel";
            btnTabLabel.Size = new Size(495, 48);
            btnTabLabel.TabIndex = 3;
            btnTabLabel.Text = "Dashboard 🐾";
            btnTabLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnTabLabel.UseVisualStyleBackColor = false;
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.BackColor = Color.FromArgb(225, 183, 186);
            btnRegisterCustomer.Dock = DockStyle.Right;
            btnRegisterCustomer.FlatStyle = FlatStyle.Flat;
            btnRegisterCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterCustomer.ForeColor = Color.FromArgb(34, 24, 28);
            btnRegisterCustomer.Location = new Point(495, 0);
            btnRegisterCustomer.Margin = new Padding(0);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(165, 48);
            btnRegisterCustomer.TabIndex = 2;
            btnRegisterCustomer.Text = "Register Customer";
            btnRegisterCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRegisterPet
            // 
            btnRegisterPet.BackColor = Color.FromArgb(225, 183, 186);
            btnRegisterPet.Dock = DockStyle.Right;
            btnRegisterPet.FlatStyle = FlatStyle.Flat;
            btnRegisterPet.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterPet.ForeColor = Color.FromArgb(34, 24, 28);
            btnRegisterPet.Location = new Point(660, 0);
            btnRegisterPet.Margin = new Padding(0);
            btnRegisterPet.Name = "btnRegisterPet";
            btnRegisterPet.Size = new Size(165, 48);
            btnRegisterPet.TabIndex = 1;
            btnRegisterPet.Text = "Register Pet";
            btnRegisterPet.UseVisualStyleBackColor = false;
            // 
            // btnAddNewBooking
            // 
            btnAddNewBooking.BackColor = Color.FromArgb(225, 183, 186);
            btnAddNewBooking.Dock = DockStyle.Right;
            btnAddNewBooking.FlatStyle = FlatStyle.Flat;
            btnAddNewBooking.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewBooking.ForeColor = Color.FromArgb(34, 24, 28);
            btnAddNewBooking.Location = new Point(825, 0);
            btnAddNewBooking.Margin = new Padding(0);
            btnAddNewBooking.Name = "btnAddNewBooking";
            btnAddNewBooking.Size = new Size(165, 48);
            btnAddNewBooking.TabIndex = 0;
            btnAddNewBooking.Text = "Add New Booking";
            btnAddNewBooking.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(246, 244, 246);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 48);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(990, 613);
            pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1190, 661);
            Controls.Add(pnlContent);
            Controls.Add(pnlQuickAccess);
            Controls.Add(flpMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doggy Daycare";
            Load += frmMain_Load;
            pnlQuickAccess.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMenu;
        private Panel pnlQuickAccess;
        private Panel pnlContent;
        private Button btnAddNewBooking;
        private Button btnRegisterPet;
        private Button btnRegisterCustomer;
        private Button btnTabLabel;
    }
}