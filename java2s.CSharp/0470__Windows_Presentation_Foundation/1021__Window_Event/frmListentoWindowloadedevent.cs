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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListentoWindowloadedevent.htm
    public partial  class frmListentoWindowloadedevent:Form
    {
        public frmListentoWindowloadedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListentoWindowloadedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListentoWindowloadedevent";
            this.Text = "frmListentoWindowloadedevent";
            this.Load += new System.EventHandler(this.frmListentoWindowloadedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmListentoWindowloadedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
