using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0020__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetDefaultButtonforaWindow.htm
    public partial  class frmSetDefaultButtonforaWindow:Form
    {
        public frmSetDefaultButtonforaWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetDefaultButtonforaWindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetDefaultButtonforaWindow";
            this.Text = "frmSetDefaultButtonforaWindow";
            this.Load += new System.EventHandler(this.frmSetDefaultButtonforaWindow_Load);
            this.ResumeLayout(false);

        }

        private void frmSetDefaultButtonforaWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
