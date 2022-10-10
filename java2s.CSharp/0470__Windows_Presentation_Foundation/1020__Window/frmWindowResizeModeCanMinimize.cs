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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WindowResizeModeCanMinimize.htm
    public partial  class frmWindowResizeModeCanMinimize:Form
    {
        public frmWindowResizeModeCanMinimize()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowResizeModeCanMinimize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowResizeModeCanMinimize";
            this.Text = "frmWindowResizeModeCanMinimize";
            this.Load += new System.EventHandler(this.frmWindowResizeModeCanMinimize_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowResizeModeCanMinimize_Load(object sender, EventArgs e)
        {

        }
    }
}
