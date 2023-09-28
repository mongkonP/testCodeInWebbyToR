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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawcenteredtext.htm
    public partial  class frmDrawcenteredtext:Form
    {
        public frmDrawcenteredtext()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
            Bounds = new Rectangle(0, 0, 500, 300);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawcenteredtext
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawcenteredtext";
            this.Text = "frmDrawcenteredtext";
            this.Load += new System.EventHandler(this.frmDrawcenteredtext_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int y = 0;

            g.FillRectangle(Brushes.White, ClientRectangle);

            // draw multiline text
            Font trFont = new Font("Times New Roman", 12);
            Rectangle rect = new Rectangle(0, y, 400, trFont.Height * 3);
            g.DrawRectangle(Pens.Blue, rect);
            String longString = "this is a test. ";
            longString += "this is a test. this is a test. this is a test. this is a test. ";
            longString += "this is a test. this is a test. this is a test. this is a test. ";
            longString += "this is a test. this is a test. this is a test. this is a test. ";
            g.DrawString(longString, trFont, Brushes.Black, rect);
            trFont.Dispose();

        }

        private void frmDrawcenteredtext_Load(object sender, EventArgs e)
        {

        }
    }
}
