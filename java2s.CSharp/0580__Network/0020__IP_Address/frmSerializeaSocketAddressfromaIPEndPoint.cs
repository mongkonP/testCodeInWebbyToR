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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SerializeaSocketAddressfromaIPEndPoint.htm
    public partial  class frmSerializeaSocketAddressfromaIPEndPoint:Form
    {
        public frmSerializeaSocketAddressfromaIPEndPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSerializeaSocketAddressfromaIPEndPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSerializeaSocketAddressfromaIPEndPoint";
            this.Text = "frmSerializeaSocketAddressfromaIPEndPoint";
            this.Load += new System.EventHandler(this.frmSerializeaSocketAddressfromaIPEndPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmSerializeaSocketAddressfromaIPEndPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
