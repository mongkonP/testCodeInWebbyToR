using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0440__ReaderWriterLock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ReaderLock.htm
    public partial  class frmReaderLock:Form
    {
        public frmReaderLock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReaderLock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReaderLock";
            this.Text = "frmReaderLock";
            this.Load += new System.EventHandler(this.frmReaderLock_Load);
            this.ResumeLayout(false);

        }

        private void frmReaderLock_Load(object sender, EventArgs e)
        {

        }
    }
}
