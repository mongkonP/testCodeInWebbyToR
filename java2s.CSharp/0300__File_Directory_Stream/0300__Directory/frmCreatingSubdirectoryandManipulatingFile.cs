using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0300__Directory
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreatingSubdirectoryandManipulatingFile.htm
    public partial  class frmCreatingSubdirectoryandManipulatingFile:Form
    {
        public frmCreatingSubdirectoryandManipulatingFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingSubdirectoryandManipulatingFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingSubdirectoryandManipulatingFile";
            this.Text = "frmCreatingSubdirectoryandManipulatingFile";
            this.Load += new System.EventHandler(this.frmCreatingSubdirectoryandManipulatingFile_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingSubdirectoryandManipulatingFile_Load(object sender, EventArgs e)
        {

        }
    }
}
