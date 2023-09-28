using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0480__Asynchronous
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsyncCallbackDelegate.htm
    public partial  class frmAsyncCallbackDelegate:Form
    {
        public frmAsyncCallbackDelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsyncCallbackDelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsyncCallbackDelegate";
            this.Text = "frmAsyncCallbackDelegate";
            this.Load += new System.EventHandler(this.frmAsyncCallbackDelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmAsyncCallbackDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
