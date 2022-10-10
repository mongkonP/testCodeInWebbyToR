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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/WriterLock.htm
    public partial  class frmWriterLock:Form
    {
        public frmWriterLock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWriterLock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWriterLock";
            this.Text = "frmWriterLock";
            this.Load += new System.EventHandler(this.frmWriterLock_Load);
            this.ResumeLayout(false);

        }

        private void frmWriterLock_Load(object sender, EventArgs e)
        {

        }
    }
}
