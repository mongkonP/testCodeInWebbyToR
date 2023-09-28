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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TickPlacementandTickFrequencyforSlider.htm
    public partial  class frmTickPlacementandTickFrequencyforSlider:Form
    {
        public frmTickPlacementandTickFrequencyforSlider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTickPlacementandTickFrequencyforSlider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTickPlacementandTickFrequencyforSlider";
            this.Text = "frmTickPlacementandTickFrequencyforSlider";
            this.Load += new System.EventHandler(this.frmTickPlacementandTickFrequencyforSlider_Load);
            this.ResumeLayout(false);

        }

        private void frmTickPlacementandTickFrequencyforSlider_Load(object sender, EventArgs e)
        {

        }
    }
}
