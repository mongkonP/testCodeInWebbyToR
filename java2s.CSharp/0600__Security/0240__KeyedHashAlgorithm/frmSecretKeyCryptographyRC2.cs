using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0240__KeyedHashAlgorithm
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/SecretKeyCryptographyRC2.htm
    public partial  class frmSecretKeyCryptographyRC2:Form
    {
        public frmSecretKeyCryptographyRC2()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSecretKeyCryptographyRC2
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSecretKeyCryptographyRC2";
            this.Text = "frmSecretKeyCryptographyRC2";
            this.Load += new System.EventHandler(this.frmSecretKeyCryptographyRC2_Load);
            this.ResumeLayout(false);

        }

        private void frmSecretKeyCryptographyRC2_Load(object sender, EventArgs e)
        {

        }
    }
}
