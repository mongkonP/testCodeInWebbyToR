using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Virtualmethodinamultilevelhierarchy.htm
    public partial  class frmVirtualmethodinamultilevelhierarchy:Form
    {
        public frmVirtualmethodinamultilevelhierarchy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVirtualmethodinamultilevelhierarchy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVirtualmethodinamultilevelhierarchy";
            this.Text = "frmVirtualmethodinamultilevelhierarchy";
            this.Load += new System.EventHandler(this.frmVirtualmethodinamultilevelhierarchy_Load);
            this.ResumeLayout(false);

        }

        private void frmVirtualmethodinamultilevelhierarchy_Load(object sender, EventArgs e)
        {

        }
    }
}
