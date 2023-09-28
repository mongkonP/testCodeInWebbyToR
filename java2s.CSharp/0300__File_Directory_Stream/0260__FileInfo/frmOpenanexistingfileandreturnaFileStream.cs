using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0260__FileInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/OpenanexistingfileandreturnaFileStream.htm
    public partial  class frmOpenanexistingfileandreturnaFileStream:Form
    {
        public frmOpenanexistingfileandreturnaFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenanexistingfileandreturnaFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenanexistingfileandreturnaFileStream";
            this.Text = "frmOpenanexistingfileandreturnaFileStream";
            this.Load += new System.EventHandler(this.frmOpenanexistingfileandreturnaFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenanexistingfileandreturnaFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
