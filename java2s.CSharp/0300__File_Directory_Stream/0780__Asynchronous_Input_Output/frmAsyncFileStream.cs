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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AsyncFileStream.htm
    public partial  class frmAsyncFileStream:Form
    {
        public frmAsyncFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsyncFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsyncFileStream";
            this.Text = "frmAsyncFileStream";
            this.Load += new System.EventHandler(this.frmAsyncFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmAsyncFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
