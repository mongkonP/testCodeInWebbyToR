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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Shadoweffectbycreatinganouterglow.htm
    public partial  class frmShadoweffectbycreatinganouterglow:Form
    {
        public frmShadoweffectbycreatinganouterglow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShadoweffectbycreatinganouterglow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShadoweffectbycreatinganouterglow";
            this.Text = "frmShadoweffectbycreatinganouterglow";
            this.Load += new System.EventHandler(this.frmShadoweffectbycreatinganouterglow_Load);
            this.ResumeLayout(false);

        }

        private void frmShadoweffectbycreatinganouterglow_Load(object sender, EventArgs e)
        {

        }
    }
}
