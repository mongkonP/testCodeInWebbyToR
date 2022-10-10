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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UselockandMonitortocoordinateProducerandConsumer.htm
    public partial  class frmUselockandMonitortocoordinateProducerandConsumer:Form
    {
        public frmUselockandMonitortocoordinateProducerandConsumer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUselockandMonitortocoordinateProducerandConsumer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUselockandMonitortocoordinateProducerandConsumer";
            this.Text = "frmUselockandMonitortocoordinateProducerandConsumer";
            this.Load += new System.EventHandler(this.frmUselockandMonitortocoordinateProducerandConsumer_Load);
            this.ResumeLayout(false);

        }

        private void frmUselockandMonitortocoordinateProducerandConsumer_Load(object sender, EventArgs e)
        {

        }
    }
}
