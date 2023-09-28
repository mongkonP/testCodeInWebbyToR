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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GetUserInputfromaSlider.htm
    public partial  class frmGetUserInputfromaSlider:Form
    {
        public frmGetUserInputfromaSlider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetUserInputfromaSlider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetUserInputfromaSlider";
            this.Text = "frmGetUserInputfromaSlider";
            this.Load += new System.EventHandler(this.frmGetUserInputfromaSlider_Load);
            this.ResumeLayout(false);

        }

        private void frmGetUserInputfromaSlider_Load(object sender, EventArgs e)
        {

        }
    }
}
