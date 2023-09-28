using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ManualUpdateTarget.htm
    public partial  class frmManualUpdateTarget:Form
    {
        public frmManualUpdateTarget()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmManualUpdateTarget
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmManualUpdateTarget";
            this.Text = "frmManualUpdateTarget";
            this.Load += new System.EventHandler(this.frmManualUpdateTarget_Load);
            this.ResumeLayout(false);

        }

        private void frmManualUpdateTarget_Load(object sender, EventArgs e)
        {

        }
    }
}
