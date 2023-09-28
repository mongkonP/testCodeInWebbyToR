using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0720__FileSystemWatcher
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Watchingforfilesystemupdatessynchronous.htm
    public partial  class frmWatchingforfilesystemupdatessynchronous:Form
    {
        public frmWatchingforfilesystemupdatessynchronous()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWatchingforfilesystemupdatessynchronous
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWatchingforfilesystemupdatessynchronous";
            this.Text = "frmWatchingforfilesystemupdatessynchronous";
            this.Load += new System.EventHandler(this.frmWatchingforfilesystemupdatessynchronous_Load);
            this.ResumeLayout(false);

        }

        private void frmWatchingforfilesystemupdatessynchronous_Load(object sender, EventArgs e)
        {

        }
    }
}
