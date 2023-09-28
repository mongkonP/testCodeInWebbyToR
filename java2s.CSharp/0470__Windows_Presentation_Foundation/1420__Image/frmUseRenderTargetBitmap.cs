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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseRenderTargetBitmap.htm
    public partial  class frmUseRenderTargetBitmap:Form
    {
        public frmUseRenderTargetBitmap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseRenderTargetBitmap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseRenderTargetBitmap";
            this.Text = "frmUseRenderTargetBitmap";
            this.Load += new System.EventHandler(this.frmUseRenderTargetBitmap_Load);
            this.ResumeLayout(false);

        }

        private void frmUseRenderTargetBitmap_Load(object sender, EventArgs e)
        {

        }
    }
}
