using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0080__Thread_Sleep
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/PuttingaThreadtoSleep.htm
    public partial  class frmPuttingaThreadtoSleep:Form
    {
        public frmPuttingaThreadtoSleep()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPuttingaThreadtoSleep
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPuttingaThreadtoSleep";
            this.Text = "frmPuttingaThreadtoSleep";
            this.Load += new System.EventHandler(this.frmPuttingaThreadtoSleep_Load);
            this.ResumeLayout(false);

        }

        private void frmPuttingaThreadtoSleep_Load(object sender, EventArgs e)
        {

        }
    }
}
