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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LineCapSquareAnchor.htm
    public partial  class frmLineCapSquareAnchor:Form
    {
        public frmLineCapSquareAnchor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLineCapSquareAnchor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLineCapSquareAnchor";
            this.Text = "frmLineCapSquareAnchor";
            this.Load += new System.EventHandler(this.frmLineCapSquareAnchor_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Brown, 15);

            // square Anchor
            p.StartCap = LineCap.SquareAnchor;
            p.EndCap = LineCap.SquareAnchor;
            g.DrawLine(p, 30, 190, Width - 50, 190);

        }
        private void frmLineCapSquareAnchor_Load(object sender, EventArgs e)
        {

        }
    }
}
