namespace DoggyDaycare.Forms
{
    partial class frmAddService
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
            btnAddServiceLabel = new Button();
            pnlMain = new Panel();
            btnAddService = new Button();
            tlpFormContent = new TableLayoutPanel();
            lblServiceName = new Label();
            lblBreedType = new Label();
            lblPrice = new Label();
            lblMaxCapacity = new Label();
            txtServiceName = new TextBox();
            cmbBreedType = new ComboBox();
            nudPrice = new NumericUpDown();
            nudMaxCapacity = new NumericUpDown();
            pnlMain.SuspendLayout();
            tlpFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxCapacity).BeginInit();
            SuspendLayout();
            // 
            // btnAddServiceLabel
            // 
            btnAddServiceLabel.Dock = DockStyle.Top;
            btnAddServiceLabel.Enabled = false;
            btnAddServiceLabel.FlatAppearance.BorderSize = 0;
            btnAddServiceLabel.FlatStyle = FlatStyle.Flat;
            btnAddServiceLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddServiceLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnAddServiceLabel.Location = new Point(0, 0);
            btnAddServiceLabel.Name = "btnAddServiceLabel";
            btnAddServiceLabel.Size = new Size(1028, 40);
            btnAddServiceLabel.TabIndex = 0;
            btnAddServiceLabel.Text = "New Service Form";
            btnAddServiceLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnAddServiceLabel.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnAddService);
            pnlMain.Controls.Add(tlpFormContent);
            pnlMain.Controls.Add(btnAddServiceLabel);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1028, 600);
            pnlMain.TabIndex = 1;
            // 
            // btnAddService
            // 
            btnAddService.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddService.ForeColor = Color.FromArgb(34, 24, 28);
            btnAddService.Location = new Point(27, 265);
            btnAddService.Margin = new Padding(50, 5, 50, 5);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(300, 30);
            btnAddService.TabIndex = 9;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // tlpFormContent
            // 
            tlpFormContent.ColumnCount = 2;
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormContent.Controls.Add(lblServiceName, 0, 0);
            tlpFormContent.Controls.Add(lblBreedType, 0, 2);
            tlpFormContent.Controls.Add(lblPrice, 0, 4);
            tlpFormContent.Controls.Add(lblMaxCapacity, 0, 6);
            tlpFormContent.Controls.Add(txtServiceName, 0, 1);
            tlpFormContent.Controls.Add(cmbBreedType, 0, 3);
            tlpFormContent.Controls.Add(nudPrice, 0, 5);
            tlpFormContent.Controls.Add(nudMaxCapacity, 0, 7);
            tlpFormContent.Dock = DockStyle.Top;
            tlpFormContent.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpFormContent.ForeColor = Color.FromArgb(34, 24, 28);
            tlpFormContent.Location = new Point(0, 40);
            tlpFormContent.Name = "tlpFormContent";
            tlpFormContent.Padding = new Padding(5);
            tlpFormContent.RowCount = 8;
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.Size = new Size(1028, 217);
            tlpFormContent.TabIndex = 1;
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Dock = DockStyle.Fill;
            lblServiceName.Font = new Font("Gadugi", 9.75F);
            lblServiceName.Location = new Point(8, 5);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(344, 16);
            lblServiceName.TabIndex = 0;
            lblServiceName.Text = "Service Name:";
            // 
            // lblBreedType
            // 
            lblBreedType.AutoSize = true;
            lblBreedType.Dock = DockStyle.Fill;
            lblBreedType.Font = new Font("Gadugi", 9.75F);
            lblBreedType.Location = new Point(8, 55);
            lblBreedType.Margin = new Padding(3, 5, 3, 0);
            lblBreedType.Name = "lblBreedType";
            lblBreedType.Size = new Size(344, 16);
            lblBreedType.TabIndex = 1;
            lblBreedType.Text = "Breed Type:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Gadugi", 9.75F);
            lblPrice.Location = new Point(8, 109);
            lblPrice.Margin = new Padding(3, 5, 3, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(344, 16);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price Per Hour:";
            // 
            // lblMaxCapacity
            // 
            lblMaxCapacity.AutoSize = true;
            lblMaxCapacity.Dock = DockStyle.Fill;
            lblMaxCapacity.Font = new Font("Gadugi", 9.75F);
            lblMaxCapacity.Location = new Point(8, 165);
            lblMaxCapacity.Margin = new Padding(3, 5, 3, 0);
            lblMaxCapacity.Name = "lblMaxCapacity";
            lblMaxCapacity.Size = new Size(344, 16);
            lblMaxCapacity.TabIndex = 3;
            lblMaxCapacity.Text = "Max Capasity Per Time Slot:";
            // 
            // txtServiceName
            // 
            txtServiceName.Dock = DockStyle.Fill;
            txtServiceName.Location = new Point(8, 24);
            txtServiceName.MaxLength = 40;
            txtServiceName.Multiline = true;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(344, 23);
            txtServiceName.TabIndex = 4;
            // 
            // cmbBreedType
            // 
            cmbBreedType.Dock = DockStyle.Fill;
            cmbBreedType.FormattingEnabled = true;
            cmbBreedType.Items.AddRange(new object[] { "Small", "Medium", "Big" });
            cmbBreedType.Location = new Point(8, 74);
            cmbBreedType.Name = "cmbBreedType";
            cmbBreedType.Size = new Size(344, 27);
            cmbBreedType.TabIndex = 5;
            cmbBreedType.Text = "Medium";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Dock = DockStyle.Fill;
            nudPrice.Location = new Point(8, 128);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(344, 29);
            nudPrice.TabIndex = 6;
            // 
            // nudMaxCapacity
            // 
            nudMaxCapacity.Dock = DockStyle.Fill;
            nudMaxCapacity.Location = new Point(8, 184);
            nudMaxCapacity.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMaxCapacity.Name = "nudMaxCapacity";
            nudMaxCapacity.Size = new Size(344, 29);
            nudMaxCapacity.TabIndex = 7;
            // 
            // frmAddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddService";
            Text = "frmAddService";
            pnlMain.ResumeLayout(false);
            tlpFormContent.ResumeLayout(false);
            tlpFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxCapacity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddServiceLabel;
        private Panel pnlMain;
        private TableLayoutPanel tlpFormContent;
        private Label lblServiceName;
        private Label lblBreedType;
        private Label lblPrice;
        private Label lblMaxCapacity;
        private TextBox txtServiceName;
        private ComboBox cmbBreedType;
        private NumericUpDown nudPrice;
        private NumericUpDown nudMaxCapacity;
        private Button btnAddService;
    }
}