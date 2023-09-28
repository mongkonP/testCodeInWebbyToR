using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0020__IP_Address
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/IPEndPointMinPortandMaxPort.htm
    public partial  class frmIPEndPointMinPortandMaxPort:Form
    {
        public frmIPEndPointMinPortandMaxPort()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIPEndPointMinPortandMaxPort
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIPEndPointMinPortandMaxPort";
            this.Text = "frmIPEndPointMinPortandMaxPort";
            this.Load += new System.EventHandler(this.frmIPEndPointMinPortandMaxPort_Load);
            this.ResumeLayout(false);

        }

        private void frmIPEndPointMinPortandMaxPort_Load(object sender, EventArgs e)
        {

        }
    }
}
