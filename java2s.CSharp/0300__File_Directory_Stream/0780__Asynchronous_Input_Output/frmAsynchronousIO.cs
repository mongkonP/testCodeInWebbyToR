using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0780__Asynchronous_Input_Output
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AsynchronousIO.htm
    public partial  class frmAsynchronousIO:Form
    {
        public frmAsynchronousIO()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousIO
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousIO";
            this.Text = "frmAsynchronousIO";
            this.Load += new System.EventHandler(this.frmAsynchronousIO_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousIO_Load(object sender, EventArgs e)
        {

        }
    }
}
