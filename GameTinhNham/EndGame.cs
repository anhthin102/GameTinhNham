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
using System.Web;
using System.Diagnostics;
using xNet;
using System.Text.RegularExpressions;
using System.Net;
using Facebook;
using NUnit.Framework;
using System.Dynamic;
using System.Configuration;
using MySql.Data.MySqlClient.Memcached;

namespace GameTinhNham
{

    public partial class EndGame : Form
    {
        private string txt_name;
        private string txt_score;
       

        WMPLib.WindowsMediaPlayer clap = new WindowsMediaPlayer();

        public EndGame()
        {
            InitializeComponent();
            clap.URL = "Tieng-vo-tay-www_nhacchuongvui_com.mp3";
            clap.controls.play();

        }

        public string Txt_name {
            get => txt_name; 
            set => txt_name = value; 
        }
        public string Txt_score { get => txt_score; set => txt_score = value; }
        #region Methods
        public void testAppendAllText(string contentfile)
        {

            var filename = "test.txt";
            

            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fullpath = Path.Combine(directory_mydoc, filename);

            if (File.Exists(fullpath))
            {
                // File đã tồn tại - nối thêm nội dung
                File.AppendAllText(fullpath, contentfile);
            }
            else
            {
                // tạo mới vì chưa tồn tại file
                File.WriteAllText(fullpath, contentfile);
            }
            
        }
        #endregion
        private void EndGame_Load(object sender, EventArgs e)
        {
            this.txtName.Text = txt_name;
            this.txtScore.Text = txt_score;
        }

      

        private void EndGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Owner!=null)
            { 
                this.Owner.Dispose();
            }    
            
           
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Form1 Child = new Form1();
            Child.Owner = this;
            Child.ShowDialog();
            this.Hide();
        }
        #region Facebook
        private void roundedButton2_Click(object sender, EventArgs e)
        {

            /*dynamic me = "100013104877011";
            FacebookClient app = new FacebookClient();
            dynamic parameters = new ExpandoObject();
            parameters.access_token = ConfigurationManager.AppSettings["EAAAAZAw4FxQIBADV8VwGPUnE7DkkBsy2FAGFmXIeSYdJ1CKBCPt8yFMJ1S6q71WsDWsh6vyCH2251OesZB5uZA7AMiZBDwaZAFF5zDKbFTRTQXGIcyo2qkEZBM9Djpn26RYhJNbRzqDmc7rvZAxywUBUkOvZAnVTtM4BsixBFcmt6gZDZD"];
            parameters.message = "This is a test message that has been published by     the Facebook C# SDK on Codeplex. " + DateTime.UtcNow.Ticks.ToString();
            parameters.attribution = "Facebook C# SDK";


            dynamic result = app.Post("/me/feed", parameters);

            Assert.AreNotEqual(null, result.id);*/
        }

       
        #endregion

    }
}
