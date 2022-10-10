using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0240__PasswordBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DisplayaPasswordEntryBoxandgettheinput.htm
    public partial  class frmDisplayaPasswordEntryBoxandgettheinput:Form
    {
        public frmDisplayaPasswordEntryBoxandgettheinput()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayaPasswordEntryBoxandgettheinput
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayaPasswordEntryBoxandgettheinput";
            this.Text = "frmDisplayaPasswordEntryBoxandgettheinput";
            this.Load += new System.EventHandler(this.frmDisplayaPasswordEntryBoxandgettheinput_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayaPasswordEntryBoxandgettheinput_Load(object sender, EventArgs e)
        {

        }
    }
}
