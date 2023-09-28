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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/HandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate.htm
    public partial  class frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate:Form
    {
        public frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate";
            this.Text = "frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate";
            this.Load += new System.EventHandler(this.frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlingbothtimeoutsandsignalswithaWaitOrTimerCallbackdelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
