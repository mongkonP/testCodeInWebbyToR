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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/GetandsetdatatoAppDomain.htm
    public partial  class frmGetandsetdatatoAppDomain:Form
    {
        public frmGetandsetdatatoAppDomain()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetandsetdatatoAppDomain
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetandsetdatatoAppDomain";
            this.Text = "frmGetandsetdatatoAppDomain";
            this.Load += new System.EventHandler(this.frmGetandsetdatatoAppDomain_Load);
            this.ResumeLayout(false);

        }

        private void frmGetandsetdatatoAppDomain_Load(object sender, EventArgs e)
        {

        }
    }
}
