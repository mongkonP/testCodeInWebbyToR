using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0340__synchronized
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/SynchronousWritingAsynchronousReading.htm
    public partial  class frmSynchronousWritingAsynchronousReading:Form
    {
        public frmSynchronousWritingAsynchronousReading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSynchronousWritingAsynchronousReading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSynchronousWritingAsynchronousReading";
            this.Text = "frmSynchronousWritingAsynchronousReading";
            this.Load += new System.EventHandler(this.frmSynchronousWritingAsynchronousReading_Load);
            this.ResumeLayout(false);

        }

        private void frmSynchronousWritingAsynchronousReading_Load(object sender, EventArgs e)
        {

        }
    }
}
