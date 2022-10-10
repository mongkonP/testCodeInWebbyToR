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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChangeTextBoxbackgroundandfontsize.htm
    public partial  class frmChangeTextBoxbackgroundandfontsize:Form
    {
        public frmChangeTextBoxbackgroundandfontsize()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangeTextBoxbackgroundandfontsize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangeTextBoxbackgroundandfontsize";
            this.Text = "frmChangeTextBoxbackgroundandfontsize";
            this.Load += new System.EventHandler(this.frmChangeTextBoxbackgroundandfontsize_Load);
            this.ResumeLayout(false);

        }

        private void frmChangeTextBoxbackgroundandfontsize_Load(object sender, EventArgs e)
        {

        }
    }
}
