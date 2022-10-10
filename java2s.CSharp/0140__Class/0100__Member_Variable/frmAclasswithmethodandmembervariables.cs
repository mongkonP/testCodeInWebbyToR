using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0100__Member_Variable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Aclasswithmethodandmembervariables.htm
    public partial  class frmAclasswithmethodandmembervariables:Form
    {
        public frmAclasswithmethodandmembervariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAclasswithmethodandmembervariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAclasswithmethodandmembervariables";
            this.Text = "frmAclasswithmethodandmembervariables";
            this.Load += new System.EventHandler(this.frmAclasswithmethodandmembervariables_Load);
            this.ResumeLayout(false);

        }

        private void frmAclasswithmethodandmembervariables_Load(object sender, EventArgs e)
        {

        }
    }
}
