using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0040__Read
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/RetrievesActiveDirectoryinformation.htm
    public partial  class frmRetrievesActiveDirectoryinformation:Form
    {
        public frmRetrievesActiveDirectoryinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievesActiveDirectoryinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievesActiveDirectoryinformation";
            this.Text = "frmRetrievesActiveDirectoryinformation";
            this.Load += new System.EventHandler(this.frmRetrievesActiveDirectoryinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievesActiveDirectoryinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
