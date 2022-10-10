using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0700__Encrypt_Decrypt_File
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Decryptingafile.htm
    public partial  class frmDecryptingafile:Form
    {
        public frmDecryptingafile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDecryptingafile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDecryptingafile";
            this.Text = "frmDecryptingafile";
            this.Load += new System.EventHandler(this.frmDecryptingafile_Load);
            this.ResumeLayout(false);

        }

        private void frmDecryptingafile_Load(object sender, EventArgs e)
        {

        }
    }
}
