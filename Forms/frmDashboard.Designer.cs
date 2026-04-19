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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlServices = new Panel();
            tabServices = new TabControl();
            tabSmall = new TabPage();
            dgvSmallServices = new DataGridView();
            tabMedium = new TabPage();
            dgvMediumServices = new DataGridView();
            tabBig = new TabPage();
            dgvBigServices = new DataGridView();
            btnServicesLabel = new Button();
            pnlBookings = new Panel();
            tabBookings = new TabControl();
            tabUpcoming = new TabPage();
            dgvUpcomingBookings = new DataGridView();
            tabCheckedIn = new TabPage();
            dgvCheckedInBookings = new DataGridView();
            tabCheckedOut = new TabPage();
            dgvCheckedOutBookings = new DataGridView();
            btnTodayLabel = new Button();
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
            // pnlServices
            // 
            pnlServices.BorderStyle = BorderStyle.FixedSingle;
            pnlServices.Controls.Add(tabServices);
            pnlServices.Controls.Add(btnServicesLabel);
            pnlServices.Dock = DockStyle.Right;
            pnlServices.Location = new Point(728, 0);
            pnlServices.Name = "pnlServices";
            pnlServices.Size = new Size(300, 600);
            pnlServices.TabIndex = 1;
            // 
            // tabServices
            // 
            tabServices.Controls.Add(tabSmall);
            tabServices.Controls.Add(tabMedium);
            tabServices.Controls.Add(tabBig);
            tabServices.Dock = DockStyle.Fill;
            tabServices.Location = new Point(0, 40);
            tabServices.Name = "tabServices";
            tabServices.SelectedIndex = 0;
            tabServices.Size = new Size(298, 558);
            tabServices.SizeMode = TabSizeMode.Fixed;
            tabServices.TabIndex = 0;
            // 
            // tabSmall
            // 
            tabSmall.AutoScroll = true;
            tabSmall.Controls.Add(dgvSmallServices);
            tabSmall.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabSmall.ForeColor = Color.FromArgb(34, 24, 28);
            tabSmall.Location = new Point(4, 29);
            tabSmall.Name = "tabSmall";
            tabSmall.Padding = new Padding(3);
            tabSmall.Size = new Size(290, 525);
            tabSmall.TabIndex = 0;
            tabSmall.Text = "Small";
            tabSmall.UseVisualStyleBackColor = true;
            // 
            // dgvSmallServices
            // 
            dgvSmallServices.AllowUserToAddRows = false;
            dgvSmallServices.AllowUserToDeleteRows = false;
            dgvSmallServices.AllowUserToResizeColumns = false;
            dgvSmallServices.AllowUserToResizeRows = false;
            dgvSmallServices.BackgroundColor = Color.FromArgb(246, 244, 246);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSmallServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSmallServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 24, 28);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSmallServices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSmallServices.Dock = DockStyle.Fill;
            dgvSmallServices.Location = new Point(3, 3);
            dgvSmallServices.MultiSelect = false;
            dgvSmallServices.Name = "dgvSmallServices";
            dgvSmallServices.ReadOnly = true;
            dgvSmallServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmallServices.Size = new Size(284, 519);
            dgvSmallServices.TabIndex = 0;
            // 
            // tabMedium
            // 
            tabMedium.Controls.Add(dgvMediumServices);
            tabMedium.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabMedium.ForeColor = Color.FromArgb(34, 24, 28);
            tabMedium.Location = new Point(4, 29);
            tabMedium.Name = "tabMedium";
            tabMedium.Padding = new Padding(3);
            tabMedium.Size = new Size(290, 525);
            tabMedium.TabIndex = 1;
            tabMedium.Text = "Medium";
            tabMedium.UseVisualStyleBackColor = true;
            // 
            // dgvMediumServices
            // 
            dgvMediumServices.AllowUserToAddRows = false;
            dgvMediumServices.AllowUserToDeleteRows = false;
            dgvMediumServices.AllowUserToResizeColumns = false;
            dgvMediumServices.AllowUserToResizeRows = false;
            dgvMediumServices.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvMediumServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMediumServices.Dock = DockStyle.Fill;
            dgvMediumServices.Location = new Point(3, 3);
            dgvMediumServices.MultiSelect = false;
            dgvMediumServices.Name = "dgvMediumServices";
            dgvMediumServices.ReadOnly = true;
            dgvMediumServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMediumServices.Size = new Size(284, 519);
            dgvMediumServices.TabIndex = 0;
            // 
            // tabBig
            // 
            tabBig.Controls.Add(dgvBigServices);
            tabBig.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabBig.ForeColor = Color.FromArgb(34, 24, 28);
            tabBig.Location = new Point(4, 29);
            tabBig.Name = "tabBig";
            tabBig.Padding = new Padding(3);
            tabBig.Size = new Size(290, 525);
            tabBig.TabIndex = 2;
            tabBig.Text = "Big";
            tabBig.UseVisualStyleBackColor = true;
            // 
            // dgvBigServices
            // 
            dgvBigServices.AllowUserToAddRows = false;
            dgvBigServices.AllowUserToDeleteRows = false;
            dgvBigServices.AllowUserToResizeColumns = false;
            dgvBigServices.AllowUserToResizeRows = false;
            dgvBigServices.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvBigServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBigServices.Dock = DockStyle.Fill;
            dgvBigServices.Location = new Point(3, 3);
            dgvBigServices.MultiSelect = false;
            dgvBigServices.Name = "dgvBigServices";
            dgvBigServices.ReadOnly = true;
            dgvBigServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBigServices.Size = new Size(284, 519);
            dgvBigServices.TabIndex = 0;
            // 
            // btnServicesLabel
            // 
            btnServicesLabel.Dock = DockStyle.Top;
            btnServicesLabel.Enabled = false;
            btnServicesLabel.FlatAppearance.BorderColor = Color.FromArgb(65, 64, 80);
            btnServicesLabel.FlatAppearance.BorderSize = 0;
            btnServicesLabel.FlatStyle = FlatStyle.Flat;
            btnServicesLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServicesLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnServicesLabel.Location = new Point(0, 0);
            btnServicesLabel.Name = "btnServicesLabel";
            btnServicesLabel.Size = new Size(298, 40);
            btnServicesLabel.TabIndex = 1;
            btnServicesLabel.Text = "Services";
            btnServicesLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnServicesLabel.UseVisualStyleBackColor = true;
            // 
            // pnlBookings
            // 
            pnlBookings.BorderStyle = BorderStyle.FixedSingle;
            pnlBookings.Controls.Add(tabBookings);
            pnlBookings.Controls.Add(btnTodayLabel);
            pnlBookings.Dock = DockStyle.Fill;
            pnlBookings.Location = new Point(0, 0);
            pnlBookings.Name = "pnlBookings";
            pnlBookings.Size = new Size(728, 600);
            pnlBookings.TabIndex = 2;
            // 
            // tabBookings
            // 
            tabBookings.Controls.Add(tabUpcoming);
            tabBookings.Controls.Add(tabCheckedIn);
            tabBookings.Controls.Add(tabCheckedOut);
            tabBookings.Dock = DockStyle.Fill;
            tabBookings.ItemSize = new Size(88, 25);
            tabBookings.Location = new Point(0, 40);
            tabBookings.Name = "tabBookings";
            tabBookings.SelectedIndex = 0;
            tabBookings.Size = new Size(726, 558);
            tabBookings.SizeMode = TabSizeMode.FillToRight;
            tabBookings.TabIndex = 0;
            // 
            // tabUpcoming
            // 
            tabUpcoming.Controls.Add(dgvUpcomingBookings);
            tabUpcoming.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabUpcoming.ForeColor = Color.FromArgb(34, 24, 28);
            tabUpcoming.Location = new Point(4, 29);
            tabUpcoming.Name = "tabUpcoming";
            tabUpcoming.Padding = new Padding(3);
            tabUpcoming.Size = new Size(718, 525);
            tabUpcoming.TabIndex = 0;
            tabUpcoming.Text = "Upcoming";
            tabUpcoming.UseVisualStyleBackColor = true;
            // 
            // dgvUpcomingBookings
            // 
            dgvUpcomingBookings.AllowUserToAddRows = false;
            dgvUpcomingBookings.AllowUserToDeleteRows = false;
            dgvUpcomingBookings.AllowUserToResizeColumns = false;
            dgvUpcomingBookings.AllowUserToResizeRows = false;
            dgvUpcomingBookings.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvUpcomingBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcomingBookings.Dock = DockStyle.Fill;
            dgvUpcomingBookings.Location = new Point(3, 3);
            dgvUpcomingBookings.MultiSelect = false;
            dgvUpcomingBookings.Name = "dgvUpcomingBookings";
            dgvUpcomingBookings.ReadOnly = true;
            dgvUpcomingBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpcomingBookings.Size = new Size(712, 519);
            dgvUpcomingBookings.TabIndex = 0;
            // 
            // tabCheckedIn
            // 
            tabCheckedIn.Controls.Add(dgvCheckedInBookings);
            tabCheckedIn.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabCheckedIn.ForeColor = Color.FromArgb(34, 24, 28);
            tabCheckedIn.Location = new Point(4, 29);
            tabCheckedIn.Name = "tabCheckedIn";
            tabCheckedIn.Padding = new Padding(3);
            tabCheckedIn.Size = new Size(718, 525);
            tabCheckedIn.TabIndex = 1;
            tabCheckedIn.Text = "Checked-In";
            tabCheckedIn.UseVisualStyleBackColor = true;
            // 
            // dgvCheckedInBookings
            // 
            dgvCheckedInBookings.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvCheckedInBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckedInBookings.Dock = DockStyle.Fill;
            dgvCheckedInBookings.Location = new Point(3, 3);
            dgvCheckedInBookings.MultiSelect = false;
            dgvCheckedInBookings.Name = "dgvCheckedInBookings";
            dgvCheckedInBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckedInBookings.Size = new Size(712, 519);
            dgvCheckedInBookings.TabIndex = 0;
            // 
            // tabCheckedOut
            // 
            tabCheckedOut.Controls.Add(dgvCheckedOutBookings);
            tabCheckedOut.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabCheckedOut.ForeColor = Color.FromArgb(34, 24, 28);
            tabCheckedOut.Location = new Point(4, 29);
            tabCheckedOut.Name = "tabCheckedOut";
            tabCheckedOut.Padding = new Padding(3);
            tabCheckedOut.Size = new Size(718, 525);
            tabCheckedOut.TabIndex = 2;
            tabCheckedOut.Text = "Checked-Out";
            tabCheckedOut.UseVisualStyleBackColor = true;
            // 
            // dgvCheckedOutBookings
            // 
            dgvCheckedOutBookings.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvCheckedOutBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckedOutBookings.Dock = DockStyle.Fill;
            dgvCheckedOutBookings.Location = new Point(3, 3);
            dgvCheckedOutBookings.MultiSelect = false;
            dgvCheckedOutBookings.Name = "dgvCheckedOutBookings";
            dgvCheckedOutBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckedOutBookings.Size = new Size(712, 519);
            dgvCheckedOutBookings.TabIndex = 0;
            // 
            // btnTodayLabel
            // 
            btnTodayLabel.Dock = DockStyle.Top;
            btnTodayLabel.Enabled = false;
            btnTodayLabel.FlatAppearance.BorderColor = Color.FromArgb(65, 64, 80);
            btnTodayLabel.FlatAppearance.BorderSize = 0;
            btnTodayLabel.FlatStyle = FlatStyle.Flat;
            btnTodayLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTodayLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnTodayLabel.Location = new Point(0, 0);
            btnTodayLabel.Name = "btnTodayLabel";
            btnTodayLabel.Size = new Size(726, 40);
            btnTodayLabel.TabIndex = 2;
            btnTodayLabel.Text = "Today";
            btnTodayLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnTodayLabel.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlBookings);
            Controls.Add(pnlServices);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDashboard";
            Load += frmDashboard_Load;
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
        private Button btnServicesLabel;
        private Button btnTodayLabel;
    }
}