using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseanonymousdelegateastheworkermethodtocreateThread.htm
    public partial  class frmUseanonymousdelegateastheworkermethodtocreateThread:Form
    {
        public frmUseanonymousdelegateastheworkermethodtocreateThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseanonymousdelegateastheworkermethodtocreateThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseanonymousdelegateastheworkermethodtocreateThread";
            this.Text = "frmUseanonymousdelegateastheworkermethodtocreateThread";
            this.Load += new System.EventHandler(this.frmUseanonymousdelegateastheworkermethodtocreateThread_Load);
            this.ResumeLayout(false);

        }

        private void frmUseanonymousdelegateastheworkermethodtocreateThread_Load(object sender, EventArgs e)
        {

        }
    }
}
