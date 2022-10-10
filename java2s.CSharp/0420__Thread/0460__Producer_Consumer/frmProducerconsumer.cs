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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Producerconsumer.htm
    public partial  class frmProducerconsumer:Form
    {
        public frmProducerconsumer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProducerconsumer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProducerconsumer";
            this.Text = "frmProducerconsumer";
            this.Load += new System.EventHandler(this.frmProducerconsumer_Load);
            this.ResumeLayout(false);

        }

        private void frmProducerconsumer_Load(object sender, EventArgs e)
        {

        }
    }
}
