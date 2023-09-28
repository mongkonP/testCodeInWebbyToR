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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/SecretKeyCryptographyDES.htm
    public partial  class frmSecretKeyCryptographyDES:Form
    {
        public frmSecretKeyCryptographyDES()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSecretKeyCryptographyDES
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSecretKeyCryptographyDES";
            this.Text = "frmSecretKeyCryptographyDES";
            this.Load += new System.EventHandler(this.frmSecretKeyCryptographyDES_Load);
            this.ResumeLayout(false);

        }

        private void frmSecretKeyCryptographyDES_Load(object sender, EventArgs e)
        {

        }
    }
}
