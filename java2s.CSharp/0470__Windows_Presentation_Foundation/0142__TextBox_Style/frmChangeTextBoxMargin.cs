using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0142__TextBox_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChangeTextBoxMargin.htm
    public partial  class frmChangeTextBoxMargin:Form
    {
        public frmChangeTextBoxMargin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangeTextBoxMargin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangeTextBoxMargin";
            this.Text = "frmChangeTextBoxMargin";
            this.Load += new System.EventHandler(this.frmChangeTextBoxMargin_Load);
            this.ResumeLayout(false);

        }

        private void frmChangeTextBoxMargin_Load(object sender, EventArgs e)
        {

        }
    }
}
