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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/StreamReaderReadLine.htm
    public partial  class frmStreamReaderReadLine:Form
    {
        public frmStreamReaderReadLine()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStreamReaderReadLine
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStreamReaderReadLine";
            this.Text = "frmStreamReaderReadLine";
            this.Load += new System.EventHandler(this.frmStreamReaderReadLine_Load);
            this.ResumeLayout(false);

        }

        private void frmStreamReaderReadLine_Load(object sender, EventArgs e)
        {

        }
    }
}
