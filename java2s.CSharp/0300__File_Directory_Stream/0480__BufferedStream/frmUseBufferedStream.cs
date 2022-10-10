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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseBufferedStream.htm
    public partial  class frmUseBufferedStream:Form
    {
        public frmUseBufferedStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseBufferedStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseBufferedStream";
            this.Text = "frmUseBufferedStream";
            this.Load += new System.EventHandler(this.frmUseBufferedStream_Load);
            this.ResumeLayout(false);

        }

        private void frmUseBufferedStream_Load(object sender, EventArgs e)
        {

        }
    }
}
