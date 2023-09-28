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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/newHatchBrushHatchStyleCrossColorWhiteColorBlack.htm
    public partial  class frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack:Form
    {
        public frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack";
            this.Text = "frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack";
            this.Load += new System.EventHandler(this.frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            HatchBrush hb = new HatchBrush(
                      HatchStyle.Cross,
                      Color.White,
                      Color.Black);
            g.FillRectangle(hb, this.ClientRectangle);
            hb.Dispose();
        }
        private void frmnewHatchBrushHatchStyleCrossColorWhiteColorBlack_Load(object sender, EventArgs e)
        {

        }
    }
}
