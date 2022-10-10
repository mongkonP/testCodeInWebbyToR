using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0220__RadioButton
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddcheckedeventlistenertoRadioButton.htm
    public partial  class frmAddcheckedeventlistenertoRadioButton:Form
    {
        public frmAddcheckedeventlistenertoRadioButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddcheckedeventlistenertoRadioButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddcheckedeventlistenertoRadioButton";
            this.Text = "frmAddcheckedeventlistenertoRadioButton";
            this.Load += new System.EventHandler(this.frmAddcheckedeventlistenertoRadioButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddcheckedeventlistenertoRadioButton_Load(object sender, EventArgs e)
        {

        }
    }
}
