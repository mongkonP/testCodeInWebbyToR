using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0180__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsPathCloseFigure.htm
    public partial  class frmGraphicsPathCloseFigure:Form
    {
        public frmGraphicsPathCloseFigure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsPathCloseFigure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsPathCloseFigure";
            this.Text = "frmGraphicsPathCloseFigure";
            this.Load += new System.EventHandler(this.frmGraphicsPathCloseFigure_Load);
            this.ResumeLayout(false);

        }

        private void frmGraphicsPathCloseFigure_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            gp.AddLine(10, 10, 110, 15);
            gp.AddLine(110, 15, 100, 96);
            gp.AddLine(100, 96, 15, 110);
            gp.CloseFigure();

            g.FillRectangle(Brushes.White, this.ClientRectangle);
            g.DrawPath(Pens.Black, gp);
            gp.Dispose();
        }
    }
}
