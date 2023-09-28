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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseMonitortocontrolmorethanoneThreads.htm
    public partial  class frmUseMonitortocontrolmorethanoneThreads:Form
    {
        public frmUseMonitortocontrolmorethanoneThreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseMonitortocontrolmorethanoneThreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseMonitortocontrolmorethanoneThreads";
            this.Text = "frmUseMonitortocontrolmorethanoneThreads";
            this.Load += new System.EventHandler(this.frmUseMonitortocontrolmorethanoneThreads_Load);
            this.ResumeLayout(false);

        }

        private void frmUseMonitortocontrolmorethanoneThreads_Load(object sender, EventArgs e)
        {

        }
    }
}
