using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0021__Button_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddimagetoButton.htm
    public partial  class frmAddimagetoButton:Form
    {
        public frmAddimagetoButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddimagetoButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddimagetoButton";
            this.Text = "frmAddimagetoButton";
            this.Load += new System.EventHandler(this.frmAddimagetoButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddimagetoButton_Load(object sender, EventArgs e)
        {

        }
    }
}
