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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseFileSystemWatchertodetectfilechanges.htm
    public partial  class frmUseFileSystemWatchertodetectfilechanges:Form
    {
        public frmUseFileSystemWatchertodetectfilechanges()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseFileSystemWatchertodetectfilechanges
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseFileSystemWatchertodetectfilechanges";
            this.Text = "frmUseFileSystemWatchertodetectfilechanges";
            this.Load += new System.EventHandler(this.frmUseFileSystemWatchertodetectfilechanges_Load);
            this.ResumeLayout(false);

        }

        private void frmUseFileSystemWatchertodetectfilechanges_Load(object sender, EventArgs e)
        {

        }
    }
}
