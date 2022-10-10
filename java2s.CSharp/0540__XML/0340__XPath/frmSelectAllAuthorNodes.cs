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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectAllAuthorNodes.htm
    public partial  class frmSelectAllAuthorNodes:Form
    {
        public frmSelectAllAuthorNodes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectAllAuthorNodes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectAllAuthorNodes";
            this.Text = "frmSelectAllAuthorNodes";
            this.Load += new System.EventHandler(this.frmSelectAllAuthorNodes_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectAllAuthorNodes_Load(object sender, EventArgs e)
        {

        }
    }
}
