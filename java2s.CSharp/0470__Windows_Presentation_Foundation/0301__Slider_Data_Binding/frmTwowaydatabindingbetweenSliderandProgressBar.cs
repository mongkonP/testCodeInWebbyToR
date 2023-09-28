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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TwowaydatabindingbetweenSliderandProgressBar.htm
    public partial  class frmTwowaydatabindingbetweenSliderandProgressBar:Form
    {
        public frmTwowaydatabindingbetweenSliderandProgressBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTwowaydatabindingbetweenSliderandProgressBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTwowaydatabindingbetweenSliderandProgressBar";
            this.Text = "frmTwowaydatabindingbetweenSliderandProgressBar";
            this.Load += new System.EventHandler(this.frmTwowaydatabindingbetweenSliderandProgressBar_Load);
            this.ResumeLayout(false);

        }

        private void frmTwowaydatabindingbetweenSliderandProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
