using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0260__FileInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateFileStreamfromFileInfoforwriting.htm
    public partial  class frmCreateFileStreamfromFileInfoforwriting:Form
    {
        public frmCreateFileStreamfromFileInfoforwriting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateFileStreamfromFileInfoforwriting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateFileStreamfromFileInfoforwriting";
            this.Text = "frmCreateFileStreamfromFileInfoforwriting";
            this.Load += new System.EventHandler(this.frmCreateFileStreamfromFileInfoforwriting_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateFileStreamfromFileInfoforwriting_Load(object sender, EventArgs e)
        {

        }
    }
}
