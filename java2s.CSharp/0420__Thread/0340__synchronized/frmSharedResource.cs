using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0340__synchronized
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/SharedResource.htm
    public partial  class frmSharedResource:Form
    {
        public frmSharedResource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSharedResource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSharedResource";
            this.Text = "frmSharedResource";
            this.Load += new System.EventHandler(this.frmSharedResource_Load);
            this.ResumeLayout(false);

        }

        private void frmSharedResource_Load(object sender, EventArgs e)
        {

        }
    }
}
