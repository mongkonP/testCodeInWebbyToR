using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0140__Ellipse
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawanellipse.htm
    public partial  class frmDrawanellipse:Form
    {
        public frmDrawanellipse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawanellipse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawanellipse";
            this.Text = "frmDrawanellipse";
            this.Load += new System.EventHandler(this.frmDrawanellipse_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAnEllipse_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawanellipse_Load(object sender, EventArgs e)
        {

        }
        private void DrawAnEllipse_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // 
            Pen p2 = new Pen(Color.Gray, 7);
            g.DrawEllipse(p2, 200, 200, 150, 190);
        }
    }
}
