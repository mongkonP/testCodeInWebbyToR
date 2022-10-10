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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawPie.htm
    public partial  class frmDrawPie:Form
    {
        public frmDrawPie()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private System.ComponentModel.Container components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawPie
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawPie";
            this.Text = "frmDrawPie";
            this.Load += new System.EventHandler(this.frmDrawPie_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPieDemo_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawPie_Load(object sender, EventArgs e)
        {

        }
        private void DrawPieDemo_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawPie(Pens.Black, 150, 10, 120, 150, 90, 80);
        }
    }
}
