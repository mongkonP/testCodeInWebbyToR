using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0300__Xml_URL_Local_Name
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/GetXMLBaseURIandLocalName.htm
    public partial  class frmGetXMLBaseURIandLocalName:Form
    {
        public frmGetXMLBaseURIandLocalName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetXMLBaseURIandLocalName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetXMLBaseURIandLocalName";
            this.Text = "frmGetXMLBaseURIandLocalName";
            this.Load += new System.EventHandler(this.frmGetXMLBaseURIandLocalName_Load);
            this.ResumeLayout(false);

        }

        private void frmGetXMLBaseURIandLocalName_Load(object sender, EventArgs e)
        {

        }
    }
}
