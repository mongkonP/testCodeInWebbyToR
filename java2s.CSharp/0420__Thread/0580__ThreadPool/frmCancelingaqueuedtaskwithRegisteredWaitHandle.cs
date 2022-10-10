using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/CancelingaqueuedtaskwithRegisteredWaitHandle.htm
    public partial  class frmCancelingaqueuedtaskwithRegisteredWaitHandle:Form
    {
        public frmCancelingaqueuedtaskwithRegisteredWaitHandle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCancelingaqueuedtaskwithRegisteredWaitHandle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCancelingaqueuedtaskwithRegisteredWaitHandle";
            this.Text = "frmCancelingaqueuedtaskwithRegisteredWaitHandle";
            this.Load += new System.EventHandler(this.frmCancelingaqueuedtaskwithRegisteredWaitHandle_Load);
            this.ResumeLayout(false);

        }

        private void frmCancelingaqueuedtaskwithRegisteredWaitHandle_Load(object sender, EventArgs e)
        {

        }
    }
}
