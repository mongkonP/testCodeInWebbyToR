using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0100__Thread_Abort
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseAbortobject.htm
    public partial  class frmUseAbortobject:Form
    {
        public frmUseAbortobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseAbortobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseAbortobject";
            this.Text = "frmUseAbortobject";
            this.Load += new System.EventHandler(this.frmUseAbortobject_Load);
            this.ResumeLayout(false);

        }

        private void frmUseAbortobject_Load(object sender, EventArgs e)
        {

        }
    }
}
