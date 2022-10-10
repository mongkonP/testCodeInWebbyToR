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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectAllChildNodes.htm
    public partial  class frmSelectAllChildNodes:Form
    {
        public frmSelectAllChildNodes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectAllChildNodes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectAllChildNodes";
            this.Text = "frmSelectAllChildNodes";
            this.Load += new System.EventHandler(this.frmSelectAllChildNodes_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectAllChildNodes_Load(object sender, EventArgs e)
        {

        }
    }
}
