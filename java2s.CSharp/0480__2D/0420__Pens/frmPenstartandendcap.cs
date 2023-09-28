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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Penstartandendcap.htm
    public partial  class frmPenstartandendcap:Form
    {
        public frmPenstartandendcap()
        {
            InitializeComponent();
     
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenstartandendcap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenstartandendcap";
            this.Text = "frmPenstartandendcap";
            this.Load += new System.EventHandler(this.frmPenstartandendcap_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenStartEndCap_Paint);
            this.ResumeLayout(false);

        }
        private void PenStartEndCap_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen p2 = new Pen(Color.Gray, 7);
            p2.EndCap = LineCap.Round;
            p2.StartCap = LineCap.ArrowAnchor;
            g.DrawLine(p2, 25, 35, 25, 365);
            g.DrawLine(p2, 35, 375, 365, 375);
            g.DrawLine(p2, 375, 365, 375, 35);
            g.DrawLine(p2, 365, 25, 35, 25);
        }
        private void frmPenstartandendcap_Load(object sender, EventArgs e)
        {

        }
    }
}
