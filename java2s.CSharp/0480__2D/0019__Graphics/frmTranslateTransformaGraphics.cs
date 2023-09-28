using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/TranslateTransformaGraphics.htm
    public partial  class frmTranslateTransformaGraphics:Form
    {
        public frmTranslateTransformaGraphics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTranslateTransformaGraphics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTranslateTransformaGraphics";
            this.Text = "frmTranslateTransformaGraphics";
            this.Load += new System.EventHandler(this.frmTranslateTransformaGraphics_Load);
            this.ResumeLayout(false);

        }

        private void frmTranslateTransformaGraphics_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            Font f = new Font("Times New Roman", 24);
            g.DrawString("Translation", f, Brushes.Black, 0, 0);

            g.TranslateTransform(150, 75);
            g.DrawString("Translation", f, Brushes.Black, 0, 0);
        }
    }
}
