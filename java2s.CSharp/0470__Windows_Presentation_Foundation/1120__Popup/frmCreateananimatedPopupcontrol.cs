using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1120__Popup
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateananimatedPopupcontrol.htm
    public partial  class frmCreateananimatedPopupcontrol:Form
    {
        public frmCreateananimatedPopupcontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateananimatedPopupcontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateananimatedPopupcontrol";
            this.Text = "frmCreateananimatedPopupcontrol";
            this.Load += new System.EventHandler(this.frmCreateananimatedPopupcontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateananimatedPopupcontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
