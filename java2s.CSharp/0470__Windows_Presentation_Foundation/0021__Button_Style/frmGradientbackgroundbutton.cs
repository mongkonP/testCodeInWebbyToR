using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0021__Button_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Gradientbackgroundbutton.htm
    public partial  class frmGradientbackgroundbutton:Form
    {
        public frmGradientbackgroundbutton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGradientbackgroundbutton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGradientbackgroundbutton";
            this.Text = "frmGradientbackgroundbutton";
            this.Load += new System.EventHandler(this.frmGradientbackgroundbutton_Load);
            this.ResumeLayout(false);

        }

        private void frmGradientbackgroundbutton_Load(object sender, EventArgs e)
        {

        }
    }
}
