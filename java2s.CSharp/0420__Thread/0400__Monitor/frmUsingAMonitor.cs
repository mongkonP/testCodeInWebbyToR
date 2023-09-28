using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0400__Monitor
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UsingAMonitor.htm
    public partial  class frmUsingAMonitor:Form
    {
        public frmUsingAMonitor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingAMonitor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingAMonitor";
            this.Text = "frmUsingAMonitor";
            this.Load += new System.EventHandler(this.frmUsingAMonitor_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingAMonitor_Load(object sender, EventArgs e)
        {

        }
    }
}
