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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Dashedpen.htm
    public partial  class frmDashedpen:Form
    {
        private System.ComponentModel.Container components = null;
        public frmDashedpen()
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
            // frmDashedpen
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDashedpen";
            this.Text = "frmDashedpen";
            this.Load += new System.EventHandler(this.frmDashedpen_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(211, 104);
            this.Text = "A Form with Style!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenCustomDash_Paint);
            this.ResumeLayout(false);

        }
        private void PenCustomDash_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen customDashPen = new Pen(Color.Black, 10);
            float[] myDashes = { 5.0f, 2.0f, 1.0f, 3.0f };
            customDashPen.DashPattern = myDashes;
            e.Graphics.DrawRectangle(customDashPen, ClientRectangle);
        }
        private void frmDashedpen_Load(object sender, EventArgs e)
        {

        }
    }
}
