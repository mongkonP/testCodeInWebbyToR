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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EmbossedEffectwithEmbossBitmapEffect.htm
    public partial  class frmEmbossedEffectwithEmbossBitmapEffect:Form
    {
        public frmEmbossedEffectwithEmbossBitmapEffect()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmbossedEffectwithEmbossBitmapEffect
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmbossedEffectwithEmbossBitmapEffect";
            this.Text = "frmEmbossedEffectwithEmbossBitmapEffect";
            this.Load += new System.EventHandler(this.frmEmbossedEffectwithEmbossBitmapEffect_Load);
            this.ResumeLayout(false);

        }

        private void frmEmbossedEffectwithEmbossBitmapEffect_Load(object sender, EventArgs e)
        {

        }
    }
}
