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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CloseafigureandCreateanotherfigure.htm
    public partial  class frmCloseafigureandCreateanotherfigure:Form
    {
        public frmCloseafigureandCreateanotherfigure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCloseafigureandCreateanotherfigure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCloseafigureandCreateanotherfigure";
            this.Text = "frmCloseafigureandCreateanotherfigure";
            this.Load += new System.EventHandler(this.frmCloseafigureandCreateanotherfigure_Load);
            this.ResumeLayout(false);

        }

        private void frmCloseafigureandCreateanotherfigure_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            GraphicsPath gp = new GraphicsPath();

            gp.AddLine(10, 10, 10, 50);
            gp.AddBezier(10, 50, 10, 55, 25, 70, 30, 70);

            gp.CloseFigure();
            gp.StartFigure();
            gp.AddLine(60, 110, 40, 160);

            g.DrawPath(Pens.Black, gp);
            gp.Dispose();
        }
    }
}
