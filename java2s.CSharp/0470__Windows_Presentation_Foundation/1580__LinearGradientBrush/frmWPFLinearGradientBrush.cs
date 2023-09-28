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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WPFLinearGradientBrush.htm
    public partial  class frmWPFLinearGradientBrush:Form
    {
        public frmWPFLinearGradientBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWPFLinearGradientBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWPFLinearGradientBrush";
            this.Text = "frmWPFLinearGradientBrush";
            this.Load += new System.EventHandler(this.frmWPFLinearGradientBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmWPFLinearGradientBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
