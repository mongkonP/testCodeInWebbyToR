using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0480__override
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/OverridingVirtualMethods.htm
    public partial  class frmOverridingVirtualMethods:Form
    {
        public frmOverridingVirtualMethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverridingVirtualMethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverridingVirtualMethods";
            this.Text = "frmOverridingVirtualMethods";
            this.Load += new System.EventHandler(this.frmOverridingVirtualMethods_Load);
            this.ResumeLayout(false);

        }

        private void frmOverridingVirtualMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
