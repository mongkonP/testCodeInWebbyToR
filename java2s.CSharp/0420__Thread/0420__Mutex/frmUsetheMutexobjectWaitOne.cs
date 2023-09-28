using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0420__Mutex
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UsetheMutexobjectWaitOne.htm
    public partial  class frmUsetheMutexobjectWaitOne:Form
    {
        public frmUsetheMutexobjectWaitOne()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheMutexobjectWaitOne
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheMutexobjectWaitOne";
            this.Text = "frmUsetheMutexobjectWaitOne";
            this.Load += new System.EventHandler(this.frmUsetheMutexobjectWaitOne_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheMutexobjectWaitOne_Load(object sender, EventArgs e)
        {

        }
    }
}
