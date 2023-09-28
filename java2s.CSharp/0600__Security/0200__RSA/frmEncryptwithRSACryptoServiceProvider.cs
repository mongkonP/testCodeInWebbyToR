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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/EncryptwithRSACryptoServiceProvider.htm
    public partial  class frmEncryptwithRSACryptoServiceProvider:Form
    {
        public frmEncryptwithRSACryptoServiceProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEncryptwithRSACryptoServiceProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEncryptwithRSACryptoServiceProvider";
            this.Text = "frmEncryptwithRSACryptoServiceProvider";
            this.Load += new System.EventHandler(this.frmEncryptwithRSACryptoServiceProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmEncryptwithRSACryptoServiceProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
