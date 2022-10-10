using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2620__Focus
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FocusaTextBox.htm
    public partial  class frmFocusaTextBox:Form
    {
        public frmFocusaTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFocusaTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFocusaTextBox";
            this.Text = "frmFocusaTextBox";
            this.Load += new System.EventHandler(this.frmFocusaTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmFocusaTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
