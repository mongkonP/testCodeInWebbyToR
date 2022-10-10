using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0900__yield
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/YieldBreakAndTryFinally.htm
    public partial  class frmYieldBreakAndTryFinally:Form
    {
        public frmYieldBreakAndTryFinally()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmYieldBreakAndTryFinally
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmYieldBreakAndTryFinally";
            this.Text = "frmYieldBreakAndTryFinally";
            this.Load += new System.EventHandler(this.frmYieldBreakAndTryFinally_Load);
            this.ResumeLayout(false);

        }

        private void frmYieldBreakAndTryFinally_Load(object sender, EventArgs e)
        {

        }
    }
}
