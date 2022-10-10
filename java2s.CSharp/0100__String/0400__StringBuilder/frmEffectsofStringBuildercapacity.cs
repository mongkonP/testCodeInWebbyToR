using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0400__StringBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/EffectsofStringBuildercapacity.htm
    public partial  class frmEffectsofStringBuildercapacity:Form
    {
        public frmEffectsofStringBuildercapacity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEffectsofStringBuildercapacity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEffectsofStringBuildercapacity";
            this.Text = "frmEffectsofStringBuildercapacity";
            this.Load += new System.EventHandler(this.frmEffectsofStringBuildercapacity_Load);
            this.ResumeLayout(false);

        }

        private void frmEffectsofStringBuildercapacity_Load(object sender, EventArgs e)
        {

        }
    }
}
