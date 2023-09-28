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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XPathSelectNodes.htm
    public partial  class frmXPathSelectNodes:Form
    {
        public frmXPathSelectNodes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXPathSelectNodes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXPathSelectNodes";
            this.Text = "frmXPathSelectNodes";
            this.Load += new System.EventHandler(this.frmXPathSelectNodes_Load);
            this.ResumeLayout(false);

        }

        private void frmXPathSelectNodes_Load(object sender, EventArgs e)
        {

        }
    }
}
