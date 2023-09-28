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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetIPaddressfromnetworkkeystoredinRegistry.htm
    public partial  class frmGetIPaddressfromnetworkkeystoredinRegistry:Form
    {
        public frmGetIPaddressfromnetworkkeystoredinRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetIPaddressfromnetworkkeystoredinRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetIPaddressfromnetworkkeystoredinRegistry";
            this.Text = "frmGetIPaddressfromnetworkkeystoredinRegistry";
            this.Load += new System.EventHandler(this.frmGetIPaddressfromnetworkkeystoredinRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetIPaddressfromnetworkkeystoredinRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
