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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/newHatchBrush.htm
    public partial  class frmnewHatchBrush:Form
    {
        public frmnewHatchBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnewHatchBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnewHatchBrush";
            this.Text = "frmnewHatchBrush";
            this.Load += new System.EventHandler(this.frmnewHatchBrush_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            HatchBrush hb = new HatchBrush(
                     HatchStyle.WideUpwardDiagonal,
                     Color.White,
                     Color.Black);
            Pen hp = new Pen(hb, 8);
            g.DrawRectangle(hp, 15, 15, 70, 70);
            hb.Dispose();
            hp.Dispose();
        }
        private void frmnewHatchBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
