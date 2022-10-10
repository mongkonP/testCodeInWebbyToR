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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Copyafile.htm
    public partial  class frmCopyafile:Form
    {
        public frmCopyafile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyafile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyafile";
            this.Text = "frmCopyafile";
            this.Load += new System.EventHandler(this.frmCopyafile_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyafile_Load(object sender, EventArgs e)
        {

        }
    }
}
