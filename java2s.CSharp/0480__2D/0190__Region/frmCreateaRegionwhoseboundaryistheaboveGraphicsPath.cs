using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0190__Region
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateaRegionwhoseboundaryistheaboveGraphicsPath.htm
    public partial  class frmCreateaRegionwhoseboundaryistheaboveGraphicsPath:Form
    {
        public frmCreateaRegionwhoseboundaryistheaboveGraphicsPath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaRegionwhoseboundaryistheaboveGraphicsPath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaRegionwhoseboundaryistheaboveGraphicsPath";
            this.Text = "frmCreateaRegionwhoseboundaryistheaboveGraphicsPath";
            this.Load += new System.EventHandler(this.frmCreateaRegionwhoseboundaryistheaboveGraphicsPath_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaRegionwhoseboundaryistheaboveGraphicsPath_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(10, 10, 10, 50);
            gp.AddLine(10, 50, 50, 50);
            gp.AddLine(50, 50, 50, 10);
            gp.StartFigure();
            gp.AddLine(60, 10, 60, 50);
            gp.AddLine(60, 50, 100, 50);
            gp.AddLine(100, 50, 100, 10);
            gp.CloseFigure();
            Rectangle r = new Rectangle(110, 10, 40, 40);
            gp.AddEllipse(r);
            Region reg = new Region(gp);
            g.FillRegion(Brushes.Green, reg);
            reg.Dispose();
            gp.Dispose();
        }
    }
}
