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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileAttributesenumeration.htm
    public partial  class frmFileAttributesenumeration:Form
    {
        public frmFileAttributesenumeration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileAttributesenumeration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileAttributesenumeration";
            this.Text = "frmFileAttributesenumeration";
            this.Load += new System.EventHandler(this.frmFileAttributesenumeration_Load);
            this.ResumeLayout(false);

        }

        private void frmFileAttributesenumeration_Load(object sender, EventArgs e)
        {

        }
    }
}
