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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/RecursiveDirectoryuse.htm
    public partial  class frmRecursiveDirectoryuse:Form
    {
        public frmRecursiveDirectoryuse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRecursiveDirectoryuse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRecursiveDirectoryuse";
            this.Text = "frmRecursiveDirectoryuse";
            this.Load += new System.EventHandler(this.frmRecursiveDirectoryuse_Load);
            this.ResumeLayout(false);

        }

        private void frmRecursiveDirectoryuse_Load(object sender, EventArgs e)
        {

        }
    }
}
