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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DeleteDirectory.htm
    public partial  class frmDeleteDirectory:Form
    {
        public frmDeleteDirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeleteDirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeleteDirectory";
            this.Text = "frmDeleteDirectory";
            this.Load += new System.EventHandler(this.frmDeleteDirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmDeleteDirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
