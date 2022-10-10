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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/HatchStyleZigZag.htm
    public partial  class frmHatchStyleZigZag:Form
    {
        public frmHatchStyleZigZag()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHatchStyleZigZag
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHatchStyleZigZag";
            this.Text = "frmHatchStyleZigZag";
            this.Load += new System.EventHandler(this.frmHatchStyleZigZag_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            HatchBrush hb4 = new HatchBrush(HatchStyle.ZigZag, Color.AntiqueWhite, Color.Black);
            g.FillEllipse(hb4, 30, 180, Width - 50, 30);

        }
        private void frmHatchStyleZigZag_Load(object sender, EventArgs e)
        {

        }
    }
}
