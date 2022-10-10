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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Constructadelegateusingmethodgroupconversion.htm
    public partial  class frmConstructadelegateusingmethodgroupconversion:Form
    {
        public frmConstructadelegateusingmethodgroupconversion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConstructadelegateusingmethodgroupconversion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConstructadelegateusingmethodgroupconversion";
            this.Text = "frmConstructadelegateusingmethodgroupconversion";
            this.Load += new System.EventHandler(this.frmConstructadelegateusingmethodgroupconversion_Load);
            this.ResumeLayout(false);

        }

        private void frmConstructadelegateusingmethodgroupconversion_Load(object sender, EventArgs e)
        {

        }
    }
}
