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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileSystemWatcherDemo.htm
    public partial  class frmFileSystemWatcherDemo:Form
    {
        public frmFileSystemWatcherDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileSystemWatcherDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileSystemWatcherDemo";
            this.Text = "frmFileSystemWatcherDemo";
            this.Load += new System.EventHandler(this.frmFileSystemWatcherDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmFileSystemWatcherDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
