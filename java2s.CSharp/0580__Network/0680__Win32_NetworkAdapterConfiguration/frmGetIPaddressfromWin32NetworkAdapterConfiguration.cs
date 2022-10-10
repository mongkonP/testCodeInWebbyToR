using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0680__Win32_NetworkAdapterConfiguration
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetIPaddressfromWin32NetworkAdapterConfiguration.htm
    public partial  class frmGetIPaddressfromWin32NetworkAdapterConfiguration:Form
    {
        public frmGetIPaddressfromWin32NetworkAdapterConfiguration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetIPaddressfromWin32NetworkAdapterConfiguration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetIPaddressfromWin32NetworkAdapterConfiguration";
            this.Text = "frmGetIPaddressfromWin32NetworkAdapterConfiguration";
            this.Load += new System.EventHandler(this.frmGetIPaddressfromWin32NetworkAdapterConfiguration_Load);
            this.ResumeLayout(false);

        }

        private void frmGetIPaddressfromWin32NetworkAdapterConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
