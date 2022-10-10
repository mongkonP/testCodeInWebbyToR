using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0600__WaitHandle
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/WaitingwithWaitHandle.htm
    public partial  class frmWaitingwithWaitHandle:Form
    {
        public frmWaitingwithWaitHandle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWaitingwithWaitHandle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWaitingwithWaitHandle";
            this.Text = "frmWaitingwithWaitHandle";
            this.Load += new System.EventHandler(this.frmWaitingwithWaitHandle_Load);
            this.ResumeLayout(false);

        }

        private void frmWaitingwithWaitHandle_Load(object sender, EventArgs e)
        {

        }
    }
}
