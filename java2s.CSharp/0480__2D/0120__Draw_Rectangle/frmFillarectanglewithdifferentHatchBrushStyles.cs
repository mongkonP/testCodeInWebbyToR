using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0120__Draw_Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/FillarectanglewithdifferentHatchBrushStyles.htm
    public partial  class frmFillarectanglewithdifferentHatchBrushStyles:Form
    {
        public frmFillarectanglewithdifferentHatchBrushStyles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillarectanglewithdifferentHatchBrushStyles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillarectanglewithdifferentHatchBrushStyles";
            this.Text = "frmFillarectanglewithdifferentHatchBrushStyles";
            this.Load += new System.EventHandler(this.frmFillarectanglewithdifferentHatchBrushStyles_Load);
            this.ResumeLayout(false);

        }

        private void frmFillarectanglewithdifferentHatchBrushStyles_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font(new FontFamily("Times New Roman"), 10);
            Brush fb = new SolidBrush(Color.Black);
            Color cb = Color.Red, cf = Color.White;

            int wi = 30, hi = 25, rectNb = 14;
            int x, y;
            HatchBrush hb = null;
            for (int i = 0; i < 53; i++)
            {
                x = (int)(i % rectNb);
                y = (int)(i / rectNb);
                hb = new HatchBrush((HatchStyle)i, cf, cb);
                g.FillRectangle(hb, 2 + x * (5 + wi), 2 + y * (5 + hi), wi, hi);
            }

            fb.Dispose(); hb.Dispose(); g.Dispose();
        }
    }
}
