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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/HatchStylePlaid.htm
    public partial  class frmHatchStylePlaid:Form
    {
        public frmHatchStylePlaid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHatchStylePlaid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHatchStylePlaid";
            this.Text = "frmHatchStylePlaid";
            this.Load += new System.EventHandler(this.frmHatchStylePlaid_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            HatchBrush hb = new HatchBrush(HatchStyle.Plaid, Color.AntiqueWhite, Color.Black);
            g.FillEllipse(hb, 30, 30, Width - 50, 30);

        }
        private void frmHatchStylePlaid_Load(object sender, EventArgs e)
        {

        }
    }
}
