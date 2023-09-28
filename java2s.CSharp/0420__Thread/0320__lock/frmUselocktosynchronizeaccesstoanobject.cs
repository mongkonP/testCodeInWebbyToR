using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0320__lock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Uselocktosynchronizeaccesstoanobject.htm
    public partial  class frmUselocktosynchronizeaccesstoanobject:Form
    {
        public frmUselocktosynchronizeaccesstoanobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUselocktosynchronizeaccesstoanobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUselocktosynchronizeaccesstoanobject";
            this.Text = "frmUselocktosynchronizeaccesstoanobject";
            this.Load += new System.EventHandler(this.frmUselocktosynchronizeaccesstoanobject_Load);
            this.ResumeLayout(false);

        }

        private void frmUselocktosynchronizeaccesstoanobject_Load(object sender, EventArgs e)
        {

        }
    }
}
