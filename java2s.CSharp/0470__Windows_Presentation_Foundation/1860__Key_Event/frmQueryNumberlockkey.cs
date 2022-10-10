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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/QueryNumberlockkey.htm
    public partial  class frmQueryNumberlockkey:Form
    {
        public frmQueryNumberlockkey()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryNumberlockkey
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryNumberlockkey";
            this.Text = "frmQueryNumberlockkey";
            this.Load += new System.EventHandler(this.frmQueryNumberlockkey_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryNumberlockkey_Load(object sender, EventArgs e)
        {

        }
    }
}
