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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsDrawLine.htm
    public partial  class frmGraphicsDrawLine:Form
    {
        public frmGraphicsDrawLine()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsDrawLine
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsDrawLine";
            this.Text = "frmGraphicsDrawLine";
            this.Load += new System.EventHandler(this.frmGraphicsDrawLine_Load);
            this.ResumeLayout(false);

        }

        private void frmGraphicsDrawLine_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }

        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            Pen pen = new Pen(clr);

            grfx.DrawLine(pen, 0, 0, cx - 1, cy - 1);
            grfx.DrawLine(pen, cx - 1, 0, 0, cy - 1);
        }
    }
}
