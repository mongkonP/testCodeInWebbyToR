using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0480__Asynchronous
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsynchronousWritingAsynchronousReading.htm
    public partial  class frmAsynchronousWritingAsynchronousReading:Form
    {
        public frmAsynchronousWritingAsynchronousReading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousWritingAsynchronousReading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousWritingAsynchronousReading";
            this.Text = "frmAsynchronousWritingAsynchronousReading";
            this.Load += new System.EventHandler(this.frmAsynchronousWritingAsynchronousReading_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousWritingAsynchronousReading_Load(object sender, EventArgs e)
        {

        }
    }
}
