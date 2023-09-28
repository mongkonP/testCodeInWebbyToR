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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TableFlowContent.htm
    public partial  class frmTableFlowContent:Form
    {
        public frmTableFlowContent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTableFlowContent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTableFlowContent";
            this.Text = "frmTableFlowContent";
            this.Load += new System.EventHandler(this.frmTableFlowContent_Load);
            this.ResumeLayout(false);

        }

        private void frmTableFlowContent_Load(object sender, EventArgs e)
        {

        }
    }
}
