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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ReuseStyleforTextBox.htm
    public partial  class frmReuseStyleforTextBox:Form
    {
        public frmReuseStyleforTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReuseStyleforTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReuseStyleforTextBox";
            this.Text = "frmReuseStyleforTextBox";
            this.Load += new System.EventHandler(this.frmReuseStyleforTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmReuseStyleforTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
