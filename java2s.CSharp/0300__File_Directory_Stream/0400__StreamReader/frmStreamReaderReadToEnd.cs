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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/StreamReaderReadToEnd.htm
    public partial  class frmStreamReaderReadToEnd:Form
    {
        public frmStreamReaderReadToEnd()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStreamReaderReadToEnd
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStreamReaderReadToEnd";
            this.Text = "frmStreamReaderReadToEnd";
            this.Load += new System.EventHandler(this.frmStreamReaderReadToEnd_Load);
            this.ResumeLayout(false);

        }

        private void frmStreamReaderReadToEnd_Load(object sender, EventArgs e)
        {

        }
    }
}
