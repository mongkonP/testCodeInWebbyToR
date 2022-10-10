using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0142__TextBox_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetVerticalScrollBarVisibilityforTextBox.htm
    public partial  class frmSetVerticalScrollBarVisibilityforTextBox:Form
    {
        public frmSetVerticalScrollBarVisibilityforTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetVerticalScrollBarVisibilityforTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetVerticalScrollBarVisibilityforTextBox";
            this.Text = "frmSetVerticalScrollBarVisibilityforTextBox";
            this.Load += new System.EventHandler(this.frmSetVerticalScrollBarVisibilityforTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmSetVerticalScrollBarVisibilityforTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
