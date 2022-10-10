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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/MakeanewAppDomaininthecurrentprocess.htm
    public partial  class frmMakeanewAppDomaininthecurrentprocess:Form
    {
        public frmMakeanewAppDomaininthecurrentprocess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMakeanewAppDomaininthecurrentprocess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMakeanewAppDomaininthecurrentprocess";
            this.Text = "frmMakeanewAppDomaininthecurrentprocess";
            this.Load += new System.EventHandler(this.frmMakeanewAppDomaininthecurrentprocess_Load);
            this.ResumeLayout(false);

        }

        private void frmMakeanewAppDomaininthecurrentprocess_Load(object sender, EventArgs e)
        {

        }
    }
}
