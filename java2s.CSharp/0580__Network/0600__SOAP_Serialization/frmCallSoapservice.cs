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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CallSoapservice.htm
    public partial  class frmCallSoapservice:Form
    {
        public frmCallSoapservice()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallSoapservice
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallSoapservice";
            this.Text = "frmCallSoapservice";
            this.Load += new System.EventHandler(this.frmCallSoapservice_Load);
            this.ResumeLayout(false);

        }

        private void frmCallSoapservice_Load(object sender, EventArgs e)
        {

        }
    }
}
