using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0320__ProcessStartInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/WaitaProcessForExit.htm
    public partial  class frmWaitaProcessForExit:Form
    {
        public frmWaitaProcessForExit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWaitaProcessForExit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWaitaProcessForExit";
            this.Text = "frmWaitaProcessForExit";
            this.Load += new System.EventHandler(this.frmWaitaProcessForExit_Load);
            this.ResumeLayout(false);

        }

        private void frmWaitaProcessForExit_Load(object sender, EventArgs e)
        {

        }
    }
}
