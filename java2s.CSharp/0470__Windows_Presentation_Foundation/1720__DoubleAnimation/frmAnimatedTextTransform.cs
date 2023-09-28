using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1720__DoubleAnimation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimatedTextTransform.htm
    public partial  class frmAnimatedTextTransform:Form
    {
        public frmAnimatedTextTransform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimatedTextTransform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimatedTextTransform";
            this.Text = "frmAnimatedTextTransform";
            this.Load += new System.EventHandler(this.frmAnimatedTextTransform_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimatedTextTransform_Load(object sender, EventArgs e)
        {

        }
    }
}
