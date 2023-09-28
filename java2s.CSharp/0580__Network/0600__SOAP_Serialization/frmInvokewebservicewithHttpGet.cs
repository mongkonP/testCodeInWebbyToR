using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0600__SOAP_Serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/InvokewebservicewithHttpGet.htm
    public partial  class frmInvokewebservicewithHttpGet:Form
    {
        public frmInvokewebservicewithHttpGet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokewebservicewithHttpGet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokewebservicewithHttpGet";
            this.Text = "frmInvokewebservicewithHttpGet";
            this.Load += new System.EventHandler(this.frmInvokewebservicewithHttpGet_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokewebservicewithHttpGet_Load(object sender, EventArgs e)
        {

        }
    }
}
