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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/HatchBrushArrayHatchStyleminimumandmaximumvalues.htm
    public partial  class frmHatchBrushArrayHatchStyleminimumandmaximumvalues:Form
    {
        const int iSize = 32, iMargin = 8;
        const int iMin = 0, iMax = 52;  // 

        public frmHatchBrushArrayHatchStyleminimumandmaximumvalues()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHatchBrushArrayHatchStyleminimumandmaximumvalues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHatchBrushArrayHatchStyleminimumandmaximumvalues";
            this.Text = "frmHatchBrushArrayHatchStyleminimumandmaximumvalues";
            this.Load += new System.EventHandler(this.frmHatchBrushArrayHatchStyleminimumandmaximumvalues_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }
        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            for (HatchStyle hs = (HatchStyle)iMin; hs <= (HatchStyle)iMax; hs++)
            {
                HatchBrush hbrush =
                               new HatchBrush(hs, Color.White, Color.Black);
                int y = (int)hs / 8;
                int x = (int)hs % 8;

                grfx.FillRectangle(hbrush, iMargin + x * (iMargin + iSize),
                                           iMargin + y * (iMargin + iSize),
                                           iSize, iSize);
            }
        }
        private void frmHatchBrushArrayHatchStyleminimumandmaximumvalues_Load(object sender, EventArgs e)
        {

        }
    }
}
