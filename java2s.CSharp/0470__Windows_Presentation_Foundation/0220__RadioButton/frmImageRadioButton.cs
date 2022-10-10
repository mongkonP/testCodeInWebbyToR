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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ImageRadioButton.htm
    public partial  class frmImageRadioButton:Form
    {
        public frmImageRadioButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImageRadioButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImageRadioButton";
            this.Text = "frmImageRadioButton";
            this.Load += new System.EventHandler(this.frmImageRadioButton_Load);
            this.ResumeLayout(false);

        }

        private void frmImageRadioButton_Load(object sender, EventArgs e)
        {

        }
    }
}
