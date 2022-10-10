using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0500__MemoryStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseMemoryStreamtoreverseafile.htm
    public partial  class frmUseMemoryStreamtoreverseafile:Form
    {
        public frmUseMemoryStreamtoreverseafile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseMemoryStreamtoreverseafile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseMemoryStreamtoreverseafile";
            this.Text = "frmUseMemoryStreamtoreverseafile";
            this.Load += new System.EventHandler(this.frmUseMemoryStreamtoreverseafile_Load);
            this.ResumeLayout(false);

        }

        private void frmUseMemoryStreamtoreverseafile_Load(object sender, EventArgs e)
        {

        }
    }
}
