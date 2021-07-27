using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GameTinhNham
{
    public partial class fPlay : Form
    {
        #region Properties
        int levelx = 0;
        
        int ans;
        int score = 0;

        //level
        private string txt_name;
        private int txt_score=0;
        private int txt_level = 0;
        private string txt_Question=null;
        private string choose1="";
        private string choose2="";
        private string choose3="";
        private int ans_value=0;
        private int timevalue=0;

       // Test t;

        //music
        bool mute = true;
        WMPLib.WindowsMediaPlayer playgame = new WindowsMediaPlayer();

        public string Txt_name { get => txt_name; set => txt_name = value; }
       
        
        public string Txt_Question { get => txt_Question; set => txt_Question = value; }
        public string Choose1 { get => choose1; set => choose1 = value; }
        public string Choose2 { get => choose2; set => choose2 = value; }
        public string Choose3 { get => choose3; set => choose3 = value; }
        public int Ans_value { get => ans_value; set => ans_value = value; }
        public int Timevalue { get => timevalue; set => timevalue = value; }
        public int Txt_score { get => txt_score; set => txt_score = value; }
        public int Txt_level { get => txt_level; set => txt_level = value; }


        #endregion
        public fPlay()
        {
            InitializeComponent();

            
            playgame.URL = "Tieng-dong-ho-tich-tac-www_tiengdong_com.mp3";
            playgame.controls.play();
            mute = false;
            
           // t = new Test(rtbAnswer, radioButton1, radioButton2, radioButton3, levelx, ans);
           // ans = CreateTest(1);


            //timer
            progressBarPlay.Step = Cons.COOL_DOWN_STEP;
            progressBarPlay.Maximum = Cons.COOL_DOWN_TIME;
            /*if(ans_value==0)
            { 
                progressBarPlay.Value = 0;
            }    
            else
            {
                progressBarPlay.Value = ans_value;
            }*/

            progressBarPlay.Value = 0;
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;
            tmCoolDown.Start();

            //t = new Test(txtScore, txtLevel, tmCoolDown, txtName);
            
        }

        #region Methods
        int CreateTest(int level)
        {
            // random ask
            Random r = new Random();
            rtbAnswer.Text = "";
            int n, result, caculator;
            n = r.Next(1, 9);
            result = n;
            rtbAnswer.Text += n.ToString();
                for (int i = 0; i < level; i++)
                {
                    caculator = r.Next(0, 99);
                    if (caculator % 2 != 0)
                    {
                        n = r.Next(1, 9);
                        result = result + n;
                        rtbAnswer.Text += "+" + n.ToString();
                    }
                    else
                    {
                        n = r.Next(0, result);
                        result = result - n;
                        rtbAnswer.Text += "-" + n.ToString();
                    }
                }

                //random answer
                n = r.Next(1, 3);
                //MessageBox.Show(result.ToString()+"choose"+n.ToString());
                if (n == 1)
                {
                    radioButton1.Text = result.ToString();
                    do
                    {
                        radioButton2.Text = r.Next(0, result + 7).ToString();
                    }
                    while (radioButton2.Text == radioButton1.Text);

                    do
                    {
                        radioButton3.Text = r.Next(0, result + 7).ToString();
                    }
                    while (radioButton3.Text == radioButton2.Text || radioButton3.Text == radioButton1.Text);
                }
                else
                {
                    if (n == 2)
                    {
                        radioButton2.Text = result.ToString();
                        do
                        {
                            radioButton3.Text = r.Next(0, result + 7).ToString();
                        }
                        while (radioButton3.Text == radioButton2.Text);

                        do
                        {
                            radioButton1.Text = r.Next(0, result + 7).ToString();
                        }
                        while (radioButton1.Text == radioButton3.Text || radioButton1.Text == radioButton2.Text);
                    }
                    else
                    {
                        radioButton3.Text = result.ToString();
                        do
                        {
                            radioButton1.Text = r.Next(0, result + 7).ToString();
                        }
                        while (radioButton1.Text == radioButton3.Text);

                        do
                        {
                            radioButton2.Text = r.Next(0, result + 7).ToString();
                        }
                        while (radioButton2.Text == radioButton1.Text || radioButton2.Text == radioButton3.Text);
                    }
             
                }
               // MessageBox.Show(n.ToString());
                return n;

            

        }

        int ReSult(int chooseradio)
        {

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton2.Checked == false)
            {
                return 0;
            }
            if ((chooseradio == 1 && radioButton1.Checked == true) || (chooseradio == 2 && radioButton2.Checked == true)
                || (chooseradio == 3 && radioButton3.Checked == true))
            {
                
                levelx = levelx + 1;
                score = score + levelx;
                //MessageBox.Show("bạn trả lời đúng rồi");
                winlevel(score, levelx);
                tmCoolDown.Start();
                progressBarPlay.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;


                
                ans = CreateTest(levelx / 5 + 1);
                return 1;
            }
            else
            {
                playgame.controls.stop();
                EndGamex();
                Endgamexx();
                return 2;


            }

        }

        void Endgamexx()
        {
            string content = txtName.Text;
            testAppendAllText(content);
            content = txtScore.Text;
            testAppendAllText(content);
            EndGame Child = new EndGame();
            Child.Txt_name = txtName.Text;
            Child.Txt_score = txtScore.Text;
            Child.Owner = this;
            if (MessageBox.Show("Kết thúc", "", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                Child.ShowDialog();

            }
            this.Hide();
        }
        public void EndGamex()
        {
            tmCoolDown.Stop();
        }




            public void winlevel(int scored, int levelxx)
        {
            txtScore.Text = scored.ToString();
            txtLevel.Text = (levelxx + 1).ToString();

        }

        public void testAppendAllText(string contentfile)
        {

            var filename = "test.txt";


            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fullpath = Path.Combine(directory_mydoc, filename);

            if (File.Exists(fullpath))
            {
                // File đã tồn tại - nối thêm nội dung
                File.AppendAllText(fullpath, contentfile+"\n");
            }
            else
            {
                // tạo mới vì chưa tồn tại file
                File.WriteAllText(fullpath, contentfile);
            }
            // Đọc nội dung File
            Console.WriteLine(fullpath);
            string s = File.ReadAllText(fullpath);
            Console.WriteLine(s);
        }
        #endregion

        private void radioButton1_Click(object sender, EventArgs e)
        {
            ReSult(ans);
            
            //MessageBox.Show(levelx.ToString());
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            ReSult(ans);
            //MessageBox.Show(levelx.ToString());
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            ReSult(ans);
            //MessageBox.Show(levelx.ToString());
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            progressBarPlay.PerformStep();
            if(progressBarPlay.Value>=progressBarPlay.Maximum)
            {
                playgame.controls.stop();
                EndGamex();
                Endgamexx();


            }
        }

       

     

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if(mute==true)
            {
                playgame.controls.play();
                Image myimage = new Bitmap("sound.png");
                roundedButton1.BackgroundImage = myimage;
                mute = false;
            }
            else
            {
                playgame.controls.stop();
                Image myimage = new Bitmap("mute.png");
                roundedButton1.BackgroundImage = myimage;
                mute = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmCoolDown.Stop();
            playgame.controls.stop();
            fLevel Child = new fLevel();
            Child.Txt_name = txtName.Text;
            Child.Txt_level = levelx.ToString();
            Child.Txt_Question = rtbAnswer.Text;
            Child.Txt_score = txtScore.Text;
            Child.Choose1 = radioButton1.Text;
            Child.Choose2 = radioButton2.Text;
            Child.Choose3 = radioButton3.Text;
            Child.Ans = ans;
            Child.Timevalue = progressBarPlay.Value;
            Child.Owner = this;
            Child.ShowDialog(); 
            this.Hide();
            
        }

        private void btnRank2_Click(object sender, EventArgs e)
        {
            Form1 Child = new Form1();
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }

        private void fPlay_Load(object sender, EventArgs e)
        {
            levelx = Txt_level;
            if (levelx == 0)
            {
                ans = CreateTest(1);
                this.txtName.Text = Txt_name;
                
            }
            else
            {
                this.txtName.Text = Txt_name;
                this.txtLevel.Text = levelx.ToString();
                levelx = levelx - 1;
                score = Txt_score;
                this.txtScore.Text = score.ToString();
                //levelx = Txt_level;
                /*rtbAnswer.Text = txt_Question;
                score = Txt_score;
                radioButton1.Text = choose1;
                radioButton2.Text = choose2;
                radioButton3.Text = choose3;
                ans = ans_value;*/
                //progressBarPlay.Value = timevalue;
                ans = CreateTest(levelx / 5 + 1);
            }

        }

        private void fPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Dispose();
            }
        }
    }
}
