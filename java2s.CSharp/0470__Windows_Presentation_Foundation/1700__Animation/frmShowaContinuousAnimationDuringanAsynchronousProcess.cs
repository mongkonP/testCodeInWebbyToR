using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1700__Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShowaContinuousAnimationDuringanAsynchronousProcess.htm
    public partial  class frmShowaContinuousAnimationDuringanAsynchronousProcess:Form
    {
        public frmShowaContinuousAnimationDuringanAsynchronousProcess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowaContinuousAnimationDuringanAsynchronousProcess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowaContinuousAnimationDuringanAsynchronousProcess";
            this.Text = "frmShowaContinuousAnimationDuringanAsynchronousProcess";
            this.Load += new System.EventHandler(this.frmShowaContinuousAnimationDuringanAsynchronousProcess_Load);
            this.ResumeLayout(false);

        }

        private void frmShowaContinuousAnimationDuringanAsynchronousProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
