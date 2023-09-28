using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0480__Xml_serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XmlSerializationforEnum.htm
    public partial  class frmXmlSerializationforEnum:Form
    {
        public frmXmlSerializationforEnum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXmlSerializationforEnum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXmlSerializationforEnum";
            this.Text = "frmXmlSerializationforEnum";
            this.Load += new System.EventHandler(this.frmXmlSerializationforEnum_Load);
            this.ResumeLayout(false);

        }

        private void frmXmlSerializationforEnum_Load(object sender, EventArgs e)
        {

        }
    }
}
