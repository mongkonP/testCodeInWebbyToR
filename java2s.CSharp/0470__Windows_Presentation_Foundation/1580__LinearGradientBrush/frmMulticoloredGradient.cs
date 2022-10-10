using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1580__LinearGradientBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MulticoloredGradient.htm
    public partial  class frmMulticoloredGradient:Form
    {
        public frmMulticoloredGradient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMulticoloredGradient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMulticoloredGradient";
            this.Text = "frmMulticoloredGradient";
            this.Load += new System.EventHandler(this.frmMulticoloredGradient_Load);
            this.ResumeLayout(false);

        }

        private void frmMulticoloredGradient_Load(object sender, EventArgs e)
        {

        }
    }
}
