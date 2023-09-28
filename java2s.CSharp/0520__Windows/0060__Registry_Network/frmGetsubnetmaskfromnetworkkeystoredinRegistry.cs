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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetsubnetmaskfromnetworkkeystoredinRegistry.htm
    public partial  class frmGetsubnetmaskfromnetworkkeystoredinRegistry:Form
    {
        public frmGetsubnetmaskfromnetworkkeystoredinRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetsubnetmaskfromnetworkkeystoredinRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetsubnetmaskfromnetworkkeystoredinRegistry";
            this.Text = "frmGetsubnetmaskfromnetworkkeystoredinRegistry";
            this.Load += new System.EventHandler(this.frmGetsubnetmaskfromnetworkkeystoredinRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetsubnetmaskfromnetworkkeystoredinRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
