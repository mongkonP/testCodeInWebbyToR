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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseSlidertocontroltheTransformation.htm
    public partial  class frmUseSlidertocontroltheTransformation:Form
    {
        public frmUseSlidertocontroltheTransformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSlidertocontroltheTransformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSlidertocontroltheTransformation";
            this.Text = "frmUseSlidertocontroltheTransformation";
            this.Load += new System.EventHandler(this.frmUseSlidertocontroltheTransformation_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSlidertocontroltheTransformation_Load(object sender, EventArgs e)
        {

        }
    }
}
