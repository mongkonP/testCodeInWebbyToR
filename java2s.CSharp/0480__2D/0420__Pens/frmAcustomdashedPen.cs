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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/AcustomdashedPen.htm
    public partial  class frmAcustomdashedPen:Form
    {
        private System.ComponentModel.Container components = null;
        public frmAcustomdashedPen()
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
            // frmAcustomdashedPen
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAcustomdashedPen";
            this.Text = "frmAcustomdashedPen";
            this.Load += new System.EventHandler(this.frmAcustomdashedPen_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenDashedDot_Paint);
            this.ResumeLayout(false);

        }

        private void frmAcustomdashedPen_Load(object sender, EventArgs e)
        {

        }

        private void PenDashedDot_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen customDashPen = new Pen(Color.BlueViolet, 5);
            float[] myDashes = { 5.0f, 2.0f, 1.0f, 3.0f };
            customDashPen.DashPattern = myDashes;
            g.DrawRectangle(customDashPen, ClientRectangle);

        }


    }
}
