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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Acceptingasocketconnectionsimplefileserver.htm
    public partial  class frmAcceptingasocketconnectionsimplefileserver:Form
    {
        public frmAcceptingasocketconnectionsimplefileserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAcceptingasocketconnectionsimplefileserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAcceptingasocketconnectionsimplefileserver";
            this.Text = "frmAcceptingasocketconnectionsimplefileserver";
            this.Load += new System.EventHandler(this.frmAcceptingasocketconnectionsimplefileserver_Load);
            this.ResumeLayout(false);

        }

        private void frmAcceptingasocketconnectionsimplefileserver_Load(object sender, EventArgs e)
        {

        }
    }
}
