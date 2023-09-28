using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0540__BinaryWriter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/BinaryWriterReader.htm
    public partial  class frmBinaryWriterReader:Form
    {
        public frmBinaryWriterReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBinaryWriterReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBinaryWriterReader";
            this.Text = "frmBinaryWriterReader";
            this.Load += new System.EventHandler(this.frmBinaryWriterReader_Load);
            this.ResumeLayout(false);

        }

        private void frmBinaryWriterReader_Load(object sender, EventArgs e)
        {

        }
    }
}
