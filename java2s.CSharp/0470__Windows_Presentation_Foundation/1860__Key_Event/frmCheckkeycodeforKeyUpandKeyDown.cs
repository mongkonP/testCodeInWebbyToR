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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CheckkeycodeforKeyUpandKeyDown.htm
    public partial  class frmCheckkeycodeforKeyUpandKeyDown:Form
    {
        public frmCheckkeycodeforKeyUpandKeyDown()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckkeycodeforKeyUpandKeyDown
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckkeycodeforKeyUpandKeyDown";
            this.Text = "frmCheckkeycodeforKeyUpandKeyDown";
            this.Load += new System.EventHandler(this.frmCheckkeycodeforKeyUpandKeyDown_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckkeycodeforKeyUpandKeyDown_Load(object sender, EventArgs e)
        {

        }
    }
}
