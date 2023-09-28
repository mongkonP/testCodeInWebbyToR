using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0320__ProgressBar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ProgressBarPerformStep.htm
    public partial  class frmProgressBarPerformStep:Form
    {
        public frmProgressBarPerformStep()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgressBarPerformStep
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgressBarPerformStep";
            this.Text = "frmProgressBarPerformStep";
            this.Load += new System.EventHandler(this.frmProgressBarPerformStep_Load);
            this.ResumeLayout(false);

        }

        private void frmProgressBarPerformStep_Load(object sender, EventArgs e)
        {

        }
    }
}
