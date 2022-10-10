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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ReadandwritewithIsolatedStorageFileStream.htm
    public partial  class frmReadandwritewithIsolatedStorageFileStream:Form
    {
        public frmReadandwritewithIsolatedStorageFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadandwritewithIsolatedStorageFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadandwritewithIsolatedStorageFileStream";
            this.Text = "frmReadandwritewithIsolatedStorageFileStream";
            this.Load += new System.EventHandler(this.frmReadandwritewithIsolatedStorageFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmReadandwritewithIsolatedStorageFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
