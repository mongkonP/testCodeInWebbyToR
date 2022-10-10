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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ReflectedGradient.htm
    public partial  class frmReflectedGradient:Form
    {
        public frmReflectedGradient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectedGradient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectedGradient";
            this.Text = "frmReflectedGradient";
            this.Load += new System.EventHandler(this.frmReflectedGradient_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectedGradient_Load(object sender, EventArgs e)
        {

        }
    }
}
