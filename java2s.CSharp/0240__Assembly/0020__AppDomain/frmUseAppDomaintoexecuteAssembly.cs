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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/UseAppDomaintoexecuteAssembly.htm
    public partial  class frmUseAppDomaintoexecuteAssembly:Form
    {
        public frmUseAppDomaintoexecuteAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseAppDomaintoexecuteAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseAppDomaintoexecuteAssembly";
            this.Text = "frmUseAppDomaintoexecuteAssembly";
            this.Load += new System.EventHandler(this.frmUseAppDomaintoexecuteAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmUseAppDomaintoexecuteAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
