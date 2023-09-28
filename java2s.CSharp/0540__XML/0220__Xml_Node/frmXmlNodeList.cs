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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XmlNodeList.htm
    public partial  class frmXmlNodeList:Form
    {
        public frmXmlNodeList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXmlNodeList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXmlNodeList";
            this.Text = "frmXmlNodeList";
            this.Load += new System.EventHandler(this.frmXmlNodeList_Load);
            this.ResumeLayout(false);

        }

        private void frmXmlNodeList_Load(object sender, EventArgs e)
        {

        }
    }
}
