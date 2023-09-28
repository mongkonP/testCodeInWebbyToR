using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BorderwithLinearGradientBrush.htm
    public partial  class frmBorderwithLinearGradientBrush:Form
    {
        public frmBorderwithLinearGradientBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBorderwithLinearGradientBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBorderwithLinearGradientBrush";
            this.Text = "frmBorderwithLinearGradientBrush";
            this.Load += new System.EventHandler(this.frmBorderwithLinearGradientBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmBorderwithLinearGradientBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
