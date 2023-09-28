using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0580__UI_Element
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Changecontrolbackgroundinmouseenterandleave.htm
    public partial  class frmChangecontrolbackgroundinmouseenterandleave:Form
    {
        public frmChangecontrolbackgroundinmouseenterandleave()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangecontrolbackgroundinmouseenterandleave
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangecontrolbackgroundinmouseenterandleave";
            this.Text = "frmChangecontrolbackgroundinmouseenterandleave";
            this.Load += new System.EventHandler(this.frmChangecontrolbackgroundinmouseenterandleave_Load);
            this.ResumeLayout(false);

        }

        private void frmChangecontrolbackgroundinmouseenterandleave_Load(object sender, EventArgs e)
        {

        }
    }
}
