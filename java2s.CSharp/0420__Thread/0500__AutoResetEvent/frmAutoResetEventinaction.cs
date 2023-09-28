using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0500__AutoResetEvent
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AutoResetEventinaction.htm
    public partial  class frmAutoResetEventinaction:Form
    {
        public frmAutoResetEventinaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAutoResetEventinaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAutoResetEventinaction";
            this.Text = "frmAutoResetEventinaction";
            this.Load += new System.EventHandler(this.frmAutoResetEventinaction_Load);
            this.ResumeLayout(false);

        }

        private void frmAutoResetEventinaction_Load(object sender, EventArgs e)
        {

        }
    }
}
