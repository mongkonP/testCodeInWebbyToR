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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/StreamWriterReaderApp.htm
    public partial  class frmStreamWriterReaderApp:Form
    {
        public frmStreamWriterReaderApp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStreamWriterReaderApp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStreamWriterReaderApp";
            this.Text = "frmStreamWriterReaderApp";
            this.Load += new System.EventHandler(this.frmStreamWriterReaderApp_Load);
            this.ResumeLayout(false);

        }

        private void frmStreamWriterReaderApp_Load(object sender, EventArgs e)
        {

        }
    }
}
