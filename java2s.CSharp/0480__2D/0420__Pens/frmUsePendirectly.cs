using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0420__Pens
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/UsePendirectly.htm
    public partial  class frmUsePendirectly:Form
    {
        public frmUsePendirectly()
        {
            InitializeComponent();
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
            // frmUsePendirectly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsePendirectly";
            this.Text = "frmUsePendirectly";
            this.Load += new System.EventHandler(this.frmUsePendirectly_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PensDirectly_Paint);
            this.ResumeLayout(false);

        }
        private void PensDirectly_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawPie(Pens.Black, 150, 10, 120, 150, 90, 80);
        }
        private void frmUsePendirectly_Load(object sender, EventArgs e)
        {

        }
    }
}
