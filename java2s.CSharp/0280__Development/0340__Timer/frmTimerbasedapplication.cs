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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Timerbasedapplication.htm
    public partial  class frmTimerbasedapplication:Form
    {
        public frmTimerbasedapplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTimerbasedapplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTimerbasedapplication";
            this.Text = "frmTimerbasedapplication";
            this.Load += new System.EventHandler(this.frmTimerbasedapplication_Load);
            this.ResumeLayout(false);

        }

        private void frmTimerbasedapplication_Load(object sender, EventArgs e)
        {

        }
    }
}
