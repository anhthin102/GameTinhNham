
namespace GameTinhNham
{
    partial class fRank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRank));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSTT = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton1 = new GameTinhNham.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.BackColor = System.Drawing.Color.Snow;
            this.lbSTT.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTT.Location = new System.Drawing.Point(8, 34);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(106, 30);
            this.lbSTT.TabIndex = 2;
            this.lbSTT.Text = "Xếp hạng";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.Snow;
            this.lbTen.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(139, 34);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(48, 30);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.BackColor = System.Drawing.Color.Snow;
            this.lbDiem.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(318, 34);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(69, 30);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Text = "Điểm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(572, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 545);
            this.panel1.TabIndex = 5;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackgroundImage = global::GameTinhNham.Properties.Resources.home;
            this.roundedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedButton1.Btn = null;
            this.roundedButton1.Location = new System.Drawing.Point(496, 29);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(70, 40);
            this.roundedButton1.TabIndex = 7;
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameTinhNham.Properties.Resources.rank2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 545);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbSTT);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game tính nhẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRank_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedButton roundedButton1;
    }
}