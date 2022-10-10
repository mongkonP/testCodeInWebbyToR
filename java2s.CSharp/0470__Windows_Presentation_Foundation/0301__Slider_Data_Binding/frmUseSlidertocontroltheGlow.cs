using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0301__Slider_Data_Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseSlidertocontroltheGlow.htm
    public partial  class frmUseSlidertocontroltheGlow:Form
    {
        public frmUseSlidertocontroltheGlow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSlidertocontroltheGlow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSlidertocontroltheGlow";
            this.Text = "frmUseSlidertocontroltheGlow";
            this.Load += new System.EventHandler(this.frmUseSlidertocontroltheGlow_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSlidertocontroltheGlow_Load(object sender, EventArgs e)
        {

        }
    }
}
