namespace DoggyDaycare.Forms
{
    partial class frmRegisterPet
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
            btnRegisterPetLabel = new Button();
            tlpFormContent = new TableLayoutPanel();
            lblVetCheckUp = new Label();
            lblOwner = new Label();
            lblPhone = new Label();
            lblBreedType = new Label();
            lblAge = new Label();
            txtName = new TextBox();
            lblSex = new Label();
            cmbOwner = new ComboBox();
            cmbBreedType = new ComboBox();
            nudAge = new NumericUpDown();
            cmbSex = new ComboBox();
            lblFeedingNotes = new Label();
            lblMedicalConditions = new Label();
            lblSocialisationLevel = new Label();
            lblKnownTriggers = new Label();
            lblBehaviouralNotes = new Label();
            lblAdditionalNotes = new Label();
            txtMedicalConditions = new TextBox();
            cmbSocialisationLevel = new ComboBox();
            txtKnownTriggers = new TextBox();
            txtBehaviouralNotes = new TextBox();
            txtAdditionalNotes = new TextBox();
            txtFeedingNotes = new TextBox();
            dtpVetCheckUp = new DateTimePicker();
            btnRegisterPet = new Button();
            tlpFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterPetLabel
            // 
            btnRegisterPetLabel.Dock = DockStyle.Top;
            btnRegisterPetLabel.Enabled = false;
            btnRegisterPetLabel.FlatAppearance.BorderSize = 0;
            btnRegisterPetLabel.FlatStyle = FlatStyle.Flat;
            btnRegisterPetLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterPetLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnRegisterPetLabel.Location = new Point(0, 0);
            btnRegisterPetLabel.Name = "btnRegisterPetLabel";
            btnRegisterPetLabel.Size = new Size(1028, 40);
            btnRegisterPetLabel.TabIndex = 11;
            btnRegisterPetLabel.Text = "Pet Registration Form";
            btnRegisterPetLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterPetLabel.UseVisualStyleBackColor = true;
            // 
            // tlpFormContent
            // 
            tlpFormContent.ColumnCount = 4;
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tlpFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormContent.Controls.Add(lblVetCheckUp, 2, 0);
            tlpFormContent.Controls.Add(lblOwner, 0, 0);
            tlpFormContent.Controls.Add(lblPhone, 0, 2);
            tlpFormContent.Controls.Add(lblBreedType, 0, 4);
            tlpFormContent.Controls.Add(lblAge, 0, 6);
            tlpFormContent.Controls.Add(txtName, 0, 3);
            tlpFormContent.Controls.Add(lblSex, 0, 8);
            tlpFormContent.Controls.Add(cmbOwner, 0, 1);
            tlpFormContent.Controls.Add(cmbBreedType, 0, 5);
            tlpFormContent.Controls.Add(nudAge, 0, 7);
            tlpFormContent.Controls.Add(cmbSex, 0, 9);
            tlpFormContent.Controls.Add(lblFeedingNotes, 0, 10);
            tlpFormContent.Controls.Add(lblMedicalConditions, 2, 2);
            tlpFormContent.Controls.Add(lblSocialisationLevel, 2, 4);
            tlpFormContent.Controls.Add(lblKnownTriggers, 2, 6);
            tlpFormContent.Controls.Add(lblBehaviouralNotes, 2, 8);
            tlpFormContent.Controls.Add(lblAdditionalNotes, 2, 10);
            tlpFormContent.Controls.Add(txtMedicalConditions, 2, 3);
            tlpFormContent.Controls.Add(cmbSocialisationLevel, 2, 5);
            tlpFormContent.Controls.Add(txtKnownTriggers, 2, 7);
            tlpFormContent.Controls.Add(txtBehaviouralNotes, 2, 9);
            tlpFormContent.Controls.Add(txtAdditionalNotes, 2, 11);
            tlpFormContent.Controls.Add(txtFeedingNotes, 0, 11);
            tlpFormContent.Controls.Add(dtpVetCheckUp, 2, 1);
            tlpFormContent.Dock = DockStyle.Top;
            tlpFormContent.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpFormContent.ForeColor = Color.FromArgb(34, 24, 28);
            tlpFormContent.Location = new Point(0, 40);
            tlpFormContent.Name = "tlpFormContent";
            tlpFormContent.Padding = new Padding(5);
            tlpFormContent.RowCount = 12;
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
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle());
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormContent.Size = new Size(1028, 338);
            tlpFormContent.TabIndex = 12;
            // 
            // lblVetCheckUp
            // 
            lblVetCheckUp.AutoSize = true;
            lblVetCheckUp.Dock = DockStyle.Fill;
            lblVetCheckUp.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVetCheckUp.Location = new Point(328, 10);
            lblVetCheckUp.Margin = new Padding(3, 5, 3, 0);
            lblVetCheckUp.Name = "lblVetCheckUp";
            lblVetCheckUp.Size = new Size(294, 16);
            lblVetCheckUp.TabIndex = 22;
            lblVetCheckUp.Text = "Vet Check-Up:";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Dock = DockStyle.Fill;
            lblOwner.Font = new Font("Gadugi", 9.75F);
            lblOwner.Location = new Point(8, 10);
            lblOwner.Margin = new Padding(3, 5, 3, 0);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(294, 16);
            lblOwner.TabIndex = 0;
            lblOwner.Text = "Owner:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Gadugi", 9.75F);
            lblPhone.Location = new Point(8, 66);
            lblPhone.Margin = new Padding(3, 5, 3, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(294, 16);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Name:";
            // 
            // lblBreedType
            // 
            lblBreedType.AutoSize = true;
            lblBreedType.Dock = DockStyle.Fill;
            lblBreedType.Font = new Font("Gadugi", 9.75F);
            lblBreedType.Location = new Point(8, 122);
            lblBreedType.Margin = new Padding(3, 5, 3, 0);
            lblBreedType.Name = "lblBreedType";
            lblBreedType.Size = new Size(294, 16);
            lblBreedType.TabIndex = 2;
            lblBreedType.Text = "Breed Type:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Dock = DockStyle.Fill;
            lblAge.Font = new Font("Gadugi", 9.75F);
            lblAge.Location = new Point(8, 176);
            lblAge.Margin = new Padding(3, 5, 3, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(294, 16);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(8, 85);
            txtName.MaxLength = 20;
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 29);
            txtName.TabIndex = 9;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(8, 232);
            lblSex.Margin = new Padding(3, 5, 3, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(30, 16);
            lblSex.TabIndex = 12;
            lblSex.Text = "Sex:";
            // 
            // cmbOwner
            // 
            cmbOwner.Dock = DockStyle.Fill;
            cmbOwner.FormattingEnabled = true;
            cmbOwner.Location = new Point(8, 29);
            cmbOwner.Name = "cmbOwner";
            cmbOwner.Size = new Size(294, 27);
            cmbOwner.TabIndex = 13;
            // 
            // cmbBreedType
            // 
            cmbBreedType.Dock = DockStyle.Fill;
            cmbBreedType.FormattingEnabled = true;
            cmbBreedType.Items.AddRange(new object[] { "Small", "Medium", "Big" });
            cmbBreedType.Location = new Point(8, 141);
            cmbBreedType.Name = "cmbBreedType";
            cmbBreedType.Size = new Size(294, 27);
            cmbBreedType.TabIndex = 14;
            cmbBreedType.Text = "Medium";
            // 
            // nudAge
            // 
            nudAge.Dock = DockStyle.Fill;
            nudAge.Location = new Point(8, 195);
            nudAge.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(294, 29);
            nudAge.TabIndex = 15;
            // 
            // cmbSex
            // 
            cmbSex.Dock = DockStyle.Fill;
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(8, 251);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(294, 27);
            cmbSex.TabIndex = 16;
            cmbSex.Text = "Male";
            // 
            // lblFeedingNotes
            // 
            lblFeedingNotes.AutoSize = true;
            lblFeedingNotes.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeedingNotes.Location = new Point(8, 288);
            lblFeedingNotes.Margin = new Padding(3, 5, 3, 0);
            lblFeedingNotes.Name = "lblFeedingNotes";
            lblFeedingNotes.Size = new Size(95, 16);
            lblFeedingNotes.TabIndex = 17;
            lblFeedingNotes.Text = "Feeding Notes:";
            // 
            // lblMedicalConditions
            // 
            lblMedicalConditions.AutoSize = true;
            lblMedicalConditions.Dock = DockStyle.Fill;
            lblMedicalConditions.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicalConditions.Location = new Point(328, 66);
            lblMedicalConditions.Margin = new Padding(3, 5, 3, 0);
            lblMedicalConditions.Name = "lblMedicalConditions";
            lblMedicalConditions.Size = new Size(294, 16);
            lblMedicalConditions.TabIndex = 24;
            lblMedicalConditions.Text = "Medical Conditions:";
            // 
            // lblSocialisationLevel
            // 
            lblSocialisationLevel.AutoSize = true;
            lblSocialisationLevel.Dock = DockStyle.Fill;
            lblSocialisationLevel.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSocialisationLevel.Location = new Point(328, 122);
            lblSocialisationLevel.Margin = new Padding(3, 5, 3, 0);
            lblSocialisationLevel.Name = "lblSocialisationLevel";
            lblSocialisationLevel.Size = new Size(294, 16);
            lblSocialisationLevel.TabIndex = 25;
            lblSocialisationLevel.Text = "Socialisation Level:";
            // 
            // lblKnownTriggers
            // 
            lblKnownTriggers.AutoSize = true;
            lblKnownTriggers.Dock = DockStyle.Fill;
            lblKnownTriggers.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKnownTriggers.Location = new Point(328, 176);
            lblKnownTriggers.Margin = new Padding(3, 5, 3, 0);
            lblKnownTriggers.Name = "lblKnownTriggers";
            lblKnownTriggers.Size = new Size(294, 16);
            lblKnownTriggers.TabIndex = 26;
            lblKnownTriggers.Text = "Known Triggers:";
            // 
            // lblBehaviouralNotes
            // 
            lblBehaviouralNotes.AutoSize = true;
            lblBehaviouralNotes.Dock = DockStyle.Fill;
            lblBehaviouralNotes.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBehaviouralNotes.Location = new Point(328, 232);
            lblBehaviouralNotes.Margin = new Padding(3, 5, 3, 0);
            lblBehaviouralNotes.Name = "lblBehaviouralNotes";
            lblBehaviouralNotes.Size = new Size(294, 16);
            lblBehaviouralNotes.TabIndex = 27;
            lblBehaviouralNotes.Text = "Behavioural Notes:";
            // 
            // lblAdditionalNotes
            // 
            lblAdditionalNotes.AutoSize = true;
            lblAdditionalNotes.Dock = DockStyle.Fill;
            lblAdditionalNotes.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdditionalNotes.Location = new Point(328, 288);
            lblAdditionalNotes.Margin = new Padding(3, 5, 3, 0);
            lblAdditionalNotes.Name = "lblAdditionalNotes";
            lblAdditionalNotes.Size = new Size(294, 16);
            lblAdditionalNotes.TabIndex = 28;
            lblAdditionalNotes.Text = "Additional Notes:";
            // 
            // txtMedicalConditions
            // 
            txtMedicalConditions.Dock = DockStyle.Fill;
            txtMedicalConditions.Location = new Point(328, 85);
            txtMedicalConditions.MaxLength = 50;
            txtMedicalConditions.Name = "txtMedicalConditions";
            txtMedicalConditions.Size = new Size(294, 29);
            txtMedicalConditions.TabIndex = 29;
            // 
            // cmbSocialisationLevel
            // 
            cmbSocialisationLevel.Dock = DockStyle.Fill;
            cmbSocialisationLevel.FormattingEnabled = true;
            cmbSocialisationLevel.Items.AddRange(new object[] { "Unknown", "Low", "Medium", "High" });
            cmbSocialisationLevel.Location = new Point(328, 141);
            cmbSocialisationLevel.Name = "cmbSocialisationLevel";
            cmbSocialisationLevel.Size = new Size(294, 27);
            cmbSocialisationLevel.TabIndex = 30;
            cmbSocialisationLevel.Text = "Unknown\n";
            // 
            // txtKnownTriggers
            // 
            txtKnownTriggers.Dock = DockStyle.Fill;
            txtKnownTriggers.Location = new Point(328, 195);
            txtKnownTriggers.MaxLength = 50;
            txtKnownTriggers.Name = "txtKnownTriggers";
            txtKnownTriggers.Size = new Size(294, 29);
            txtKnownTriggers.TabIndex = 31;
            // 
            // txtBehaviouralNotes
            // 
            txtBehaviouralNotes.Dock = DockStyle.Fill;
            txtBehaviouralNotes.Location = new Point(328, 251);
            txtBehaviouralNotes.MaxLength = 50;
            txtBehaviouralNotes.Name = "txtBehaviouralNotes";
            txtBehaviouralNotes.Size = new Size(294, 29);
            txtBehaviouralNotes.TabIndex = 32;
            // 
            // txtAdditionalNotes
            // 
            txtAdditionalNotes.Dock = DockStyle.Fill;
            txtAdditionalNotes.Location = new Point(328, 307);
            txtAdditionalNotes.MaxLength = 50;
            txtAdditionalNotes.Name = "txtAdditionalNotes";
            txtAdditionalNotes.Size = new Size(294, 29);
            txtAdditionalNotes.TabIndex = 33;
            // 
            // txtFeedingNotes
            // 
            txtFeedingNotes.Dock = DockStyle.Fill;
            txtFeedingNotes.Location = new Point(8, 307);
            txtFeedingNotes.MaxLength = 50;
            txtFeedingNotes.Name = "txtFeedingNotes";
            txtFeedingNotes.Size = new Size(294, 29);
            txtFeedingNotes.TabIndex = 34;
            // 
            // dtpVetCheckUp
            // 
            dtpVetCheckUp.Dock = DockStyle.Fill;
            dtpVetCheckUp.Location = new Point(328, 29);
            dtpVetCheckUp.MaxDate = new DateTime(2026, 4, 17, 0, 0, 0, 0);
            dtpVetCheckUp.MinDate = new DateTime(2025, 4, 17, 0, 0, 0, 0);
            dtpVetCheckUp.Name = "dtpVetCheckUp";
            dtpVetCheckUp.Size = new Size(294, 29);
            dtpVetCheckUp.TabIndex = 35;
            dtpVetCheckUp.Value = new DateTime(2026, 4, 17, 0, 0, 0, 0);
            // 
            // btnRegisterPet
            // 
            btnRegisterPet.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterPet.ForeColor = Color.FromArgb(34, 24, 28);
            btnRegisterPet.Location = new Point(165, 386);
            btnRegisterPet.Margin = new Padding(50, 5, 50, 5);
            btnRegisterPet.Name = "btnRegisterPet";
            btnRegisterPet.Size = new Size(300, 30);
            btnRegisterPet.TabIndex = 13;
            btnRegisterPet.Text = "Register Pet";
            btnRegisterPet.UseVisualStyleBackColor = true;
            // 
            // frmRegisterPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(btnRegisterPet);
            Controls.Add(tlpFormContent);
            Controls.Add(btnRegisterPetLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegisterPet";
            Text = "frmRegisterPet";
            tlpFormContent.ResumeLayout(false);
            tlpFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterPetLabel;
        private TableLayoutPanel tlpFormContent;
        private Label lblOwner;
        private Label lblPhone;
        private Label lblBreedType;
        private Label lblAge;
        private TextBox txtOwner;
        private TextBox txtName;
        private Label lblSex;
        private Button btnRegisterPet;
        private ComboBox cmbOwner;
        private ComboBox cmbBreedType;
        private NumericUpDown nudAge;
        private ComboBox cmbSex;
        private Label lblFeedingNotes;
        private Label lblVetCheckUp;
        private Label lblMedicalConditions;
        private Label lblSocialisationLevel;
        private Label lblKnownTriggers;
        private Label lblBehaviouralNotes;
        private Label lblAdditionalNotes;
        private TextBox txtMedicalConditions;
        private ComboBox cmbSocialisationLevel;
        private TextBox txtKnownTriggers;
        private TextBox txtBehaviouralNotes;
        private TextBox txtAdditionalNotes;
        private TextBox txtFeedingNotes;
        private DateTimePicker dtpVetCheckUp;
    }
}