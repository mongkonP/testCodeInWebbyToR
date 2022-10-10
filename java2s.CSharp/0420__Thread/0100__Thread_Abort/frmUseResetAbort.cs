using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0100__Thread_Abort
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseResetAbort.htm
    public partial  class frmUseResetAbort:Form
    {
        public frmUseResetAbort()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseResetAbort
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseResetAbort";
            this.Text = "frmUseResetAbort";
            this.Load += new System.EventHandler(this.frmUseResetAbort_Load);
            this.ResumeLayout(false);

        }

        private void frmUseResetAbort_Load(object sender, EventArgs e)
        {

        }
    }
}
