using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Usenativewindowsfunctiontoreadfile.htm
    public partial  class frmUsenativewindowsfunctiontoreadfile:Form
    {
        public frmUsenativewindowsfunctiontoreadfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsenativewindowsfunctiontoreadfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsenativewindowsfunctiontoreadfile";
            this.Text = "frmUsenativewindowsfunctiontoreadfile";
            this.Load += new System.EventHandler(this.frmUsenativewindowsfunctiontoreadfile_Load);
            this.ResumeLayout(false);

        }

        private void frmUsenativewindowsfunctiontoreadfile_Load(object sender, EventArgs e)
        {

        }
    }
}
