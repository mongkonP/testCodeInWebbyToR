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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/CspParametersandRSACryptoServiceProvider.htm
    public partial  class frmCspParametersandRSACryptoServiceProvider:Form
    {
        public frmCspParametersandRSACryptoServiceProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCspParametersandRSACryptoServiceProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCspParametersandRSACryptoServiceProvider";
            this.Text = "frmCspParametersandRSACryptoServiceProvider";
            this.Load += new System.EventHandler(this.frmCspParametersandRSACryptoServiceProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmCspParametersandRSACryptoServiceProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
