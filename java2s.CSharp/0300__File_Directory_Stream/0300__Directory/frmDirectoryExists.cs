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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DirectoryExists.htm
    public partial  class frmDirectoryExists:Form
    {
        public frmDirectoryExists()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDirectoryExists
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDirectoryExists";
            this.Text = "frmDirectoryExists";
            this.Load += new System.EventHandler(this.frmDirectoryExists_Load);
            this.ResumeLayout(false);

        }

        private void frmDirectoryExists_Load(object sender, EventArgs e)
        {

        }
    }
}
