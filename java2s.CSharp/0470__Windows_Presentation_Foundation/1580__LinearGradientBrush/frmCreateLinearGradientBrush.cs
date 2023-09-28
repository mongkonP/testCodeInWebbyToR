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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateLinearGradientBrush.htm
    public partial  class frmCreateLinearGradientBrush:Form
    {
        public frmCreateLinearGradientBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateLinearGradientBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateLinearGradientBrush";
            this.Text = "frmCreateLinearGradientBrush";
            this.Load += new System.EventHandler(this.frmCreateLinearGradientBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateLinearGradientBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
