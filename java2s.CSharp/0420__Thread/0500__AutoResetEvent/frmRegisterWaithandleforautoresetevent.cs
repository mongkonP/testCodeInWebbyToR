using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0500__AutoResetEvent
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/RegisterWaithandleforautoresetevent.htm
    public partial  class frmRegisterWaithandleforautoresetevent:Form
    {
        public frmRegisterWaithandleforautoresetevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegisterWaithandleforautoresetevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegisterWaithandleforautoresetevent";
            this.Text = "frmRegisterWaithandleforautoresetevent";
            this.Load += new System.EventHandler(this.frmRegisterWaithandleforautoresetevent_Load);
            this.ResumeLayout(false);

        }

        private void frmRegisterWaithandleforautoresetevent_Load(object sender, EventArgs e)
        {

        }
    }
}
