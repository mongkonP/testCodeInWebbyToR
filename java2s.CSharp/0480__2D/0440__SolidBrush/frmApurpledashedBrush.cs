using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0440__SolidBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/ApurpledashedBrush.htm
    public partial  class frmApurpledashedBrush:Form
    {
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
        public frmApurpledashedBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApurpledashedBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApurpledashedBrush";
            this.Text = "frmApurpledashedBrush";
            this.Load += new System.EventHandler(this.frmApurpledashedBrush_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "Solid Brushes...";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brush3 = new SolidBrush(Color.Purple);

            g.FillPolygon(brush3, new Point[]{new Point(30, 140),
                       new Point(265, 200),
                       new Point(100, 225),
                       new Point(190, 190),
                       new Point(50, 330),
                       new Point(20, 180)});

        }
        private void frmApurpledashedBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
