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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ReaddatainFileStreamintoMemoryStream.htm
    public partial  class frmReaddatainFileStreamintoMemoryStream:Form
    {
        public frmReaddatainFileStreamintoMemoryStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReaddatainFileStreamintoMemoryStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReaddatainFileStreamintoMemoryStream";
            this.Text = "frmReaddatainFileStreamintoMemoryStream";
            this.Load += new System.EventHandler(this.frmReaddatainFileStreamintoMemoryStream_Load);
            this.ResumeLayout(false);

        }

        private void frmReaddatainFileStreamintoMemoryStream_Load(object sender, EventArgs e)
        {

        }
    }
}
