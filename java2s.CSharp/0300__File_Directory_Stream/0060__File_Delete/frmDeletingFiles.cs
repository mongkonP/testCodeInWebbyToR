using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0060__File_Delete
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DeletingFiles.htm
    public partial  class frmDeletingFiles:Form
    {
        public frmDeletingFiles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeletingFiles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeletingFiles";
            this.Text = "frmDeletingFiles";
            this.Load += new System.EventHandler(this.frmDeletingFiles_Load);
            this.ResumeLayout(false);

        }

        private void frmDeletingFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
