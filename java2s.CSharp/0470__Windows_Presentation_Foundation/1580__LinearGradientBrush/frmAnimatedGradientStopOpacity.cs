using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1580__LinearGradientBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimatedGradientStopOpacity.htm
    public partial  class frmAnimatedGradientStopOpacity:Form
    {
        public frmAnimatedGradientStopOpacity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimatedGradientStopOpacity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimatedGradientStopOpacity";
            this.Text = "frmAnimatedGradientStopOpacity";
            this.Load += new System.EventHandler(this.frmAnimatedGradientStopOpacity_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimatedGradientStopOpacity_Load(object sender, EventArgs e)
        {

        }
    }
}
