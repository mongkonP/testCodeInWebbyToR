using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Listentowindowmousedownevent.htm
    public partial  class frmListentowindowmousedownevent:Form
    {
        public frmListentowindowmousedownevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListentowindowmousedownevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListentowindowmousedownevent";
            this.Text = "frmListentowindowmousedownevent";
            this.Load += new System.EventHandler(this.frmListentowindowmousedownevent_Load);
            this.ResumeLayout(false);

        }

        private void frmListentowindowmousedownevent_Load(object sender, EventArgs e)
        {

        }
    }
}
