using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0050__ToggleButton
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ToggleButtoncheckuncheckevent.htm
    public partial  class frmToggleButtoncheckuncheckevent:Form
    {
        public frmToggleButtoncheckuncheckevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToggleButtoncheckuncheckevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToggleButtoncheckuncheckevent";
            this.Text = "frmToggleButtoncheckuncheckevent";
            this.Load += new System.EventHandler(this.frmToggleButtoncheckuncheckevent_Load);
            this.ResumeLayout(false);

        }

        private void frmToggleButtoncheckuncheckevent_Load(object sender, EventArgs e)
        {

        }
    }
}
