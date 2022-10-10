using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AvailableworkerIOthreads.htm
    public partial  class frmAvailableworkerIOthreads:Form
    {
        public frmAvailableworkerIOthreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAvailableworkerIOthreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAvailableworkerIOthreads";
            this.Text = "frmAvailableworkerIOthreads";
            this.Load += new System.EventHandler(this.frmAvailableworkerIOthreads_Load);
            this.ResumeLayout(false);

        }

        private void frmAvailableworkerIOthreads_Load(object sender, EventArgs e)
        {

        }
    }
}
