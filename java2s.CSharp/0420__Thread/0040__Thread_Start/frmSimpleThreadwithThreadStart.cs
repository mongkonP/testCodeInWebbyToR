using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0040__Thread_Start
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/SimpleThreadwithThreadStart.htm
    public partial  class frmSimpleThreadwithThreadStart:Form
    {
        public frmSimpleThreadwithThreadStart()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleThreadwithThreadStart
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleThreadwithThreadStart";
            this.Text = "frmSimpleThreadwithThreadStart";
            this.Load += new System.EventHandler(this.frmSimpleThreadwithThreadStart_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleThreadwithThreadStart_Load(object sender, EventArgs e)
        {

        }
    }
}
