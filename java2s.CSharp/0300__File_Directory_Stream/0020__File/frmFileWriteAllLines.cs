using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0020__File
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileWriteAllLines.htm
    public partial  class frmFileWriteAllLines:Form
    {
        public frmFileWriteAllLines()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileWriteAllLines
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileWriteAllLines";
            this.Text = "frmFileWriteAllLines";
            this.Load += new System.EventHandler(this.frmFileWriteAllLines_Load);
            this.ResumeLayout(false);

        }

        private void frmFileWriteAllLines_Load(object sender, EventArgs e)
        {

        }
    }
}
