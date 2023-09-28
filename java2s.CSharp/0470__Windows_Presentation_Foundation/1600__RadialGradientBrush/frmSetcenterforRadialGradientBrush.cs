using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1600__RadialGradientBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetcenterforRadialGradientBrush.htm
    public partial  class frmSetcenterforRadialGradientBrush:Form
    {
        public frmSetcenterforRadialGradientBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetcenterforRadialGradientBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetcenterforRadialGradientBrush";
            this.Text = "frmSetcenterforRadialGradientBrush";
            this.Load += new System.EventHandler(this.frmSetcenterforRadialGradientBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmSetcenterforRadialGradientBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
