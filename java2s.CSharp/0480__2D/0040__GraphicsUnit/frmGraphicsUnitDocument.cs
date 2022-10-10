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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsUnitDocument.htm
    public partial  class frmGraphicsUnitDocument:Form
    {
        public frmGraphicsUnitDocument()
        {
            InitializeComponent();
            ResizeRedraw = true;
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
            // frmGraphicsUnitDocument
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(408, 273);
            this.Name = "GraphicUnitDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDI+ Coordinate";
            this.Resize += new System.EventHandler(this.OnResize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }

        protected void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsUnit gUnit = GraphicsUnit.Pixel;

            Point renderingOrgPt = new Point(0, 0);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;


            gUnit = GraphicsUnit.Document;


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
