
namespace GameTinhNham
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.pBEndgame = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.roundedButton2 = new GameTinhNham.RoundedButton();
            this.roundedButton1 = new GameTinhNham.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBEndgame)).BeginInit();
            this.SuspendLayout();
            // 
            // pBEndgame
            // 
            this.pBEndgame.BackgroundImage = global::GameTinhNham.Properties.Resources.endgame1;
            this.pBEndgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBEndgame.Location = new System.Drawing.Point(280, 140);
            this.pBEndgame.Name = "pBEndgame";
            this.pBEndgame.Size = new System.Drawing.Size(430, 180);
            this.pBEndgame.TabIndex = 0;
            this.pBEndgame.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(461, 418);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(100, 30);
            this.txtScore.TabIndex = 3;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Snow;
            this.lbScore.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(386, 418);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(69, 33);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(461, 360);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 30);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackgroundImage = global::GameTinhNham.Properties.Resources.facebook;
            this.roundedButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedButton2.Btn = null;
            this.roundedButton2.Location = new System.Drawing.Point(640, 360);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(70, 40);
            this.roundedButton2.TabIndex = 2;
            this.roundedButton2.UseVisualStyleBackColor = true;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackgroundImage = global::GameTinhNham.Properties.Resources.home;
            this.roundedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedButton1.Btn = null;
            this.roundedButton1.Location = new System.Drawing.Point(280, 360);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(70, 40);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTinhNham.Properties.Resources.formInfo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.pBEndgame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game tính nhẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndGame_FormClosing);
            this.Load += new System.EventHandler(this.EndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBEndgame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBEndgame;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}