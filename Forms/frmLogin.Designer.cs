namespace DoggyDaycare.Forms
{
    partial class frmLogin
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
            btnLogin = new Button();
            picSeparator2 = new PictureBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            picSeparator1 = new PictureBox();
            lblUsername = new Label();
            lblWelcomeMsg2 = new Label();
            lblWelcomeMsg1 = new Label();
            picLoginDog = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSeparator2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoginDog).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(520, 357);
            btnLogin.Margin = new Padding(3, 10, 3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 30);
            btnLogin.TabIndex = 30;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // picSeparator2
            // 
            picSeparator2.Image = Properties.Resources.Separator;
            picSeparator2.Location = new Point(437, 344);
            picSeparator2.Margin = new Padding(0);
            picSeparator2.Name = "picSeparator2";
            picSeparator2.Size = new Size(374, 3);
            picSeparator2.SizeMode = PictureBoxSizeMode.AutoSize;
            picSeparator2.TabIndex = 29;
            picSeparator2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(437, 297);
            txtPassword.Margin = new Padding(3, 3, 3, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(374, 27);
            txtPassword.TabIndex = 28;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(34, 24, 28);
            lblPassword.Location = new Point(437, 277);
            lblPassword.Margin = new Padding(0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 17);
            lblPassword.TabIndex = 27;
            lblPassword.Text = "Password: ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(437, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(374, 27);
            txtUsername.TabIndex = 26;
            // 
            // picSeparator1
            // 
            picSeparator1.Image = Properties.Resources.Separator;
            picSeparator1.Location = new Point(437, 188);
            picSeparator1.Margin = new Padding(0);
            picSeparator1.Name = "picSeparator1";
            picSeparator1.Size = new Size(374, 3);
            picSeparator1.SizeMode = PictureBoxSizeMode.AutoSize;
            picSeparator1.TabIndex = 25;
            picSeparator1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(34, 24, 28);
            lblUsername.Location = new Point(437, 201);
            lblUsername.Margin = new Padding(0, 10, 0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(85, 17);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "User Name: ";
            // 
            // lblWelcomeMsg2
            // 
            lblWelcomeMsg2.AutoSize = true;
            lblWelcomeMsg2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeMsg2.ForeColor = Color.FromArgb(34, 24, 28);
            lblWelcomeMsg2.Location = new Point(452, 132);
            lblWelcomeMsg2.Margin = new Padding(3, 10, 3, 0);
            lblWelcomeMsg2.Name = "lblWelcomeMsg2";
            lblWelcomeMsg2.Size = new Size(339, 42);
            lblWelcomeMsg2.TabIndex = 23;
            lblWelcomeMsg2.Text = "Let’s make tails wag and keep everything \r\nrunning smoothly!\r\n";
            lblWelcomeMsg2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeMsg1
            // 
            lblWelcomeMsg1.AutoSize = true;
            lblWelcomeMsg1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeMsg1.ForeColor = Color.FromArgb(34, 24, 28);
            lblWelcomeMsg1.Location = new Point(437, 92);
            lblWelcomeMsg1.Margin = new Padding(20, 0, 0, 0);
            lblWelcomeMsg1.Name = "lblWelcomeMsg1";
            lblWelcomeMsg1.Size = new Size(374, 30);
            lblWelcomeMsg1.TabIndex = 22;
            lblWelcomeMsg1.Text = "Welcome Back to the Pack 🐾\r\n";
            // 
            // picLoginDog
            // 
            picLoginDog.Image = Properties.Resources.LoginDog;
            picLoginDog.Location = new Point(23, 23);
            picLoginDog.Margin = new Padding(20, 3, 0, 3);
            picLoginDog.Name = "picLoginDog";
            picLoginDog.Size = new Size(394, 465);
            picLoginDog.SizeMode = PictureBoxSizeMode.Zoom;
            picLoginDog.TabIndex = 21;
            picLoginDog.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(834, 511);
            Controls.Add(btnLogin);
            Controls.Add(picSeparator2);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(picSeparator1);
            Controls.Add(lblUsername);
            Controls.Add(lblWelcomeMsg2);
            Controls.Add(lblWelcomeMsg1);
            Controls.Add(picLoginDog);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(850, 550);
            MinimizeBox = false;
            MinimumSize = new Size(834, 511);
            Name = "frmLogin";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)picSeparator2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoginDog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private PictureBox picSeparator2;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private PictureBox picSeparator1;
        private Label lblUsername;
        private Label lblWelcomeMsg2;
        private Label lblWelcomeMsg1;
        private PictureBox picLoginDog;
    }
}