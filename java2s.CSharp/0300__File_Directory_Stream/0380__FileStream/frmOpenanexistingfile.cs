using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0380__FileStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Openanexistingfile.htm
    public partial  class frmOpenanexistingfile:Form
    {
        public frmOpenanexistingfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenanexistingfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenanexistingfile";
            this.Text = "frmOpenanexistingfile";
            this.Load += new System.EventHandler(this.frmOpenanexistingfile_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenanexistingfile_Load(object sender, EventArgs e)
        {

        }
    }
}
