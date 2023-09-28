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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LineCapRound.htm
    public partial  class frmLineCapRound:Form
    {
        public frmLineCapRound()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLineCapRound
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLineCapRound";
            this.Text = "frmLineCapRound";
            this.Load += new System.EventHandler(this.frmLineCapRound_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Brown, 15);

            // round ends
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;
            g.DrawLine(p, 30, 80, Width - 50, 80);

        }
        private void frmLineCapRound_Load(object sender, EventArgs e)
        {

        }
    }
}
