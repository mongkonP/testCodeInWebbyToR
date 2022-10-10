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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseSlidertocontroltheBevel.htm
    public partial  class frmUseSlidertocontroltheBevel:Form
    {
        public frmUseSlidertocontroltheBevel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSlidertocontroltheBevel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSlidertocontroltheBevel";
            this.Text = "frmUseSlidertocontroltheBevel";
            this.Load += new System.EventHandler(this.frmUseSlidertocontroltheBevel_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSlidertocontroltheBevel_Load(object sender, EventArgs e)
        {

        }
    }
}
