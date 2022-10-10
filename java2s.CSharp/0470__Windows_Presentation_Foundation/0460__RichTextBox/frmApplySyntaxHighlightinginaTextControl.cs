using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0460__RichTextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ApplySyntaxHighlightinginaTextControl.htm
    public partial  class frmApplySyntaxHighlightinginaTextControl:Form
    {
        public frmApplySyntaxHighlightinginaTextControl()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplySyntaxHighlightinginaTextControl
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplySyntaxHighlightinginaTextControl";
            this.Text = "frmApplySyntaxHighlightinginaTextControl";
            this.Load += new System.EventHandler(this.frmApplySyntaxHighlightinginaTextControl_Load);
            this.ResumeLayout(false);

        }

        private void frmApplySyntaxHighlightinginaTextControl_Load(object sender, EventArgs e)
        {

        }
    }
}
