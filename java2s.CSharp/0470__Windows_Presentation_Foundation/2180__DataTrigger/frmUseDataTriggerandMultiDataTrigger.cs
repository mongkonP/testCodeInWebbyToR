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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseDataTriggerandMultiDataTrigger.htm
    public partial  class frmUseDataTriggerandMultiDataTrigger:Form
    {
        public frmUseDataTriggerandMultiDataTrigger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseDataTriggerandMultiDataTrigger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseDataTriggerandMultiDataTrigger";
            this.Text = "frmUseDataTriggerandMultiDataTrigger";
            this.Load += new System.EventHandler(this.frmUseDataTriggerandMultiDataTrigger_Load);
            this.ResumeLayout(false);

        }

        private void frmUseDataTriggerandMultiDataTrigger_Load(object sender, EventArgs e)
        {

        }
    }
}
