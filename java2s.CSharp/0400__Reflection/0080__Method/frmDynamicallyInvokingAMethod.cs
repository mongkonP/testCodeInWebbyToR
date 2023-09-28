using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0080__Method
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/DynamicallyInvokingAMethod.htm
    public partial  class frmDynamicallyInvokingAMethod:Form
    {
        public frmDynamicallyInvokingAMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicallyInvokingAMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicallyInvokingAMethod";
            this.Text = "frmDynamicallyInvokingAMethod";
            this.Load += new System.EventHandler(this.frmDynamicallyInvokingAMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicallyInvokingAMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
