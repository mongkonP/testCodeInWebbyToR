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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/UsingRSACryptoServiceProvider.htm
    public partial  class frmUsingRSACryptoServiceProvider:Form
    {
        public frmUsingRSACryptoServiceProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingRSACryptoServiceProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingRSACryptoServiceProvider";
            this.Text = "frmUsingRSACryptoServiceProvider";
            this.Load += new System.EventHandler(this.frmUsingRSACryptoServiceProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingRSACryptoServiceProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
