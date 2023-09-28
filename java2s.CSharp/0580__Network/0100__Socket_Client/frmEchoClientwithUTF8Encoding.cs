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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/EchoClientwithUTF8Encoding.htm
    public partial  class frmEchoClientwithUTF8Encoding:Form
    {
        public frmEchoClientwithUTF8Encoding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEchoClientwithUTF8Encoding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEchoClientwithUTF8Encoding";
            this.Text = "frmEchoClientwithUTF8Encoding";
            this.Load += new System.EventHandler(this.frmEchoClientwithUTF8Encoding_Load);
            this.ResumeLayout(false);

        }

        private void frmEchoClientwithUTF8Encoding_Load(object sender, EventArgs e)
        {

        }
    }
}
