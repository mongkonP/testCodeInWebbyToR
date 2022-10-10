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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Testifthecurrentassemblyhasthespecifiedpermission.htm
    public partial  class frmTestifthecurrentassemblyhasthespecifiedpermission:Form
    {
        public frmTestifthecurrentassemblyhasthespecifiedpermission()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTestifthecurrentassemblyhasthespecifiedpermission
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTestifthecurrentassemblyhasthespecifiedpermission";
            this.Text = "frmTestifthecurrentassemblyhasthespecifiedpermission";
            this.Load += new System.EventHandler(this.frmTestifthecurrentassemblyhasthespecifiedpermission_Load);
            this.ResumeLayout(false);

        }

        private void frmTestifthecurrentassemblyhasthespecifiedpermission_Load(object sender, EventArgs e)
        {

        }
    }
}
