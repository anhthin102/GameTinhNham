using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTinhNham
{
    public partial class fLevel : Form
    {
        #region Properties
        LevelManager level;
        RoundedButton btn2;
        //Play
        private string txt_name="";
        private string txt_score="";
        private string txt_level="";
        private string txt_Question="";
        private string choose1="";
        private string choose2="";
        private string choose3="";
        private int ans=0;
        private int timevalue=0;
        //private string txt

        //Play2
        int play_level;
        string play_score;
        string play_question;
        string play_choose1, play_choose2, play_choose3;
        int play_ans;
        int play_timevalue;
        // RoundedText text;
        // RoundedText text2 = new RoundedText();
        #endregion
        public fLevel()
        {
            InitializeComponent();
            level = new LevelManager(pnlLevel);
            //level.DrawLevelBoard(play_level);
            pnlImage.BackColor = ColorTranslator.FromHtml(Colors.bcolPnl);
            pnlInfo.BackColor = ColorTranslator.FromHtml(Colors.bcolPnl);
            //RoundBtn(btnAmthanh2);
            rdBtnStart.BackColor = ColorTranslator.FromHtml(Colors.bcolBtnStart);
            rdBtnResume.BackColor = ColorTranslator.FromHtml(Colors.bcolBtnResume);

            //RoundTxt(txtName);
            //this.Controls.Add(text2);
        }

        public string Txt_name { get => txt_name; set => txt_name = value; }
        public string Txt_level { get => txt_level; set => txt_level = value; }
        public string Txt_Question { get => txt_Question; set => txt_Question = value; }
        public string Txt_score { get => txt_score; set => txt_score = value; }
        public string Choose1 { get => choose1; set => choose1 = value; }
        public string Choose2 { get => choose2; set => choose2 = value; }
        public string Choose3 { get => choose3; set => choose3 = value; }
        public int Ans { get => ans; set => ans = value; }
        public int Timevalue { get => timevalue; set => timevalue = value; }

        #region Methods
        public void RoundBtn(Button btnControl)
        {
            btn2 = new RoundedButton();
            Button button = btn2.DrawButton(btnControl);
            this.Controls.Add(button);
        }
        /*

        public void RoundTxt(TextBox txtControl)
        {
            text = new RoundedText();
            TextBox txt = text.DrawTxt(txtControl);
            this.Controls.Add(txt);
        }
        */
        #endregion

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 Child = new Form1();
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }

        private void rdBtnResume_Click(object sender, EventArgs e)
        {
            fPlay Child = new fPlay();
            Child.Txt_name = txtName.Text;
            Child.Txt_level = Int32.Parse(txt_level)+1;
           // Child.Txt_Question = txt_Question;
            Child.Txt_score = Int32.Parse(txt_score);
           /* Child.Choose1 = choose1;
            Child.Choose2 = choose2;
            Child.Choose3 = choose3;
            Child.Ans_value = ans;
            Child.Timevalue = timevalue;*/
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }

        private void rdBtnStart_Click(object sender, EventArgs e)
        {
           
            fPlay Child = new fPlay();
            Child.Txt_name = txtName.Text;
            Child.Txt_level = 0;
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }

        private void fLevel_Load(object sender, EventArgs e)
        {
            this.txtName.Text = txt_name;
            play_level = Int32.Parse(txt_level);
            play_question = txt_Question;
            play_score = txt_score;
            play_choose1 = choose1;
            play_choose2 = choose2;
            play_choose3 = choose3;
            play_ans = ans;
            play_timevalue = timevalue;
            level.DrawLevelBoard(play_level);
        }

        private void fLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Owner!=null)
            {
                this.Owner.Dispose(); 
            }    
            
        }
    }
}

