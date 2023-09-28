using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0020__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseTextBoxasButtonContent.htm
    public partial  class frmUseTextBoxasButtonContent:Form
    {
        public frmUseTextBoxasButtonContent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseTextBoxasButtonContent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseTextBoxasButtonContent";
            this.Text = "frmUseTextBoxasButtonContent";
            this.Load += new System.EventHandler(this.frmUseTextBoxasButtonContent_Load);
            this.ResumeLayout(false);

        }

        private void frmUseTextBoxasButtonContent_Load(object sender, EventArgs e)
        {

        }
    }
}
