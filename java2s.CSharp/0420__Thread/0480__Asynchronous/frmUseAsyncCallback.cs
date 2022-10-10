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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseAsyncCallback.htm
    public partial  class frmUseAsyncCallback:Form
    {
        public frmUseAsyncCallback()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseAsyncCallback
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseAsyncCallback";
            this.Text = "frmUseAsyncCallback";
            this.Load += new System.EventHandler(this.frmUseAsyncCallback_Load);
            this.ResumeLayout(false);

        }

        private void frmUseAsyncCallback_Load(object sender, EventArgs e)
        {

        }
    }
}
