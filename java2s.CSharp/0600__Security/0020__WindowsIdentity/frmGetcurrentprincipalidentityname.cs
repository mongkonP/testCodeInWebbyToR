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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Getcurrentprincipalidentityname.htm
    public partial  class frmGetcurrentprincipalidentityname:Form
    {
        public frmGetcurrentprincipalidentityname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetcurrentprincipalidentityname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetcurrentprincipalidentityname";
            this.Text = "frmGetcurrentprincipalidentityname";
            this.Load += new System.EventHandler(this.frmGetcurrentprincipalidentityname_Load);
            this.ResumeLayout(false);

        }

        private void frmGetcurrentprincipalidentityname_Load(object sender, EventArgs e)
        {

        }
    }
}
