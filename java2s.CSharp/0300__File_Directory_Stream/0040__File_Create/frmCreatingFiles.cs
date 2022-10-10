using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0040__File_Create
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreatingFiles.htm
    public partial  class frmCreatingFiles:Form
    {
        public frmCreatingFiles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingFiles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingFiles";
            this.Text = "frmCreatingFiles";
            this.Load += new System.EventHandler(this.frmCreatingFiles_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
