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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateanirregularRegionaddacircletotheregion.htm
    public partial  class frmCreateanirregularRegionaddacircletotheregion:Form
    {
        public frmCreateanirregularRegionaddacircletotheregion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateanirregularRegionaddacircletotheregion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateanirregularRegionaddacircletotheregion";
            this.Text = "frmCreateanirregularRegionaddacircletotheregion";
            this.Load += new System.EventHandler(this.frmCreateanirregularRegionaddacircletotheregion_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateanirregularRegionaddacircletotheregion_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            Region reg = new Region();
            reg.MakeEmpty();

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(10, 10, 50, 50);
            reg.Union(gp);
            gp.Reset();
            gp.AddLine(40, 40, 70, 10);
            gp.AddLine(70, 10, 100, 40);
            gp.CloseFigure();
            reg.Union(gp);
            reg.Union(new Rectangle(40, 50, 60, 60));
            g.SetClip(reg, CombineMode.Replace);
            g.FillRectangle(Brushes.Green, this.ClientRectangle);
            gp.Dispose();
            reg.Dispose();
        }
    }
}
