using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0160__File_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/GetFileInfofilesizefileattributelist.htm
    public partial  class frmGetFileInfofilesizefileattributelist:Form
    {
        public frmGetFileInfofilesizefileattributelist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetFileInfofilesizefileattributelist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetFileInfofilesizefileattributelist";
            this.Text = "frmGetFileInfofilesizefileattributelist";
            this.Load += new System.EventHandler(this.frmGetFileInfofilesizefileattributelist_Load);
            this.ResumeLayout(false);

        }

        private void frmGetFileInfofilesizefileattributelist_Load(object sender, EventArgs e)
        {

        }
    }
}
