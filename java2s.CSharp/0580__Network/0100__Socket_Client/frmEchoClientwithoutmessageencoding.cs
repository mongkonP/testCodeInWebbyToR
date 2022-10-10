using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0100__Socket_Client
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/EchoClientwithoutmessageencoding.htm
    public partial  class frmEchoClientwithoutmessageencoding:Form
    {
        public frmEchoClientwithoutmessageencoding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEchoClientwithoutmessageencoding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEchoClientwithoutmessageencoding";
            this.Text = "frmEchoClientwithoutmessageencoding";
            this.Load += new System.EventHandler(this.frmEchoClientwithoutmessageencoding_Load);
            this.ResumeLayout(false);

        }

        private void frmEchoClientwithoutmessageencoding_Load(object sender, EventArgs e)
        {

        }
    }
}
