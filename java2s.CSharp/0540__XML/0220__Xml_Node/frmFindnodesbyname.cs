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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/Findnodesbyname.htm
    public partial  class frmFindnodesbyname:Form
    {
        public frmFindnodesbyname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFindnodesbyname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFindnodesbyname";
            this.Text = "frmFindnodesbyname";
            this.Load += new System.EventHandler(this.frmFindnodesbyname_Load);
            this.ResumeLayout(false);

        }

        private void frmFindnodesbyname_Load(object sender, EventArgs e)
        {

        }
    }
}
