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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Makeabigbluepen.htm
    public partial  class frmMakeabigbluepen:Form
    {
        private System.ComponentModel.Container components = null;
        public frmMakeabigbluepen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMakeabigbluepen
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMakeabigbluepen";
            this.Text = "frmMakeabigbluepen";
            this.Load += new System.EventHandler(this.frmMakeabigbluepen_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenBigBlue_Paint);
            this.ResumeLayout(false);

        }
        private void PenBigBlue_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Make a big blue pen.
            Pen bluePen = new Pen(Color.Blue, 20);

            g.DrawEllipse(bluePen, 10, 10, 100, 100);
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
        private void frmMakeabigbluepen_Load(object sender, EventArgs e)
        {

        }
    }
}
