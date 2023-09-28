using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0143__TextBox_Validation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TextBoxwithdefaultErrorTemplate.htm
    public partial  class frmTextBoxwithdefaultErrorTemplate:Form
    {
        public frmTextBoxwithdefaultErrorTemplate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxwithdefaultErrorTemplate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxwithdefaultErrorTemplate";
            this.Text = "frmTextBoxwithdefaultErrorTemplate";
            this.Load += new System.EventHandler(this.frmTextBoxwithdefaultErrorTemplate_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxwithdefaultErrorTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
