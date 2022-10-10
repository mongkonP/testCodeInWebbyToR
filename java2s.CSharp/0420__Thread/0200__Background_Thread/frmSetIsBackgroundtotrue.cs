using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0200__Background_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/SetIsBackgroundtotrue.htm
    public partial  class frmSetIsBackgroundtotrue:Form
    {
        public frmSetIsBackgroundtotrue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetIsBackgroundtotrue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetIsBackgroundtotrue";
            this.Text = "frmSetIsBackgroundtotrue";
            this.Load += new System.EventHandler(this.frmSetIsBackgroundtotrue_Load);
            this.ResumeLayout(false);

        }

        private void frmSetIsBackgroundtotrue_Load(object sender, EventArgs e)
        {

        }
    }
}
