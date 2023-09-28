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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/IsKeyCapsLockToggled.htm
    public partial  class frmIsKeyCapsLockToggled:Form
    {
        public frmIsKeyCapsLockToggled()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsKeyCapsLockToggled
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsKeyCapsLockToggled";
            this.Text = "frmIsKeyCapsLockToggled";
            this.Load += new System.EventHandler(this.frmIsKeyCapsLockToggled_Load);
            this.ResumeLayout(false);

        }

        private void frmIsKeyCapsLockToggled_Load(object sender, EventArgs e)
        {

        }
    }
}
