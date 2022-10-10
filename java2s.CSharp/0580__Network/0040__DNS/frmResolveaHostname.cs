using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0040__DNS
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ResolveaHostname.htm
    public partial  class frmResolveaHostname:Form
    {
        public frmResolveaHostname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResolveaHostname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResolveaHostname";
            this.Text = "frmResolveaHostname";
            this.Load += new System.EventHandler(this.frmResolveaHostname_Load);
            this.ResumeLayout(false);

        }

        private void frmResolveaHostname_Load(object sender, EventArgs e)
        {

        }
    }
}
