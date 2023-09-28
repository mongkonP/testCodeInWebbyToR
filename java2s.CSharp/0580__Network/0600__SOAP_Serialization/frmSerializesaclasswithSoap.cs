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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SerializesaclasswithSoap.htm
    public partial  class frmSerializesaclasswithSoap:Form
    {
        public frmSerializesaclasswithSoap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSerializesaclasswithSoap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSerializesaclasswithSoap";
            this.Text = "frmSerializesaclasswithSoap";
            this.Load += new System.EventHandler(this.frmSerializesaclasswithSoap_Load);
            this.ResumeLayout(false);

        }

        private void frmSerializesaclasswithSoap_Load(object sender, EventArgs e)
        {

        }
    }
}
