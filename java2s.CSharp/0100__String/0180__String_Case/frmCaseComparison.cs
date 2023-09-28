using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0180__String_Case
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/CaseComparison.htm
    public partial  class frmCaseComparison:Form
    {
        public frmCaseComparison()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCaseComparison
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCaseComparison";
            this.Text = "frmCaseComparison";
            this.Load += new System.EventHandler(this.frmCaseComparison_Load);
            this.ResumeLayout(false);

        }

        private void frmCaseComparison_Load(object sender, EventArgs e)
        {

        }
    }
}
