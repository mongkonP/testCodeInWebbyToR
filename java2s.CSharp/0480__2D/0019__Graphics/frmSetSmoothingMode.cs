using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/SetSmoothingMode.htm
    public partial  class frmSetSmoothingMode:Form
    {
        public frmSetSmoothingMode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetSmoothingMode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetSmoothingMode";
            this.Text = "frmSetSmoothingMode";
            this.Load += new System.EventHandler(this.frmSetSmoothingMode_Load);
            this.ResumeLayout(false);

        }

        private void frmSetSmoothingMode_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.White, this.ClientRectangle);

            Pen p = new Pen(Color.Black, 10);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p, 30, 30, 80, 30);
            p.Dispose();
        }
    }
}
