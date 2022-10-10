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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadSleep.htm
    public partial  class frmThreadSleep:Form
    {
        public frmThreadSleep()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadSleep
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadSleep";
            this.Text = "frmThreadSleep";
            this.Load += new System.EventHandler(this.frmThreadSleep_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadSleep_Load(object sender, EventArgs e)
        {

        }
    }
}
