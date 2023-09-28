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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CodeOnlyWPFApplicationSample.htm
    public partial  class frmCodeOnlyWPFApplicationSample:Form
    {
        public frmCodeOnlyWPFApplicationSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCodeOnlyWPFApplicationSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCodeOnlyWPFApplicationSample";
            this.Text = "frmCodeOnlyWPFApplicationSample";
            this.Load += new System.EventHandler(this.frmCodeOnlyWPFApplicationSample_Load);
            this.ResumeLayout(false);

        }

        private void frmCodeOnlyWPFApplicationSample_Load(object sender, EventArgs e)
        {

        }
    }
}
