using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0020__Registry_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Loopthroughthevaluesinsideakeyanddisplay.htm
    public partial  class frmLoopthroughthevaluesinsideakeyanddisplay:Form
    {
        public frmLoopthroughthevaluesinsideakeyanddisplay()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoopthroughthevaluesinsideakeyanddisplay
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoopthroughthevaluesinsideakeyanddisplay";
            this.Text = "frmLoopthroughthevaluesinsideakeyanddisplay";
            this.Load += new System.EventHandler(this.frmLoopthroughthevaluesinsideakeyanddisplay_Load);
            this.ResumeLayout(false);

        }

        private void frmLoopthroughthevaluesinsideakeyanddisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
