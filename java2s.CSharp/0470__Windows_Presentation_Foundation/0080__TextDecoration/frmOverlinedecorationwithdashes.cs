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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Overlinedecorationwithdashes.htm
    public partial  class frmOverlinedecorationwithdashes:Form
    {
        public frmOverlinedecorationwithdashes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverlinedecorationwithdashes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverlinedecorationwithdashes";
            this.Text = "frmOverlinedecorationwithdashes";
            this.Load += new System.EventHandler(this.frmOverlinedecorationwithdashes_Load);
            this.ResumeLayout(false);

        }

        private void frmOverlinedecorationwithdashes_Load(object sender, EventArgs e)
        {

        }
    }
}
