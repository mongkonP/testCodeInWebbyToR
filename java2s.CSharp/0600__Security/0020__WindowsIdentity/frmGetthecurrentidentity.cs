using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0020__WindowsIdentity
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Getthecurrentidentity.htm
    public partial  class frmGetthecurrentidentity:Form
    {
        public frmGetthecurrentidentity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthecurrentidentity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthecurrentidentity";
            this.Text = "frmGetthecurrentidentity";
            this.Load += new System.EventHandler(this.frmGetthecurrentidentity_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthecurrentidentity_Load(object sender, EventArgs e)
        {

        }
    }
}
