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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetNetworkCardInformationfromRegistry.htm
    public partial  class frmGetNetworkCardInformationfromRegistry:Form
    {
        public frmGetNetworkCardInformationfromRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetNetworkCardInformationfromRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetNetworkCardInformationfromRegistry";
            this.Text = "frmGetNetworkCardInformationfromRegistry";
            this.Load += new System.EventHandler(this.frmGetNetworkCardInformationfromRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetNetworkCardInformationfromRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
