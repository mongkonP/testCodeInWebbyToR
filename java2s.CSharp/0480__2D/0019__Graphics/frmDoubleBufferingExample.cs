using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DoubleBufferingExample.htm
    public partial  class frmDoubleBufferingExample:Form
    {
        public frmDoubleBufferingExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDoubleBufferingExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDoubleBufferingExample";
            this.Text = "frmDoubleBufferingExample";
            this.Load += new System.EventHandler(this.frmDoubleBufferingExample_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics displayGraphics = e.Graphics;
            Random r = new Random();
            Image i = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            Graphics g = Graphics.FromImage(i);

            g.FillRectangle(Brushes.White, ClientRectangle);

            for (int x = 0; x < ClientRectangle.Width; x++)
            {
                for (int y = 0; y < ClientRectangle.Height; y += 10)
                {
                    Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    Pen p = new Pen(c, 1);
                    g.DrawLine(p, new Point(0, 0), new Point(x, y));
                    g.DrawLine(p, new Point(10, 10), new Point(x, y));
                    g.DrawLine(p, new Point(20, 10), new Point(x, y));
                    g.DrawLine(p, new Point(30, 10), new Point(x, y));
                    g.DrawLine(p, new Point(40, 10), new Point(x, y));
                    g.DrawLine(p, new Point(50, 10), new Point(x, y));
                    g.DrawLine(p, new Point(60, 10), new Point(x, y));
                    g.DrawLine(p, new Point(70, 10), new Point(x, y));
                    g.DrawLine(p, new Point(80, 10), new Point(x, y));
                    g.DrawLine(p, new Point(90, 10), new Point(x, y));
                    p.Dispose();
                }
            }
            displayGraphics.DrawImage(i, ClientRectangle);
            i.Dispose();
        }
        private void frmDoubleBufferingExample_Load(object sender, EventArgs e)
        {

        }
    }
}
