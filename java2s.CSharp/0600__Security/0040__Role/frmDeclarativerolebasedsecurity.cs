using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0040__Role
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Declarativerolebasedsecurity.htm
    public partial  class frmDeclarativerolebasedsecurity:Form
    {
        public frmDeclarativerolebasedsecurity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclarativerolebasedsecurity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclarativerolebasedsecurity";
            this.Text = "frmDeclarativerolebasedsecurity";
            this.Load += new System.EventHandler(this.frmDeclarativerolebasedsecurity_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclarativerolebasedsecurity_Load(object sender, EventArgs e)
        {

        }
    }
}
