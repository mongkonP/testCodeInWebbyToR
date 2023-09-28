using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0160__Pie
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Fillapiewithsolidbrush.htm
    public partial  class frmFillapiewithsolidbrush:Form
    {
        public frmFillapiewithsolidbrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillapiewithsolidbrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillapiewithsolidbrush";
            this.Text = "frmFillapiewithsolidbrush";
            this.Load += new System.EventHandler(this.frmFillapiewithsolidbrush_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SolidBrushWithColor_Paint);
            this.ResumeLayout(false);

        }

        private void frmFillapiewithsolidbrush_Load(object sender, EventArgs e)
        {

        }
        private void SolidBrushWithColor_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush brSolid = new SolidBrush(Color.Blue);
            g.FillPie(brSolid, 0, 0, 300, 300, 285, 75);
        }
    }
}
