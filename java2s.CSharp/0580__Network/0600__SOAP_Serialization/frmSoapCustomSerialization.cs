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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SoapCustomSerialization.htm
    public partial  class frmSoapCustomSerialization:Form
    {
        public frmSoapCustomSerialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSoapCustomSerialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSoapCustomSerialization";
            this.Text = "frmSoapCustomSerialization";
            this.Load += new System.EventHandler(this.frmSoapCustomSerialization_Load);
            this.ResumeLayout(false);

        }

        private void frmSoapCustomSerialization_Load(object sender, EventArgs e)
        {

        }
    }
}
