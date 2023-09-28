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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseSlidertocontroltheEmboss.htm
    public partial  class frmUseSlidertocontroltheEmboss:Form
    {
        public frmUseSlidertocontroltheEmboss()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSlidertocontroltheEmboss
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSlidertocontroltheEmboss";
            this.Text = "frmUseSlidertocontroltheEmboss";
            this.Load += new System.EventHandler(this.frmUseSlidertocontroltheEmboss_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSlidertocontroltheEmboss_Load(object sender, EventArgs e)
        {

        }
    }
}
