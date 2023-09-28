using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0800__GZipStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CompressanduncompresswithGZipStream.htm
    public partial  class frmCompressanduncompresswithGZipStream:Form
    {
        public frmCompressanduncompresswithGZipStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompressanduncompresswithGZipStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompressanduncompresswithGZipStream";
            this.Text = "frmCompressanduncompresswithGZipStream";
            this.Load += new System.EventHandler(this.frmCompressanduncompresswithGZipStream_Load);
            this.ResumeLayout(false);

        }

        private void frmCompressanduncompresswithGZipStream_Load(object sender, EventArgs e)
        {

        }
    }
}
