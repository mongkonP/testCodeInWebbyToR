using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1860__Key_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OverrideOnTextInputmethodtogettheinputfromkeyboard.htm
    public partial  class frmOverrideOnTextInputmethodtogettheinputfromkeyboard:Form
    {
        public frmOverrideOnTextInputmethodtogettheinputfromkeyboard()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverrideOnTextInputmethodtogettheinputfromkeyboard
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverrideOnTextInputmethodtogettheinputfromkeyboard";
            this.Text = "frmOverrideOnTextInputmethodtogettheinputfromkeyboard";
            this.Load += new System.EventHandler(this.frmOverrideOnTextInputmethodtogettheinputfromkeyboard_Load);
            this.ResumeLayout(false);

        }

        private void frmOverrideOnTextInputmethodtogettheinputfromkeyboard_Load(object sender, EventArgs e)
        {

        }
    }
}
