using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1160__Extension
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ExtensionMethodOnNullReference.htm
    public partial  class frmExtensionMethodOnNullReference:Form
    {
        public frmExtensionMethodOnNullReference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExtensionMethodOnNullReference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExtensionMethodOnNullReference";
            this.Text = "frmExtensionMethodOnNullReference";
            this.Load += new System.EventHandler(this.frmExtensionMethodOnNullReference_Load);
            this.ResumeLayout(false);

        }

        private void frmExtensionMethodOnNullReference_Load(object sender, EventArgs e)
        {

        }
    }
}
