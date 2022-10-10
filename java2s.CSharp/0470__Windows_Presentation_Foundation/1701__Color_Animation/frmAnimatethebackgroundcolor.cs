using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1701__Color_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Animatethebackgroundcolor.htm
    public partial  class frmAnimatethebackgroundcolor:Form
    {
        public frmAnimatethebackgroundcolor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimatethebackgroundcolor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimatethebackgroundcolor";
            this.Text = "frmAnimatethebackgroundcolor";
            this.Load += new System.EventHandler(this.frmAnimatethebackgroundcolor_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimatethebackgroundcolor_Load(object sender, EventArgs e)
        {

        }
    }
}
