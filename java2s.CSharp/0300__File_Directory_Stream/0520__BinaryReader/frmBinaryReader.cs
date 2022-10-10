using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0520__BinaryReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/BinaryReader.htm
    public partial  class frmBinaryReader:Form
    {
        public frmBinaryReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBinaryReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBinaryReader";
            this.Text = "frmBinaryReader";
            this.Load += new System.EventHandler(this.frmBinaryReader_Load);
            this.ResumeLayout(false);

        }

        private void frmBinaryReader_Load(object sender, EventArgs e)
        {

        }
    }
}
