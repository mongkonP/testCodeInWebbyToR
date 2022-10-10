using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0020__delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Delegatewithreturnvalues.htm
    public partial  class frmDelegatewithreturnvalues:Form
    {
        public frmDelegatewithreturnvalues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegatewithreturnvalues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegatewithreturnvalues";
            this.Text = "frmDelegatewithreturnvalues";
            this.Load += new System.EventHandler(this.frmDelegatewithreturnvalues_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegatewithreturnvalues_Load(object sender, EventArgs e)
        {

        }
    }
}
