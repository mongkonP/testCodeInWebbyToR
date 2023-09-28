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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Testforegroundworkerbehaviors.htm
    public partial  class frmTestforegroundworkerbehaviors:Form
    {
        public frmTestforegroundworkerbehaviors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTestforegroundworkerbehaviors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTestforegroundworkerbehaviors";
            this.Text = "frmTestforegroundworkerbehaviors";
            this.Load += new System.EventHandler(this.frmTestforegroundworkerbehaviors_Load);
            this.ResumeLayout(false);

        }

        private void frmTestforegroundworkerbehaviors_Load(object sender, EventArgs e)
        {

        }
    }
}
