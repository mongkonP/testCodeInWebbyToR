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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/STAThread.htm
    public partial  class frmSTAThread:Form
    {
        public frmSTAThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSTAThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSTAThread";
            this.Text = "frmSTAThread";
            this.Load += new System.EventHandler(this.frmSTAThread_Load);
            this.ResumeLayout(false);

        }

        private void frmSTAThread_Load(object sender, EventArgs e)
        {

        }
    }
}
