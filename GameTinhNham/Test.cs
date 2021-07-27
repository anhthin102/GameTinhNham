using System;
using System.Windows.Forms;

namespace GameTinhNham
{
    class Test
    {
        /*#region Properties
        *//* private RichTextBox rtbAnswer;
         private RadioButton radioButton1;
         private RadioButton radioButton2;
         private RadioButton radioButton3;
         private int levelx;
         private int ans;

         public RichTextBox RtbAnswer { get => rtbAnswer; set => rtbAnswer = value; }
         public RadioButton RadioButton2 { get => radioButton2; set => radioButton2 = value; }
         public RadioButton RadioButton3 { get => radioButton3; set => radioButton3 = value; }
         public RadioButton RadioButton1 { get => radioButton1; set => radioButton1 = value; }
         public int Levelx { get => levelx; set => levelx = value; }
         public int Ans { get => ans; set => ans = value; }*//*
        private TextBox txtans;
        private TextBox txtlevel;
        private Timer tmCoolDown;
        private TextBox txtname;
        public TextBox Txtans { get => txtans; set => txtans = value; }
        public TextBox Txtlevel { get => txtlevel; set => txtlevel = value; }
        public Timer TmCoolDown { get => tmCoolDown; set => tmCoolDown = value; }
        public TextBox Txtname { get => txtname; set => txtname = value; }

        *//* private event EventHandler endedGame;
         public event EventHandler EndedGame
         {
             add
             {
                 endedGame += value;
             }
             remove
             {
                 endedGame -= value;
             }
         }*/
        /*private event EventHandler playerTicked;
        public event EventHandler PlayerTicked
        {
            add
            {
                playerTicked += value;
            }
            remove
            {
                playerTicked -= value;
            }
        }
*//*

        #endregion

        #region Initialize
        *//*  public Test(RichTextBox rtbAnswer, RadioButton radioButton1, RadioButton radioButton2,
              RadioButton radioButton3, int levelx, int ans)
          {
              this.rtbAnswer = rtbAnswer;
              this.radioButton1 = radioButton1;
              this.radioButton2 = radioButton2;
              this.radioButton2 = radioButton2;
              this.levelx = levelx;
              this.ans = ans;
          }*//*
        public Test(TextBox score, TextBox txtlevel, Timer tmCoolDown, TextBox txtname)
        {
            txtans = score;
            this.txtlevel = txtlevel;
            this.tmCoolDown = tmCoolDown;
            this.txtname = txtname;

        }
        #endregion

        #region Methods
        *//* int CreateTestt(int level)
        {
            // random ask
            Random r = new Random();
            RtbAnswer.Text = "";
            int n, result, caculator;
            n = r.Next(1, 9);
            result = n;
            RtbAnswer.Text += n.ToString();
            for (int i = 0; i < level; i++)
            {
                caculator = r.Next(0, 99);
                if (caculator % 2 != 0)
                {
                    n = r.Next(1, 9);
                    result = result + n;
                    RtbAnswer.Text += "+" + n.ToString();
                }
                else
                {
                    n = r.Next(0, result);
                    result = result - n;
                    RtbAnswer.Text += "-" + n.ToString();
                }
            }

            //random answer
            n = r.Next(1, 3);
            //MessageBox.Show(result.ToString()+"choose"+n.ToString());
            if (n == 1)
            {
                RadioButton1.Text = result.ToString();
                RadioButton2.Text = r.Next(0, result + 7).ToString();
                do
                {
                    RadioButton3.Text = r.Next(0, result + 7).ToString();
                }
                while (RadioButton3.Text == RadioButton2.Text);
            }
            else
            {
                if (n == 2)
                {
                    RadioButton2.Text = result.ToString();
                    RadioButton3.Text = r.Next(0, result + 7).ToString();
                    do
                    {
                        RadioButton1.Text = r.Next(0, result + 7).ToString();
                    }
                    while (RadioButton1.Text == RadioButton3.Text);
                }
                else
                {
                    RadioButton3.Text = result.ToString();
                    RadioButton1.Text = r.Next(0, result + 7).ToString();
                    do
                    {
                        RadioButton2.Text = r.Next(0, result + 7).ToString();
                    }
                    while (RadioButton2.Text == RadioButton1.Text);
                }
            }
            return n;
        }*/

        /*int ReSultt(int chooseradio)
        {

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton2.Checked == false)
            {
                return 0;
            }
            if ((chooseradio == 1 && radioButton1.Checked == true) || (chooseradio == 2 && radioButton2.Checked == true)
                || (chooseradio == 3 && radioButton3.Checked == true))
            {
                MessageBox.Show("bạn trả lời đúng rồi");
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;


                Levelx += 1;
                Ans = CreateTest(Levelx / 5 + 1);
                return 1;
            }
            else
            {

                MessageBox.Show("bạn trả lời sai rồi");

                return 2;


            }

        }*//*

        private bool isEndGame(int result)
        {
            if(result==2)
            return true;
            return false;
        }
        public void EndGamex()
        {
            TmCoolDown.Stop();
            


           

        }

        *//*public void PlayerTick()
        {

        }*//*

        public void winlevel(int scored, int levelxx)
        {
            txtans.Text = scored.ToString();
            txtlevel.Text = (levelxx + 1).ToString();

        }


        
        #endregion*/


    }
}
