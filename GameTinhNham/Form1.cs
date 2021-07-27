using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTinhNham
{
    public partial class Form1 : Form
    {
        #region Properties
        RoundedButton btn;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Create_file_model();


        }

        #region Methods
        public void RoundBtn(Button btnControl)
        {
            btn = new RoundedButton();
            Button button = btn.DrawButton(btnControl);
            this.Controls.Add(button);
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Dispose();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            fLevel Child = new fLevel();
            Child.Txt_name = " ";
            Child.Txt_level = "0";
            Child.Txt_Question = " ";
            Child.Txt_score = "0";
            Child.Choose1 = "0";
            Child.Choose2 = "0";
            Child.Choose3 = "0";
            Child.Ans = 0;
            Child.Timevalue = 0;
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }

        private void btnRank1_Click(object sender, EventArgs e)
        {
            fRank Child = new fRank();
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }

        public void Create_file_model()
        {
            var filename = "test.txt";
            string[] contentfile = {"Lâm Hân", "11", "Ngũ", "23","Lan","45","Linh","12",
                                "Lê Lê","9","Lựu","13","Nhung","22", "Thy", "4", 
                               "Nhi","9","Trâm","12","Vân","17","Thìn","18","Liên",
                                "22", "Na","10","Mạnh","9","Thành","23","Hoa","5",
                                "Kha", "7", "Nguyên","9","Ngưu", "25", "Han ni","3",
                                "Hà","6","Han y","0","Han","21","Han","21"};

            // Lấy thư mục Document của User trên hệ thống
            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var fullpath = Path.Combine(directory_mydoc, filename);
            if (System.IO.File.Exists(fullpath))
            {
               
            }
            else
            {
                System.IO.File.WriteAllLines(fullpath, contentfile);
            }
           
        }
    }
}

