using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0080__Socket
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DisplaytheconnectedclientIPaddress.htm
    public partial  class frmDisplaytheconnectedclientIPaddress:Form
    {
        public frmDisplaytheconnectedclientIPaddress()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaytheconnectedclientIPaddress
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaytheconnectedclientIPaddress";
            this.Text = "frmDisplaytheconnectedclientIPaddress";
            this.Load += new System.EventHandler(this.frmDisplaytheconnectedclientIPaddress_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaytheconnectedclientIPaddress_Load(object sender, EventArgs e)
        {

        }
    }
}
