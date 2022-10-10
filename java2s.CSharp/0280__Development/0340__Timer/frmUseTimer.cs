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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UseTimer.htm
    public partial  class frmUseTimer:Form
    {
        public frmUseTimer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseTimer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseTimer";
            this.Text = "frmUseTimer";
            this.Load += new System.EventHandler(this.frmUseTimer_Load);
            this.ResumeLayout(false);

        }

        private void frmUseTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
