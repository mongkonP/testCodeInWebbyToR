using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0100__Line
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawtwolineswithonepen.htm
    public partial  class frmDrawtwolineswithonepen:Form
    {
        public frmDrawtwolineswithonepen()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawtwolineswithonepen
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawtwolineswithonepen";
            this.Text = "frmDrawtwolineswithonepen";
            this.Load += new System.EventHandler(this.frmDrawtwolineswithonepen_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenWidthColor_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawtwolineswithonepen_Load(object sender, EventArgs e)
        {

        }
        private void PenWidthColor_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen p = new Pen(Color.Black, 10);
            g.DrawLine(p, 25, 25, 375, 375);
            g.DrawLine(p, 25, 375, 375, 25);
        }
    }
}
