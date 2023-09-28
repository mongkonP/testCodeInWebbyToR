using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0200__RSA
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/UsingRSAPKCS1SignatureDeformatter.htm
    public partial  class frmUsingRSAPKCS1SignatureDeformatter:Form
    {
        public frmUsingRSAPKCS1SignatureDeformatter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingRSAPKCS1SignatureDeformatter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingRSAPKCS1SignatureDeformatter";
            this.Text = "frmUsingRSAPKCS1SignatureDeformatter";
            this.Load += new System.EventHandler(this.frmUsingRSAPKCS1SignatureDeformatter_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingRSAPKCS1SignatureDeformatter_Load(object sender, EventArgs e)
        {

        }
    }
}
