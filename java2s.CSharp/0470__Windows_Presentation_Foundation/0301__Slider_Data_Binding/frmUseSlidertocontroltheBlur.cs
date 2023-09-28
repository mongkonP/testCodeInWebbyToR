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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseSlidertocontroltheBlur.htm
    public partial  class frmUseSlidertocontroltheBlur:Form
    {
        public frmUseSlidertocontroltheBlur()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSlidertocontroltheBlur
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSlidertocontroltheBlur";
            this.Text = "frmUseSlidertocontroltheBlur";
            this.Load += new System.EventHandler(this.frmUseSlidertocontroltheBlur_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSlidertocontroltheBlur_Load(object sender, EventArgs e)
        {

        }
    }
}
