using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0440__Context
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/GetnameofcurrentAppDomainandcontextID.htm
    public partial  class frmGetnameofcurrentAppDomainandcontextID:Form
    {
        public frmGetnameofcurrentAppDomainandcontextID()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetnameofcurrentAppDomainandcontextID
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetnameofcurrentAppDomainandcontextID";
            this.Text = "frmGetnameofcurrentAppDomainandcontextID";
            this.Load += new System.EventHandler(this.frmGetnameofcurrentAppDomainandcontextID_Load);
            this.ResumeLayout(false);

        }

        private void frmGetnameofcurrentAppDomainandcontextID_Load(object sender, EventArgs e)
        {

        }
    }
}
