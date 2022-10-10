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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ASimpleAnimationinCode.htm
    public partial  class frmASimpleAnimationinCode:Form
    {
        public frmASimpleAnimationinCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmASimpleAnimationinCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmASimpleAnimationinCode";
            this.Text = "frmASimpleAnimationinCode";
            this.Load += new System.EventHandler(this.frmASimpleAnimationinCode_Load);
            this.ResumeLayout(false);

        }

        private void frmASimpleAnimationinCode_Load(object sender, EventArgs e)
        {

        }
    }
}
