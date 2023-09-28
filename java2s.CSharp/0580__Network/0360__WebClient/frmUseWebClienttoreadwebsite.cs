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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseWebClienttoreadwebsite.htm
    public partial  class frmUseWebClienttoreadwebsite:Form
    {
        public frmUseWebClienttoreadwebsite()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseWebClienttoreadwebsite
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseWebClienttoreadwebsite";
            this.Text = "frmUseWebClienttoreadwebsite";
            this.Load += new System.EventHandler(this.frmUseWebClienttoreadwebsite_Load);
            this.ResumeLayout(false);

        }

        private void frmUseWebClienttoreadwebsite_Load(object sender, EventArgs e)
        {

        }
    }
}
