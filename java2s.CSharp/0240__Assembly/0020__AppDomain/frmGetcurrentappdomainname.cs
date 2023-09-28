using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0020__AppDomain
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Getcurrentappdomainname.htm
    public partial  class frmGetcurrentappdomainname:Form
    {
        public frmGetcurrentappdomainname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetcurrentappdomainname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetcurrentappdomainname";
            this.Text = "frmGetcurrentappdomainname";
            this.Load += new System.EventHandler(this.frmGetcurrentappdomainname_Load);
            this.ResumeLayout(false);

        }

        private void frmGetcurrentappdomainname_Load(object sender, EventArgs e)
        {

        }
    }
}
