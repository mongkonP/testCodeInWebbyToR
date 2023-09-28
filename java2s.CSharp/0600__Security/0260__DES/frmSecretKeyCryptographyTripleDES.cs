using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0260__DES
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/SecretKeyCryptographyTripleDES.htm
    public partial  class frmSecretKeyCryptographyTripleDES:Form
    {
        public frmSecretKeyCryptographyTripleDES()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSecretKeyCryptographyTripleDES
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSecretKeyCryptographyTripleDES";
            this.Text = "frmSecretKeyCryptographyTripleDES";
            this.Load += new System.EventHandler(this.frmSecretKeyCryptographyTripleDES_Load);
            this.ResumeLayout(false);

        }

        private void frmSecretKeyCryptographyTripleDES_Load(object sender, EventArgs e)
        {

        }
    }
}
