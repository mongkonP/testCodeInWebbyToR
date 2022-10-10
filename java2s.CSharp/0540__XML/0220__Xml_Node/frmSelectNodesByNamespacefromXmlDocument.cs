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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectNodesByNamespacefromXmlDocument.htm
    public partial  class frmSelectNodesByNamespacefromXmlDocument:Form
    {
        public frmSelectNodesByNamespacefromXmlDocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectNodesByNamespacefromXmlDocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectNodesByNamespacefromXmlDocument";
            this.Text = "frmSelectNodesByNamespacefromXmlDocument";
            this.Load += new System.EventHandler(this.frmSelectNodesByNamespacefromXmlDocument_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectNodesByNamespacefromXmlDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
