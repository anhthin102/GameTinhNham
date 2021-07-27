using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTinhNham
{
    public class LevelManager
    {
        #region Properties
        private Panel level;

        public Panel Level
        { 
            get => level; set => level = value; 
        }
        #endregion

        #region Initialize
        public LevelManager(Panel level)
        {
            this.level = level;
            this.level.BackColor= ColorTranslator.FromHtml(Colors.bcolPnl);
        }
        #endregion

        #region Methods
        public void DrawLevelBoard(int levels)
        {
            Button oldButton = new Button()
            {
                Width = 0,
                Height = Cons.LEVEL_HEIGHT,
                Location = new Point(Cons.FIRST_LOCATION_WIDTH, Cons.FIRST_LOCATION_HEIGHT)
            };
            for (int j = 0; j < Cons.NUM_LEVEL_HEIGHT; j++)
            {
                for (int i = 0; i < Cons.NUM_LEVEL_WIDTH; i++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.LEVEL_WIDTH,
                        Height = Cons.LEVEL_HEIGHT,
                    };
                    if (oldButton.Width == 0)
                    {
                        btn.Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y);

                    }
                    else
                    {
                        btn.Location = new Point(oldButton.Location.X + oldButton.Width + Cons.RANGE_LEVEL, oldButton.Location.Y);
                    }
                    btn.Text = (j*5+i + 1).ToString();
                    Color col = ColorTranslator.FromHtml(Colors.bcolBtnLevel);
                    Color col2 = ColorTranslator.FromHtml(Colors.bcolBtnLevel2);
                    if((j*5+i)<levels)
                    {
                        btn.BackColor = col2;
                    }
                    else
                    {
                        btn.BackColor = col;
                    }
                    
                    level.Controls.Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(Cons.FIRST_LOCATION_WIDTH, oldButton.Location.Y + Cons.LEVEL_HEIGHT + Cons.RANGE_LEVEL);
                oldButton.Width = 0;
                oldButton.Height = Cons.LEVEL_HEIGHT;
            }
        }
        #endregion

    }
}
