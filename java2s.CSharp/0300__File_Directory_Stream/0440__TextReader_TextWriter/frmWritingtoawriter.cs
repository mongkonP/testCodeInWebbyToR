using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0440__TextReader_TextWriter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Writingtoawriter.htm
    public partial  class frmWritingtoawriter:Form
    {
        public frmWritingtoawriter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritingtoawriter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritingtoawriter";
            this.Text = "frmWritingtoawriter";
            this.Load += new System.EventHandler(this.frmWritingtoawriter_Load);
            this.ResumeLayout(false);

        }

        private void frmWritingtoawriter_Load(object sender, EventArgs e)
        {

        }
    }
}
