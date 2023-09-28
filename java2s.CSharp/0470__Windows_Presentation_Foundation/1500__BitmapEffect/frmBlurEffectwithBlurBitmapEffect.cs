using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1500__BitmapEffect
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BlurEffectwithBlurBitmapEffect.htm
    public partial  class frmBlurEffectwithBlurBitmapEffect:Form
    {
        public frmBlurEffectwithBlurBitmapEffect()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBlurEffectwithBlurBitmapEffect
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBlurEffectwithBlurBitmapEffect";
            this.Text = "frmBlurEffectwithBlurBitmapEffect";
            this.Load += new System.EventHandler(this.frmBlurEffectwithBlurBitmapEffect_Load);
            this.ResumeLayout(false);

        }

        private void frmBlurEffectwithBlurBitmapEffect_Load(object sender, EventArgs e)
        {

        }
    }
}
