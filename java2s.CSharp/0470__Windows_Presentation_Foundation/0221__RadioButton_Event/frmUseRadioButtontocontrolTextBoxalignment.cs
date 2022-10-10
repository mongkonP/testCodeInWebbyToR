using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0221__RadioButton_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseRadioButtontocontrolTextBoxalignment.htm
    public partial  class frmUseRadioButtontocontrolTextBoxalignment:Form
    {
        public frmUseRadioButtontocontrolTextBoxalignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseRadioButtontocontrolTextBoxalignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseRadioButtontocontrolTextBoxalignment";
            this.Text = "frmUseRadioButtontocontrolTextBoxalignment";
            this.Load += new System.EventHandler(this.frmUseRadioButtontocontrolTextBoxalignment_Load);
            this.ResumeLayout(false);

        }

        private void frmUseRadioButtontocontrolTextBoxalignment_Load(object sender, EventArgs e)
        {

        }
    }
}
