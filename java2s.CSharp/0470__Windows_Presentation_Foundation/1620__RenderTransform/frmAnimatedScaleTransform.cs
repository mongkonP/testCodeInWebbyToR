using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1620__RenderTransform
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimatedScaleTransform.htm
    public partial  class frmAnimatedScaleTransform:Form
    {
        public frmAnimatedScaleTransform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimatedScaleTransform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimatedScaleTransform";
            this.Text = "frmAnimatedScaleTransform";
            this.Load += new System.EventHandler(this.frmAnimatedScaleTransform_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimatedScaleTransform_Load(object sender, EventArgs e)
        {

        }
    }
}
