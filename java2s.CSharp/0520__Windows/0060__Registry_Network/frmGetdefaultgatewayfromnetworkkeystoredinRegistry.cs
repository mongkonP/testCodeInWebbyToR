using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0060__Registry_Network
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetdefaultgatewayfromnetworkkeystoredinRegistry.htm
    public partial  class frmGetdefaultgatewayfromnetworkkeystoredinRegistry:Form
    {
        public frmGetdefaultgatewayfromnetworkkeystoredinRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetdefaultgatewayfromnetworkkeystoredinRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetdefaultgatewayfromnetworkkeystoredinRegistry";
            this.Text = "frmGetdefaultgatewayfromnetworkkeystoredinRegistry";
            this.Load += new System.EventHandler(this.frmGetdefaultgatewayfromnetworkkeystoredinRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetdefaultgatewayfromnetworkkeystoredinRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
