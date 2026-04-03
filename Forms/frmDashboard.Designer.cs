namespace DoggyDaycare.Forms
{
    partial class frmDashboard
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
            pnlLabels = new Panel();
            btnTodayLabel = new Button();
            btnServicesLabel = new Button();
            pnlServices = new Panel();
            tabServices = new TabControl();
            tabSmall = new TabPage();
            dgvSmallServices = new DataGridView();
            tabMedium = new TabPage();
            dgvMediumServices = new DataGridView();
            tabBig = new TabPage();
            dgvBigServices = new DataGridView();
            pnlBookings = new Panel();
            tabBookings = new TabControl();
            tabUpcoming = new TabPage();
            dgvUpcomingBookings = new DataGridView();
            tabCheckedIn = new TabPage();
            dgvCheckedInBookings = new DataGridView();
            tabCheckedOut = new TabPage();
            dgvCheckedOutBookings = new DataGridView();
            pnlLabels.SuspendLayout();
            pnlServices.SuspendLayout();
            tabServices.SuspendLayout();
            tabSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSmallServices).BeginInit();
            tabMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMediumServices).BeginInit();
            tabBig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBigServices).BeginInit();
            pnlBookings.SuspendLayout();
            tabBookings.SuspendLayout();
            tabUpcoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingBookings).BeginInit();
            tabCheckedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedInBookings).BeginInit();
            tabCheckedOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedOutBookings).BeginInit();
            SuspendLayout();
            // 
            // pnlLabels
            // 
            pnlLabels.Controls.Add(btnTodayLabel);
            pnlLabels.Controls.Add(btnServicesLabel);
            pnlLabels.Dock = DockStyle.Top;
            pnlLabels.Location = new Point(0, 0);
            pnlLabels.Name = "pnlLabels";
            pnlLabels.Size = new Size(1028, 40);
            pnlLabels.TabIndex = 0;
            // 
            // btnTodayLabel
            // 
            btnTodayLabel.Dock = DockStyle.Fill;
            btnTodayLabel.Enabled = false;
            btnTodayLabel.FlatAppearance.BorderColor = Color.FromArgb(65, 64, 80);
            btnTodayLabel.FlatAppearance.BorderSize = 0;
            btnTodayLabel.FlatStyle = FlatStyle.Flat;
            btnTodayLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTodayLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnTodayLabel.Location = new Point(0, 0);
            btnTodayLabel.Name = "btnTodayLabel";
            btnTodayLabel.Size = new Size(728, 40);
            btnTodayLabel.TabIndex = 1;
            btnTodayLabel.Text = "Today";
            btnTodayLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnTodayLabel.UseVisualStyleBackColor = true;
            // 
            // btnServicesLabel
            // 
            btnServicesLabel.Dock = DockStyle.Right;
            btnServicesLabel.Enabled = false;
            btnServicesLabel.FlatAppearance.BorderColor = Color.FromArgb(65, 64, 80);
            btnServicesLabel.FlatAppearance.BorderSize = 0;
            btnServicesLabel.FlatStyle = FlatStyle.Flat;
            btnServicesLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServicesLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnServicesLabel.Location = new Point(728, 0);
            btnServicesLabel.Name = "btnServicesLabel";
            btnServicesLabel.Size = new Size(300, 40);
            btnServicesLabel.TabIndex = 0;
            btnServicesLabel.Text = "Services";
            btnServicesLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnServicesLabel.UseVisualStyleBackColor = true;
            // 
            // pnlServices
            // 
            pnlServices.Controls.Add(tabServices);
            pnlServices.Dock = DockStyle.Right;
            pnlServices.Location = new Point(728, 40);
            pnlServices.Name = "pnlServices";
            pnlServices.Size = new Size(300, 560);
            pnlServices.TabIndex = 1;
            // 
            // tabServices
            // 
            tabServices.Controls.Add(tabSmall);
            tabServices.Controls.Add(tabMedium);
            tabServices.Controls.Add(tabBig);
            tabServices.Dock = DockStyle.Fill;
            tabServices.Location = new Point(0, 0);
            tabServices.Name = "tabServices";
            tabServices.SelectedIndex = 0;
            tabServices.Size = new Size(300, 560);
            tabServices.SizeMode = TabSizeMode.Fixed;
            tabServices.TabIndex = 0;
            // 
            // tabSmall
            // 
            tabSmall.Controls.Add(dgvSmallServices);
            tabSmall.ForeColor = Color.FromArgb(34, 24, 28);
            tabSmall.Location = new Point(4, 29);
            tabSmall.Name = "tabSmall";
            tabSmall.Padding = new Padding(3);
            tabSmall.Size = new Size(292, 527);
            tabSmall.TabIndex = 0;
            tabSmall.Text = "Small";
            tabSmall.UseVisualStyleBackColor = true;
            // 
            // dgvSmallServices
            // 
            dgvSmallServices.AllowUserToAddRows = false;
            dgvSmallServices.AllowUserToDeleteRows = false;
            dgvSmallServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSmallServices.Dock = DockStyle.Fill;
            dgvSmallServices.Location = new Point(3, 3);
            dgvSmallServices.Name = "dgvSmallServices";
            dgvSmallServices.ReadOnly = true;
            dgvSmallServices.Size = new Size(286, 521);
            dgvSmallServices.TabIndex = 0;
            // 
            // tabMedium
            // 
            tabMedium.Controls.Add(dgvMediumServices);
            tabMedium.ForeColor = Color.FromArgb(34, 24, 28);
            tabMedium.Location = new Point(4, 29);
            tabMedium.Name = "tabMedium";
            tabMedium.Padding = new Padding(3);
            tabMedium.Size = new Size(292, 527);
            tabMedium.TabIndex = 1;
            tabMedium.Text = "Medium";
            tabMedium.UseVisualStyleBackColor = true;
            // 
            // dgvMediumServices
            // 
            dgvMediumServices.AllowUserToAddRows = false;
            dgvMediumServices.AllowUserToDeleteRows = false;
            dgvMediumServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMediumServices.Dock = DockStyle.Fill;
            dgvMediumServices.Location = new Point(3, 3);
            dgvMediumServices.Name = "dgvMediumServices";
            dgvMediumServices.ReadOnly = true;
            dgvMediumServices.Size = new Size(286, 521);
            dgvMediumServices.TabIndex = 0;
            // 
            // tabBig
            // 
            tabBig.Controls.Add(dgvBigServices);
            tabBig.ForeColor = Color.FromArgb(34, 24, 28);
            tabBig.Location = new Point(4, 29);
            tabBig.Name = "tabBig";
            tabBig.Padding = new Padding(3);
            tabBig.Size = new Size(292, 527);
            tabBig.TabIndex = 2;
            tabBig.Text = "Big";
            tabBig.UseVisualStyleBackColor = true;
            // 
            // dgvBigServices
            // 
            dgvBigServices.AllowUserToAddRows = false;
            dgvBigServices.AllowUserToDeleteRows = false;
            dgvBigServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBigServices.Dock = DockStyle.Fill;
            dgvBigServices.Location = new Point(3, 3);
            dgvBigServices.Name = "dgvBigServices";
            dgvBigServices.ReadOnly = true;
            dgvBigServices.Size = new Size(286, 521);
            dgvBigServices.TabIndex = 0;
            // 
            // pnlBookings
            // 
            pnlBookings.Controls.Add(tabBookings);
            pnlBookings.Dock = DockStyle.Fill;
            pnlBookings.Location = new Point(0, 40);
            pnlBookings.Name = "pnlBookings";
            pnlBookings.Size = new Size(728, 560);
            pnlBookings.TabIndex = 2;
            // 
            // tabBookings
            // 
            tabBookings.Controls.Add(tabUpcoming);
            tabBookings.Controls.Add(tabCheckedIn);
            tabBookings.Controls.Add(tabCheckedOut);
            tabBookings.Dock = DockStyle.Fill;
            tabBookings.ItemSize = new Size(88, 25);
            tabBookings.Location = new Point(0, 0);
            tabBookings.Name = "tabBookings";
            tabBookings.SelectedIndex = 0;
            tabBookings.Size = new Size(728, 560);
            tabBookings.SizeMode = TabSizeMode.FillToRight;
            tabBookings.TabIndex = 0;
            // 
            // tabUpcoming
            // 
            tabUpcoming.Controls.Add(dgvUpcomingBookings);
            tabUpcoming.ForeColor = Color.FromArgb(34, 24, 28);
            tabUpcoming.Location = new Point(4, 29);
            tabUpcoming.Name = "tabUpcoming";
            tabUpcoming.Padding = new Padding(3);
            tabUpcoming.Size = new Size(720, 527);
            tabUpcoming.TabIndex = 0;
            tabUpcoming.Text = "Upcoming";
            tabUpcoming.UseVisualStyleBackColor = true;
            // 
            // dgvUpcomingBookings
            // 
            dgvUpcomingBookings.AllowUserToAddRows = false;
            dgvUpcomingBookings.AllowUserToDeleteRows = false;
            dgvUpcomingBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcomingBookings.Dock = DockStyle.Fill;
            dgvUpcomingBookings.Location = new Point(3, 3);
            dgvUpcomingBookings.Name = "dgvUpcomingBookings";
            dgvUpcomingBookings.ReadOnly = true;
            dgvUpcomingBookings.Size = new Size(714, 521);
            dgvUpcomingBookings.TabIndex = 0;
            // 
            // tabCheckedIn
            // 
            tabCheckedIn.Controls.Add(dgvCheckedInBookings);
            tabCheckedIn.ForeColor = Color.FromArgb(34, 24, 28);
            tabCheckedIn.Location = new Point(4, 29);
            tabCheckedIn.Name = "tabCheckedIn";
            tabCheckedIn.Padding = new Padding(3);
            tabCheckedIn.Size = new Size(720, 527);
            tabCheckedIn.TabIndex = 1;
            tabCheckedIn.Text = "Checked-In";
            tabCheckedIn.UseVisualStyleBackColor = true;
            // 
            // dgvCheckedInBookings
            // 
            dgvCheckedInBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckedInBookings.Dock = DockStyle.Fill;
            dgvCheckedInBookings.Location = new Point(3, 3);
            dgvCheckedInBookings.Name = "dgvCheckedInBookings";
            dgvCheckedInBookings.Size = new Size(714, 521);
            dgvCheckedInBookings.TabIndex = 0;
            // 
            // tabCheckedOut
            // 
            tabCheckedOut.Controls.Add(dgvCheckedOutBookings);
            tabCheckedOut.ForeColor = Color.FromArgb(34, 24, 28);
            tabCheckedOut.Location = new Point(4, 29);
            tabCheckedOut.Name = "tabCheckedOut";
            tabCheckedOut.Padding = new Padding(3);
            tabCheckedOut.Size = new Size(720, 527);
            tabCheckedOut.TabIndex = 2;
            tabCheckedOut.Text = "Checked-Out";
            tabCheckedOut.UseVisualStyleBackColor = true;
            // 
            // dgvCheckedOutBookings
            // 
            dgvCheckedOutBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckedOutBookings.Dock = DockStyle.Fill;
            dgvCheckedOutBookings.Location = new Point(3, 3);
            dgvCheckedOutBookings.Name = "dgvCheckedOutBookings";
            dgvCheckedOutBookings.Size = new Size(714, 521);
            dgvCheckedOutBookings.TabIndex = 0;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlBookings);
            Controls.Add(pnlServices);
            Controls.Add(pnlLabels);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDashboard";
            pnlLabels.ResumeLayout(false);
            pnlServices.ResumeLayout(false);
            tabServices.ResumeLayout(false);
            tabSmall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSmallServices).EndInit();
            tabMedium.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMediumServices).EndInit();
            tabBig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBigServices).EndInit();
            pnlBookings.ResumeLayout(false);
            tabBookings.ResumeLayout(false);
            tabUpcoming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingBookings).EndInit();
            tabCheckedIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCheckedInBookings).EndInit();
            tabCheckedOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCheckedOutBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLabels;
        private Button btnServicesLabel;
        private Button btnTodayLabel;
        private Panel pnlServices;
        private Panel pnlBookings;
        private TabControl tabServices;
        private TabPage tabSmall;
        private TabPage tabMedium;
        private TabControl tabBookings;
        private TabPage tabUpcoming;
        private TabPage tabCheckedIn;
        private TabPage tabCheckedOut;
        private TabPage tabBig;
        private DataGridView dgvUpcomingBookings;
        private DataGridView dgvCheckedInBookings;
        private DataGridView dgvCheckedOutBookings;
        private DataGridView dgvSmallServices;
        private DataGridView dgvMediumServices;
        private DataGridView dgvBigServices;
    }
}