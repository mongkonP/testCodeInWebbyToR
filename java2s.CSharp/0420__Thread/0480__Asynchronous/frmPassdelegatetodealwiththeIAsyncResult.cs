using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0480__Asynchronous
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/PassdelegatetodealwiththeIAsyncResult.htm
    public partial  class frmPassdelegatetodealwiththeIAsyncResult:Form
    {
        public frmPassdelegatetodealwiththeIAsyncResult()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassdelegatetodealwiththeIAsyncResult
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassdelegatetodealwiththeIAsyncResult";
            this.Text = "frmPassdelegatetodealwiththeIAsyncResult";
            this.Load += new System.EventHandler(this.frmPassdelegatetodealwiththeIAsyncResult_Load);
            this.ResumeLayout(false);

        }

        private void frmPassdelegatetodealwiththeIAsyncResult_Load(object sender, EventArgs e)
        {

        }
    }
}
