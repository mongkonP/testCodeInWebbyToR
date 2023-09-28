using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0020__AppDomain
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/PrintAllAssembliesInAppDomain.htm
    public partial  class frmPrintAllAssembliesInAppDomain:Form
    {
        public frmPrintAllAssembliesInAppDomain()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintAllAssembliesInAppDomain
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintAllAssembliesInAppDomain";
            this.Text = "frmPrintAllAssembliesInAppDomain";
            this.Load += new System.EventHandler(this.frmPrintAllAssembliesInAppDomain_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintAllAssembliesInAppDomain_Load(object sender, EventArgs e)
        {

        }
    }
}
