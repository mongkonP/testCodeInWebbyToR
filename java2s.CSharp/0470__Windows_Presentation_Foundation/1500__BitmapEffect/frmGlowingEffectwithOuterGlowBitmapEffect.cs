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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GlowingEffectwithOuterGlowBitmapEffect.htm
    public partial  class frmGlowingEffectwithOuterGlowBitmapEffect:Form
    {
        public frmGlowingEffectwithOuterGlowBitmapEffect()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGlowingEffectwithOuterGlowBitmapEffect
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGlowingEffectwithOuterGlowBitmapEffect";
            this.Text = "frmGlowingEffectwithOuterGlowBitmapEffect";
            this.Load += new System.EventHandler(this.frmGlowingEffectwithOuterGlowBitmapEffect_Load);
            this.ResumeLayout(false);

        }

        private void frmGlowingEffectwithOuterGlowBitmapEffect_Load(object sender, EventArgs e)
        {

        }
    }
}
