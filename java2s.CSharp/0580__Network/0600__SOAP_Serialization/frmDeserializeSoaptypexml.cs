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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DeserializeSoaptypexml.htm
    public partial  class frmDeserializeSoaptypexml:Form
    {
        public frmDeserializeSoaptypexml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeserializeSoaptypexml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeserializeSoaptypexml";
            this.Text = "frmDeserializeSoaptypexml";
            this.Load += new System.EventHandler(this.frmDeserializeSoaptypexml_Load);
            this.ResumeLayout(false);

        }

        private void frmDeserializeSoaptypexml_Load(object sender, EventArgs e)
        {

        }
    }
}
