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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/UsePenstodrawLines.htm
    public partial  class frmUsePenstodrawLines:Form
    {
        public frmUsePenstodrawLines()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsePenstodrawLines
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsePenstodrawLines";
            this.Text = "frmUsePenstodrawLines";
            this.Load += new System.EventHandler(this.frmUsePenstodrawLines_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawLineDemo_Paint);
            this.ResumeLayout(false);

        }

        private void frmUsePenstodrawLines_Load(object sender, EventArgs e)
        {

        }
        private void DrawLineDemo_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 10);
            g.DrawLine(p, 25, 25, 375, 375);
        }
    }
}
