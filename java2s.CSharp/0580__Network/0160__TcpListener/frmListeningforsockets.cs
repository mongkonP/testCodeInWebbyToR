using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0160__TcpListener
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Listeningforsockets.htm
    public partial  class frmListeningforsockets:Form
    {
        public frmListeningforsockets()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListeningforsockets
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListeningforsockets";
            this.Text = "frmListeningforsockets";
            this.Load += new System.EventHandler(this.frmListeningforsockets_Load);
            this.ResumeLayout(false);

        }

        private void frmListeningforsockets_Load(object sender, EventArgs e)
        {

        }
    }
}
