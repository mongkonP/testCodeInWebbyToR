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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/VisualTreeHelperHitTest.htm
    public partial  class frmVisualTreeHelperHitTest:Form
    {
        public frmVisualTreeHelperHitTest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVisualTreeHelperHitTest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVisualTreeHelperHitTest";
            this.Text = "frmVisualTreeHelperHitTest";
            this.Load += new System.EventHandler(this.frmVisualTreeHelperHitTest_Load);
            this.ResumeLayout(false);

        }

        private void frmVisualTreeHelperHitTest_Load(object sender, EventArgs e)
        {

        }
    }
}
