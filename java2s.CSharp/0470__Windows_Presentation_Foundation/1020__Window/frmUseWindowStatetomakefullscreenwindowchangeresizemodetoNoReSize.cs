using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize.htm
    public partial  class frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize:Form
    {
        public frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize";
            this.Text = "frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize";
            this.Load += new System.EventHandler(this.frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize_Load);
            this.ResumeLayout(false);

        }

        private void frmUseWindowStatetomakefullscreenwindowchangeresizemodetoNoReSize_Load(object sender, EventArgs e)
        {

        }
    }
}
