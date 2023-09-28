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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ApplicationCurrentShutdownMode.htm
    public partial  class frmApplicationCurrentShutdownMode:Form
    {
        public frmApplicationCurrentShutdownMode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplicationCurrentShutdownMode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplicationCurrentShutdownMode";
            this.Text = "frmApplicationCurrentShutdownMode";
            this.Load += new System.EventHandler(this.frmApplicationCurrentShutdownMode_Load);
            this.ResumeLayout(false);

        }

        private void frmApplicationCurrentShutdownMode_Load(object sender, EventArgs e)
        {

        }
    }
}
