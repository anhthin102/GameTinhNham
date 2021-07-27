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

namespace GameTinhNham
{
    public partial class fRank : Form
    {
        string[] lines;
       
        public fRank()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(Colors.bcolForm);
            
            docfile();
            int leng = lines.Length;
            
            //MessageBox.Show(leng.ToString());

            string[] name = lines;
            string[] score = lines;
            Order(name, score);
            DrawRank1(name, score);
        }

        private void fRank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Dispose();
            }
        }
       
        string[] docfile()
        {
            var filename = "test.txt";


            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(directory_mydoc, filename);
            
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                //MessageBox.Show(lines[0]+" "+lines[1]);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!!");
            }
            
            
            return lines;
        }

        #region Methods
        public void DrawRank1(string[] name, string[] score)
        {
            /* int lh;
             lh = Cons.RANK_LABEL_HEIGHT;*/
        /*for (int j = 0; j < Cons.NUM_RANK_HEIGHT; j++)
        {

            Label lb = new Label()
            {
                Width = Cons.RANK_LABEL_WIDTH,
                Height = Cons.RANK_LABEL_HEIGHT,
                Location = new Point(Cons.FIRST_LOCATION_WIDTH, lh)
            };
            lb.Text = (j + 1).ToString();
            Color col = ColorTranslator.FromHtml(Colors.bcolBtnLevel2);
            lb.BackColor = col;
            flowLayoutPanel1.Controls.Add(lb);
            lh = lh + Cons.RANK_LABEL_HEIGHT + Cons.RANGE_LEVEL;

        }*/
            Color col = ColorTranslator.FromHtml(Colors.bcolBtnLevel2);
            /*Label lb = DrawLabel(Cons.RANK_LABEL_WIDTH, Cons.RANK_LABEL_HEIGHT,
                Cons.FIRST_LOCATION_WIDTH, Cons.FIRST_LOCATION_HEIGHT,"1", col);
            flowLayoutPanel1.Controls.Add(lb);*/
           
            int vtw= Cons.FIRST_LOCATION_WIDTH, vth= Cons.FIRST_LOCATION_HEIGHT;
            string s="";
            for(int i= 0; i<10; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if(j==0)
                    {
                        s = (i + 1).ToString();
                        
                    }
                    else
                    {
                        int n = i;

                        if(j==1)
                        {
                            /*MessageBox.Show(names.Length.ToString());
                            if(n<names.Length)
                            {
                                s = names[n];
                            }
                            else { s = names[0]; }*/
                            //s = names[0];
                            s = name[i*2];
                           
                            vtw = vtw + Cons.RANK_LABEL_WIDTH;
                        }
                        else
                        {
                            s = score[i * 2 + 1];
                            vtw = vtw + Cons.RANK_LABEL_WIDTH*2;
                        }
                    }
                    Label lb = DrawLabel(Cons.RANK_LABEL_WIDTH, Cons.RANK_LABEL_HEIGHT,
                    vtw, vth, s, col);
                    flowLayoutPanel1.Controls.Add(lb);
                    
                }
                vth = vth + Cons.RANK_LABEL_HEIGHT;
            }    

        }

        public void Order(string[] name, string[] score)
        {
            int n = score.Length/2;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(score[i*2+1]);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        // Nếu arr[i] < arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = arr[i];
                        string temp1 = score[i * 2 + 1];
                        string temp2 = name[i * 2];
                        
                        arr[i] = arr[j];
                        arr[j] = temp;
                        score[i * 2 + 1] = score[j * 2 + 1]; ;
                        score[j * 2 + 1] = temp1;
                        name[i * 2 ] = name[j * 2 ]; ;
                        name[j * 2 ] = temp2;
                    }
                }
            }
        }
        Label DrawLabel(int w, int h, int vtw,int vth, string s, Color col)
        {
            Label lb1 = new Label()
            {
                Width = w,
                Height = h,
                Location = Location = new Point(vtw, vth)
            };
            lb1.Text = s;
            lb1.BackColor = col;
            return lb1;
        }
        #endregion

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Form1 Child = new Form1();
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }
    }
}
