using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0320__Directory_Copy
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CopyDirectory.htm
    public partial  class frmCopyDirectory:Form
    {
        public frmCopyDirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyDirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyDirectory";
            this.Text = "frmCopyDirectory";
            this.Load += new System.EventHandler(this.frmCopyDirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyDirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
