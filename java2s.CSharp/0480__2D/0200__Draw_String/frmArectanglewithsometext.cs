using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0200__Draw_String
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Arectanglewithsometext.htm
    public partial  class frmArectanglewithsometext:Form
    {
        private System.ComponentModel.Container components = null;
        public frmArectanglewithsometext()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArectanglewithsometext
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArectanglewithsometext";
            this.Text = "frmArectanglewithsometext";
            this.Load += new System.EventHandler(this.frmArectanglewithsometext_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RectangleWithText_Paint);
            this.ResumeLayout(false);

        }
        private void RectangleWithText_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle r = new Rectangle(150, 10, 130, 60);
            g.DrawRectangle(Pens.Blue, r);
            g.DrawString("www.java2s.com", new Font("Arial", 12), Brushes.Black, r);

        }
        private void frmArectanglewithsometext_Load(object sender, EventArgs e)
        {

        }
    }
}
