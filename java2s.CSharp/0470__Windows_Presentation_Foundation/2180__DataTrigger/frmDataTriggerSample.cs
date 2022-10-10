using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2180__DataTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DataTriggerSample.htm
    public partial  class frmDataTriggerSample:Form
    {
        public frmDataTriggerSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataTriggerSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataTriggerSample";
            this.Text = "frmDataTriggerSample";
            this.Load += new System.EventHandler(this.frmDataTriggerSample_Load);
            this.ResumeLayout(false);

        }

        private void frmDataTriggerSample_Load(object sender, EventArgs e)
        {

        }
    }
}
