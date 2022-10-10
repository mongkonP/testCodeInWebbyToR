using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UsingSystemThreadingTimer.htm
    public partial  class frmUsingSystemThreadingTimer:Form
    {
        public frmUsingSystemThreadingTimer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingSystemThreadingTimer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingSystemThreadingTimer";
            this.Text = "frmUsingSystemThreadingTimer";
            this.Load += new System.EventHandler(this.frmUsingSystemThreadingTimer_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingSystemThreadingTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
