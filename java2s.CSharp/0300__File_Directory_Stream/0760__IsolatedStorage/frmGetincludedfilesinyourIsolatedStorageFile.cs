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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/GetincludedfilesinyourIsolatedStorageFile.htm
    public partial  class frmGetincludedfilesinyourIsolatedStorageFile:Form
    {
        public frmGetincludedfilesinyourIsolatedStorageFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetincludedfilesinyourIsolatedStorageFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetincludedfilesinyourIsolatedStorageFile";
            this.Text = "frmGetincludedfilesinyourIsolatedStorageFile";
            this.Load += new System.EventHandler(this.frmGetincludedfilesinyourIsolatedStorageFile_Load);
            this.ResumeLayout(false);

        }

        private void frmGetincludedfilesinyourIsolatedStorageFile_Load(object sender, EventArgs e)
        {

        }
    }
}
