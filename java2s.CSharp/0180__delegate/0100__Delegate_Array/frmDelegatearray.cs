using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0100__Delegate_Array
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Delegatearray.htm
    public partial  class frmDelegatearray:Form
    {
        public frmDelegatearray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegatearray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegatearray";
            this.Text = "frmDelegatearray";
            this.Load += new System.EventHandler(this.frmDelegatearray_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegatearray_Load(object sender, EventArgs e)
        {

        }
    }
}
