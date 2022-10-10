using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0880__Func
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OverloadingByDelegateReturnType.htm
    public partial  class frmOverloadingByDelegateReturnType:Form
    {
        public frmOverloadingByDelegateReturnType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadingByDelegateReturnType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadingByDelegateReturnType";
            this.Text = "frmOverloadingByDelegateReturnType";
            this.Load += new System.EventHandler(this.frmOverloadingByDelegateReturnType_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadingByDelegateReturnType_Load(object sender, EventArgs e)
        {

        }
    }
}
