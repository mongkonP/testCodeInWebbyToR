using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0080__File_Copy
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CopyingAFilebyusingFileInfo.htm
    public partial  class frmCopyingAFilebyusingFileInfo:Form
    {
        public frmCopyingAFilebyusingFileInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyingAFilebyusingFileInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyingAFilebyusingFileInfo";
            this.Text = "frmCopyingAFilebyusingFileInfo";
            this.Load += new System.EventHandler(this.frmCopyingAFilebyusingFileInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyingAFilebyusingFileInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
