using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0780__Extension_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ExtensionMethodsDiscoverability.htm
    public partial  class frmExtensionMethodsDiscoverability:Form
    {
        public frmExtensionMethodsDiscoverability()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExtensionMethodsDiscoverability
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExtensionMethodsDiscoverability";
            this.Text = "frmExtensionMethodsDiscoverability";
            this.Load += new System.EventHandler(this.frmExtensionMethodsDiscoverability_Load);
            this.ResumeLayout(false);

        }

        private void frmExtensionMethodsDiscoverability_Load(object sender, EventArgs e)
        {

        }
    }
}
