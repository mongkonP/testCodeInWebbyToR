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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GetFlowDocumentfromRichTextBox.htm
    public partial  class frmGetFlowDocumentfromRichTextBox:Form
    {
        public frmGetFlowDocumentfromRichTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetFlowDocumentfromRichTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetFlowDocumentfromRichTextBox";
            this.Text = "frmGetFlowDocumentfromRichTextBox";
            this.Load += new System.EventHandler(this.frmGetFlowDocumentfromRichTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmGetFlowDocumentfromRichTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
