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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsynchronousInvocationOfDelegates.htm
    public partial  class frmAsynchronousInvocationOfDelegates:Form
    {
        public frmAsynchronousInvocationOfDelegates()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousInvocationOfDelegates
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousInvocationOfDelegates";
            this.Text = "frmAsynchronousInvocationOfDelegates";
            this.Load += new System.EventHandler(this.frmAsynchronousInvocationOfDelegates_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousInvocationOfDelegates_Load(object sender, EventArgs e)
        {

        }
    }
}
