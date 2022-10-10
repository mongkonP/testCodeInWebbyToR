using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0460__Producer_Consumer
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ConsumerProducerwithMonitor.htm
    public partial  class frmConsumerProducerwithMonitor:Form
    {
        public frmConsumerProducerwithMonitor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConsumerProducerwithMonitor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConsumerProducerwithMonitor";
            this.Text = "frmConsumerProducerwithMonitor";
            this.Load += new System.EventHandler(this.frmConsumerProducerwithMonitor_Load);
            this.ResumeLayout(false);

        }

        private void frmConsumerProducerwithMonitor_Load(object sender, EventArgs e)
        {

        }
    }
}
