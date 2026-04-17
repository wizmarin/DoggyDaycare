namespace DoggyDaycare.Forms
{
    partial class frmRegisterCustomer
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
            btnRegisterCustomer = new Button();
            tlpFormContent = new TableLayoutPanel();
            lblFullName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblEmergencyContact = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtEmergencyContact = new TextBox();
            txtEmergencyContactPhone = new TextBox();
            lblEmergencyContactPhone = new Label();
            btnRegisterCustomerLabel = new Button();
            tlpFormContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterCustomer.ForeColor = Color.FromArgb(34, 24, 28);
            btnRegisterCustomer.Location = new Point(30, 329);
            btnRegisterCustomer.Margin = new Padding(50, 5, 50, 5);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(300, 30);
            btnRegisterCustomer.TabIndex = 12;
            btnRegisterCustomer.Text = "Register Customer";
            btnRegisterCustomer.UseVisualStyleBackColor = true;
            // 
            // tlpFormContent
            // 
            tlpFormContent.ColumnCount = 2;
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormContent.Controls.Add(lblFullName, 0, 0);
            tlpFormContent.Controls.Add(lblPhone, 0, 2);
            tlpFormContent.Controls.Add(lblEmail, 0, 4);
            tlpFormContent.Controls.Add(lblEmergencyContact, 0, 6);
            tlpFormContent.Controls.Add(txtFullName, 0, 1);
            tlpFormContent.Controls.Add(txtPhone, 0, 3);
            tlpFormContent.Controls.Add(txtEmail, 0, 5);
            tlpFormContent.Controls.Add(txtEmergencyContact, 0, 7);
            tlpFormContent.Controls.Add(txtEmergencyContactPhone, 0, 9);
            tlpFormContent.Controls.Add(lblEmergencyContactPhone, 0, 8);
            tlpFormContent.Dock = DockStyle.Top;
            tlpFormContent.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormContent.Size = new Size(1028, 281);
            tlpFormContent.TabIndex = 11;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Font = new Font("Gadugi", 9.75F);
            lblFullName.Location = new Point(8, 5);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(344, 16);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Gadugi", 9.75F);
            lblPhone.Location = new Point(8, 61);
            lblPhone.Margin = new Padding(3, 5, 3, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(344, 16);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Gadugi", 9.75F);
            lblEmail.Location = new Point(8, 117);
            lblEmail.Margin = new Padding(3, 5, 3, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(344, 16);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.AutoSize = true;
            lblEmergencyContact.Dock = DockStyle.Fill;
            lblEmergencyContact.Font = new Font("Gadugi", 9.75F);
            lblEmergencyContact.Location = new Point(8, 173);
            lblEmergencyContact.Margin = new Padding(3, 5, 3, 0);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(344, 16);
            lblEmergencyContact.TabIndex = 3;
            lblEmergencyContact.Text = "Emergency Contact:";
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Location = new Point(8, 24);
            txtFullName.MaxLength = 30;
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(344, 29);
            txtFullName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(8, 80);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(344, 29);
            txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(8, 136);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 29);
            txtEmail.TabIndex = 8;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Dock = DockStyle.Fill;
            txtEmergencyContact.Location = new Point(8, 192);
            txtEmergencyContact.MaxLength = 30;
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(344, 29);
            txtEmergencyContact.TabIndex = 10;
            // 
            // txtEmergencyContactPhone
            // 
            txtEmergencyContactPhone.Dock = DockStyle.Fill;
            txtEmergencyContactPhone.Location = new Point(8, 247);
            txtEmergencyContactPhone.MaxLength = 10;
            txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
            txtEmergencyContactPhone.Size = new Size(344, 29);
            txtEmergencyContactPhone.TabIndex = 11;
            // 
            // lblEmergencyContactPhone
            // 
            lblEmergencyContactPhone.AutoSize = true;
            lblEmergencyContactPhone.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmergencyContactPhone.Location = new Point(8, 229);
            lblEmergencyContactPhone.Margin = new Padding(3, 5, 3, 0);
            lblEmergencyContactPhone.Name = "lblEmergencyContactPhone";
            lblEmergencyContactPhone.Size = new Size(214, 15);
            lblEmergencyContactPhone.TabIndex = 12;
            lblEmergencyContactPhone.Text = "Emergency Contact Phone Number:";
            // 
            // btnRegisterCustomerLabel
            // 
            btnRegisterCustomerLabel.Dock = DockStyle.Top;
            btnRegisterCustomerLabel.Enabled = false;
            btnRegisterCustomerLabel.FlatAppearance.BorderSize = 0;
            btnRegisterCustomerLabel.FlatStyle = FlatStyle.Flat;
            btnRegisterCustomerLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterCustomerLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnRegisterCustomerLabel.Location = new Point(0, 0);
            btnRegisterCustomerLabel.Name = "btnRegisterCustomerLabel";
            btnRegisterCustomerLabel.Size = new Size(1028, 40);
            btnRegisterCustomerLabel.TabIndex = 10;
            btnRegisterCustomerLabel.Text = "Customer Registration Form";
            btnRegisterCustomerLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterCustomerLabel.UseVisualStyleBackColor = true;
            // 
            // frmRegisterCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(btnRegisterCustomer);
            Controls.Add(tlpFormContent);
            Controls.Add(btnRegisterCustomerLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegisterCustomer";
            Text = "frmRegisterCustomer";
            tlpFormContent.ResumeLayout(false);
            tlpFormContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterCustomer;
        private TableLayoutPanel tlpFormContent;
        private Label lblFullName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblEmergencyContact;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtEmergencyContact;
        private TextBox txtEmergencyContactPhone;
        private Label lblEmergencyContactPhone;
        private Button btnRegisterCustomerLabel;
    }
}