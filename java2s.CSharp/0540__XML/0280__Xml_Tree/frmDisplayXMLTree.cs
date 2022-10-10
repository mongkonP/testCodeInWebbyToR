using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0280__Xml_Tree
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/DisplayXMLTree.htm
    public partial  class frmDisplayXMLTree:Form
    {
        public frmDisplayXMLTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayXMLTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayXMLTree";
            this.Text = "frmDisplayXMLTree";
            this.Load += new System.EventHandler(this.frmDisplayXMLTree_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayXMLTree_Load(object sender, EventArgs e)
        {

        }
    }
}
