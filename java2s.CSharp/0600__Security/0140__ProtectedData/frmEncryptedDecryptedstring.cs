using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0140__ProtectedData
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/EncryptedDecryptedstring.htm
    public partial  class frmEncryptedDecryptedstring:Form
    {
        public frmEncryptedDecryptedstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEncryptedDecryptedstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEncryptedDecryptedstring";
            this.Text = "frmEncryptedDecryptedstring";
            this.Load += new System.EventHandler(this.frmEncryptedDecryptedstring_Load);
            this.ResumeLayout(false);

        }

        private void frmEncryptedDecryptedstring_Load(object sender, EventArgs e)
        {

        }
    }
}
