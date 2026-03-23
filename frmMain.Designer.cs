namespace DoggyDaycare
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
            pnlMainPanel = new Panel();
            SuspendLayout();
            // 
            // pnlMainPanel
            // 
            pnlMainPanel.AutoSize = true;
            pnlMainPanel.Dock = DockStyle.Fill;
            pnlMainPanel.Location = new Point(0, 0);
            pnlMainPanel.Name = "pnlMainPanel";
            pnlMainPanel.Size = new Size(834, 511);
            pnlMainPanel.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 246);
            ClientSize = new Size(834, 511);
            Controls.Add(pnlMainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Doggy Daycare";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMainPanel;
    }
}