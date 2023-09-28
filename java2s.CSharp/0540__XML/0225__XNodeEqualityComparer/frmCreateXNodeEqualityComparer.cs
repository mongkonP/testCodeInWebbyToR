using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0225__XNodeEqualityComparer
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/CreateXNodeEqualityComparer.htm
    public partial  class frmCreateXNodeEqualityComparer:Form
    {
        public frmCreateXNodeEqualityComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateXNodeEqualityComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateXNodeEqualityComparer";
            this.Text = "frmCreateXNodeEqualityComparer";
            this.Load += new System.EventHandler(this.frmCreateXNodeEqualityComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateXNodeEqualityComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
