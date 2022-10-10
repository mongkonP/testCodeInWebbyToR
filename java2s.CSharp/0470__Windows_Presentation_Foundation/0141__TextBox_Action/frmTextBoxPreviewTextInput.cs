using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0141__TextBox_Action
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TextBoxPreviewTextInput.htm
    public partial  class frmTextBoxPreviewTextInput:Form
    {
        public frmTextBoxPreviewTextInput()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxPreviewTextInput
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxPreviewTextInput";
            this.Text = "frmTextBoxPreviewTextInput";
            this.Load += new System.EventHandler(this.frmTextBoxPreviewTextInput_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxPreviewTextInput_Load(object sender, EventArgs e)
        {

        }
    }
}
