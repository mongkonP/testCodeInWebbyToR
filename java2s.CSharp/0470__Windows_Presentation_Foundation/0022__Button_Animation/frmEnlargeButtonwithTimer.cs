using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0022__Button_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EnlargeButtonwithTimer.htm
    public partial  class frmEnlargeButtonwithTimer:Form
    {
        public frmEnlargeButtonwithTimer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnlargeButtonwithTimer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnlargeButtonwithTimer";
            this.Text = "frmEnlargeButtonwithTimer";
            this.Load += new System.EventHandler(this.frmEnlargeButtonwithTimer_Load);
            this.ResumeLayout(false);

        }

        private void frmEnlargeButtonwithTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
