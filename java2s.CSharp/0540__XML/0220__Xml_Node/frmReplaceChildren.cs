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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReplaceChildren.htm
    public partial  class frmReplaceChildren:Form
    {
        public frmReplaceChildren()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReplaceChildren
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReplaceChildren";
            this.Text = "frmReplaceChildren";
            this.Load += new System.EventHandler(this.frmReplaceChildren_Load);
            this.ResumeLayout(false);

        }

        private void frmReplaceChildren_Load(object sender, EventArgs e)
        {

        }
    }
}
