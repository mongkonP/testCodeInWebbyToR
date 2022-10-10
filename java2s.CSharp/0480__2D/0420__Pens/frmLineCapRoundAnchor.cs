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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LineCapRoundAnchor.htm
    public partial  class frmLineCapRoundAnchor:Form
    {
        public frmLineCapRoundAnchor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLineCapRoundAnchor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLineCapRoundAnchor";
            this.Text = "frmLineCapRoundAnchor";
            this.Load += new System.EventHandler(this.frmLineCapRoundAnchor_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Brown, 15);

            // round Anchor
            p.StartCap = LineCap.RoundAnchor;
            p.EndCap = LineCap.RoundAnchor;
            g.DrawLine(p, 30, 120, Width - 50, 120);

        }
        private void frmLineCapRoundAnchor_Load(object sender, EventArgs e)
        {

        }
    }
}
