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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AFileReader.htm
    public partial  class frmAFileReader:Form
    {
        public frmAFileReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAFileReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAFileReader";
            this.Text = "frmAFileReader";
            this.Load += new System.EventHandler(this.frmAFileReader_Load);
            this.ResumeLayout(false);

        }

        private void frmAFileReader_Load(object sender, EventArgs e)
        {

        }
    }
}
