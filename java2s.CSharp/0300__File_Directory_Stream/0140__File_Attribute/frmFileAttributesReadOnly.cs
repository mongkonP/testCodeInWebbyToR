using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0140__File_Attribute
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileAttributesReadOnly.htm
    public partial  class frmFileAttributesReadOnly:Form
    {
        public frmFileAttributesReadOnly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileAttributesReadOnly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileAttributesReadOnly";
            this.Text = "frmFileAttributesReadOnly";
            this.Load += new System.EventHandler(this.frmFileAttributesReadOnly_Load);
            this.ResumeLayout(false);

        }

        private void frmFileAttributesReadOnly_Load(object sender, EventArgs e)
        {

        }
    }
}
