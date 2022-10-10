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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SettooltipforImage.htm
    public partial  class frmSettooltipforImage:Form
    {
        public frmSettooltipforImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSettooltipforImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSettooltipforImage";
            this.Text = "frmSettooltipforImage";
            this.Load += new System.EventHandler(this.frmSettooltipforImage_Load);
            this.ResumeLayout(false);

        }

        private void frmSettooltipforImage_Load(object sender, EventArgs e)
        {

        }
    }
}
