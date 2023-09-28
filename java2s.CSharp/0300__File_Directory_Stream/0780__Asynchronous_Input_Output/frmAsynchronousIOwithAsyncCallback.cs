using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0780__Asynchronous_Input_Output
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AsynchronousIOwithAsyncCallback.htm
    public partial  class frmAsynchronousIOwithAsyncCallback:Form
    {
        public frmAsynchronousIOwithAsyncCallback()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousIOwithAsyncCallback
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousIOwithAsyncCallback";
            this.Text = "frmAsynchronousIOwithAsyncCallback";
            this.Load += new System.EventHandler(this.frmAsynchronousIOwithAsyncCallback_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousIOwithAsyncCallback_Load(object sender, EventArgs e)
        {

        }
    }
}
