using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0420__HttpWebRequest
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/AccesstheInternet.htm
    public partial  class frmAccesstheInternet:Form
    {
        public frmAccesstheInternet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccesstheInternet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccesstheInternet";
            this.Text = "frmAccesstheInternet";
            this.Load += new System.EventHandler(this.frmAccesstheInternet_Load);
            this.ResumeLayout(false);

        }

        private void frmAccesstheInternet_Load(object sender, EventArgs e)
        {

        }
    }
}
