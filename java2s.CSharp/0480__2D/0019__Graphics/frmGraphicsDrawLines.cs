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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsDrawLines.htm
    public partial  class frmGraphicsDrawLines:Form
    {
        public frmGraphicsDrawLines()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsDrawLines
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsDrawLines";
            this.Text = "frmGraphicsDrawLines";
            this.Load += new System.EventHandler(this.frmGraphicsDrawLines_Load);
            this.ResumeLayout(false);

        }

        private void frmGraphicsDrawLines_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }

        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            Point[] apt = {new Point(0,      0),
                         new Point(cx - 1, 0),
                         new Point(cx - 1, cy - 1),
                         new Point(0,      cy - 1),
                         new Point(0,      0)};

            grfx.DrawLines(new Pen(clr), apt);
        }
    }
}
