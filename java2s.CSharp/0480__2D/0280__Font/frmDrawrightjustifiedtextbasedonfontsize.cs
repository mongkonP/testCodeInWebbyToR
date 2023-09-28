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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawrightjustifiedtextbasedonfontsize.htm
    public partial  class frmDrawrightjustifiedtextbasedonfontsize:Form
    {
        public frmDrawrightjustifiedtextbasedonfontsize()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
            Bounds = new Rectangle(0, 0, 500, 300);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawrightjustifiedtextbasedonfontsize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawrightjustifiedtextbasedonfontsize";
            this.Text = "frmDrawrightjustifiedtextbasedonfontsize";
            this.Load += new System.EventHandler(this.frmDrawrightjustifiedtextbasedonfontsize_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int y = 0;

            g.FillRectangle(Brushes.White, ClientRectangle);

            Font aFont = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            Rectangle rect = new Rectangle(0, y, 400, aFont.Height);
            g.DrawRectangle(Pens.Blue, rect);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            g.DrawString("This text is right justified.", aFont, Brushes.Blue, rect, sf);
            y += aFont.Height + 20;
            aFont.Dispose();

        }
        private void frmDrawrightjustifiedtextbasedonfontsize_Load(object sender, EventArgs e)
        {

        }
    }
}
