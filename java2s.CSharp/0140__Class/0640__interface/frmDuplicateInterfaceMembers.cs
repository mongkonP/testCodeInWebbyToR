using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0640__interface
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/DuplicateInterfaceMembers.htm
    public partial  class frmDuplicateInterfaceMembers:Form
    {
        public frmDuplicateInterfaceMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDuplicateInterfaceMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDuplicateInterfaceMembers";
            this.Text = "frmDuplicateInterfaceMembers";
            this.Load += new System.EventHandler(this.frmDuplicateInterfaceMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmDuplicateInterfaceMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
