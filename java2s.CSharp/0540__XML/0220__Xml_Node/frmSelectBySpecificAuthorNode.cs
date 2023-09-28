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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectBySpecificAuthorNode.htm
    public partial  class frmSelectBySpecificAuthorNode:Form
    {
        public frmSelectBySpecificAuthorNode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectBySpecificAuthorNode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectBySpecificAuthorNode";
            this.Text = "frmSelectBySpecificAuthorNode";
            this.Load += new System.EventHandler(this.frmSelectBySpecificAuthorNode_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectBySpecificAuthorNode_Load(object sender, EventArgs e)
        {

        }
    }
}
