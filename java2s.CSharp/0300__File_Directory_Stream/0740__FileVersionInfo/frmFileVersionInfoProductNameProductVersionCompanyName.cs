using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0740__FileVersionInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileVersionInfoProductNameProductVersionCompanyName.htm
    public partial  class frmFileVersionInfoProductNameProductVersionCompanyName:Form
    {
        public frmFileVersionInfoProductNameProductVersionCompanyName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileVersionInfoProductNameProductVersionCompanyName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileVersionInfoProductNameProductVersionCompanyName";
            this.Text = "frmFileVersionInfoProductNameProductVersionCompanyName";
            this.Load += new System.EventHandler(this.frmFileVersionInfoProductNameProductVersionCompanyName_Load);
            this.ResumeLayout(false);

        }

        private void frmFileVersionInfoProductNameProductVersionCompanyName_Load(object sender, EventArgs e)
        {

        }
    }
}
