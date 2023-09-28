using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2500__3D
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimationRotateTransform3D.htm
    public partial  class frmAnimationRotateTransform3D:Form
    {
        public frmAnimationRotateTransform3D()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimationRotateTransform3D
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimationRotateTransform3D";
            this.Text = "frmAnimationRotateTransform3D";
            this.Load += new System.EventHandler(this.frmAnimationRotateTransform3D_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimationRotateTransform3D_Load(object sender, EventArgs e)
        {

        }
    }
}
