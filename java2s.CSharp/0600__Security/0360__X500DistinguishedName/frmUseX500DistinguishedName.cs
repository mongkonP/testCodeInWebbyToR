using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0360__X500DistinguishedName
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/UseX500DistinguishedName.htm
    public partial  class frmUseX500DistinguishedName:Form
    {
        public frmUseX500DistinguishedName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseX500DistinguishedName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseX500DistinguishedName";
            this.Text = "frmUseX500DistinguishedName";
            this.Load += new System.EventHandler(this.frmUseX500DistinguishedName_Load);
            this.ResumeLayout(false);

        }

        private void frmUseX500DistinguishedName_Load(object sender, EventArgs e)
        {

        }
    }
}
