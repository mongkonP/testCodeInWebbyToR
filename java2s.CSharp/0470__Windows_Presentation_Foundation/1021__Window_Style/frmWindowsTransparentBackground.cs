using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WindowsTransparentBackground.htm
    public partial  class frmWindowsTransparentBackground:Form
    {
        public frmWindowsTransparentBackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowsTransparentBackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowsTransparentBackground";
            this.Text = "frmWindowsTransparentBackground";
            this.Load += new System.EventHandler(this.frmWindowsTransparentBackground_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowsTransparentBackground_Load(object sender, EventArgs e)
        {

        }
    }
}
