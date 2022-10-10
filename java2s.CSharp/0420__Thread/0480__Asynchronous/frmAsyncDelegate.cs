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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsyncDelegate.htm
    public partial  class frmAsyncDelegate:Form
    {
        public frmAsyncDelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsyncDelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsyncDelegate";
            this.Text = "frmAsyncDelegate";
            this.Load += new System.EventHandler(this.frmAsyncDelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmAsyncDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
