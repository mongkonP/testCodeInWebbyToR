using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0020__File
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileGetCreationTimeandGetLastAccessTime.htm
    public partial  class frmFileGetCreationTimeandGetLastAccessTime:Form
    {
        public frmFileGetCreationTimeandGetLastAccessTime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileGetCreationTimeandGetLastAccessTime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileGetCreationTimeandGetLastAccessTime";
            this.Text = "frmFileGetCreationTimeandGetLastAccessTime";
            this.Load += new System.EventHandler(this.frmFileGetCreationTimeandGetLastAccessTime_Load);
            this.ResumeLayout(false);

        }

        private void frmFileGetCreationTimeandGetLastAccessTime_Load(object sender, EventArgs e)
        {

        }
    }
}
