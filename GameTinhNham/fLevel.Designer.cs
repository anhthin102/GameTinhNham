
namespace GameTinhNham
{
    partial class fLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLevel));
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rdBtnResume = new GameTinhNham.RoundedButton();
            this.rdBtnStart = new GameTinhNham.RoundedButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnhome = new GameTinhNham.RoundedButton();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLevel
            // 
            this.pnlLevel.BackgroundImage = global::GameTinhNham.Properties.Resources.formInfo;
            this.pnlLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLevel.Location = new System.Drawing.Point(34, 67);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(460, 400);
            this.pnlLevel.TabIndex = 3;
            // 
            // pnlImage
            // 
            this.pnlImage.BackgroundImage = global::GameTinhNham.Properties.Resources.logoLevel;
            this.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImage.Location = new System.Drawing.Point(511, 67);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(429, 150);
            this.pnlImage.TabIndex = 4;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.BackgroundImage = global::GameTinhNham.Properties.Resources.card;
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.btnhome);
            this.pnlInfo.Controls.Add(this.rdBtnResume);
            this.pnlInfo.Controls.Add(this.rdBtnStart);
            this.pnlInfo.Controls.Add(this.txtName);
            this.pnlInfo.Controls.Add(this.lbName);
            this.pnlInfo.Location = new System.Drawing.Point(511, 241);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(429, 250);
            this.pnlInfo.TabIndex = 5;
            // 
            // rdBtnResume
            // 
            this.rdBtnResume.Btn = null;
            this.rdBtnResume.Location = new System.Drawing.Point(205, 160);
            this.rdBtnResume.Name = "rdBtnResume";
            this.rdBtnResume.Size = new System.Drawing.Size(84, 35);
            this.rdBtnResume.TabIndex = 3;
            this.rdBtnResume.Text = "Resume";
            this.rdBtnResume.UseVisualStyleBackColor = true;
            this.rdBtnResume.Click += new System.EventHandler(this.rdBtnResume_Click);
            // 
            // rdBtnStart
            // 
            this.rdBtnStart.Btn = null;
            this.rdBtnStart.Location = new System.Drawing.Point(76, 160);
            this.rdBtnStart.Name = "rdBtnStart";
            this.rdBtnStart.Size = new System.Drawing.Size(84, 35);
            this.rdBtnStart.TabIndex = 2;
            this.rdBtnStart.Text = "Start";
            this.rdBtnStart.UseVisualStyleBackColor = true;
            this.rdBtnStart.Click += new System.EventHandler(this.rdBtnStart_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(108, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Han";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Snow;
            this.lbName.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(168, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 33);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImage = global::GameTinhNham.Properties.Resources.home;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.Btn = null;
            this.btnhome.Location = new System.Drawing.Point(332, 157);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(70, 40);
            this.btnhome.TabIndex = 6;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // fLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::GameTinhNham.Properties.Resources.Level;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlLevel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game tính nhẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLevel_FormClosing);
            this.Load += new System.EventHandler(this.fLevel_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbName;
        private RoundedButton rdBtnResume;
        private RoundedButton rdBtnStart;
        private System.Windows.Forms.TextBox txtName;
        private RoundedButton btnhome;
    }
}