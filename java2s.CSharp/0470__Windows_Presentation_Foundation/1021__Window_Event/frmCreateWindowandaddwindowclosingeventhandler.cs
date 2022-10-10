using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateWindowandaddwindowclosingeventhandler.htm
    public partial  class frmCreateWindowandaddwindowclosingeventhandler:Form
    {
        public frmCreateWindowandaddwindowclosingeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateWindowandaddwindowclosingeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateWindowandaddwindowclosingeventhandler";
            this.Text = "frmCreateWindowandaddwindowclosingeventhandler";
            this.Load += new System.EventHandler(this.frmCreateWindowandaddwindowclosingeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateWindowandaddwindowclosingeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
