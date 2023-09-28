using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0160__Pie
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/ApurpledashedPen.htm
    public partial  class frmApurpledashedPen:Form
    {
        public frmApurpledashedPen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
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
            // frmApurpledashedPen
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApurpledashedPen";
            this.Text = "frmApurpledashedPen";
            this.Load += new System.EventHandler(this.frmApurpledashedPen_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenPurpleDashed_Paint);
            this.ResumeLayout(false);

        }
        private void PenPurpleDashed_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen3 = new Pen(Color.Purple, 5);
            pen3.DashStyle = DashStyle.DashDotDot;

            g.DrawPolygon(pen3, new Point[]{new Point(30, 140),
                       new Point(265, 200),
                       new Point(100, 225),
                       new Point(190, 190),
                       new Point(50, 330),
                       new Point(20, 180)});
        }
        private void frmApurpledashedPen_Load(object sender, EventArgs e)
        {

        }
    }
}
