using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0760__IsolatedStorage
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateDirectoryinyourIsolatedStorageFile.htm
    public partial  class frmCreateDirectoryinyourIsolatedStorageFile:Form
    {
        public frmCreateDirectoryinyourIsolatedStorageFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateDirectoryinyourIsolatedStorageFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateDirectoryinyourIsolatedStorageFile";
            this.Text = "frmCreateDirectoryinyourIsolatedStorageFile";
            this.Load += new System.EventHandler(this.frmCreateDirectoryinyourIsolatedStorageFile_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateDirectoryinyourIsolatedStorageFile_Load(object sender, EventArgs e)
        {

        }
    }
}
