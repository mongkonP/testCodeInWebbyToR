using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0120__Socket_Server
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UsebackgroundthreadtodealwiththeServersocket.htm
    public partial  class frmUsebackgroundthreadtodealwiththeServersocket:Form
    {
        public frmUsebackgroundthreadtodealwiththeServersocket()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsebackgroundthreadtodealwiththeServersocket
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsebackgroundthreadtodealwiththeServersocket";
            this.Text = "frmUsebackgroundthreadtodealwiththeServersocket";
            this.Load += new System.EventHandler(this.frmUsebackgroundthreadtodealwiththeServersocket_Load);
            this.ResumeLayout(false);

        }

        private void frmUsebackgroundthreadtodealwiththeServersocket_Load(object sender, EventArgs e)
        {

        }
    }
}
