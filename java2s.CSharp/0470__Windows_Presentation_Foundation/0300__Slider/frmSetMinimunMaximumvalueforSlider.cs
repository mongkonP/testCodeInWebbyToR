using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0300__Slider
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetMinimunMaximumvalueforSlider.htm
    public partial  class frmSetMinimunMaximumvalueforSlider:Form
    {
        public frmSetMinimunMaximumvalueforSlider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetMinimunMaximumvalueforSlider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetMinimunMaximumvalueforSlider";
            this.Text = "frmSetMinimunMaximumvalueforSlider";
            this.Load += new System.EventHandler(this.frmSetMinimunMaximumvalueforSlider_Load);
            this.ResumeLayout(false);

        }

        private void frmSetMinimunMaximumvalueforSlider_Load(object sender, EventArgs e)
        {

        }
    }
}
