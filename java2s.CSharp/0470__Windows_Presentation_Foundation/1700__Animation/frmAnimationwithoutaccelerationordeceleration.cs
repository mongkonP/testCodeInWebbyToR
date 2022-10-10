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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Animationwithoutaccelerationordeceleration.htm
    public partial  class frmAnimationwithoutaccelerationordeceleration:Form
    {
        public frmAnimationwithoutaccelerationordeceleration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationwithoutaccelerationordeceleration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationwithoutaccelerationordeceleration";
            this.Text = "frmAnimationwithoutaccelerationordeceleration";
            this.Load += new System.EventHandler(this.frmAnimationwithoutaccelerationordeceleration_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationwithoutaccelerationordeceleration_Load(object sender, EventArgs e)
        {

        }
    }
}
