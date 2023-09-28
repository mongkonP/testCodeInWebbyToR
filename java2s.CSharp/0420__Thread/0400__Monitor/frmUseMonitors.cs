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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseMonitors.htm
    public partial  class frmUseMonitors:Form
    {
        public frmUseMonitors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseMonitors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseMonitors";
            this.Text = "frmUseMonitors";
            this.Load += new System.EventHandler(this.frmUseMonitors_Load);
            this.ResumeLayout(false);

        }

        private void frmUseMonitors_Load(object sender, EventArgs e)
        {

        }
    }
}
