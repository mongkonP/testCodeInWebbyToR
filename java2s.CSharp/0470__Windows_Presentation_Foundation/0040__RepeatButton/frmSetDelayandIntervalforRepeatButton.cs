using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0040__RepeatButton
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetDelayandIntervalforRepeatButton.htm
    public partial  class frmSetDelayandIntervalforRepeatButton:Form
    {
        public frmSetDelayandIntervalforRepeatButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetDelayandIntervalforRepeatButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetDelayandIntervalforRepeatButton";
            this.Text = "frmSetDelayandIntervalforRepeatButton";
            this.Load += new System.EventHandler(this.frmSetDelayandIntervalforRepeatButton_Load);
            this.ResumeLayout(false);

        }

        private void frmSetDelayandIntervalforRepeatButton_Load(object sender, EventArgs e)
        {

        }
    }
}
