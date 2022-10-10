using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0280__Font
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawleftjustifiedtextbasedonfontsize.htm
    public partial  class frmDrawleftjustifiedtextbasedonfontsize:Form
    {
        public frmDrawleftjustifiedtextbasedonfontsize()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
            Bounds = new Rectangle(0, 0, 500, 300);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawleftjustifiedtextbasedonfontsize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawleftjustifiedtextbasedonfontsize";
            this.Text = "frmDrawleftjustifiedtextbasedonfontsize";
            this.Load += new System.EventHandler(this.frmDrawleftjustifiedtextbasedonfontsize_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int y = 0;

            g.FillRectangle(Brushes.White, ClientRectangle);

            // draw left justified text
            Rectangle rect = new Rectangle(0, y, 400, Font.Height);
            g.DrawRectangle(Pens.Blue, rect);
            g.DrawString("This text is left justified.", Font, Brushes.Black, rect);
            y += Font.Height + 20;

        }

        private void frmDrawleftjustifiedtextbasedonfontsize_Load(object sender, EventArgs e)
        {

        }
    }
}
