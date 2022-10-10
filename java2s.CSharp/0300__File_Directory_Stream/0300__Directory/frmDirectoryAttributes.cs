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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DirectoryAttributes.htm
    public partial  class frmDirectoryAttributes:Form
    {
        public frmDirectoryAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDirectoryAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDirectoryAttributes";
            this.Text = "frmDirectoryAttributes";
            this.Load += new System.EventHandler(this.frmDirectoryAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmDirectoryAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
