using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0900__Frame
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FrameNavigationDemoWindow.htm
    public partial  class frmFrameNavigationDemoWindow:Form
    {
        public frmFrameNavigationDemoWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFrameNavigationDemoWindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFrameNavigationDemoWindow";
            this.Text = "frmFrameNavigationDemoWindow";
            this.Load += new System.EventHandler(this.frmFrameNavigationDemoWindow_Load);
            this.ResumeLayout(false);

        }

        private void frmFrameNavigationDemoWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
