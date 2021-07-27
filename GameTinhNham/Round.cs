using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTinhNham
{
    public class RoundedButton : Button
    {
        #region Properties
        private Button btn;

        public Button Btn { get => btn; set => btn = value; }
        #endregion

        #region Initialize
      
        #endregion

        #region Methods
        public Button DrawButton(Button button)
        {
            RoundedButton myButton = new RoundedButton();
            myButton.Text = button.Text;
            myButton.Location = button.Location;
            myButton.Size = button.Size;
            myButton.Font = button.Font;
            myButton.BackColor = button.BackColor;
            myButton.BackgroundImage = button.BackgroundImage;
            myButton.BackgroundImageLayout = button.BackgroundImageLayout;
            button.Size = new Size(0, 0);
            return myButton;
        }
       
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height-r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, 
                                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width -r2, Rect.Height, Rect.X+r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height-radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y+r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, Cons.BORDER_RADIUS);
            this.Region = new Region(GraphPath);
            using(Pen pen = new Pen(Color.CadetBlue, Cons.PEN_WIDTH))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }    
        }

        
        #endregion
    }
/*    public class RoundedText : TextBox
    {
        #region Properties
        private TextBox txt;

        public TextBox Txt { get => txt; set => txt = value; }


        #endregion

        #region Initialize

        #endregion

        #region Methods
        public TextBox DrawTxt(TextBox text)
        {
            RoundedText myText = new RoundedText();
            myText.Text = text.Text;
            myText.Location = text.Location;
            myText.Size = text.Size;
            myText.Font = text.Font;
            myText.BackColor = text.BackColor;
            myText.BackgroundImage = text.BackgroundImage;
            myText.BackgroundImageLayout = text.BackgroundImageLayout;
            myText.Size = new Size(0, 0);
            return myText;
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, Cons.BORDER_RADIUS);
            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.CadetBlue, Cons.PEN_WIDTH))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }


        #endregion
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                        //RADIUS, how round do you want it to be?
        int nheightRect, //height of ellipse 
        int nweightRect //width of ellipse
    );
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        }
    }
*/
}
