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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateStreamWriterfromFileInfo.htm
    public partial  class frmCreateStreamWriterfromFileInfo:Form
    {
        public frmCreateStreamWriterfromFileInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateStreamWriterfromFileInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateStreamWriterfromFileInfo";
            this.Text = "frmCreateStreamWriterfromFileInfo";
            this.Load += new System.EventHandler(this.frmCreateStreamWriterfromFileInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateStreamWriterfromFileInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
