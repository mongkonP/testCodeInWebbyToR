using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2440__FlowDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddFlowDocumenttoButton.htm
    public partial  class frmAddFlowDocumenttoButton:Form
    {
        public frmAddFlowDocumenttoButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddFlowDocumenttoButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddFlowDocumenttoButton";
            this.Text = "frmAddFlowDocumenttoButton";
            this.Load += new System.EventHandler(this.frmAddFlowDocumenttoButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddFlowDocumenttoButton_Load(object sender, EventArgs e)
        {

        }
    }
}
