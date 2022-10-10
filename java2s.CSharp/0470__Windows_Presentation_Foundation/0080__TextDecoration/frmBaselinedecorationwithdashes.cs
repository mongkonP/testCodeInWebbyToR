using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0080__TextDecoration
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Baselinedecorationwithdashes.htm
    public partial  class frmBaselinedecorationwithdashes:Form
    {
        public frmBaselinedecorationwithdashes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBaselinedecorationwithdashes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBaselinedecorationwithdashes";
            this.Text = "frmBaselinedecorationwithdashes";
            this.Load += new System.EventHandler(this.frmBaselinedecorationwithdashes_Load);
            this.ResumeLayout(false);

        }

        private void frmBaselinedecorationwithdashes_Load(object sender, EventArgs e)
        {

        }
    }
}
