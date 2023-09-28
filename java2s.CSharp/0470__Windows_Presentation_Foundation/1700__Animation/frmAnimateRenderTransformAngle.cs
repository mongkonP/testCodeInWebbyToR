using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1700__Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimateRenderTransformAngle.htm
    public partial  class frmAnimateRenderTransformAngle:Form
    {
        public frmAnimateRenderTransformAngle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimateRenderTransformAngle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimateRenderTransformAngle";
            this.Text = "frmAnimateRenderTransformAngle";
            this.Load += new System.EventHandler(this.frmAnimateRenderTransformAngle_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimateRenderTransformAngle_Load(object sender, EventArgs e)
        {

        }
    }
}
