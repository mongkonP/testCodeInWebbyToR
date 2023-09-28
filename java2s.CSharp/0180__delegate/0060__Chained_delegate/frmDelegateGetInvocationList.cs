using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0060__Chained_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/DelegateGetInvocationList.htm
    public partial  class frmDelegateGetInvocationList:Form
    {
        public frmDelegateGetInvocationList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegateGetInvocationList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegateGetInvocationList";
            this.Text = "frmDelegateGetInvocationList";
            this.Load += new System.EventHandler(this.frmDelegateGetInvocationList_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegateGetInvocationList_Load(object sender, EventArgs e)
        {

        }
    }
}
