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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Windowmouseupevent.htm
    public partial  class frmWindowmouseupevent:Form
    {
        public frmWindowmouseupevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowmouseupevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowmouseupevent";
            this.Text = "frmWindowmouseupevent";
            this.Load += new System.EventHandler(this.frmWindowmouseupevent_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowmouseupevent_Load(object sender, EventArgs e)
        {

        }
    }
}
