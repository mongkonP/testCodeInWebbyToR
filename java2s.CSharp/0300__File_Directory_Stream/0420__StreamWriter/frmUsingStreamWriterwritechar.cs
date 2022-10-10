using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0420__StreamWriter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UsingStreamWriterwritechar.htm
    public partial  class frmUsingStreamWriterwritechar:Form
    {
        public frmUsingStreamWriterwritechar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingStreamWriterwritechar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingStreamWriterwritechar";
            this.Text = "frmUsingStreamWriterwritechar";
            this.Load += new System.EventHandler(this.frmUsingStreamWriterwritechar_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingStreamWriterwritechar_Load(object sender, EventArgs e)
        {

        }
    }
}
