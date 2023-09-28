using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0285__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/ImageFromFileloadimagefromfile.htm
    public partial  class frmImageFromFileloadimagefromfile:Form
    {
        public frmImageFromFileloadimagefromfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImageFromFileloadimagefromfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImageFromFileloadimagefromfile";
            this.Text = "frmImageFromFileloadimagefromfile";
            this.Load += new System.EventHandler(this.frmImageFromFileloadimagefromfile_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }
        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            Image image = Image.FromFile(@"Files\Image\promotion_marketing.png");

            grfx.DrawImage(image, 0, 0);
        }
        private void frmImageFromFileloadimagefromfile_Load(object sender, EventArgs e)
        {

        }
    }
}
