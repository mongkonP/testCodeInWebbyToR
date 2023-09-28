using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0040__GraphicsUnit
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsUnitDisplayMillimeterInchPixel.htm
    public partial  class frmGraphicsUnitDisplayMillimeterInchPixel:Form
    {
        public frmGraphicsUnitDisplayMillimeterInchPixel()
        {
            InitializeComponent();
        }
        private System.ComponentModel.Container components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsUnitDisplayMillimeterInchPixel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsUnitDisplayMillimeterInchPixel";
            this.Text = "frmGraphicsUnitDisplayMillimeterInchPixel";
            this.Load += new System.EventHandler(this.frmGraphicsUnitDisplayMillimeterInchPixel_Load);
            this.ResumeLayout(false);

        }

        private void frmGraphicsUnitDisplayMillimeterInchPixel_Load(object sender, EventArgs e)
        {

        }
        protected void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsUnit gUnit = GraphicsUnit.Pixel;

            Point renderingOrgPt = new Point(0, 0);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;


            gUnit = GraphicsUnit.Display;
            /*

                gUnit = GraphicsUnit.Millimeter;
                gUnit = GraphicsUnit.Inch;
                gUnit = GraphicsUnit.Pixel;
            */


            g.PageUnit = gUnit;
            g.TranslateTransform(renderingOrgPt.X, renderingOrgPt.Y);
            g.DrawRectangle(new Pen(Color.Red, 1), 0, 0, 100, 100);

            this.Text = string.Format("PageUnit: {0}, Origin: {1}", gUnit, renderingOrgPt.ToString());
        }

        protected void OnResize(object sender, System.EventArgs e)
        {
            Invalidate();
        }
    }
}
