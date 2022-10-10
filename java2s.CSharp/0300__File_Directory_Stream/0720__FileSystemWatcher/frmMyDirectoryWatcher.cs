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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/MyDirectoryWatcher.htm
    public partial  class frmMyDirectoryWatcher:Form
    {
        public frmMyDirectoryWatcher()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMyDirectoryWatcher
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMyDirectoryWatcher";
            this.Text = "frmMyDirectoryWatcher";
            this.Load += new System.EventHandler(this.frmMyDirectoryWatcher_Load);
            this.ResumeLayout(false);

        }

        private void frmMyDirectoryWatcher_Load(object sender, EventArgs e)
        {

        }
    }
}
