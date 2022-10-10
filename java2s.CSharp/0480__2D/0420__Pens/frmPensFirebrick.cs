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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/PensFirebrick.htm
    public partial  class frmPensFirebrick:Form
    {

        private System.ComponentModel.Container components = null;


        public frmPensFirebrick()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
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
            // frmPensFirebrick
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPensFirebrick";
            this.Text = "frmPensFirebrick";
            this.Load += new System.EventHandler(this.frmPensFirebrick_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PensFirebrick_Paint);
            this.ResumeLayout(false);

        }
        private void PensFirebrick_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen2 = Pens.Firebrick;

            g.DrawLine(pen2, 10, 130, 110, 130);
        }
        private void frmPensFirebrick_Load(object sender, EventArgs e)
        {

        }
    }
}
