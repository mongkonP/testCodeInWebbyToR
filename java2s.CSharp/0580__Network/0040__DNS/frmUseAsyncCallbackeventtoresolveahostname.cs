using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0040__DNS
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseAsyncCallbackeventtoresolveahostname.htm
    public partial  class frmUseAsyncCallbackeventtoresolveahostname:Form
    {
        public frmUseAsyncCallbackeventtoresolveahostname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseAsyncCallbackeventtoresolveahostname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseAsyncCallbackeventtoresolveahostname";
            this.Text = "frmUseAsyncCallbackeventtoresolveahostname";
            this.Load += new System.EventHandler(this.frmUseAsyncCallbackeventtoresolveahostname_Load);
            this.ResumeLayout(false);

        }

        private void frmUseAsyncCallbackeventtoresolveahostname_Load(object sender, EventArgs e)
        {

        }
    }
}
