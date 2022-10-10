using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0220__Xml_Node
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectnodesfromXmlDocument.htm
    public partial  class frmSelectnodesfromXmlDocument:Form
    {
        public frmSelectnodesfromXmlDocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectnodesfromXmlDocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectnodesfromXmlDocument";
            this.Text = "frmSelectnodesfromXmlDocument";
            this.Load += new System.EventHandler(this.frmSelectnodesfromXmlDocument_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectnodesfromXmlDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
