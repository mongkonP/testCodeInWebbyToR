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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DemonstrateMemoryStream.htm
    public partial  class frmDemonstrateMemoryStream:Form
    {
        public frmDemonstrateMemoryStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateMemoryStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateMemoryStream";
            this.Text = "frmDemonstrateMemoryStream";
            this.Load += new System.EventHandler(this.frmDemonstrateMemoryStream_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateMemoryStream_Load(object sender, EventArgs e)
        {

        }
    }
}
