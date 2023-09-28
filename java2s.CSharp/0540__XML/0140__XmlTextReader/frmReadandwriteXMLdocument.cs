using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0140__XmlTextReader
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadandwriteXMLdocument.htm
    public partial  class frmReadandwriteXMLdocument:Form
    {
        public frmReadandwriteXMLdocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadandwriteXMLdocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadandwriteXMLdocument";
            this.Text = "frmReadandwriteXMLdocument";
            this.Load += new System.EventHandler(this.frmReadandwriteXMLdocument_Load);
            this.ResumeLayout(false);

        }

        private void frmReadandwriteXMLdocument_Load(object sender, EventArgs e)
        {

        }
    }
}
