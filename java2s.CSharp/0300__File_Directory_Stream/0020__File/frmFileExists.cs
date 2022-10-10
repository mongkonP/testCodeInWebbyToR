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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileExists.htm
    public partial  class frmFileExists:Form
    {
        public frmFileExists()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileExists
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileExists";
            this.Text = "frmFileExists";
            this.Load += new System.EventHandler(this.frmFileExists_Load);
            this.ResumeLayout(false);

        }

        private void frmFileExists_Load(object sender, EventArgs e)
        {

        }
    }
}
