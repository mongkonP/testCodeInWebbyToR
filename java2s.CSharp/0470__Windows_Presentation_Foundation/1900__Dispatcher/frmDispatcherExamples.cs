using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1900__Dispatcher
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DispatcherExamples.htm
    public partial  class frmDispatcherExamples:Form
    {
        public frmDispatcherExamples()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDispatcherExamples
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDispatcherExamples";
            this.Text = "frmDispatcherExamples";
            this.Load += new System.EventHandler(this.frmDispatcherExamples_Load);
            this.ResumeLayout(false);

        }

        private void frmDispatcherExamples_Load(object sender, EventArgs e)
        {

        }
    }
}
