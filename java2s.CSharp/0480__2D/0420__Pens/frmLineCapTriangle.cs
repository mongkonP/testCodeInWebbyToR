using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0420__Pens
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LineCapTriangle.htm
    public partial  class frmLineCapTriangle:Form
    {
        public frmLineCapTriangle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLineCapTriangle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLineCapTriangle";
            this.Text = "frmLineCapTriangle";
            this.Load += new System.EventHandler(this.frmLineCapTriangle_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Brown, 15);

            // triangle
            p.StartCap = LineCap.Triangle;
            p.EndCap = LineCap.Triangle;
            g.DrawLine(p, 30, 150, Width - 50, 150);

        }
        private void frmLineCapTriangle_Load(object sender, EventArgs e)
        {

        }
    }
}
