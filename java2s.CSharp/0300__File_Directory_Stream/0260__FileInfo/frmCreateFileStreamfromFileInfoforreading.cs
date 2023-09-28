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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateFileStreamfromFileInfoforreading.htm
    public partial  class frmCreateFileStreamfromFileInfoforreading:Form
    {
        public frmCreateFileStreamfromFileInfoforreading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateFileStreamfromFileInfoforreading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateFileStreamfromFileInfoforreading";
            this.Text = "frmCreateFileStreamfromFileInfoforreading";
            this.Load += new System.EventHandler(this.frmCreateFileStreamfromFileInfoforreading_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateFileStreamfromFileInfoforreading_Load(object sender, EventArgs e)
        {

        }
    }
}
