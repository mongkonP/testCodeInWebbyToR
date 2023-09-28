using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ExitcurrentactionwithApplicationCurrentShutdown.htm
    public partial  class frmExitcurrentactionwithApplicationCurrentShutdown:Form
    {
        public frmExitcurrentactionwithApplicationCurrentShutdown()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExitcurrentactionwithApplicationCurrentShutdown
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExitcurrentactionwithApplicationCurrentShutdown";
            this.Text = "frmExitcurrentactionwithApplicationCurrentShutdown";
            this.Load += new System.EventHandler(this.frmExitcurrentactionwithApplicationCurrentShutdown_Load);
            this.ResumeLayout(false);

        }

        private void frmExitcurrentactionwithApplicationCurrentShutdown_Load(object sender, EventArgs e)
        {

        }
    }
}
