using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0400__StreamReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateStreamReaderthroughFileStream.htm
    public partial  class frmCreateStreamReaderthroughFileStream:Form
    {
        public frmCreateStreamReaderthroughFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateStreamReaderthroughFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateStreamReaderthroughFileStream";
            this.Text = "frmCreateStreamReaderthroughFileStream";
            this.Load += new System.EventHandler(this.frmCreateStreamReaderthroughFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateStreamReaderthroughFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
