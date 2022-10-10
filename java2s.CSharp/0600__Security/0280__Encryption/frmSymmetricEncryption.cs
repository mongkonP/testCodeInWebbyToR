using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0280__Encryption
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/SymmetricEncryption.htm
    public partial  class frmSymmetricEncryption:Form
    {
        public frmSymmetricEncryption()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSymmetricEncryption
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSymmetricEncryption";
            this.Text = "frmSymmetricEncryption";
            this.Load += new System.EventHandler(this.frmSymmetricEncryption_Load);
            this.ResumeLayout(false);

        }

        private void frmSymmetricEncryption_Load(object sender, EventArgs e)
        {

        }
    }
}
