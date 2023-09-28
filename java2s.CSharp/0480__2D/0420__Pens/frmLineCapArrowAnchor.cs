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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LineCapArrowAnchor.htm
    public partial  class frmLineCapArrowAnchor:Form
    {
        public frmLineCapArrowAnchor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLineCapArrowAnchor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLineCapArrowAnchor";
            this.Text = "frmLineCapArrowAnchor";
            this.Load += new System.EventHandler(this.frmLineCapArrowAnchor_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Brown, 15);

            // set the Arrow
            p.StartCap = LineCap.ArrowAnchor;
            p.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p, 30, 30, Width - 50, 30);
        }
        private void frmLineCapArrowAnchor_Load(object sender, EventArgs e)
        {

        }
    }
}
