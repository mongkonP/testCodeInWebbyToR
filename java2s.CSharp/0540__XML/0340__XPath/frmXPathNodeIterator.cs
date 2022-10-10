using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0340__XPath
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XPathNodeIterator.htm
    public partial  class frmXPathNodeIterator:Form
    {
        public frmXPathNodeIterator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXPathNodeIterator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXPathNodeIterator";
            this.Text = "frmXPathNodeIterator";
            this.Load += new System.EventHandler(this.frmXPathNodeIterator_Load);
            this.ResumeLayout(false);

        }

        private void frmXPathNodeIterator_Load(object sender, EventArgs e)
        {

        }
    }
}
