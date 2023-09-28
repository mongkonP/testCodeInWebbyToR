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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ForegroundThreadSleep.htm
    public partial  class frmForegroundThreadSleep:Form
    {
        public frmForegroundThreadSleep()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmForegroundThreadSleep
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmForegroundThreadSleep";
            this.Text = "frmForegroundThreadSleep";
            this.Load += new System.EventHandler(this.frmForegroundThreadSleep_Load);
            this.ResumeLayout(false);

        }

        private void frmForegroundThreadSleep_Load(object sender, EventArgs e)
        {

        }
    }
}
