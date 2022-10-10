using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0040__Read
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/GetDirectoryEntryPath.htm
    public partial  class frmGetDirectoryEntryPath:Form
    {
        public frmGetDirectoryEntryPath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetDirectoryEntryPath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetDirectoryEntryPath";
            this.Text = "frmGetDirectoryEntryPath";
            this.Load += new System.EventHandler(this.frmGetDirectoryEntryPath_Load);
            this.ResumeLayout(false);

        }

        private void frmGetDirectoryEntryPath_Load(object sender, EventArgs e)
        {

        }
    }
}
