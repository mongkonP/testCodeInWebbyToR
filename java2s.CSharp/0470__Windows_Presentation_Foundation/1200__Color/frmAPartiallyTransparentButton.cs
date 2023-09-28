using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1200__Color
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/APartiallyTransparentButton.htm
    public partial  class frmAPartiallyTransparentButton:Form
    {
        public frmAPartiallyTransparentButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAPartiallyTransparentButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAPartiallyTransparentButton";
            this.Text = "frmAPartiallyTransparentButton";
            this.Load += new System.EventHandler(this.frmAPartiallyTransparentButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAPartiallyTransparentButton_Load(object sender, EventArgs e)
        {

        }
    }
}
