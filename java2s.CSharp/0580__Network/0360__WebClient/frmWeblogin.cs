using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0360__WebClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Weblogin.htm
    public partial  class frmWeblogin:Form
    {
        public frmWeblogin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWeblogin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWeblogin";
            this.Text = "frmWeblogin";
            this.Load += new System.EventHandler(this.frmWeblogin_Load);
            this.ResumeLayout(false);

        }

        private void frmWeblogin_Load(object sender, EventArgs e)
        {

        }
    }
}
