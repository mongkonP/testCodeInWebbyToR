using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1280__Clip
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ClippedButton.htm
    public partial  class frmClippedButton:Form
    {
        public frmClippedButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClippedButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClippedButton";
            this.Text = "frmClippedButton";
            this.Load += new System.EventHandler(this.frmClippedButton_Load);
            this.ResumeLayout(false);

        }

        private void frmClippedButton_Load(object sender, EventArgs e)
        {

        }
    }
}
