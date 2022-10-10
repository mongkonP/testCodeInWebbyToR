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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NormalSliderMax100Val10.htm
    public partial  class frmNormalSliderMax100Val10:Form
    {
        public frmNormalSliderMax100Val10()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNormalSliderMax100Val10
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNormalSliderMax100Val10";
            this.Text = "frmNormalSliderMax100Val10";
            this.Load += new System.EventHandler(this.frmNormalSliderMax100Val10_Load);
            this.ResumeLayout(false);

        }

        private void frmNormalSliderMax100Val10_Load(object sender, EventArgs e)
        {

        }
    }
}
