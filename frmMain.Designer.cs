namespace PairingLogo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBrowseLogo = new System.Windows.Forms.Button();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.btnBrowseImageFolder = new System.Windows.Forms.Button();
            this.txtImageFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrRatio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(441, 103);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(133, 23);
            this.btnProcess.TabIndex = 34;
            this.btnProcess.Text = "Process Image";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBrowseLogo
            // 
            this.btnBrowseLogo.Location = new System.Drawing.Point(441, 61);
            this.btnBrowseLogo.Name = "btnBrowseLogo";
            this.btnBrowseLogo.Size = new System.Drawing.Size(133, 23);
            this.btnBrowseLogo.TabIndex = 29;
            this.btnBrowseLogo.Text = "Browse Logo file";
            this.btnBrowseLogo.UseVisualStyleBackColor = true;
            this.btnBrowseLogo.Click += new System.EventHandler(this.btnBrowseLogo_Click);
            // 
            // txtLogo
            // 
            this.txtLogo.Enabled = false;
            this.txtLogo.Location = new System.Drawing.Point(12, 61);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(423, 23);
            this.txtLogo.TabIndex = 28;
            // 
            // btnBrowseImageFolder
            // 
            this.btnBrowseImageFolder.Location = new System.Drawing.Point(441, 24);
            this.btnBrowseImageFolder.Name = "btnBrowseImageFolder";
            this.btnBrowseImageFolder.Size = new System.Drawing.Size(133, 23);
            this.btnBrowseImageFolder.TabIndex = 27;
            this.btnBrowseImageFolder.Text = "Browse Image folder";
            this.btnBrowseImageFolder.UseVisualStyleBackColor = true;
            this.btnBrowseImageFolder.Click += new System.EventHandler(this.btnBrowseImageFolder_Click);
            // 
            // txtImageFolder
            // 
            this.txtImageFolder.Enabled = false;
            this.txtImageFolder.Location = new System.Drawing.Point(12, 25);
            this.txtImageFolder.Name = "txtImageFolder";
            this.txtImageFolder.Size = new System.Drawing.Size(423, 23);
            this.txtImageFolder.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Logo size (%)";
            // 
            // nmrRatio
            // 
            this.nmrRatio.Location = new System.Drawing.Point(12, 104);
            this.nmrRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrRatio.Name = "nmrRatio";
            this.nmrRatio.Size = new System.Drawing.Size(84, 23);
            this.nmrRatio.TabIndex = 35;
            this.nmrRatio.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrRatio);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowseLogo);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.btnBrowseImageFolder);
            this.Controls.Add(this.txtImageFolder);
            this.MinimumSize = new System.Drawing.Size(605, 189);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo Paring";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnProcess;
        private Button btnBrowseLogo;
        private TextBox txtLogo;
        private Button btnBrowseImageFolder;
        private TextBox txtImageFolder;
        private Label label1;
        private NumericUpDown nmrRatio;
    }
}