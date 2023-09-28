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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Monitortrytoenter.htm
    public partial  class frmMonitortrytoenter:Form
    {
        public frmMonitortrytoenter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMonitortrytoenter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMonitortrytoenter";
            this.Text = "frmMonitortrytoenter";
            this.Load += new System.EventHandler(this.frmMonitortrytoenter_Load);
            this.ResumeLayout(false);

        }

        private void frmMonitortrytoenter_Load(object sender, EventArgs e)
        {

        }
    }
}
