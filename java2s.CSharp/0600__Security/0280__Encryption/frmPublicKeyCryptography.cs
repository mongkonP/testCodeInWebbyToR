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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/PublicKeyCryptography.htm
    public partial  class frmPublicKeyCryptography:Form
    {
        public frmPublicKeyCryptography()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPublicKeyCryptography
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPublicKeyCryptography";
            this.Text = "frmPublicKeyCryptography";
            this.Load += new System.EventHandler(this.frmPublicKeyCryptography_Load);
            this.ResumeLayout(false);

        }

        private void frmPublicKeyCryptography_Load(object sender, EventArgs e)
        {

        }
    }
}
