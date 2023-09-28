using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0380__XmlPathNavigator
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/Selectanode.htm
    public partial  class frmSelectanode:Form
    {
        public frmSelectanode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectanode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectanode";
            this.Text = "frmSelectanode";
            this.Load += new System.EventHandler(this.frmSelectanode_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectanode_Load(object sender, EventArgs e)
        {

        }
    }
}
