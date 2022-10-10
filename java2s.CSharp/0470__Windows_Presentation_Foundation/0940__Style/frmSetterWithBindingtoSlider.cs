using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0940__Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetterWithBindingtoSlider.htm
    public partial  class frmSetterWithBindingtoSlider:Form
    {
        public frmSetterWithBindingtoSlider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetterWithBindingtoSlider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetterWithBindingtoSlider";
            this.Text = "frmSetterWithBindingtoSlider";
            this.Load += new System.EventHandler(this.frmSetterWithBindingtoSlider_Load);
            this.ResumeLayout(false);

        }

        private void frmSetterWithBindingtoSlider_Load(object sender, EventArgs e)
        {

        }
    }
}
