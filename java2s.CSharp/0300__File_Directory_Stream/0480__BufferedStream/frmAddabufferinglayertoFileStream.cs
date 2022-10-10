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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AddabufferinglayertoFileStream.htm
    public partial  class frmAddabufferinglayertoFileStream:Form
    {
        public frmAddabufferinglayertoFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddabufferinglayertoFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddabufferinglayertoFileStream";
            this.Text = "frmAddabufferinglayertoFileStream";
            this.Load += new System.EventHandler(this.frmAddabufferinglayertoFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmAddabufferinglayertoFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
