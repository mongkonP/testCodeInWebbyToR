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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindingProgressBarwithSlider.htm
    public partial  class frmBindingProgressBarwithSlider:Form
    {
        public frmBindingProgressBarwithSlider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingProgressBarwithSlider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingProgressBarwithSlider";
            this.Text = "frmBindingProgressBarwithSlider";
            this.Load += new System.EventHandler(this.frmBindingProgressBarwithSlider_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingProgressBarwithSlider_Load(object sender, EventArgs e)
        {

        }
    }
}
