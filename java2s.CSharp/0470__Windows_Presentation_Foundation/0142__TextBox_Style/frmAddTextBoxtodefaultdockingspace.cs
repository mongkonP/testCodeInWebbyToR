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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddTextBoxtodefaultdockingspace.htm
    public partial  class frmAddTextBoxtodefaultdockingspace:Form
    {
        public frmAddTextBoxtodefaultdockingspace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddTextBoxtodefaultdockingspace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddTextBoxtodefaultdockingspace";
            this.Text = "frmAddTextBoxtodefaultdockingspace";
            this.Load += new System.EventHandler(this.frmAddTextBoxtodefaultdockingspace_Load);
            this.ResumeLayout(false);

        }

        private void frmAddTextBoxtodefaultdockingspace_Load(object sender, EventArgs e)
        {

        }
    }
}
