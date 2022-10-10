using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0022__Button_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateaFishEyeButtonwithDoubleAnimation.htm
    public partial  class frmCreateaFishEyeButtonwithDoubleAnimation:Form
    {
        public frmCreateaFishEyeButtonwithDoubleAnimation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaFishEyeButtonwithDoubleAnimation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaFishEyeButtonwithDoubleAnimation";
            this.Text = "frmCreateaFishEyeButtonwithDoubleAnimation";
            this.Load += new System.EventHandler(this.frmCreateaFishEyeButtonwithDoubleAnimation_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaFishEyeButtonwithDoubleAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
