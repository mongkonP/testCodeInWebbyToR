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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Timerbasedactionfiring.htm
    public partial  class frmTimerbasedactionfiring:Form
    {
        public frmTimerbasedactionfiring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTimerbasedactionfiring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTimerbasedactionfiring";
            this.Text = "frmTimerbasedactionfiring";
            this.Load += new System.EventHandler(this.frmTimerbasedactionfiring_Load);
            this.ResumeLayout(false);

        }

        private void frmTimerbasedactionfiring_Load(object sender, EventArgs e)
        {

        }
    }
}
