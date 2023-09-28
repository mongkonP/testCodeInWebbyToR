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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/WritebytearraywithFileStream.htm
    public partial  class frmWritebytearraywithFileStream:Form
    {
        public frmWritebytearraywithFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritebytearraywithFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritebytearraywithFileStream";
            this.Text = "frmWritebytearraywithFileStream";
            this.Load += new System.EventHandler(this.frmWritebytearraywithFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmWritebytearraywithFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
