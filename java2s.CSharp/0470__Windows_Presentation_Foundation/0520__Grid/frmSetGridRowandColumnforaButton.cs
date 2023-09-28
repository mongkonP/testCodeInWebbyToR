using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0520__Grid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetGridRowandColumnforaButton.htm
    public partial  class frmSetGridRowandColumnforaButton:Form
    {
        public frmSetGridRowandColumnforaButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetGridRowandColumnforaButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetGridRowandColumnforaButton";
            this.Text = "frmSetGridRowandColumnforaButton";
            this.Load += new System.EventHandler(this.frmSetGridRowandColumnforaButton_Load);
            this.ResumeLayout(false);

        }

        private void frmSetGridRowandColumnforaButton_Load(object sender, EventArgs e)
        {

        }
    }
}
