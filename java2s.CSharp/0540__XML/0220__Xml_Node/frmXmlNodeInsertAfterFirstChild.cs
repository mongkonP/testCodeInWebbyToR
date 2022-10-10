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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XmlNodeInsertAfterFirstChild.htm
    public partial  class frmXmlNodeInsertAfterFirstChild:Form
    {
        public frmXmlNodeInsertAfterFirstChild()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXmlNodeInsertAfterFirstChild
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXmlNodeInsertAfterFirstChild";
            this.Text = "frmXmlNodeInsertAfterFirstChild";
            this.Load += new System.EventHandler(this.frmXmlNodeInsertAfterFirstChild_Load);
            this.ResumeLayout(false);

        }

        private void frmXmlNodeInsertAfterFirstChild_Load(object sender, EventArgs e)
        {

        }
    }
}
