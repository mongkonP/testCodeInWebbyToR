using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2740__DrawingContext
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OverlappingVisualHitTesting.htm
    public partial  class frmOverlappingVisualHitTesting:Form
    {
        public frmOverlappingVisualHitTesting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverlappingVisualHitTesting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverlappingVisualHitTesting";
            this.Text = "frmOverlappingVisualHitTesting";
            this.Load += new System.EventHandler(this.frmOverlappingVisualHitTesting_Load);
            this.ResumeLayout(false);

        }

        private void frmOverlappingVisualHitTesting_Load(object sender, EventArgs e)
        {

        }
    }
}
