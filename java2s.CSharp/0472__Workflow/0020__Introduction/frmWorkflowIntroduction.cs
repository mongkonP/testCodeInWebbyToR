using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0472__Workflow.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0472__Workflow/WorkflowIntroduction.htm
    public partial  class frmWorkflowIntroduction:Form
    {
        public frmWorkflowIntroduction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWorkflowIntroduction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWorkflowIntroduction";
            this.Text = "frmWorkflowIntroduction";
            this.Load += new System.EventHandler(this.frmWorkflowIntroduction_Load);
            this.ResumeLayout(false);

        }

        private void frmWorkflowIntroduction_Load(object sender, EventArgs e)
        {

        }
    }
}
