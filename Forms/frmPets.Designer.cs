namespace DoggyDaycare.Forms
{
    partial class frmPets
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
            pnlPetInfo = new Panel();
            tlpPetInfo = new TableLayoutPanel();
            lblPetID = new Label();
            lblOwner = new Label();
            lblPetName = new Label();
            lblBreedType = new Label();
            lblAge = new Label();
            lblSex = new Label();
            lblFeedingNotes = new Label();
            lblVetCheckUp = new Label();
            lblMedicalConditions = new Label();
            lblSocialisationLevel = new Label();
            lblKnownTriggers = new Label();
            lblBehaviouralNotes = new Label();
            lblAdditionalNotes = new Label();
            btnUpdateInformation = new Button();
            btnDeactivate = new Button();
            btnPetInfoLabel = new Button();
            pnlPetSearch = new Panel();
            pnlResults = new Panel();
            dgvResult = new DataGridView();
            tlpSearchControls = new TableLayoutPanel();
            cmbSearchType = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnSearchLabel = new Button();
            pnlPetInfo.SuspendLayout();
            tlpPetInfo.SuspendLayout();
            pnlPetSearch.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            tlpSearchControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPetInfo
            // 
            pnlPetInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlPetInfo.Controls.Add(tlpPetInfo);
            pnlPetInfo.Controls.Add(btnPetInfoLabel);
            pnlPetInfo.Dock = DockStyle.Right;
            pnlPetInfo.Location = new Point(728, 0);
            pnlPetInfo.Name = "pnlPetInfo";
            pnlPetInfo.Size = new Size(300, 600);
            pnlPetInfo.TabIndex = 0;
            // 
            // tlpPetInfo
            // 
            tlpPetInfo.AutoScroll = true;
            tlpPetInfo.ColumnCount = 1;
            tlpPetInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPetInfo.Controls.Add(lblPetID, 0, 0);
            tlpPetInfo.Controls.Add(lblOwner, 0, 1);
            tlpPetInfo.Controls.Add(lblPetName, 0, 2);
            tlpPetInfo.Controls.Add(lblBreedType, 0, 3);
            tlpPetInfo.Controls.Add(lblAge, 0, 4);
            tlpPetInfo.Controls.Add(lblSex, 0, 5);
            tlpPetInfo.Controls.Add(lblFeedingNotes, 0, 6);
            tlpPetInfo.Controls.Add(lblVetCheckUp, 0, 7);
            tlpPetInfo.Controls.Add(lblMedicalConditions, 0, 8);
            tlpPetInfo.Controls.Add(lblSocialisationLevel, 0, 9);
            tlpPetInfo.Controls.Add(lblKnownTriggers, 0, 10);
            tlpPetInfo.Controls.Add(lblBehaviouralNotes, 0, 11);
            tlpPetInfo.Controls.Add(lblAdditionalNotes, 0, 12);
            tlpPetInfo.Controls.Add(btnUpdateInformation, 0, 14);
            tlpPetInfo.Controls.Add(btnDeactivate, 0, 15);
            tlpPetInfo.Dock = DockStyle.Fill;
            tlpPetInfo.Location = new Point(0, 40);
            tlpPetInfo.Name = "tlpPetInfo";
            tlpPetInfo.Padding = new Padding(5);
            tlpPetInfo.RowCount = 16;
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle());
            tlpPetInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpPetInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpPetInfo.Size = new Size(298, 558);
            tlpPetInfo.TabIndex = 1;
            // 
            // lblPetID
            // 
            lblPetID.AutoSize = true;
            lblPetID.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPetID.Location = new Point(8, 5);
            lblPetID.Name = "lblPetID";
            lblPetID.Size = new Size(57, 19);
            lblPetID.TabIndex = 0;
            lblPetID.Text = "Pet ID: ";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOwner.Location = new Point(8, 24);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(63, 19);
            lblOwner.TabIndex = 1;
            lblOwner.Text = "Owner: ";
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPetName.Location = new Point(8, 43);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(84, 19);
            lblPetName.TabIndex = 2;
            lblPetName.Text = "Pet Name: ";
            // 
            // lblBreedType
            // 
            lblBreedType.AutoSize = true;
            lblBreedType.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBreedType.Location = new Point(8, 62);
            lblBreedType.Name = "lblBreedType";
            lblBreedType.Size = new Size(93, 19);
            lblBreedType.TabIndex = 3;
            lblBreedType.Text = "Breed Type: ";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(8, 81);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(43, 19);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age: ";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(8, 100);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(40, 19);
            lblSex.TabIndex = 5;
            lblSex.Text = "Sex: ";
            // 
            // lblFeedingNotes
            // 
            lblFeedingNotes.AutoSize = true;
            lblFeedingNotes.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeedingNotes.Location = new Point(8, 119);
            lblFeedingNotes.Name = "lblFeedingNotes";
            lblFeedingNotes.Size = new Size(116, 19);
            lblFeedingNotes.TabIndex = 6;
            lblFeedingNotes.Text = "Feeding Notes: ";
            // 
            // lblVetCheckUp
            // 
            lblVetCheckUp.AutoSize = true;
            lblVetCheckUp.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVetCheckUp.Location = new Point(8, 138);
            lblVetCheckUp.Name = "lblVetCheckUp";
            lblVetCheckUp.Size = new Size(111, 19);
            lblVetCheckUp.TabIndex = 7;
            lblVetCheckUp.Text = "Vet Check-Up: ";
            // 
            // lblMedicalConditions
            // 
            lblMedicalConditions.AutoSize = true;
            lblMedicalConditions.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicalConditions.Location = new Point(8, 157);
            lblMedicalConditions.Name = "lblMedicalConditions";
            lblMedicalConditions.Size = new Size(149, 19);
            lblMedicalConditions.TabIndex = 8;
            lblMedicalConditions.Text = "Medical Conditions: ";
            // 
            // lblSocialisationLevel
            // 
            lblSocialisationLevel.AutoSize = true;
            lblSocialisationLevel.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSocialisationLevel.Location = new Point(8, 176);
            lblSocialisationLevel.Name = "lblSocialisationLevel";
            lblSocialisationLevel.Size = new Size(143, 19);
            lblSocialisationLevel.TabIndex = 9;
            lblSocialisationLevel.Text = "Socialisation Level: ";
            // 
            // lblKnownTriggers
            // 
            lblKnownTriggers.AutoSize = true;
            lblKnownTriggers.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKnownTriggers.Location = new Point(8, 195);
            lblKnownTriggers.Name = "lblKnownTriggers";
            lblKnownTriggers.Size = new Size(125, 19);
            lblKnownTriggers.TabIndex = 10;
            lblKnownTriggers.Text = "Known Triggers: ";
            // 
            // lblBehaviouralNotes
            // 
            lblBehaviouralNotes.AutoSize = true;
            lblBehaviouralNotes.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBehaviouralNotes.Location = new Point(8, 214);
            lblBehaviouralNotes.Name = "lblBehaviouralNotes";
            lblBehaviouralNotes.Size = new Size(143, 19);
            lblBehaviouralNotes.TabIndex = 11;
            lblBehaviouralNotes.Text = "Behavioural Notes: ";
            // 
            // lblAdditionalNotes
            // 
            lblAdditionalNotes.AutoSize = true;
            lblAdditionalNotes.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdditionalNotes.Location = new Point(8, 233);
            lblAdditionalNotes.Name = "lblAdditionalNotes";
            lblAdditionalNotes.Size = new Size(132, 19);
            lblAdditionalNotes.TabIndex = 12;
            lblAdditionalNotes.Text = "Additional Notes: ";
            // 
            // btnUpdateInformation
            // 
            btnUpdateInformation.Dock = DockStyle.Fill;
            btnUpdateInformation.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateInformation.Location = new Point(8, 486);
            btnUpdateInformation.Name = "btnUpdateInformation";
            btnUpdateInformation.Size = new Size(282, 29);
            btnUpdateInformation.TabIndex = 13;
            btnUpdateInformation.Text = "Update Information";
            btnUpdateInformation.UseVisualStyleBackColor = true;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Dock = DockStyle.Fill;
            btnDeactivate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.Location = new Point(8, 521);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(282, 29);
            btnDeactivate.TabIndex = 14;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = true;
            // 
            // btnPetInfoLabel
            // 
            btnPetInfoLabel.Dock = DockStyle.Top;
            btnPetInfoLabel.Enabled = false;
            btnPetInfoLabel.FlatAppearance.BorderSize = 0;
            btnPetInfoLabel.FlatStyle = FlatStyle.Flat;
            btnPetInfoLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPetInfoLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnPetInfoLabel.Location = new Point(0, 0);
            btnPetInfoLabel.Name = "btnPetInfoLabel";
            btnPetInfoLabel.Size = new Size(298, 40);
            btnPetInfoLabel.TabIndex = 0;
            btnPetInfoLabel.Text = "Pet Information";
            btnPetInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnPetInfoLabel.UseVisualStyleBackColor = true;
            // 
            // pnlPetSearch
            // 
            pnlPetSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlPetSearch.Controls.Add(pnlResults);
            pnlPetSearch.Controls.Add(tlpSearchControls);
            pnlPetSearch.Controls.Add(btnSearchLabel);
            pnlPetSearch.Dock = DockStyle.Fill;
            pnlPetSearch.Location = new Point(0, 0);
            pnlPetSearch.Name = "pnlPetSearch";
            pnlPetSearch.Size = new Size(728, 600);
            pnlPetSearch.TabIndex = 1;
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dgvResult);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 75);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(5);
            pnlResults.Size = new Size(726, 523);
            pnlResults.TabIndex = 4;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToAddRows = false;
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.AllowUserToResizeColumns = false;
            dgvResult.AllowUserToResizeRows = false;
            dgvResult.BackgroundColor = Color.FromArgb(246, 244, 246);
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.Location = new Point(5, 5);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.Size = new Size(716, 513);
            dgvResult.TabIndex = 2;
            // 
            // tlpSearchControls
            // 
            tlpSearchControls.ColumnCount = 3;
            tlpSearchControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tlpSearchControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSearchControls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpSearchControls.Controls.Add(cmbSearchType, 0, 0);
            tlpSearchControls.Controls.Add(btnSearch, 2, 0);
            tlpSearchControls.Controls.Add(txtSearch, 1, 0);
            tlpSearchControls.Dock = DockStyle.Top;
            tlpSearchControls.Location = new Point(0, 40);
            tlpSearchControls.Name = "tlpSearchControls";
            tlpSearchControls.RowCount = 1;
            tlpSearchControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSearchControls.Size = new Size(726, 35);
            tlpSearchControls.TabIndex = 2;
            // 
            // cmbSearchType
            // 
            cmbSearchType.Dock = DockStyle.Fill;
            cmbSearchType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSearchType.ForeColor = Color.FromArgb(34, 24, 28);
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "By ID", "By Owner ID", "By Name", "By Breed Type", "By Age" });
            cmbSearchType.Location = new Point(3, 3);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(129, 29);
            cmbSearchType.TabIndex = 0;
            cmbSearchType.Text = "By ID";
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(34, 24, 28);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(629, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(5, 0, 0, 0);
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(34, 24, 28);
            txtSearch.Location = new Point(138, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(485, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearchLabel
            // 
            btnSearchLabel.Dock = DockStyle.Top;
            btnSearchLabel.Enabled = false;
            btnSearchLabel.FlatAppearance.BorderSize = 0;
            btnSearchLabel.FlatStyle = FlatStyle.Flat;
            btnSearchLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchLabel.ForeColor = Color.FromArgb(34, 24, 28);
            btnSearchLabel.Location = new Point(0, 0);
            btnSearchLabel.Name = "btnSearchLabel";
            btnSearchLabel.Size = new Size(726, 40);
            btnSearchLabel.TabIndex = 0;
            btnSearchLabel.Text = "Search";
            btnSearchLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchLabel.UseVisualStyleBackColor = true;
            // 
            // frmPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(1028, 600);
            Controls.Add(pnlPetSearch);
            Controls.Add(pnlPetInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPets";
            Text = "frmPets";
            pnlPetInfo.ResumeLayout(false);
            tlpPetInfo.ResumeLayout(false);
            tlpPetInfo.PerformLayout();
            pnlPetSearch.ResumeLayout(false);
            pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            tlpSearchControls.ResumeLayout(false);
            tlpSearchControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPetInfo;
        private Button btnPetInfoLabel;
        private Panel pnlPetSearch;
        private Button btnSearchLabel;
        private TableLayoutPanel tlpSearchControls;
        private ComboBox cmbSearchType;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel pnlResults;
        private DataGridView dgvResult;
        private TableLayoutPanel tlpPetInfo;
        private Label lblPetID;
        private Label lblOwner;
        private Label lblPetName;
        private Label lblBreedType;
        private Label lblAge;
        private Label lblSex;
        private Label lblFeedingNotes;
        private Label lblVetCheckUp;
        private Label lblMedicalConditions;
        private Label lblSocialisationLevel;
        private Label lblKnownTriggers;
        private Label lblBehaviouralNotes;
        private Label lblAdditionalNotes;
        private Button btnDeactivate;
        private Button btnUpdateInformation;
    }
}