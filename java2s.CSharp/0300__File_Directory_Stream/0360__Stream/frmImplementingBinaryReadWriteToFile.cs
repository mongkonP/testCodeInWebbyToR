using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0360__Stream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ImplementingBinaryReadWriteToFile.htm
    public partial  class frmImplementingBinaryReadWriteToFile:Form
    {
        public frmImplementingBinaryReadWriteToFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementingBinaryReadWriteToFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementingBinaryReadWriteToFile";
            this.Text = "frmImplementingBinaryReadWriteToFile";
            this.Load += new System.EventHandler(this.frmImplementingBinaryReadWriteToFile_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementingBinaryReadWriteToFile_Load(object sender, EventArgs e)
        {

        }
    }
}
