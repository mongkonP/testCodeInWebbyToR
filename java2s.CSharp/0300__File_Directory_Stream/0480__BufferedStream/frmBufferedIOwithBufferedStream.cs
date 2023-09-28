using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0480__BufferedStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/BufferedIOwithBufferedStream.htm
    public partial  class frmBufferedIOwithBufferedStream:Form
    {
        public frmBufferedIOwithBufferedStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBufferedIOwithBufferedStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBufferedIOwithBufferedStream";
            this.Text = "frmBufferedIOwithBufferedStream";
            this.Load += new System.EventHandler(this.frmBufferedIOwithBufferedStream_Load);
            this.ResumeLayout(false);

        }

        private void frmBufferedIOwithBufferedStream_Load(object sender, EventArgs e)
        {

        }
    }
}
