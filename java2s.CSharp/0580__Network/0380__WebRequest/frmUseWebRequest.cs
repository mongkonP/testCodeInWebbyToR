using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0380__WebRequest
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseWebRequest.htm
    public partial  class frmUseWebRequest:Form
    {
        public frmUseWebRequest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseWebRequest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseWebRequest";
            this.Text = "frmUseWebRequest";
            this.Load += new System.EventHandler(this.frmUseWebRequest_Load);
            this.ResumeLayout(false);

        }

        private void frmUseWebRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
