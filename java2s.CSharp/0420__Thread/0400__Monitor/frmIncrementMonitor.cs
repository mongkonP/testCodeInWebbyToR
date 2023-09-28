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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/IncrementMonitor.htm
    public partial  class frmIncrementMonitor:Form
    {
        public frmIncrementMonitor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIncrementMonitor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIncrementMonitor";
            this.Text = "frmIncrementMonitor";
            this.Load += new System.EventHandler(this.frmIncrementMonitor_Load);
            this.ResumeLayout(false);

        }

        private void frmIncrementMonitor_Load(object sender, EventArgs e)
        {

        }
    }
}
