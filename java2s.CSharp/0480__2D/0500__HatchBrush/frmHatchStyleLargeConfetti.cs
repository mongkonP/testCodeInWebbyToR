using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0500__HatchBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/HatchStyleLargeConfetti.htm
    public partial  class frmHatchStyleLargeConfetti:Form
    {
        public frmHatchStyleLargeConfetti()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHatchStyleLargeConfetti
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHatchStyleLargeConfetti";
            this.Text = "frmHatchStyleLargeConfetti";
            this.Load += new System.EventHandler(this.frmHatchStyleLargeConfetti_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            HatchBrush hb = new HatchBrush(HatchStyle.LargeConfetti, Color.AntiqueWhite, Color.Blue);
            g.FillEllipse(hb, 30, 30, Width - 50, 30);


        }
        private void frmHatchStyleLargeConfetti_Load(object sender, EventArgs e)
        {

        }
    }
}
