using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1840__EventTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TriggerPropertyFrameworkElementIsFocused.htm
    public partial  class frmTriggerPropertyFrameworkElementIsFocused:Form
    {
        public frmTriggerPropertyFrameworkElementIsFocused()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTriggerPropertyFrameworkElementIsFocused
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTriggerPropertyFrameworkElementIsFocused";
            this.Text = "frmTriggerPropertyFrameworkElementIsFocused";
            this.Load += new System.EventHandler(this.frmTriggerPropertyFrameworkElementIsFocused_Load);
            this.ResumeLayout(false);

        }

        private void frmTriggerPropertyFrameworkElementIsFocused_Load(object sender, EventArgs e)
        {

        }
    }
}
