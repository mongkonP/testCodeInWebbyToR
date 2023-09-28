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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/SolidBrushwithcolor.htm
    public partial  class frmSolidBrushwithcolor:Form
    {
        public frmSolidBrushwithcolor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSolidBrushwithcolor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSolidBrushwithcolor";
            this.Text = "frmSolidBrushwithcolor";
            this.Load += new System.EventHandler(this.frmSolidBrushwithcolor_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SolidBrushWithColor_Paint);
            this.ResumeLayout(false);

        }
        private void SolidBrushWithColor_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush brSolid = new SolidBrush(Color.Blue);
            g.FillPie(brSolid, 0, 0, 300, 300, 285, 75);
        }
        private void frmSolidBrushwithcolor_Load(object sender, EventArgs e)
        {

        }
    }
}
