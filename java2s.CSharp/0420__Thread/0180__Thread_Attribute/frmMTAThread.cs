using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0180__Thread_Attribute
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/MTAThread.htm
    public partial  class frmMTAThread:Form
    {
        public frmMTAThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMTAThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMTAThread";
            this.Text = "frmMTAThread";
            this.Load += new System.EventHandler(this.frmMTAThread_Load);
            this.ResumeLayout(false);

        }

        private void frmMTAThread_Load(object sender, EventArgs e)
        {

        }
    }
}
