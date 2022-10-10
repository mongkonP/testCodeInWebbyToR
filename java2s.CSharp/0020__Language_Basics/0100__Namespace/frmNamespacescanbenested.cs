using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Namespacescanbenested.htm
    public partial  class frmNamespacescanbenested:Form
    {
        public frmNamespacescanbenested()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNamespacescanbenested
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNamespacescanbenested";
            this.Text = "frmNamespacescanbenested";
            this.Load += new System.EventHandler(this.frmNamespacescanbenested_Load);
            this.ResumeLayout(false);

        }

        private void frmNamespacescanbenested_Load(object sender, EventArgs e)
        {

        }
    }
}
