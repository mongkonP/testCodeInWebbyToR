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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AsynchronousIOsomeblockingonthemainthread.htm
    public partial  class frmAsynchronousIOsomeblockingonthemainthread:Form
    {
        public frmAsynchronousIOsomeblockingonthemainthread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousIOsomeblockingonthemainthread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousIOsomeblockingonthemainthread";
            this.Text = "frmAsynchronousIOsomeblockingonthemainthread";
            this.Load += new System.EventHandler(this.frmAsynchronousIOsomeblockingonthemainthread_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousIOsomeblockingonthemainthread_Load(object sender, EventArgs e)
        {

        }
    }
}
