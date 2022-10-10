using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0200__Label
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindingLabeltoTextBox.htm
    public partial  class frmBindingLabeltoTextBox:Form
    {
        public frmBindingLabeltoTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingLabeltoTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingLabeltoTextBox";
            this.Text = "frmBindingLabeltoTextBox";
            this.Load += new System.EventHandler(this.frmBindingLabeltoTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingLabeltoTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
