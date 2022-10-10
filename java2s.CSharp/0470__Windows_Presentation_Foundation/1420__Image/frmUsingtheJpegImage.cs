using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingtheJpegImage.htm
    public partial  class frmUsingtheJpegImage:Form
    {
        public frmUsingtheJpegImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingtheJpegImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingtheJpegImage";
            this.Text = "frmUsingtheJpegImage";
            this.Load += new System.EventHandler(this.frmUsingtheJpegImage_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingtheJpegImage_Load(object sender, EventArgs e)
        {

        }
    }
}
