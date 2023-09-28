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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FlowDocumentwithTable.htm
    public partial  class frmFlowDocumentwithTable:Form
    {
        public frmFlowDocumentwithTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFlowDocumentwithTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFlowDocumentwithTable";
            this.Text = "frmFlowDocumentwithTable";
            this.Load += new System.EventHandler(this.frmFlowDocumentwithTable_Load);
            this.ResumeLayout(false);

        }

        private void frmFlowDocumentwithTable_Load(object sender, EventArgs e)
        {

        }
    }
}
