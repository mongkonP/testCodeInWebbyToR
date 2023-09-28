using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0080__Permissions
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/PrincipalPolicyIntersectUnion.htm
    public partial  class frmPrincipalPolicyIntersectUnion:Form
    {
        public frmPrincipalPolicyIntersectUnion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrincipalPolicyIntersectUnion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrincipalPolicyIntersectUnion";
            this.Text = "frmPrincipalPolicyIntersectUnion";
            this.Load += new System.EventHandler(this.frmPrincipalPolicyIntersectUnion_Load);
            this.ResumeLayout(false);

        }

        private void frmPrincipalPolicyIntersectUnion_Load(object sender, EventArgs e)
        {

        }
    }
}
