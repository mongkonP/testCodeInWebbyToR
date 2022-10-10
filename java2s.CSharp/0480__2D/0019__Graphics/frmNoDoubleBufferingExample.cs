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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/NoDoubleBufferingExample.htm
    public partial  class frmNoDoubleBufferingExample:Form
    {
        public frmNoDoubleBufferingExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNoDoubleBufferingExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNoDoubleBufferingExample";
            this.Text = "frmNoDoubleBufferingExample";
            this.Load += new System.EventHandler(this.frmNoDoubleBufferingExample_Load);
            this.ResumeLayout(false);

        }

        private void frmNoDoubleBufferingExample_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();

            g.FillRectangle(Brushes.White, ClientRectangle);

            for (int x = 0; x < ClientRectangle.Width; x++)
            {
                for (int y = 0; y < ClientRectangle.Height; y += 10)
                {
                    Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    using (Pen p = new Pen(c, 1))
                    {
                        g.DrawLine(p, new Point(0, 0), new Point(x, y));
                        g.DrawLine(p, new Point(10, 40), new Point(x, y));
                        g.DrawLine(p, new Point(20, 30), new Point(x, y));
                        g.DrawLine(p, new Point(30, 20), new Point(x, y));
                        g.DrawLine(p, new Point(40, 10), new Point(x, y));
                        g.DrawLine(p, new Point(50, 10), new Point(x, y));
                    }
                }
            }
        }

    }
}
