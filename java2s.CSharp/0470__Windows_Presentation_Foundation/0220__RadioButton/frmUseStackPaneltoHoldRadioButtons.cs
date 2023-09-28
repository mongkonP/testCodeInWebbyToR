using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0220__RadioButton
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseStackPaneltoHoldRadioButtons.htm
    public partial  class frmUseStackPaneltoHoldRadioButtons:Form
    {
        public frmUseStackPaneltoHoldRadioButtons()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseStackPaneltoHoldRadioButtons
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseStackPaneltoHoldRadioButtons";
            this.Text = "frmUseStackPaneltoHoldRadioButtons";
            this.Load += new System.EventHandler(this.frmUseStackPaneltoHoldRadioButtons_Load);
            this.ResumeLayout(false);

        }

        private void frmUseStackPaneltoHoldRadioButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
