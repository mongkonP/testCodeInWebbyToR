using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0320__ProgressBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProgressBarwithfiveiterations.htm
    public partial  class frmProgressBarwithfiveiterations:Form
    {
        public frmProgressBarwithfiveiterations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgressBarwithfiveiterations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgressBarwithfiveiterations";
            this.Text = "frmProgressBarwithfiveiterations";
            this.Load += new System.EventHandler(this.frmProgressBarwithfiveiterations_Load);
            this.ResumeLayout(false);

        }

        private void frmProgressBarwithfiveiterations_Load(object sender, EventArgs e)
        {

        }
    }
}
