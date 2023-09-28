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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/CommunicatingDatatoaThread.htm
    public partial  class frmCommunicatingDatatoaThread:Form
    {
        public frmCommunicatingDatatoaThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCommunicatingDatatoaThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCommunicatingDatatoaThread";
            this.Text = "frmCommunicatingDatatoaThread";
            this.Load += new System.EventHandler(this.frmCommunicatingDatatoaThread_Load);
            this.ResumeLayout(false);

        }

        private void frmCommunicatingDatatoaThread_Load(object sender, EventArgs e)
        {

        }
    }
}
